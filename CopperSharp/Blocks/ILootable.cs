using CopperSharp.Registry;

namespace CopperSharp.Blocks;

/// <summary>
/// Represents a block that may have loot inside
/// </summary>
public interface ILootable : IState
{
    /// <summary>
    /// Sets loot table for this lootable block
    /// </summary>
    /// <param name="table">Loot table to be set</param>
    /// <returns>This lootable block</returns>
    public ILootable LootTable(Identifier table);

    /// <summary>
    /// Sets seed for this lootable block
    /// </summary>
    /// <param name="seed">Seed to be set</param>
    /// <returns>This lootable block</returns>
    public ILootable Seed(long seed);
}