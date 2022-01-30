using CopperSharp.Data.SNbt;
using CopperSharp.Registry;

namespace CopperSharp.Block;

/// <summary>
/// An abstract superclass for all block states
/// </summary>
public abstract class BlockState
{
    /// <summary>
    /// Creates a new block state
    /// </summary>
    /// <param name="id">Material ID of block</param>
    protected BlockState(Identifier id)
    {
        Id = id;
    }

    /// <summary>
    /// Data stored inside this block state
    /// </summary>
    protected NbtCompound Data { get; set; } = new();

    private Identifier Id { get; set; }

    /// <summary>
    /// Serializes extra data of this block state
    /// </summary>
    /// <param name="sw">String writer into which all data should be written</param>
    internal virtual void SerializeExtra(StringNbtWriter sw)
    {
    }

    /// <summary>
    /// Serializes this block state into stringified NBT
    /// </summary>
    /// <returns>Stringified NBT of this block state</returns>
    public string Serialize()
    {
        using var sw = new StringWriter();
        using var w = new StringNbtWriter(sw);

        w.WriteBeginCompound();
        w.WriteString("Name", Id.ToString());
        w.WritePropertyName("Properties");
        w.WriteBeginCompound();
        SerializeExtra(w);
        w.WriteEndCompound();
        w.WriteEndCompound();

        return sw.ToString();
    }
}