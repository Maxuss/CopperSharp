using System.Collections;
using CopperSharp.Data.SNbt;

namespace CopperSharp.Item;

/// <summary>
///     Represents an inventory
/// </summary>
public abstract class Inventory : IEnumerable<(ItemStack?, int)>
{
    /// <summary>
    ///     Max amount of items in this inventory
    /// </summary>
    protected abstract int MaxSize { get; }

    private List<(ItemStack?, int)> Slots { get; } = new();

    /// <inheritdoc />
    public IEnumerator<(ItemStack?, int)> GetEnumerator()
    {
        return Slots.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    /// <summary>
    ///     Adds an item to the next free slot
    /// </summary>
    /// <param name="item">Item to be added</param>
    /// <returns>This inventory</returns>
    public Inventory AddItem(ItemStack? item)
    {
        if (Slots.Count < MaxSize)
            Slots.Add((item, Slots.Count));

        return this;
    }

    /// <summary>
    ///     Sets item at specified position
    /// </summary>
    /// <param name="item">Item to be set</param>
    /// <param name="pos">Position at which the item should be set</param>
    /// <returns>This inventory</returns>
    public Inventory SetItem(ItemStack? item, int pos)
    {
        Slots.Add((item, pos));
        Slots.Capacity = MaxSize;
        Slots.TrimExcess();
        return this;
    }

    /// <summary>
    ///     Removes an item entry from this inventory
    /// </summary>
    /// <param name="pos">Position of item to be removed</param>
    /// <returns>This inventory</returns>
    public Inventory RemoveItem(int pos)
    {
        Slots.RemoveAt(pos);
        return this;
    }

    /// <summary>
    ///     Wipes an item entry, converting it to <see cref="ItemStack.AirStack" />
    /// </summary>
    /// <param name="pos">Position, at which the item should be wiped</param>
    /// <returns>This inventory</returns>
    public Inventory WipeItem(int pos)
    {
        Slots[pos] = (ItemStack.AirStack, pos);
        return this;
    }

    /// <summary>
    ///     Serializes this inventory into provided string nbt writer
    /// </summary>
    /// <param name="sw">String nbt writer into which data should be serialized</param>
    /// <param name="enclosed">Whether to enclose the compound in braces</param>
    public void SerializeInto(StringNbtWriter sw, bool enclosed = true)
    {
        if (enclosed) sw.WriteBeginCompound();

        sw.WritePropertyName("Items");

        sw.WriteBeginArray();
        foreach (var (item, index) in Slots.Where(it => it.Item1 != null)) sw.WriteItem(item, index);
        sw.WriteEndArray();
        if (enclosed) sw.WriteEndCompound();
    }
}