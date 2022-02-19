using CopperSharp.Blocks.Data.Impl;
using CopperSharp.Data.SNbt;

namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents a spawner minecart vehicle
/// </summary>
public sealed class SpawnerMinecart : AbstractMinecart
{
    internal SpawnerMinecart() : base(EntityType.SpawnerMinecart)
    {
    }

    private MobSpawner? Data { get; set; }

    /// <summary>
    ///     Gets spawner data from this mob spawner
    /// </summary>
    /// <param name="spawner">Spawner from which to get data</param>
    /// <returns>This spawner minecart</returns>
    public SpawnerMinecart GetDataFrom(MobSpawner spawner)
    {
        Data = spawner;
        return this;
    }

    /// <inheritdoc />
    protected override async Task SerializeExtra(INbtWriter sw)
    {
        await base.SerializeExtra(sw);

        Data?.SerializeExtra(sw);
    }
}