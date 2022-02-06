namespace CopperSharp.Blocks.Data.Impl;

/// <summary>
///     Represents a repeater block
/// </summary>
public sealed class Repeater :
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
    public IPowerable Powered(bool power = true)
    {
        Data["powered"] = power;
        return this;
    }

    /// <summary>
    ///     Sets delay of this repeater
    /// </summary>
    /// <param name="delay">Delay in range of 1 to 4</param>
    /// <returns>This repeater</returns>
    public Repeater Delay(int delay)
    {
        Data["delay"] = Math.Clamp(delay, 1, 4);
        return this;
    }

    /// <summary>
    ///     Makes this repeater locked
    /// </summary>
    /// <param name="locked">Whether to make the repeater locked</param>
    /// <returns>This repeater</returns>
    public Repeater Lock(bool locked = true)
    {
        Data["locked"] = locked;
        return this;
    }
}