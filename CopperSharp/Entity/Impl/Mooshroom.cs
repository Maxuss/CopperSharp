using CopperSharp.Data.Effects;

namespace CopperSharp.Entity.Impl;

/// <summary>
/// Represents a mooshroom entity
/// </summary>
public sealed class Mooshroom : BreedableEntity
{
    internal Mooshroom() : base(EntityType.Mooshroom)
    {
    }

    /// <summary>
    /// Sets effect duration this mooshroom gives if it is brown.
    /// </summary>
    /// <param name="duration">Amount of time in ticks</param>
    /// <returns>This mooshroom</returns>
    public Mooshroom EffectDuration(int duration)
    {
        Ints["EffectDuration"] = duration;
        return this;
    }

    /// <summary>
    /// Sets effect this mooshroom gives if it is brown
    /// </summary>
    /// <param name="effect">Type of effect</param>
    /// <returns>This mooshroom</returns>
    public Mooshroom Effect(StatusEffect effect)
    {
        Bytes["EffectId"] = (byte) effect;
        return this;
    }

    /// <summary>
    /// Makes this mooshroom brown, allowing to milk it for<br/>
    /// Suspicious stew.
    /// </summary>
    /// <param name="brown">Whether to make this mooshroom brown</param>
    /// <returns>This mooshroom</returns>
    public Mooshroom Brown(bool brown = true)
    {
        Strings["Type"] = brown ? "brown" : "red";
        return this;
    }
}