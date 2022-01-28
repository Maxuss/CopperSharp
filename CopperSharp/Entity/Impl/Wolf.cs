using CopperSharp.Item.Meta;

namespace CopperSharp.Entity.Impl;

/// <summary>
/// Represents a wolf entity
/// </summary>
public class Wolf : TameableEntity, IAngerableEntity
{
    internal Wolf() : base(EntityType.Wolf)
    {
    }

    /// <inheritdoc />
    public IAngerableEntity AngryOn(Guid @on)
    {
        Ids["AngryAt"] = on;
        return this;
    }

    /// <inheritdoc />
    public IAngerableEntity AngerTime(int time)
    {
        Ints["AngerTime"] = time;
        return this;
    }

    /// <summary>
    /// Sets color of this wolf's collar
    /// </summary>
    /// <param name="color">Color to be set</param>
    /// <returns>This wolf</returns>
    public Wolf CollarColor(NumberedColor color)
    {
        Bytes["CollarColor"] = (byte) color;
        return this;
    }
}