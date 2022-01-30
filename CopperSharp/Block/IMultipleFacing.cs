namespace CopperSharp.Block;

/// <summary>
/// Represents a tile entity that can have multiple attached faces
/// </summary>
public interface IMultipleFacing : IBlockData
{
    /// <summary>
    /// Gets whether this entity has provided block face
    /// </summary>
    /// <param name="face">Face to be checked for</param>
    public bool HasFace(BlockFace face);

    /// <summary>
    /// Sets whether this entity has this face attached
    /// </summary>
    /// <param name="face">Face to be set</param>
    /// <param name="has">Whether this entity will have this face</param>
    /// <returns>This multiple facing entity</returns>
    public IMultipleFacing SetFace(BlockFace face, bool has = true);
}