using CopperSharp.Data.SNbt;
using CopperSharp.Item;

namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents a donkey entity
/// </summary>
public class Donkey : HorseEntity
{
    internal Donkey() : base(EntityType.Donkey)
    {
    }

    private List<ItemStack?> Inventory { get; } = new();

    /// <summary>
    ///     Marks whether this donkey has chests
    /// </summary>
    /// <param name="has">Whether the donkey has chests</param>
    /// <returns>This donkey</returns>
    public Donkey HasChests(bool has = true)
    {
        Bools["ChestedHorse"] = has;
        return this;
    }

    /// <summary>
    ///     Adds an item to donkey's inventory
    /// </summary>
    /// <param name="item">Item to be added</param>
    /// <param name="slot">Slot to which to add item. If negative, next free space will be used.</param>
    /// <returns>This donkey</returns>
    public Donkey AddItem(ItemStack? item, int slot = -1)
    {
        if (slot < 0)
        {
            if (Inventory.Count > 15)
                Inventory[15] = item;
            else
                Inventory.Add(item);
        }
        else
        {
            Inventory[Math.Min(15, slot)] = item;
        }

        return this;
    }

    /// <inheritdoc />
    protected override async Task SerializeExtra(INbtWriter sw)
    {
        await base.SerializeExtra(sw);

        if (Inventory.All(it => it == null)) return;

        await sw.WritePropertyNameAsync("Inventory");
        await sw.WriteBeginArrayAsync();
        foreach (var item in Inventory.Where(it => it != null)) await sw.WriteItem(item);

        await sw.WriteEndArrayAsync();
    }
}