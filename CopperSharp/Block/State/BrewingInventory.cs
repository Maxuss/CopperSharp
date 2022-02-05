using CopperSharp.Item;

namespace CopperSharp.Block.State;

/// <summary>
/// Represents brewing stand's inventory
/// </summary>
public sealed class BrewingInventory : Inventory
{
    /// <inheritdoc />
    protected override int MaxSize => 5;

    /// <summary>
    /// Sets item in the left potion slot
    /// </summary>
    /// <param name="left">Item to be set</param>
    /// <returns>This brewing inventory</returns>
    public BrewingInventory LeftPotion(ItemStack? left)
    {
        SetItem(left, 0);
        return this;
    }
    
    /// <summary>
    /// Sets item in the middle potion slot
    /// </summary>
    /// <param name="mid">Item to be set</param>
    /// <returns>This brewing inventory</returns>
    public BrewingInventory MiddlePotion(ItemStack? mid)
    {
        SetItem(mid, 1);
        return this;
    }
    
    /// <summary>
    /// Sets item in the right potion slot
    /// </summary>
    /// <param name="right">Item to be set</param>
    /// <returns>This brewing inventory</returns>
    public BrewingInventory RightPotion(ItemStack? right)
    {
        SetItem(right, 2);
        return this;
    }

    /// <summary>
    /// Sets item in the ingredient slot
    /// </summary>
    /// <param name="ingredient">Item to be set</param>
    /// <returns>This brewing inventory</returns>
    public BrewingInventory Ingredient(ItemStack? ingredient)
    {
        SetItem(ingredient, 3);
        return this;
    }
    
    /// <summary>
    /// Sets item in the fuel slot
    /// </summary>
    /// <param name="fuel">Item to be set</param>
    /// <returns>This brewing inventory</returns>
    public BrewingInventory Fuel(ItemStack? fuel)
    {
        SetItem(fuel, 4);
        return this;
    }
}