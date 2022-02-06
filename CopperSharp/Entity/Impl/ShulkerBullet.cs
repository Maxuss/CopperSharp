namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents a shulker bullet projectile
/// </summary>
public sealed class ShulkerBullet : Projectile
{
    internal ShulkerBullet() : base(EntityType.ShulkerBullet)
    {
    }

    /// <summary>
    ///     Sets "steps" it takes to get to target entity.
    ///     If it is 0, the bullet will just travel in straight line,
    ///     according to <see cref="Offset" />
    /// </summary>
    /// <param name="accuracy">Accuracy to be set</param>
    /// <returns>This shulker bullet</returns>
    public ShulkerBullet Accuracy(int accuracy)
    {
        Ints["Steps"] = accuracy;
        return this;
    }

    /// <summary>
    ///     Sets target of this bullet
    /// </summary>
    /// <param name="target">Target to be set</param>
    /// <returns>This shulker bullet</returns>
    public ShulkerBullet Targets(Guid target)
    {
        Ids["Target"] = target;
        return this;
    }

    /// <summary>
    ///     Sets offset with which this bullet travels
    /// </summary>
    /// <param name="x">X offset</param>
    /// <param name="y">Y offset</param>
    /// <param name="z">Z offset</param>
    /// <returns></returns>
    public ShulkerBullet Offset(double x, double y, double z)
    {
        Doubles["TXD"] = x;
        Doubles["TYD"] = y;
        Doubles["TZD"] = z;
        return this;
    }
}