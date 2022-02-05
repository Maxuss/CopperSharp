using CopperSharp.Item;

namespace CopperSharp.Block.State;

/// <summary>
/// Represents block state of furnace-like items
/// </summary>
public class FurnaceState : InventoryBlock<FurnaceInventory>, ILockable
{
    /// <summary>
    /// Number of ticks left before the current fuel runs out.
    /// </summary>
    /// <param name="time">Amount of time in ticks</param>
    /// <returns>This furnace state</returns>
    public FurnaceState BurnTime(short time)
    {
        Data["BurnTime"] = time;
        return this;
    }

    /// <summary>
    /// Number of ticks the item has been smelting for. Smelting finishes when it reaches 200
    /// </summary>
    /// <param name="time">Amount of time in ticks</param>
    /// <returns>This furnace state</returns>
    public FurnaceState CookTime(short time)
    {
        Data["CookTime"] = time;
        return this;
    }

    /// <summary>
    /// Number of ticks It takes for the item to be smelted. 200 by default
    /// </summary>
    /// <param name="time">Amount of time in ticks</param>
    /// <returns>This furnace state</returns>
    public FurnaceState ItemCookTime(short time)
    {
        Data["CookTimeTotal"] = time;
        return this;
    }
    
    /// <inheritdoc />
    protected FurnaceState(Material id) : base(id)
    {
        Inventory = new FurnaceInventory();
    }

    /// <inheritdoc />
    public ILockable Allow(string name)
    {
        Data["Lock"] = name;
        return this;
    }
}