namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents a chicken mob
/// </summary>
public sealed class Chicken : BreedableEntity
{
    internal Chicken() : base(EntityType.Chicken)
    {
    }

    /// <summary>
    ///     Number of ticks until the chicken lays its egg.
    /// </summary>
    /// <param name="time">Amount of time in ticks</param>
    /// <returns>This chicken</returns>
    public Chicken EggLayTime(int time)
    {
        Ints["EggLayTime"] = time;
        return this;
    }

    /// <summary>
    ///     Marks that the chicken is a chicken jokey
    /// </summary>
    /// <param name="isJokey">Whether the chicken is jokey</param>
    /// <returns>This chicken</returns>
    public Chicken ChickenJokey(bool isJokey)
    {
        Bools["IsChickenJokey"] = isJokey;
        return this;
    }
}