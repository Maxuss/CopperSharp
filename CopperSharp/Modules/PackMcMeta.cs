using Newtonsoft.Json;

namespace CopperSharp.Modules;

/// <summary>
/// MC meta info for datapack
/// </summary>
public readonly struct PackMcMeta
{
    internal PackMcMeta(int packFormat, string description)
    {
        PackFormat = packFormat;
        Description = description;
    }

    /// <summary>
    /// Format of this pack
    /// </summary>
    public int PackFormat { get; }
    /// <summary>
    /// Description of this pack
    /// </summary>
    public string Description { get; }

    public async Task<string> Serialize()
    {
        await using var sw = new StringWriter();
        using var jw = new JsonTextWriter(sw);
        jw.Formatting = Formatting.Indented;

        await jw.WriteStartObjectAsync();

        await jw.WritePropertyNameAsync("pack");
        await jw.WriteStartObjectAsync();

        await jw.WritePropertyNameAsync("pack_format");
        await jw.WriteValueAsync(PackFormat);

        await jw.WritePropertyNameAsync("description");
        await jw.WriteValueAsync(Description);
        
        await jw.WriteEndObjectAsync();
        
        await jw.WriteEndObjectAsync();

        return sw.ToString();
    }
}