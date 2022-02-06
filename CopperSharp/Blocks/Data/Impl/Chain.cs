namespace CopperSharp.Blocks.Data.Impl;

/// <summary>
///     Represents a chain block
/// </summary>
public sealed class Chain : AbstractBlockData, IOrientable, IWaterlogged
{
    /// <inheritdoc />
    public IOrientable Axis(Axis axis)
    {
        Data["axis"] = Enum.GetName(axis)?.ToLower() ?? "x";
        return this;
    }

    /// <inheritdoc />
    public IWaterlogged Waterlogged(bool logged)
    {
        Data["waterlogged"] = logged;
        return this;
    }
}