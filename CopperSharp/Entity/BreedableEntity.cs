using CopperSharp.Data.SNbt;

namespace CopperSharp.Entity;

/// <summary>
/// Represents an entity that can breed
/// </summary>
public abstract class BreedableEntity : LivingEntity
{
    /// <inheritdoc />
    protected BreedableEntity(EntityType type) : base(type)
    {
    }

    /// <summary>
    /// Extra integers in this entity
    /// </summary>
    protected Dictionary<string, int> Ints { get; set; } = new();

    private Guid? LoveCause { get; set; }

    /// <summary>
    /// Sets amount of time in ticks until the mob can breed
    /// </summary>
    /// <param name="age">Age of mob</param>
    /// <returns>This breedable entity</returns>
    public BreedableEntity SetAge(int age)
    {
        Ints["Age"] = age;
        return this;
    }

    /// <summary>
    /// Sets age this entity will be set to, when it becomes an adult
    /// </summary>
    /// <param name="age">Forced age of mob</param>
    /// <returns>This breedable entity</returns>
    public BreedableEntity SetForcedAge(int age)
    {
        Ints["ForcedAge"] = age;
        return this;
    }

    /// <summary>
    /// Sets lover of this entity
    /// </summary>
    /// <param name="lover">The UUID of the entity that caused this animal to breed</param>
    /// <param name="duration">Number of ticks until the mob loses its breeding hearts and stops searching for a mate</param>
    /// <returns>This breedable entity</returns>
    public BreedableEntity Love(Guid lover, int duration)
    {
        LoveCause = lover;
        Ints["InLove"] = duration;
        return this;
    }

    /// <inheritdoc />
    protected override void SerializeExtra(StringNbtWriter sw)
    {
        base.SerializeExtra(sw);

        foreach (var (key, val) in Ints)
        {
            sw.WriteInteger(key, val);
        }

        if (LoveCause != null)
            sw.WriteUuidArray("LoveCause", LoveCause ?? Guid.Empty);
    }
}