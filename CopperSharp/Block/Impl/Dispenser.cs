namespace CopperSharp.Block.Impl;

/// <summary>
/// Represents a dispenser block
/// </summary>
public sealed class Dispenser : AbstractBlockData, IDirectional
{
    /// <inheritdoc />
    public IDirectional Facing(BlockFace face)
    {
        if (!face.Cartesian)
            return this;

        Data["facing"] = face.Name;
        return this;
    }

    /// <summary>
    /// Sets whether this dispenser is activated
    /// </summary>
    /// <param name="trigger">Marker</param>
    /// <returns>This dispenser</returns>
    public Dispenser Triggered(bool trigger)
    {
        Data["triggered"] = trigger;
        return this;
    }
}