using CopperSharp.Item;

namespace CopperSharp.Contexts;

public sealed class PlayerInventory
{
    internal PlayerInventory(WorldContext @lock, string name)
    {
        Lock = @lock;
        Name = name;
    }

    private string Name { get; }
    private WorldContext Lock { get; }

    /// <summary>
    ///     Sets item at certain position
    /// </summary>
    /// <param name="slot">Slot of item. Must be in range of 0 to 53</param>
    public ItemStack this[int slot]
    {
        set => InternalSetItem(slot, value);
    }

    private void InternalSetItem(int at, ItemStack item, string? slot = null)
    {
        var aslot = slot ?? $"container.{Math.Clamp(at, 0, 53)}";
        Lock.Cache.Add($"item replace entity {Name} {aslot} with {item.Serialize()}");
    }

    /// <summary>
    ///     Adds an item to this inventory
    /// </summary>
    /// <param name="item">Item to be added</param>
    public void AddItem(ItemStack item)
    {
        Lock.Cache.Add($"give {Name} {item.Serialize()}");
    }

    /// <summary>
    ///     Sets item in inventory
    /// </summary>
    /// <param name="item">Item to be set</param>
    /// <param name="at">Item index. Must be in range of 0 to 26</param>
    public void SetInventoryItem(ItemStack item, int at)
    {
        InternalSetItem(at, item, $"inventory.{Math.Clamp(at, 0, 26)}");
    }

    /// <summary>
    ///     Sets item in hotbar
    /// </summary>
    /// <param name="item">Item to be set</param>
    /// <param name="at">Item index. Must be in range of 0 to 8</param>
    public void SetHotbarItem(ItemStack item, int at)
    {
        InternalSetItem(at, item, $"hotbar.{Math.Clamp(at, 0, 8)}");
    }

    /// <summary>
    ///     Sets item in ender chest
    /// </summary>
    /// <param name="item">Item to be set</param>
    /// <param name="at">Item index. Must be in range of 0 to 26</param>
    public void SetEnderItem(ItemStack item, int at)
    {
        InternalSetItem(at, item, $"enderchest.{Math.Clamp(at, 0, 26)}");
    }

    /// <summary>
    ///     Sets helmet
    /// </summary>
    /// <param name="item">Item to be set</param>
    public void SetHelmet(ItemStack item)
    {
        InternalSetItem(-1, item, "armor.head");
    }

    /// <summary>
    ///     Sets chestplate
    /// </summary>
    /// <param name="item">Item to be set</param>
    public void SetChestplate(ItemStack item)
    {
        InternalSetItem(-1, item, "armor.chest");
    }

    /// <summary>
    ///     Sets leggings
    /// </summary>
    /// <param name="item">Item to be set</param>
    public void SetLeggings(ItemStack item)
    {
        InternalSetItem(-1, item, "armor.legs");
    }

    /// <summary>
    ///     Sets boots
    /// </summary>
    /// <param name="item">Item to be set</param>
    public void SetBoots(ItemStack item)
    {
        InternalSetItem(-1, item, "armor.feet");
    }

    /// <summary>
    ///     Sets item in main hand
    /// </summary>
    /// <param name="item">Item to be set</param>
    public void SetMainhand(ItemStack item)
    {
        InternalSetItem(-1, item, "weapon.mainhand");
    }

    /// <summary>
    ///     Sets item in off hand
    /// </summary>
    /// <param name="item">Item to be set</param>
    public void SetOffhand(ItemStack item)
    {
        InternalSetItem(-1, item, "weapon.offhand");
    }

    /// <summary>
    ///     Clears this inventory
    /// </summary>
    public void Clear()
    {
        Lock.Cache.Add($"clear {Name}");
    }
}