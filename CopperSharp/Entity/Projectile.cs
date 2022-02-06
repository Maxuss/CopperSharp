namespace CopperSharp.Entity;

/// <summary>
///     Represents a projectile
/// </summary>
public abstract class Projectile : AbstractEntity
{
    /// <inheritdoc />
    protected Projectile(EntityType type) : base(type)
    {
    }

    /// <summary>
    ///     Marks whether this projectile was shot
    /// </summary>
    /// <param name="was">Marker</param>
    /// <returns>This projectile</returns>
    public Projectile WasShot(bool was)
    {
        Bools["HasBeenShot"] = was;
        return this;
    }

    /// <summary>
    ///     Marks whether this projectile has escaped owner's hitbox
    ///     and can collide with entities
    /// </summary>
    /// <param name="escaped">Marker</param>
    /// <returns>This projectile</returns>
    public Projectile EscapedOwner(bool escaped)
    {
        Bools["LeftOwner"] = escaped;
        return this;
    }

    /// <summary>
    ///     Sets owner of this projectile
    /// </summary>
    /// <param name="owner">UUID of entity that shoot this projectile</param>
    /// <returns>This projectile</returns>
    public Projectile Shooter(Guid owner)
    {
        Ids["Owner"] = owner;
        return this;
    }
}