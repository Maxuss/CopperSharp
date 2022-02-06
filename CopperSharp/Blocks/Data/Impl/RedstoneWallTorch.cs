namespace CopperSharp.Blocks.Data.Impl;

/// <summary>
///     Represents a redstone wall torch block
/// </summary>
public sealed class RedstoneWallTorch :
    AbstractBlockData,
    IDirectional,
    ILightable
{
    /// <inheritdoc />
    public IDirectional Facing(BlockFace face)
    {
        Data["facing"] = face;
        return this;
    }

    /// <inheritdoc />
    public ILightable Lit(bool lit)
    {
        Data["lit"] = lit;
        return this;
    }
}