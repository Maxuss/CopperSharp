using CopperSharp.Item;
using CopperSharp.Registry;

namespace CopperSharp.Blocks.State;

/// <summary>
///     Represents a hopper block state
/// </summary>
public sealed class HopperState : InventoryBlock<DispenserInventory>, ILockable, ILootable
{
    internal HopperState(Material id) : base(id)
    {
        Inventory = new DispenserInventory();
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