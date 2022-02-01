namespace CopperSharp.Block.Data.Impl;

/// <summary>
/// Represents an observer block
/// </summary>
public sealed class Observer :
    AbstractBlockData,
    IDirectional,
    IPowerable
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
    public IPowerable Powered(bool power)
    {
        Data["powered"] = power;
        return this;
    }
}