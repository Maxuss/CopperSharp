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
    public string Serialize()
    {
        using var sw = new StringWriter();
        using var w = new StringNbtWriter(sw);

        w.WriteBeginCompound();

        Data.SerializeInto(w, false);

        SerializeExtra(w);
        w.WriteEndCompound();

        return sw.ToString();
    }

    /// <summary>
    ///     Serializes extra data into provided string nbt writer
    /// </summary>
    /// <param name="sw">Writer into which to write data</param>
    internal virtual void SerializeExtra(StringNbtWriter sw)
    {
    }
}