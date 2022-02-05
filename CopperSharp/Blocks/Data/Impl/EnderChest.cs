namespace CopperSharp.Blocks.Data.Impl;

/// <summary>
/// Represents an ender chest block
/// </summary>
public sealed class EnderChest : AbstractBlockData, IDirectional, IWaterlogged
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