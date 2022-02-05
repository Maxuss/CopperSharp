using CopperSharp.Item;

namespace CopperSharp.Blocks.State;

/// <summary>
/// Represents a brewing stand block state
/// </summary>
public sealed class BrewingStandState : InventoryBlock<BrewingInventory>, ILockable
{
    /// <summary>
    /// Sets time it takes potions to brew
    /// </summary>
    /// <param name="time">Amount of time in ticks</param>
    /// <returns>This brewing stand state</returns>
    public BrewingStandState BrewingTime(short time)
    {
        Data["BrewTime"] = time;
        return this;
    }

    /// <summary>
    /// Sets left fuel inside this brewing stand
    /// </summary>
    /// <param name="fuel">Amount of fuel left</param>
    /// <returns>This brewing stand state</returns>
    public BrewingStandState FuelLeft(byte fuel)
    {
        Data["Fuel"] = fuel;
        return this;
    }
    
    internal BrewingStandState(Material id) : base(id)
    {
        Inventory = new BrewingInventory();
    }

    /// <inheritdoc />
    public ILockable Allow(string name)
    {
        Data["Lock"] = name;
        return this;
    }
}