using CopperSharp.Registry;
using Newtonsoft.Json;

namespace CopperSharp.Tags;

public sealed class Tag
{
    /// <summary>
    ///     Constructs a new empty tag
    /// </summary>
    public Tag()
    {
    }

    /// <summary>
    ///     Constructs a new tag with provided values
    /// </summary>
    /// <param name="ids">Values to be set</param>
    public Tag(params Identifier[] ids)
    {
        Values.AddRange(ids.Select(it => it.ToString()));
    }

    private List<string> Values { get; } = new();
    private bool ReplaceVals { get; set; } = true;

    /// <summary>
    ///     Adds provided values to this tag
    /// </summary>
    /// <param name="ids">Values to be added</param>
    /// <returns>This tag</returns>
    public Tag AddValues(params Identifier[] ids)
    {
        Values.AddRange(ids.Select(it => it.ToString()));
        return this;
    }

    /// <summary>
    ///     Whether to suppress other datapack's tags with this tag
    /// </summary>
    /// <param name="replace">Marker</param>
    /// <returns>This tag</returns>
    public Tag ReplaceSimilar(bool replace = true)
    {
        ReplaceVals = replace;
        return this;
    }

    /// <summary>
    ///     Asynchronously serializes this tag to json
    /// </summary>
    /// <returns>Serialized json string</returns>
    public async Task<string> Serialize()
    {
        await using var sw = new StringWriter();
        using var jw = new JsonTextWriter(sw);
        jw.Formatting = Formatting.Indented;

        await jw.WriteStartObjectAsync();

        await jw.WritePropertyNameAsync("replace");
        await jw.WriteValueAsync(ReplaceVals);
        await jw.WritePropertyNameAsync("values");
        await jw.WriteStartArrayAsync();
        foreach (var v in Values) await jw.WriteValueAsync(v);
        await jw.WriteEndArrayAsync();

        await jw.WriteEndObjectAsync();

        return sw.ToString();
    }
}