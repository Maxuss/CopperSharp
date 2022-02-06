namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents a skeleton horse entity
/// </summary>
public sealed class SkeletonHorse : HorseEntity
{
    internal SkeletonHorse() : base(EntityType.SkeletonHorse)
    {
    }

    /// <summary>
    ///     Whether this horse is trapped
    /// </summary>
    /// <param name="trap">Marker</param>
    /// <returns>This skeleton horse</returns>
    public SkeletonHorse Trap(bool trap = true)
    {
        Bools["SkeletonTrap"] = trap;
        return this;
    }

    /// <summary>
    ///     If it's a trap, the horse automatically despawns<br />
    ///     after this value reaches 18000 ticks
    /// </summary>
    /// <param name="ticks">Amount of time in ticks</param>
    /// <returns>This skeleton horse</returns>
    public SkeletonHorse TrapTime(int ticks)
    {
        Ints["SkeletonTrapTime"] = ticks;
        return this;
    }
}