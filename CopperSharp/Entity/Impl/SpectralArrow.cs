namespace CopperSharp.Entity.Impl;

/// <summary>
/// Represents a spectral arrow projectile
/// </summary>
public sealed class SpectralArrow : AbstractArrow
{
    /// <summary>
    /// Sets duration of Glowing effect
    /// </summary>
    /// <param name="ticks">Amount of time in ticks</param>
    /// <returns>This spectral arrow</returns>
    public SpectralArrow GlowDuration(int ticks)
    {
        Ints["Duration"] = ticks;
        return this;
    }
    
    internal SpectralArrow() : base(EntityType.SpectralArrow)
    {
    }
}