namespace CopperSharp.Blocks.Data;

/// <summary>
///     Represents a bisected entity, that is split into two parts
/// </summary>
public interface IBisected : IBlockData
{
    /// <summary>
    ///     Type of bisected half
    /// </summary>
    public enum Half
    {
        /// <summary>
        ///     Upper half, or TOP
        /// </summary>
        Upper,

        /// <summary>
        ///     Lower half, or BOTTOM
        /// </summary>
        Lower
    }

    /// <summary>
    ///     Sets half of this bisected entity
    /// </summary>
    /// <param name="half">Half to be set</param>
    /// <returns>This bisected entity</returns>
    public IBisected SetHalf(Half half);
}