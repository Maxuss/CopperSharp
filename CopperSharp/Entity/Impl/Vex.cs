using CopperSharp.Data.Locations;

namespace CopperSharp.Entity.Impl;

/// <summary>
/// Represents a vec entity
/// </summary>
public sealed class Vex : LivingEntity
{
    internal Vex() : base(EntityType.Vex)
    {
    }

    /// <summary>
    /// Sets position around which this vex will roam
    /// </summary>
    /// <param name="loc">Location to be set</param>
    /// <returns>This vex</returns>
    public Vex BoundPosition(Location loc)
    {
        Ints["BoundX"] = (int) loc.X.Value;
        Ints["BoundY"] = (int) loc.Y.Value;
        Ints["BoundZ"] = (int) loc.Z.Value;
        return this;
    }

    /// <summary>
    /// Sets amount of life ticks this vex has left
    /// </summary>
    /// <param name="ticks">Amount of time in tix</param>
    /// <returns>This vex</returns>
    public Vex LifeTicks(int ticks)
    {
        Ints["LifeTicks"] = ticks;
        return this;
    }
}