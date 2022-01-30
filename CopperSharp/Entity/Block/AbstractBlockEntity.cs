using CopperSharp.Data.SNbt;
using CopperSharp.Item;
using CopperSharp.Registry;

namespace CopperSharp.Entity.Block;

/// <summary>
/// Abstract implementation for block entity
/// </summary>
public abstract class AbstractBlockEntity : IBlockEntity
{
    /// <summary>
    /// Constructs a new block entity
    /// </summary>
    /// <param name="id">Block material of this block entity</param>
    protected AbstractBlockEntity(Material id)
    {
        Id = id.Id;
    }

    /// <inheritdoc />
    public Identifier Id { get; set; }

    /// <inheritdoc />
    public NbtCompound Data { get; set; } = new();

    /// <inheritdoc />
    public IBlockEntity IsInvalidated(bool inv = true)
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
    /// Serializes extra data into provided string nbt writer
    /// </summary>
    /// <param name="sw">Writer into which to write data</param>
    internal virtual void SerializeExtra(StringNbtWriter sw)
    {
    }
}