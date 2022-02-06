namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents an illusioner entity
/// </summary>
public sealed class Illusioner : RaidEntity
{
    internal Illusioner() : base(EntityType.Illusioner)
    {
    }

    /// <summary>
    ///     Sets number of ticks until a spell can be cast
    /// </summary>
    /// <param name="ticks">Amount of time in ticks</param>
    /// <returns>This illusioner</returns>
    public Illusioner SpellTicks(int ticks)
    {
        Ints["SpellTicks"] = ticks;
        return this;
    }
}