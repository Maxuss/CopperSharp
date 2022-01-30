using CopperSharp.Data.SNbt;
using CopperSharp.Entity;
using CopperSharp.Item;

namespace CopperSharp.Block.Impl;

/// <summary>
/// Represents a spawner block
/// </summary>
public sealed class MobSpawner : AbstractTileEntity
{
    internal MobSpawner() : base(Material.Spawner)
    {
    }

    private AbstractEntity? Spawning { get; set; }

    /// <summary>
    /// Sets delay until this spawner can spawn entity
    /// </summary>
    /// <param name="ticks">Amount of time in ticks</param>
    /// <returns>This mob spawner</returns>
    public MobSpawner Delay(short ticks)
    {
        Data["Delay"] = ticks;
        return this;
    }

    /// <summary>
    /// Sets max amount of entities the spawner can spawn
    /// </summary>
    /// <param name="amount">Amount of entities</param>
    /// <returns>This mob spawner</returns>
    public MobSpawner MaxSpawnAmount(short amount)
    {
        Data["MaxNearbyEntities"] = amount;
        return this;
    }

    /// <summary>
    /// Sets maximum delay until the spawner can spawn entities again
    /// </summary>
    /// <param name="delay">Amount of time in ticks</param>
    /// <returns>This mob spawner</returns>
    public MobSpawner MaxDelay(short delay)
    {
        Data["MaxSpawnDelay"] = delay;
        return this;
    }

    /// <summary>
    /// Sets minimum delay until the spawner can spawn entities again
    /// </summary>
    /// <param name="delay">Amount of time in ticks</param>
    /// <returns>This mob spawner</returns>
    public MobSpawner MinDelay(short delay)
    {
        Data["MinSpawnDelay"] = delay;
        return this;
    }

    /// <summary>
    /// Sets the entity to be spawned
    /// </summary>
    /// <param name="spawn">Entity to be spawned</param>
    /// <returns>This mob spawner</returns>
    public MobSpawner SpawnEntity(AbstractEntity spawn)
    {
        Spawning = spawn;
        return this;
    }

    /// <summary>
    /// Sets spawn range of this spawner
    /// </summary>
    /// <param name="range">Range to be set</param>
    /// <returns>This mob spawner</returns>
    public MobSpawner SpawnRange(short range)
    {
        Data["SpawnRange"] = range;
        return this;
    }

    /// <inheritdoc />
    internal override void SerializeExtra(StringNbtWriter sw)
    {
        base.SerializeExtra(sw);

        if (Spawning == null)
            return;

        sw.WritePropertyName("SpawnData");
        sw.WriteRawValue(Spawning.Serialize(false));
    }
}