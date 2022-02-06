namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents a piglin brute entity
/// </summary>
public sealed class PiglinBrute : LivingEntity
{
    internal PiglinBrute() : base(EntityType.PiglinBrute)
    {
    }

    /// <summary>
    ///     Whether this piglin is immune to zombification
    /// </summary>
    /// <param name="immune">Marker</param>
    /// <returns>This piglin</returns>
    public PiglinBrute ImmuneToZombification(bool immune = true)
    {
        Bools["IsImmuneToZombification"] = immune;
        return this;
    }

    /// <summary>
    ///     Time this piglin has spent in the overworld
    /// </summary>
    /// <param name="time">Amount of time in ticks</param>
    /// <returns>This piglin</returns>
    public PiglinBrute TimeInOverworld(int time)
    {
        Ints["TimeInOverworld"] = time;
        return this;
    }
}