namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents a ghast
/// </summary>
public sealed class Ghast : LivingEntity
{
    internal Ghast() : base(EntityType.Ghast)
    {
    }

    /// <summary>
    ///     Sets explosion power of this ghast
    /// </summary>
    /// <param name="power">Radius of explosion caused by fireballs</param>
    /// <returns>This ghast</returns>
    public Ghast ExplosionPower(byte power)
    {
        Ints["ExplosionPower"] = power;
        return this;
    }
}