using CopperSharp.Data.SNbt;
using CopperSharp.Item;
using CopperSharp.Registry;

namespace CopperSharp.Entity.Block;

/// <summary>
/// A global abstract superclass for all block entities
/// </summary>
public abstract class AbstractBlockEntity
{
    /// <summary>
    /// Constructs a new block entity
    /// </summary>
    /// <param name="block">Type of block entity</param>
    protected AbstractBlockEntity(Material block)
    {
        Id = block.Id;
    }

    private Identifier Id { get; set; }

    /// <summary>
    /// Extra UUID values to store inside this entity
    /// </summary>
    protected Dictionary<string, Guid> Ids { get; set; } = new();

    /// <summary>
    /// Extra string values to store inside this entity
    /// </summary>
    protected Dictionary<string, string> Strings { get; set; } = new();

    /// <summary>
    /// Extra byte values to store inside this entity
    /// </summary>
    protected Dictionary<string, byte> Bytes { get; set; } = new();

    /// <summary>
    /// Extra bool values to store inside this entity
    /// </summary>
    protected Dictionary<string, bool> Bools { get; set; } = new();

    /// <summary>
    /// Extra integers in this entity
    /// </summary>
    protected Dictionary<string, int> Ints { get; set; } = new();

    /// <summary>
    /// Extra integers in this entity
    /// </summary>
    protected Dictionary<string, double> Doubles { get; set; } = new();

    /// <summary>
    /// Whether this entity is invalidated, and thus does
    /// not immediately place the block in a loaded chunk
    /// </summary>
    /// <param name="inv">Marker</param>
    /// <returns>This abstract block entity</returns>
    public AbstractBlockEntity IsInvalidated(bool inv = true)
    {
        Bools["keepPacked"] = inv;
        return this;
    }

    /// <summary>
    /// Serializes extra data from this inheritor
    /// </summary>
    /// <param name="sw">Writer to which the data should be written</param>
    protected virtual void SerializeExtra(StringNbtWriter sw)
    {
    }

    /// <summary>
    /// Serializes this entity into SNBT
    /// </summary>
    /// <returns>Serialized entity</returns>
    public string Serialize()
    {
        using var sw = new StringWriter();
        using var w = new StringNbtWriter(sw);

        w.WriteBeginCompound();

        foreach (var (key, val) in Bools)
        {
            w.WriteBool(key, val);
        }

        foreach (var (key, val) in Bytes)
        {
            w.WriteByte(key, val);
        }

        foreach (var (key, val) in Strings)
        {
            w.WriteString(key, val);
        }

        foreach (var (key, val) in Ids)
        {
            w.WriteUuidArray(key, val);
        }

        foreach (var (key, val) in Ints)
        {
            w.WriteInteger(key, val);
        }

        foreach (var (key, val) in Doubles)
        {
            w.WriteDouble(key, val);
        }

        SerializeExtra(w);
        w.WriteEndCompound();

        return sw.ToString();
    }
}