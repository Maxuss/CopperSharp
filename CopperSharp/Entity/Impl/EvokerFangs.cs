namespace CopperSharp.Entity.Impl;

/// <summary>
/// Represents evoker fangs entity
/// </summary>
public sealed class EvokerFangs : AbstractEntity
{
    internal EvokerFangs() : base(EntityType.EvokerFangs)
    {
    }

    /// <summary>
    /// Sets owner of this fangs
    /// </summary>
    /// <param name="owner">UUID of owner entity</param>
    /// <returns>These evoker fangs</returns>
    public EvokerFangs Owner(Guid owner)
    {
        Ids["Owner"] = owner;
        return this;
    }

    /// <summary>
    /// Sets time until these fangs appear
    /// </summary>
    /// <param name="ticks">Amount of time in ticks</param>
    /// <returns>These evoker fangs</returns>
    public EvokerFangs TimeUntilSpawn(int ticks)
    {
        Ints["Warmup"] = ticks;
        return this;
    }
}