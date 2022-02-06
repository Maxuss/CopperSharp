namespace CopperSharp.Blocks.Data.Impl;

/// <summary>
///     Represents a sign block data
/// </summary>
public sealed class Sign :
    AbstractBlockData,
    IRotatable,
    IWaterlogged,
    ILightable
{
    /// <inheritdoc />
    public ILightable Lit(bool lit = true)
    {
        Data["lit"] = lit;
        return this;
    }

    /// <inheritdoc />
    public IRotatable Rotate(BlockFace rotation)
    {
        Data["rotation"] = rotation.Mod;
        return this;
    }

    /// <inheritdoc />
    public IWaterlogged Waterlogged(bool logged = true)
    {
        Data["waterlogged"] = logged;
        return this;
    }
}