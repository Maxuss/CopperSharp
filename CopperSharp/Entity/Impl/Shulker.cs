using CopperSharp.Data.Locations;
using CopperSharp.Item.Meta;

namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents a shulker entity
/// </summary>
public sealed class Shulker : LivingEntity
{
    internal Shulker() : base(EntityType.Shulker)
    {
    }

    /// <summary>
    ///     Sets approximate location of this shulker
    /// </summary>
    /// <param name="loc">Location to be set</param>
    /// <returns>This shulker</returns>
    public Shulker ApproximatePosition(Location loc)
    {
        Ints["APX"] = (int) loc.X.Value;
        Ints["APY"] = (int) loc.Y.Value;
        Ints["APZ"] = (int) loc.Z.Value;
        return this;
    }

    /// <summary>
    ///     Sets direction to which this shulker is attached
    /// </summary>
    /// <param name="direction">Block face to be set</param>
    /// <returns>This shulker</returns>
    public Shulker AttachedFace(byte direction)
    {
        Bytes["AttachFace"] = direction;
        return this;
    }

    /// <summary>
    ///     Applies a provided color to this shulker
    /// </summary>
    /// <param name="color">Color to be applied</param>
    /// <returns>This shulker</returns>
    public Shulker Colored(NumberedColor color)
    {
        Bytes["Color"] = (byte) color;
        return this;
    }

    /// <summary>
    ///     Sets the height of the head of this shulker
    /// </summary>
    /// <param name="height">Height to be set</param>
    /// <returns>This shulker</returns>
    public Shulker HeadHeight(byte height)
    {
        Bytes["Peek"] = height;
        return this;
    }
}