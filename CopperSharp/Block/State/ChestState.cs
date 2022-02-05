using CopperSharp.Item;
using CopperSharp.Registry;

namespace CopperSharp.Block.State;

/// <summary>
/// Represents a chest block state
/// </summary>
public class ChestState : InventoryBlock<ChestInventory>, ILockable, ILootable
{
    internal ChestState(Material id) : base(id)
    {
        Inventory = new ChestInventory();
    }

    /// <inheritdoc />
    public ILockable Allow(string name)
    {
        Data["Lock"] = name;
        return this;
    }

    /// <inheritdoc />
    public ILootable LootTable(Identifier table)
    {
        Data["LootTable"] = table.ToString();
        return this;
    }

    /// <inheritdoc />
    public ILootable Seed(long seed)
    {
        Data["LootTableSeed"] = seed;
        return this;
    }
}