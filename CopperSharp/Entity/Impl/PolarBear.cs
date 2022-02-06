namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents a polar bear entity
/// </summary>
public sealed class PolarBear : BreedableEntity, IAngerableEntity
{
    internal PolarBear() : base(EntityType.PolarBear)
    {
    }

    /// <inheritdoc />
    public IAngerableEntity AngryOn(Guid on)
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
}