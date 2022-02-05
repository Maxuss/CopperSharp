namespace CopperSharp.Blocks.Data.Impl;

/// <summary>
/// Represents a ladder block
/// </summary>
public sealed class Ladder : AbstractBlockData, IDirectional, IWaterlogged
{
    /// <inheritdoc />
    public IDirectional Facing(BlockFace face)
    {
        if (!face.Cartesian)
            return this;

        Data["facing"] = face.Name;
        return this;
    }

    /// <inheritdoc />
    public IWaterlogged Waterlogged(bool logged)
    {
        Data["waterlogged"] = logged;
        return this;
    }
}