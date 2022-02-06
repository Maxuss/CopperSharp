namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents an endermite
/// </summary>
public sealed class Endermite : LivingEntity
{
    internal Endermite() : base(EntityType.Endermite)
    {
    }

    /// <summary>
    ///     Sets amount of time this endermite has existed.<br />
    ///     Disappears when reaches around 2400 ticks
    /// </summary>
    /// <param name="time">Amount of time in ticks</param>
    /// <returns>This endermite</returns>
    public Endermite Lifetime(int time)
    {
        Ints["Lifetime"] = time;
        return this;
    }
}