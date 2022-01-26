namespace CopperSharp.Entity.Impl;

/// <summary>
/// Represents an iron golem entity
/// </summary>
public sealed class IronGolem : LivingEntity, IAngerableEntity
{
    internal IronGolem() : base(EntityType.IronGolem)
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

    /// <summary>
    /// Whether this golem was made by player
    /// </summary>
    /// <param name="made">Marker</param>
    /// <returns>This iron golem</returns>
    public IronGolem PlayerMade(bool made = true)
    {
        Bools["PlayerCreated"] = made;
        return this;
    }
}