namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents a creeper entity
/// </summary>
public sealed class Creeper : LivingEntity
{
    internal Creeper() : base(EntityType.Creeper)
    {
    }

    /// <summary>
    ///     The radius of the explosion itself, default 3.
    /// </summary>
    /// <param name="radius">Radius to be set</param>
    /// <returns>This creeper</returns>
    public Creeper ExplosionRadius(byte radius)
    {
        Ints["ExplosionRadius"] = radius;
        return this;
    }

    /// <summary>
    ///     States the initial value of the creeper's internal fuse timer
    /// </summary>
    /// <param name="fuse">New fuse timer</param>
    /// <returns>This creeper</returns>
    public Creeper Fuse(short fuse)
    {
        Ints["Fuse"] = fuse;
        return this;
    }

    /// <summary>
    ///     Whether the creeper has been ignited
    /// </summary>
    /// <param name="ignited">Whether the creeper has been ignited</param>
    /// <returns>This creeper</returns>
    public Creeper Ignited(bool ignited = true)
    {
        Bools["Ignited"] = ignited;
        return this;
    }

    /// <summary>
    ///     Whether the creeper is charged from being struck by lightning.
    /// </summary>
    /// <param name="powered">Whether to charge the creeper</param>
    /// <returns>This creeper</returns>
    public Creeper Powered(bool powered = true)
    {
        Bools["Powered"] = powered;
        return this;
    }
}