namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents a glowsquid
/// </summary>
public sealed class GlowSquid : LivingEntity
{
    internal GlowSquid() : base(EntityType.GlowSquid)
    {
    }

    /// <summary>
    ///     Sets remaining ticks until the squid can glow again
    /// </summary>
    /// <param name="ticks">Amount of time in ticks</param>
    /// <returns>This glow squid</returns>
    public GlowSquid DarkTicks(int ticks)
    {
        Ints["DarkTicksRemaining"] = ticks;
        return this;
    }
}