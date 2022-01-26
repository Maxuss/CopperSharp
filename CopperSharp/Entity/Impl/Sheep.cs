using CopperSharp.Item.Meta;

namespace CopperSharp.Entity.Impl;

/// <summary>
/// Represents a sheep entity
/// </summary>
public sealed class Sheep : BreedableEntity
{
    internal Sheep() : base(EntityType.Sheep)
    {
    }

    /// <summary>
    /// Makes this sheep sheared
    /// </summary>
    /// <param name="sheared">Whether to shear the sheep</param>
    /// <returns>This sheep</returns>
    public Sheep Sheared(bool sheared = true)
    {
        Bools["Sheared"] = sheared;
        return this;
    }

    /// <summary>
    /// Colors this sheep
    /// </summary>
    /// <param name="color">Color to be applied to this sheep</param>
    /// <returns>This sheep</returns>
    public Sheep Colored(NumberedColor color)
    {
        Bytes["Color"] = (byte) color;
        return this;
    }
}