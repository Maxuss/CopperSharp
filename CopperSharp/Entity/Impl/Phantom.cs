using CopperSharp.Data.Locations;

namespace CopperSharp.Entity.Impl;

/// <summary>
/// Represents a phantom entity
/// </summary>
public sealed class Phantom : LivingEntity
{
    internal Phantom() : base(EntityType.Phantom)
    {
    }

    /// <summary>
    /// Sets location around which the phantom will be circling
    /// </summary>
    /// <param name="loc">The location</param>
    /// <returns>This phantom</returns>
    public Phantom CirclingLocation(Location loc)
    {
        Ints["AX"] = (int) loc.X.Value;
        Ints["AY"] = (int) loc.Y.Value;
        Ints["AZ"] = (int) loc.Z.Value;
        return this;
    }

    /// <summary>
    /// Sets zero-based size of this phantom
    /// </summary>
    /// <param name="size">Size in range of 0 to 64</param>
    /// <returns>This phantom</returns>
    public Phantom Sized(int size)
    {
        Ints["Size"] = size;
        return this;
    }
}