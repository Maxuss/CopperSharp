namespace CopperSharp.Block.Impl;

/// <summary>
/// Represents a furnace block
/// </summary>
public sealed class Furnace : AbstractBlockData, IDirectional, ILightable
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
}