namespace CopperSharp.Block;

/// <summary>
/// Represents a tile entity that can have level containers
/// </summary>
public interface ILevelled : ITileEntity
{
    /// <summary>
    /// Sets level of this levelled tile entity
    /// </summary>
    /// <param name="level">Level to be set</param>
    /// <returns>This levelled entity</returns>
    public ILevelled Level(int level);
}