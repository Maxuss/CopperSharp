using CopperSharp.Data.SNbt;
using CopperSharp.Registry;

namespace CopperSharp.Block;

/// <summary>
/// A global abstract superclass for all block entities
/// </summary>
public interface ITileEntity
{
    /// <summary>
    /// ID of this block entity
    /// </summary>
    public Identifier Id { get; set; }

    /// <summary>
    /// All extra NBT data for this tile entity
    /// </summary>
    public NbtCompound Data { get; set; }

    /// <summary>
    /// Whether this entity is invalidated, and thus does
    /// not immediately place the block in a loaded chunk
    /// </summary>
    /// <param name="inv">Marker</param>
    /// <returns>This abstract block entity</returns>
    public ITileEntity IsInvalidated(bool inv = true);

    /// <summary>
    /// Serializes this entity into SNBT
    /// </summary>
    /// <returns>Serialized entity</returns>
    public string Serialize();
}