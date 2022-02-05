using CopperSharp.Item;
using CopperSharp.Registry;

namespace CopperSharp.Block.State;


/// <summary>
/// Represents a dispenser block state
/// </summary>
public sealed class DropperState : InventoryBlock<DispenserInventory>, ILootable, ILockable
{
    internal DropperState(Material id) : base(id)
    {
        Inventory = new DispenserInventory();
    }

    /// <inheritdoc />
    public ILootable LootTable(Identifier table)
    {
        Data["LootTable"] = table;
        return this;
    }

    /// <inheritdoc />
    public ILootable Seed(long seed)
    {
        Data["LootTableSeed"] = seed;
        return this;
    }

    /// <inheritdoc />
    public ILockable Allow(string name)
    {
        Data["Lock"] = name;
        return this;
    }
}