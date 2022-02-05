using CopperSharp.Item;

namespace CopperSharp.Blocks.State;

/// <summary>
/// Represents furnace's inventory
/// </summary>
public sealed class FurnaceInventory : Inventory
{
    /// <inheritdoc />
    protected override int MaxSize => 3;

    /// <summary>
    /// Sets the item being smelted
    /// </summary>
    /// <param name="smelted">Item to be set</param>
    /// <returns>This furnace inventory</returns>
    public FurnaceInventory SetSmelted(ItemStack? smelted)
    {
        SetItem(smelted, 0);
        return this;
    }

    /// <summary>
    /// Sets the fuel of this furnace
    /// </summary>
    /// <param name="fuel">Fuel to be set</param>
    /// <returns>This furnace inventory</returns>
    public FurnaceInventory SetFuel(ItemStack? fuel)
    {
        SetItem(fuel, 1);
        return this;
    }

    /// <summary>
    /// Sets the smelting result of this furnace
    /// </summary>
    /// <param name="result">Item to be set</param>
    /// <returns>This furnace inventory</returns>
    public FurnaceInventory SetResult(ItemStack? result)
    {
        SetItem(result, 2);
        return this;
    }
}