namespace CopperSharp.Entity;

/// <summary>
/// Represents a zombie-like entity
/// </summary>
public abstract class ZombieEntity : LivingEntity
{
    /// <inheritdoc />
    protected ZombieEntity(EntityType type) : base(type)
    {
    }

    /// <summary>
    /// Marks that this zombie can break doors
    /// </summary>
    /// <param name="can">Whether this zombie can break doors</param>
    /// <returns>This zombie entity</returns>
    public ZombieEntity CanBreakDoors(bool can = true)
    {
        Bools["CanBreakDoors"] = can;
        return this;
    }

    /// <summary>
    /// Sets amount of time it takes to convert into drowned
    /// </summary>
    /// <param name="time">Amount of time in ticks</param>
    /// <returns>This zombie entity</returns>
    public ZombieEntity DrownedConversionTime(int time)
    {
        Ints["DrownedConversionTime"] = time;
        return this;
    }

    /// <summary>
    /// Sets time this zombie is in water
    /// </summary>
    /// <param name="time">Amount of time in ticks</param>
    /// <returns>This zombie entity</returns>
    public ZombieEntity TimeInWater(int time)
    {
        Ints["InWaterTime"] = time;
        return this;
    }

    /// <summary>
    /// Marks that this zombie is baby
    /// </summary>
    /// <param name="isBaby">Whether this zombie is baby</param>
    /// <returns>This zombie entity</returns>
    public ZombieEntity Baby(bool isBaby)
    {
        Bools["IsBaby"] = isBaby;
        return this;
    }
}