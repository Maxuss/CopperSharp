namespace CopperSharp.Entity.Impl;

/// <summary>
/// Represents a furnace minecart vehicle
/// </summary>
public sealed class FurnaceMinecart : AbstractMinecart
{
    internal FurnaceMinecart() : base(EntityType.FurnaceMinecart)
    {
    }

    /// <summary>
    /// Sets fuel amount inside this minecart
    /// </summary>
    /// <param name="fuel">Amount of fuel</param>
    /// <returns>This furnace minecart</returns>
    public FurnaceMinecart FuelAmount(short fuel)
    {
        Ints["Fuel"] = fuel;
        return this;
    }

    /// <summary>
    /// Sets force applied to this furnace minecart
    /// </summary>
    /// <param name="x">Force along X axis</param>
    /// <param name="z">Force along Z axis</param>
    /// <returns></returns>
    public FurnaceMinecart Force(double x, double z)
    {
        Doubles["PushX"] = x;
        Doubles["PushZ"] = z;
        return this;
    }
}