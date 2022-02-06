using CopperSharp.Item;
using CopperSharp.Registry;

namespace CopperSharp.Blocks.State;

/// <summary>
///     Represents a shulker box block state
/// </summary>
public sealed class ShulkerBoxState : InventoryBlock<ChestInventory>, ILockable, ILootable
{
    /// <inheritdoc />
    public ShulkerBoxState(Material id) : base(id)
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