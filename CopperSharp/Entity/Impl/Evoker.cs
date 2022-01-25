namespace CopperSharp.Entity.Impl;

/// <summary>
/// Represents an evoker entity
/// </summary>
public class Evoker : RaidEntity
{
    internal Evoker() : base(EntityType.Evoker)
    {
    }

    /// <summary>
    /// Number of ticks until a spell can be cast
    /// </summary>
    /// <param name="ticks">Amount of time in ticks</param>
    /// <returns>This evoker</returns>
    public Evoker SpellTicks(int ticks)
    {
        Ints["SpellTicks"] = ticks;
        return this;
    }
}