namespace CopperSharp.Blocks.Data.Impl;

/// <summary>
/// Represents a sea pickle block
/// </summary>
public sealed class SeaPickle : AbstractBlockData, IWaterlogged
{
    /// <inheritdoc />
    public IWaterlogged Waterlogged(bool logged)
    {
        Data["waterlogged"] = logged;
        return this;
    }

    /// <summary>
    /// Sets amount of pickles within this pickles
    /// </summary>
    /// <param name="pickles">Amount of pickles in range of 1 to 4</param>
    /// <returns>This sea pickle</returns>
    public SeaPickle Pickles(int pickles)
    {
        Data["pickles"] = Math.Clamp(pickles, 1, 4);
        return this;
    }
}