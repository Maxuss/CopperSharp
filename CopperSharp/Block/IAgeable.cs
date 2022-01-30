namespace CopperSharp.Block;

/// <summary>
/// Represents a tile entity that can have age
/// </summary>
public interface IAgeable : ITileEntity
{
    /// <summary>
    /// Sets age of this tile entity
    /// </summary>
    /// <param name="age">Age to be set</param>
    /// <returns>This ageable entity</returns>
    public IAgeable Age(int age);
}