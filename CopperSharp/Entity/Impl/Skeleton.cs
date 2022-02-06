namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents a skeleton entity
/// </summary>
public class Skeleton : LivingEntity
{
    internal Skeleton() : base(EntityType.Skeleton)
    {
    }

    /// <summary>
    ///     Sets amount of time left until this skeleton converts into stray
    /// </summary>
    /// <param name="ticks">Amount of time in ticks</param>
    /// <returns>This skeleton</returns>
    public Skeleton StrayConversion(int ticks)
    {
        Ints["StrayConversionTime"] = ticks;
        return this;
    }
}