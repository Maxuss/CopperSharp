namespace CopperSharp.Blocks.Data.Impl;

/// <summary>
/// Represents a lightning rod block
/// </summary>
public sealed class LightningRod :
    AbstractBlockData,
    IDirectional,
    IPowerable,
    IWaterlogged
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
    public IPowerable Powered(bool power = true)
    {
        Data["powered"] = power;
        return this;
    }

    /// <inheritdoc />
    public IWaterlogged Waterlogged(bool logged = true)
    {
        Data["waterlogged"] = logged;
        return this;
    }
}