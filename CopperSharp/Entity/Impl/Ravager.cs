namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents a ravager entity
/// </summary>
public sealed class Ravager : RaidEntity
{
    internal Ravager() : base(EntityType.Ravager)
    {
    }

    /// <summary>
    ///     Sets this ravager's attack cooldown
    /// </summary>
    /// <param name="tick">Amount of time in ticks</param>
    /// <returns>This ravager</returns>
    public Ravager AttackCooldown(int tick)
    {
        Ints["AttackTick"] = tick;
        return this;
    }

    /// <summary>
    ///     Sets this ravager's roar attack cooldown
    /// </summary>
    /// <param name="tick">Amount of time in ticks</param>
    /// <returns>This ravager</returns>
    public Ravager RoarCooldown(int tick)
    {
        Ints["RoarTick"] = tick;
        return this;
    }

    /// <summary>
    ///     Sets this ravager's stun attack cooldown
    /// </summary>
    /// <param name="tick">Amount of time in ticks</param>
    /// <returns>This ravager</returns>
    public Ravager StunCooldown(int tick)
    {
        Ints["StunTick"] = tick;
        return this;
    }
}