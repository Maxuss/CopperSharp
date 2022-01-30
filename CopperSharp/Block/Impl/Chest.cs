namespace CopperSharp.Block.Impl;

/// <summary>
/// Represents a chest block
/// </summary>
public sealed class Chest : AbstractBlockData, IDirectional, IWaterlogged
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