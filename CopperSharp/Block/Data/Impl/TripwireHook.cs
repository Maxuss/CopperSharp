namespace CopperSharp.Block.Data.Impl;

/// <summary>
/// Represents a tripwire hook block
/// </summary>
public sealed class TripwireHook :
    AbstractBlockData,
    IAttachable,
    IDirectional,
    IPowerable
{
    /// <inheritdoc />
    public IAttachable Attach(bool attached = true)
    {
        Data["attached"] = attached;
        return this;
    }

    /// <inheritdoc />
    public IDirectional Facing(BlockFace face)
    {
        if (!face.Cartesian)
            return this;

        Data["facing"] = face;
        return this;
    }

    /// <inheritdoc />
    public IPowerable Powered(bool power = true)
    {
        Data["powered"] = power;
        return this;
    }
}