using CopperSharp.Data.SNbt;
using CopperSharp.Item;

namespace CopperSharp.Blocks;

/// <summary>
///     Represents a block that can have an inventory inside
/// </summary>
public abstract class InventoryBlock<TInventory> : BlockState where TInventory : Inventory
{
    /// <inheritdoc />
    protected InventoryBlock(Material id) : base(id)
    {
    }

    /// <summary>
    ///     Inventory of this inventory block state
    /// </summary>
    #nullable disable
    public TInventory Inventory { get; protected set; }
    #nullable restore
    /// <summary>
    ///     Adds an item to this inventory container
    /// </summary>
    /// <param name="item">Item to be added</param>
    /// <param name="at">Position on which to add item. -1 For next avaialable</param>
    /// <returns>This inventory block</returns>
    public InventoryBlock<TInventory> AddItem(ItemStack? item, int at = -1)
    {
        if (at < 0)
            Inventory.AddItem(item);
        else
            Inventory.SetItem(item, at);

        return this;
    }

    /// <inheritdoc />
    internal override void SerializeExtra(StringNbtWriter sw)
    {
        base.SerializeExtra(sw);

        if (Inventory.Any(it => it.Item1 != null))
            Inventory.SerializeInto(sw, false);
    }
}