namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents a wither entity
/// </summary>
public sealed class Wither : LivingEntity
{
    internal Wither() : base(EntityType.Wither)
    {
    }

    /// <summary>
    ///     Sets amount of invulnerability ticks left for this wither
    /// </summary>
    /// <param name="ticks">Amount of ticks left</param>
    /// <returns>This wither</returns>
    public Wither InvulnerabilityLeft(int ticks)
    {
        Ints["Invul"] = ticks;
        return this;
    }
}