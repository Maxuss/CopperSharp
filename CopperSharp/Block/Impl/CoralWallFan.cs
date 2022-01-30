namespace CopperSharp.Block.Impl;

/// <summary>
/// Represents a coral wall fan block
/// </summary>
public sealed class CoralWallFan : AbstractBlockData, IDirectional, IWaterlogged
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