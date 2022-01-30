namespace CopperSharp.Block;

/// <summary>
/// Represents a growable tile entity
/// </summary>
public interface ISapling : ITileEntity
{
    /// <summary>
    /// Whether this sapling is trying to grow
    /// </summary>
    /// <param name="growing">Whether it is possible for sapling to grow</param>
    /// <returns>This sapling entity</returns>
    public ISapling Growing(bool growing);
}