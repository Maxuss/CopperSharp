using CopperSharp.Data.SNbt;

namespace CopperSharp.Blocks.Data;

/// <summary>
///     A global abstract superclass for all block entities
/// </summary>
public interface IBlockData
{
    /// <summary>
    ///     All extra NBT data for this tile entity
    /// </summary>
    public NbtCompound Data { get; set; }

    /// <summary>
    ///     Whether this entity is invalidated, and thus does
    ///     not immediately place the block in a loaded chunk
    /// </summary>
    /// <param name="inv">Marker</param>
    /// <returns>This abstract block entity</returns>
    public IBlockData IsInvalidated(bool inv = true);

    /// <summary>
    ///     Serializes this block data into provided writer
    /// </summary>
    /// <param name="w">Writer to be used</param>
    public Task SerializeInto(INbtWriter w);

    /// <summary>
    ///     Serializes this entity into SNBT
    /// </summary>
    /// <returns>Serialized entity</returns>
    public Task<string> Serialize();
}