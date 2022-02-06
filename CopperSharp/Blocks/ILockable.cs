namespace CopperSharp.Blocks;

/// <summary>
///     Represents a lockable block
/// </summary>
public interface ILockable : IState
{
    /// <summary>
    ///     Allows only player holding item with provided name to use this block
    /// </summary>
    /// <param name="name">Item name to be whitelisted</param>
    /// <returns>This lockable block</returns>
    public ILockable Allow(string name);
}