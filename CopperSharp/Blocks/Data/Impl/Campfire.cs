namespace CopperSharp.Blocks.Data.Impl;

/// <summary>
///     Represents a campfire block data
/// </summary>
public sealed class Campfire :
    AbstractBlockData,
    IDirectional,
    ILightable,
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
    public ILightable Lit(bool lit)
    {
        Data["lit"] = lit;
        return this;
    }

    /// <inheritdoc />
    public IWaterlogged Waterlogged(bool logged)
    {
        Data["waterlogged"] = logged;
        return this;
    }
}