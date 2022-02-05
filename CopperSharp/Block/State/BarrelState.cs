using CopperSharp.Item;
using CopperSharp.Registry;
using CopperSharp.Text;

namespace CopperSharp.Block.State;

/// <summary>
/// Represents a barrel block
/// </summary>
public sealed class BarrelState : InventoryBlock, ILootable, ILockable
{
    internal BarrelState(Material id) : base(id)
    {
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

    /// <inheritdoc />
    public ILockable Allow(string name)
    {
        Data["Lock"] = name;
        return this;
    }
}