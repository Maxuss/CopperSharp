namespace CopperSharp.Entity.Impl;

/// <summary>
/// Represents a hoglin entity
/// </summary>
public sealed class Hoglin : BreedableEntity
{
    internal Hoglin() : base(EntityType.Hoglin)
    {
    }

    /// <summary>
    /// Whether this hoglin can be hunted by piglins
    /// </summary>
    /// <param name="can">Marker</param>
    /// <returns>This hoglin</returns>
    public Hoglin CanBeHunted(bool can = false)
    {
        Bools["CannotBeHunted"] = !can;
        return this;
    }

    /// <summary>
    /// Whether this hoglin is immune to being zombified
    /// </summary>
    /// <param name="immune">Marker</param>
    /// <returns>This hoglin</returns>
    public Hoglin ZombificationImmunity(bool immune = true)
    {
        Bools["IsImmuneToZombification"] = immune;
        return this;
    }

    /// <summary>
    /// Amount of time spent in overworld
    /// </summary>
    /// <param name="time">Amount of time in ticks</param>
    /// <returns>This hoglin</returns>
    public Hoglin TimeInOverworld(int time)
    {
        Ints["TimeInOverworld"] = time;
        return this;
    }
}