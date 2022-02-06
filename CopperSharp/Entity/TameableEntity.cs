using CopperSharp.Data.SNbt;

namespace CopperSharp.Entity;

/// <summary>
///     Represents an entity that can be tamed
/// </summary>
public abstract class TameableEntity : BreedableEntity
{
    /// <inheritdoc />
    protected TameableEntity(EntityType type) : base(type)
    {
    }

    private Guid? Owner { get; set; }

    /// <summary>
    ///     Sets the owner of this entity
    /// </summary>
    /// <param name="owner">New owner of this entity</param>
    /// <returns>This tameable entity</returns>
    public TameableEntity SetOwner(Guid owner)
    {
        Owner = owner;
        return this;
    }

    /// <summary>
    ///     Makes this entity sit
    /// </summary>
    /// <param name="sitting">Whether the entity should be sitting</param>
    /// <returns>This tameable entity</returns>
    public TameableEntity Sitting(bool sitting = true)
    {
        Bools["Sitting"] = sitting;
        return this;
    }

    /// <inheritdoc />
    protected override void SerializeExtra(StringNbtWriter sw)
    {
        base.SerializeExtra(sw);

        if (Owner != null)
            sw.WriteUuidArray("Owner", Owner ?? default);
    }
}