namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents a zombified piglin entity
/// </summary>
public sealed class ZombifiedPiglin : ZombieEntity, IAngerableEntity
{
    internal ZombifiedPiglin() : base(EntityType.ZombifiedPiglin)
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