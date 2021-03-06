namespace CopperSharp.Blocks.Data;

/// <summary>
///     Represents a tile entity that can have powered state
/// </summary>
public interface IPowerable : IBlockData
{
    /// <summary>
    ///     Whether to make this tile entity powered
    /// </summary>
    /// <param name="power">Whether to make this tile entity powered</param>
    /// <returns>This powerable entity</returns>
    public IPowerable Powered(bool power);
}