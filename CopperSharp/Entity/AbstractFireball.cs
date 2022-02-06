using CopperSharp.Data.SNbt;

namespace CopperSharp.Entity;

/// <summary>
///     A super class for all fireballs
/// </summary>
public abstract class AbstractFireball : Projectile
{
    /// <inheritdoc />
    protected AbstractFireball(EntityType type) : base(type)
    {
    }

    private double[] Power { get; } = {0, 0, 0};

    /// <summary>
    ///     Sets acceleration for this fireball
    /// </summary>
    /// <param name="x">X acceleration</param>
    /// <param name="y">Y acceleration</param>
    /// <param name="z">Z acceleration</param>
    /// <returns>This abstract fireball</returns>
    public AbstractFireball Accelerate(double x = 0d, double y = 0d, double z = 0d)
    {
        Power[0] = x;
        Power[1] = y;
        Power[2] = z;
        return this;
    }

    /// <inheritdoc />
    protected override void SerializeExtra(StringNbtWriter sw)
    {
        base.SerializeExtra(sw);

        sw.WritePropertyName("power");
        sw.WriteBeginArray();
        sw.WriteDouble(Power[0]);
        sw.WriteDouble(Power[1]);
        sw.WriteDouble(Power[2]);
        sw.WriteEndArray();
    }
}