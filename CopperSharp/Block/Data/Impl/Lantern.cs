namespace CopperSharp.Block.Data.Impl;

/// <summary>
/// Represents a lantern block
/// </summary>
public sealed class Lantern : AbstractBlockData, IWaterlogged
{
    /// <inheritdoc />
    public IWaterlogged Waterlogged(bool logged)
    {
        Data["waterlogged"] = logged;
        return this;
    }

    /// <summary>
    /// Whether this lantern is hanging from a block
    /// </summary>
    /// <param name="hang">Marker</param>
    /// <returns>This lantern</returns>
    public Lantern Hanging(bool hang = true)
    {
        Data["hanging"] = hang;
        return this;
    }
}