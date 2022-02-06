namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents a zoglin entity
/// </summary>
public sealed class Zoglin : LivingEntity
{
    internal Zoglin() : base(EntityType.Zoglin)
    {
    }

    /// <summary>
    ///     Sets whether this zoglin is baby
    /// </summary>
    /// <param name="baby">Whether this zoglin is baby</param>
    /// <returns>This zoglin</returns>
    public Zoglin IsBaby(bool baby = true)
    {
        Bools["IsBaby"] = baby;
        return this;
    }
}