namespace CopperSharp.Block.Impl;

/// <summary>
/// Represents a light block (yep, it does exist)
/// </summary>
public sealed class Light : AbstractBlockData, ILevelled, IWaterlogged
{
    /// <inheritdoc />
    public ILevelled Level(int level)
    {
        Data["level"] = Math.Clamp(level, 0, 15);
        return this;
    }

    /// <inheritdoc />
    public IWaterlogged Waterlogged(bool logged)
    {
        Data["waterlogged"] = logged;
        return this;
    }
}