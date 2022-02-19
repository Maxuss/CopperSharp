using CopperSharp.Item;
using CopperSharp.Models;
using CopperSharp.Modules;

namespace CopperSharp.Contexts;

/// <summary>
///     An inventory for player
/// </summary>
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
        set => InternalSetItem(slot, value).Wait();
    }

    private async Task InternalSetItem(int at, ItemStack item, string? slot = null)
    {
        var aslot = slot ?? $"container.{Math.Clamp(at, 0, 53)}";
        Lock.Cache.Add($"item replace entity {Name} {aslot} with {await item.Serialize()}");
    }

    /// <summary>
    ///     Adds an item to this inventory
    /// </summary>
    /// <param name="item">Item to be added</param>
    public async Task AddItem(ItemStack item)
    {
        Lock.Cache.Add($"give {Name} {await item.Serialize()}");
    }

    /// <summary>
    ///     Adds a disguised item to this inventory
    /// </summary>
    /// <param name="dis">Disguised item to be added</param>
    public async Task AddDisguise(Disguise dis)
    {
        var id = ModuleLoader.ModelManager.Lookup(dis);

        var item = new ItemStack(Material.Inject(dis.Base));
        item.Meta.CustomModelData = id;
        await AddItem(item);
    }

    /// <summary>
    ///     Sets item in inventory
    /// </summary>
    /// <param name="item">Item to be set</param>
    /// <param name="at">Item index. Must be in range of 0 to 26</param>
    public async Task SetInventoryItem(ItemStack item, int at)
    {
        await InternalSetItem(at, item, $"inventory.{Math.Clamp(at, 0, 26)}");
    }

    /// <summary>
    ///     Sets item in hotbar
    /// </summary>
    /// <param name="item">Item to be set</param>
    /// <param name="at">Item index. Must be in range of 0 to 8</param>
    public async Task SetHotbarItem(ItemStack item, int at)
    {
        await InternalSetItem(at, item, $"hotbar.{Math.Clamp(at, 0, 8)}");
    }

    /// <summary>
    ///     Sets item in ender chest
    /// </summary>
    /// <param name="item">Item to be set</param>
    /// <param name="at">Item index. Must be in range of 0 to 26</param>
    public async Task SetEnderItem(ItemStack item, int at)
    {
        await InternalSetItem(at, item, $"enderchest.{Math.Clamp(at, 0, 26)}");
    }

    /// <summary>
    ///     Sets helmet
    /// </summary>
    /// <param name="item">Item to be set</param>
    public async Task SetHelmet(ItemStack item)
    {
        await InternalSetItem(-1, item, "armor.head");
    }

    /// <summary>
    ///     Sets chestplate
    /// </summary>
    /// <param name="item">Item to be set</param>
    public async Task SetChestplate(ItemStack item)
    {
        await InternalSetItem(-1, item, "armor.chest");
    }

    /// <summary>
    ///     Sets leggings
    /// </summary>
    /// <param name="item">Item to be set</param>
    public async Task SetLeggings(ItemStack item)
    {
        await InternalSetItem(-1, item, "armor.legs");
    }

    /// <summary>
    ///     Sets boots
    /// </summary>
    /// <param name="item">Item to be set</param>
    public async Task SetBoots(ItemStack item)
    {
        await InternalSetItem(-1, item, "armor.feet");
    }

    /// <summary>
    ///     Sets item in main hand
    /// </summary>
    /// <param name="item">Item to be set</param>
    public async Task SetMainhand(ItemStack item)
    {
        await InternalSetItem(-1, item, "weapon.mainhand");
    }

    /// <summary>
    ///     Sets item in off hand
    /// </summary>
    /// <param name="item">Item to be set</param>
    public async Task SetOffhand(ItemStack item)
    {
        await InternalSetItem(-1, item, "weapon.offhand");
    }

    /// <summary>
    ///     Clears this inventory
    /// </summary>
    public void Clear()
    {
        Lock.Cache.Add($"clear {Name}");
    }
}