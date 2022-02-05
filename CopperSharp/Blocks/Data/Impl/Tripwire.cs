namespace CopperSharp.Blocks.Data.Impl;

/// <summary>
/// Represents a tripwire block
/// </summary>
public sealed class Tripwire :
    AbstractBlockData,
    IAttachable,
    IMultipleFacing,
    IPowerable
{
    /// <inheritdoc />
    public IAttachable Attach(bool attached = true)
    {
        Data["attached"] = attached;
        return this;
    }

    /// <inheritdoc />
    public IMultipleFacing SetFace(BlockFace face, bool has = true)
    {
        if (!face.Cartesian)
            return this;

        Data[face.Name] = has;
        return this;
    }

    /// <inheritdoc />
    public IPowerable Powered(bool power)
    {
        Data["powered"] = power;
        return this;
    }

    /// <summary>
    /// Makes this tripwire disarmed
    /// </summary>
    /// <param name="disarmed">Set to true to make tripwire not emit signal</param>
    /// <returns>This tripwire</returns>
    public Tripwire Disarmed(bool disarmed = true)
    {
        Data["disarmed"] = disarmed;
        return this;
    }
}