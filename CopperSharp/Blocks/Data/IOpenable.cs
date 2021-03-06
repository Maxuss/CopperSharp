namespace CopperSharp.Blocks.Data;

/// <summary>
///     Represents a tile entity that can be opened
/// </summary>
public interface IOpenable : IBlockData
{
    /// <summary>
    ///     Opens this openable tile entity
    /// </summary>
    /// <param name="open">Whether to open this tile entity</param>
    /// <returns>This openable entity</returns>
    public IOpenable Open(bool open);
}