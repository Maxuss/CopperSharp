using CopperSharp.Data.SNbt;
using CopperSharp.Item;

namespace CopperSharp.Entity.Impl;

/// <summary>
/// Represents a mule entity
/// </summary>
public class Mule : HorseEntity
{
    internal Mule() : base(EntityType.Mule)
    {
    }

    private List<ItemStack?> Inventory { get; set; } = new();

    /// <summary>
    /// Marks that this mule has chests
    /// </summary>
    /// <param name="has">Whether this mule has chests</param>
    /// <returns>This mule</returns>
    public Mule HasChest(bool has = true)
    {
        Bools["ChestedHorse"] = has;
        return this;
    }

    /// <summary>
    /// Adds an item to mule's inventory
    /// </summary>
    /// <param name="item">Item to be added</param>
    /// <param name="slot">Slot to which to add item. If negative, next free space will be used.</param>
    /// <returns>This donkey</returns>
    public Mule AddItem(ItemStack? item, int slot = -1)
    {
        if (slot < 0)
        {
            if (Inventory.Count > 15)
                Inventory[15] = item;
            else
                Inventory.Add(item);
        }
        else Inventory[Math.Min(15, slot)] = item;

        return this;
    }

    /// <inheritdoc />
    protected override void SerializeExtra(StringNbtWriter sw)
    {
        base.SerializeExtra(sw);

        if (Inventory.All(it => it == null)) return;

        sw.WritePropertyName("Inventory");
        sw.WriteBeginArray();
        foreach (var item in Inventory.Where(it => it != null))
        {
            sw.WriteItem(item);
        }

        sw.WriteEndArray();
    }
}