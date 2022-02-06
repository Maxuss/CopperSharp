namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents a snow golem entity
/// </summary>
public sealed class SnowGolem : LivingEntity
{
    internal SnowGolem() : base(EntityType.SnowGolem)
    {
    }

    /// <summary>
    ///     Whether this golem has a pumpkin
    /// </summary>
    /// <param name="has">Marker</param>
    /// <returns>This snow golem</returns>
    public SnowGolem HasPumpkin(bool has = true)
    {
        Bools["Pumpkin"] = has;
        return this;
    }
}