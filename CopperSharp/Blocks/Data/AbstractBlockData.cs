using CopperSharp.Data.SNbt;

namespace CopperSharp.Blocks.Data;

/// <summary>
///     Abstract implementation for block entity
/// </summary>
public abstract class AbstractBlockData : IBlockData
{
    /// <inheritdoc />
    public NbtCompound Data { get; set; } = new();

    /// <inheritdoc />
    public IBlockData IsInvalidated(bool inv = true)
    {
        Data["keepPacked"] = inv;
        return this;
    }

    /// <inheritdoc />
    public async Task SerializeInto(INbtWriter w)
    {
        await w.WriteBeginCompoundAsync();

        await Data.SerializeInto(w, false);

        await SerializeExtra(w);
        await w.WriteEndCompoundAsync();
    }

    /// <inheritdoc />
    public async Task<string> Serialize()
    {
        await using var sw = new StringWriter();
        await using var w = new StringNbtWriter(sw);

        await SerializeInto(w);

        return sw.ToString();
    }

    /// <summary>
    ///     Serializes extra data into provided string nbt writer
    /// </summary>
    /// <param name="sw">Writer into which to write data</param>
    internal virtual Task SerializeExtra(INbtWriter sw)
    {
        return Task.CompletedTask;
    }
}