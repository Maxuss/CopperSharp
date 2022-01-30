namespace CopperSharp.Block;

/// <summary>
/// Represents a rotatable tile entity
/// </summary>
public interface IRotatable : ITileEntity
{
    /// <summary>
    /// Rotates this tile entity to provided block face
    /// </summary>
    /// <param name="rotation">Rotation to be set</param>
    /// <returns>This rotatable entity</returns>
    public IRotatable Rotate(BlockFace rotation);
}