namespace CopperSharp.Blocks.Data;

/// <summary>
/// Represents a waterlogged block entity
/// </summary>
public interface IWaterlogged : IBlockData
{
    /// <summary>
    /// Makes this block entity waterlogged
    /// </summary>
    /// <param name="logged">Whether to make this block entity waterlogged</param>
    /// <returns>This block entity</returns>
    public IWaterlogged Waterlogged(bool logged);
}