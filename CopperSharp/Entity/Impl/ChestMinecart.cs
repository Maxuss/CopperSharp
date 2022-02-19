using CopperSharp.Data.SNbt;
using CopperSharp.Item;
using CopperSharp.Registry;

namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents a chest minecart vehicle
/// </summary>
public sealed class ChestMinecart : AbstractMinecart
{
    internal ChestMinecart() : base(EntityType.ChestMinecart)
    {
    }

    private List<ItemStack> Items { get; } = new();

    /// <summary>
    ///     Adds provided items to this minecart's storage
    /// </summary>
    /// <param name="items">Items to be added</param>
    /// <returns>This chest minecart</returns>
    public ChestMinecart AddItems(params ItemStack[] items)
    {
        Items.AddRange(items);
        return this;
    }

    /// <summary>
    ///     Sets loot table used to populate this minecart's contents
    /// </summary>
    /// <param name="table">Loot table identifier</param>
    /// <returns>This chest minecart</returns>
    public ChestMinecart LootTable(Identifier table)
    {
        Strings["LootTable"] = table.ToString();
        return this;
    }

    /// <inheritdoc />
    protected override async Task SerializeExtra(INbtWriter sw)
    {
        await base.SerializeExtra(sw);

        if (!Items.Any())
            return;

        await sw.WritePropertyNameAsync("Items");
        await sw.WriteBeginArrayAsync();
        foreach (var item in Items)
        {
            var ind = Items.IndexOf(item);

            await sw.WriteItem(item, ind);
        }

        await sw.WriteEndArrayAsync();
    }
}