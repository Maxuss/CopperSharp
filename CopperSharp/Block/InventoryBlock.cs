using CopperSharp.Data.SNbt;
using CopperSharp.Item;

namespace CopperSharp.Block;

/// <summary>
/// Represents a block that can have an inventory inside
/// </summary>
public abstract class InventoryBlock : BlockState
{
    private List<(ItemStack?, int)> Inventory { get; set; } = new();

    /// <summary>
    /// Adds an item to this inventory container
    /// </summary>
    /// <param name="item">Item to be added</param>
    /// <param name="at">Position on which to add item. -1 For next avaialable</param>
    /// <returns>This inventory block</returns>
    public InventoryBlock AddItem(ItemStack? item, int at = -1)
    {
        Inventory.Add(at == -1 ? (item, Inventory.Count) : (item, at));
        return this;
    }

    /// <inheritdoc />
    protected override void SerializeExtra(StringNbtWriter sw)
    {
        base.SerializeExtra(sw);

        if (Inventory.All(it => it.Item1 == null)) return;
        sw.WritePropertyName("Items"); 
        sw.WriteBeginArray();
        foreach (var (item, pos) in Inventory.Where(it => it.Item1 != null))
        {
            sw.WriteItem(item, pos); 
        }
        sw.WriteEndArray();
    }

    /// <inheritdoc />
    protected InventoryBlock(Material id) : base(id)
    {
    }
}