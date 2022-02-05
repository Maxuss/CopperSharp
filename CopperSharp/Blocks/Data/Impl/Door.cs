namespace CopperSharp.Blocks.Data.Impl;

/// <summary>
/// Represents a door block
/// </summary>
public sealed class Door :
    AbstractBlockData,
    IDirectional,
    IOpenable,
    IPowerable,
    IBisected
{
    /// <summary>
    /// Which side the door is attached to
    /// </summary>
    public enum Hinge
    {
        /// <summary>
        /// Left side
        /// </summary>
        Left,

        /// <summary>
        /// Right side
        /// </summary>
        Right
    }

    /// <inheritdoc />
    public IBisected SetHalf(IBisected.Half half)
    {
        Data["half"] = Enum.GetName(half)?.ToLower() ?? "lower";
        return this;
    }

    /// <inheritdoc />
    public IDirectional Facing(BlockFace face)
    {
        if (!face.Cartesian)
            return this;

        Data["facing"] = face.Name;
        return this;
    }

    /// <inheritdoc />
    public IOpenable Open(bool open = true)
    {
        Data["open"] = open;
        return this;
    }

    /// <inheritdoc />
    public IPowerable Powered(bool power = true)
    {
        Data["powered"] = power;
        return this;
    }

    /// <summary>
    /// Sets hinge of this door
    /// </summary>
    /// <param name="hinge">Hinge to be set</param>
    /// <returns>This door</returns>
    public Door SetHinge(Hinge hinge)
    {
        Data["hinge"] = Enum.GetName(hinge)?.ToLower() ?? "left";
        return this;
    }
}