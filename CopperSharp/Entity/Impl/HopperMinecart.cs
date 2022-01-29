using CopperSharp.Data.SNbt;
using CopperSharp.Item;
using CopperSharp.Registry;

namespace CopperSharp.Entity.Impl;

/// <summary>
/// Represents a hopper minecart vehicle
/// </summary>
public class HopperMinecart : AbstractMinecart
{
    internal HopperMinecart() : base(EntityType.HopperMinecart)
    {
    }

    private List<ItemStack> Items { get; set; } = new();

    /// <summary>
    /// Whether to enable this hopper minecart
    /// </summary>
    /// <param name="enable">Marker</param>
    /// <returns>This hopper minecart</returns>
    public HopperMinecart Enabled(bool enable = true)
    {
        Bools["Enabled"] = enable;
        return this;
    }

    /// <summary>
    /// Sets cooldown between this hopper can transfer items.
    ///
    /// Cooldown must be within range of 0 to 8.
    ///
    /// Set 0 if there is no transfer
    /// </summary>
    /// <param name="cd"></param>
    /// <returns></returns>
    public HopperMinecart TransferCooldown(int cd)
    {
        Ints["TransferCooldown"] = Math.Clamp(cd, 0, 8);
        return this;
    }

    /// <summary>
    /// Adds provided items to this minecart's storage
    /// </summary>
    /// <param name="items">Items to be added</param>
    /// <returns>This hopper minecart</returns>
    public HopperMinecart AddItems(params ItemStack[] items)
    {
        Items.AddRange(items);
        return this;
    }

    /// <summary>
    /// Sets loot table used to populate this minecart's contents
    /// </summary>
    /// <param name="table">Loot table identifier</param>
    /// <returns>This hopper minecart</returns>
    public HopperMinecart LootTable(Identifier table)
    {
        Strings["LootTable"] = table.ToString();
        return this;
    }

    /// <inheritdoc />
    protected override void SerializeExtra(StringNbtWriter sw)
    {
        base.SerializeExtra(sw);

        if (!Items.Any())
            return;

        sw.WritePropertyName("Items");
        sw.WriteBeginArray();
        foreach (var item in Items)
        {
            var ind = Items.IndexOf(item);
            if (ind != 0)
                sw.WriteComma();

            sw.WriteItem(item, ind);
        }

        sw.WriteEndArray();
    }
}