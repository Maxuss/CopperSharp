using CopperSharp.Data.Attributes;
using CopperSharp.Data.SNbt;
using CopperSharp.Registry;
using CopperSharp.Text;
using CopperSharp.Utils;

namespace CopperSharp.Item.Meta;

/// <summary>
///     NBT Tag for items
/// </summary>
public abstract class ItemMeta
{
    /// <summary>
    ///     Instantiates a new item meta class
    /// </summary>
    /// <param name="type"></param>
    protected ItemMeta(Material type)
    {
        Type = type;
    }

    /// <summary>
    ///     Material of this item
    /// </summary>
    private Material Type { get; }

    /// <summary>
    ///     Attribute modifiers on this item
    /// </summary>
    private List<AttributeModifier> AttributeModifiers { get; } = new();

    /// <summary>
    ///     All enchantments applied to this item
    /// </summary>
    private List<Enchantment> Enchantments { get; } = new();

    /// <summary>
    ///     Item flags to be hidden
    /// </summary>
    private List<ItemFlag> HiddenFlags { get; } = new();

    /// <summary>
    ///     Whether this item is unbreakable
    /// </summary>
    public bool? Unbreakable { get; set; } = null;

    /// <summary>
    ///     Name of this item's display
    /// </summary>
    private Component? Name { get; set; }

    /// <summary>
    ///     Lore of this item's display
    /// </summary>
    private List<Component> Lore { get; } = new();

    /// <summary>
    ///     Represents blocks this item can/can not destroy
    /// </summary>
    private List<string> Destroyable { get; } = new();

    /// <summary>
    ///     Time required to pick this item up in ticks (when dropped)
    /// </summary>
    public int? PickupDelay { get; set; } = null;

    /// <summary>
    ///     Time it takes this item to disappear in ticks (when dropped)
    /// </summary>
    public int? Age { get; set; } = null;

    /// <summary>
    ///     Custom model data of this item
    /// </summary>
    public int? CustomModelData { get; set; } = null;

    /// <summary>
    ///     Adds specific enchantments to this item
    /// </summary>
    /// <param name="enchants">Enchantments to be added</param>
    /// <returns>This item meta</returns>
    public ItemMeta Enchant(params Enchantment[] enchants)
    {
        Enchantments.AddRange(enchants);
        return this;
    }

    /// <summary>
    ///     Appends provided components to item's lore display
    /// </summary>
    /// <param name="lore">Lines to be appended to item lore</param>
    /// <returns>This item meta</returns>
    public ItemMeta AppendLore(params Component[] lore)
    {
        Lore.AddRange(lore);
        return this;
    }

    /// <summary>
    ///     Adds a custom name to this item's lore display
    /// </summary>
    /// <param name="name">New custom name of the item</param>
    /// <returns>This item meta</returns>
    public ItemMeta CustomName(Component name)
    {
        Name = name;
        return this;
    }

    /// <summary>
    ///     Adds attribute modifiers to this item's meta
    /// </summary>
    /// <param name="modifiers">Modifiers to be applied to this item</param>
    /// <returns>This item meta</returns>
    public ItemMeta AddAttributes(params AttributeModifier[] modifiers)
    {
        AttributeModifiers.AddRange(modifiers);
        return this;
    }

    /// <summary>
    ///     Hides provided item flags from item meta
    /// </summary>
    /// <param name="flags">Item flags to be hidden on this item</param>
    /// <returns>This item meta</returns>
    public ItemMeta HideFlags(params ItemFlag[] flags)
    {
        HiddenFlags.AddRange(flags);
        return this;
    }

    /// <summary>
    ///     Adds provided ids as blocks, this item can destroy
    /// </summary>
    /// <param name="ids">Blocks that can be destroyed</param>
    /// <returns>This item meta</returns>
    public ItemMeta CanDestroy(params Identifier[] ids)
    {
        Destroyable.AddRange(ids.Select(it => it.ToString()));
        return this;
    }

    /// <summary>
    ///     Converts this item meta to Stringified NBT
    /// </summary>
    /// <returns>Serialized StringNBT</returns>
    public async Task<string> Serialize(int? slot = null, Identifier? id = null)
    {
        await using var sw = new StringWriter();
        await using var w = new StringNbtWriter(sw);

        await w.WriteBeginCompoundAsync();
        // begin display tag
        if (slot != null)
            await w.WriteIntegerAsync("Slot", slot ?? -1);

        if (Name != null || Lore.Any())
        {
            await w.WritePropertyNameAsync("display");
            await w.WriteBeginCompoundAsync();

            if (Name != null)
            {
                await w.WritePropertyNameAsync("Name");
                await w.WriteStringAsync(await Name.Serialize());
            }

            if (Lore.Any())
            {
                await w.WritePropertyNameAsync("Lore");
                await w.WriteBeginArrayAsync();
                foreach (var component in Lore)
                    await w.WriteStringAsync(await component.Serialize());

                await w.WriteEndArrayAsync();
            }

            await w.WriteEndCompoundAsync();
        }
        // end display tag

        // begin enchantments tag
        if (Enchantments.Any())
        {
            await w.WritePropertyNameAsync("Enchantments");
            await w.WriteBeginArrayAsync();
            foreach (var enchant in Enchantments)
            {
                var edata = enchant.Enchant.GetEnchantData() ??
                            throw new Exception("Invalid enchantment data provided!");
                var lvl = enchant.Level;
                await w.WriteBeginCompoundAsync();
                await w.WritePropertyNameAsync("id");
                await w.WriteStringAsync($"minecraft:{edata.Id}");
                await w.WritePropertyNameAsync("lvl");
                await w.WriteIntegerAsync(lvl);
                await w.WriteEndCompoundAsync();
            }

            await w.WriteEndArrayAsync();
        }
        // end enchantments tag

        // begin CanDestroy tag
        if (Destroyable.Any())
        {
            await w.WritePropertyNameAsync("CanDestroy");
            await w.WriteBeginArrayAsync();
            foreach (var dest in Destroyable) await w.WriteStringAsync(dest);

            await w.WriteEndArrayAsync();
        }
        // end CanDestroy tag

        // begin HideFlags tag
        if (HiddenFlags.Any())
        {
            await w.WritePropertyNameAsync("HideFlags");
            await w.WriteIntegerAsync(HiddenFlags.Sum(it => (int) it));
        }
        // end HideFlags tag

        // begin AttributeModifiers tag
        if (AttributeModifiers.Any())
        {
            await w.WritePropertyNameAsync("AttributeModifiers");
            await w.WriteBeginArrayAsync();
            foreach (var attr in AttributeModifiers)
            {
                await w.WriteBeginCompoundAsync();
                await w.WritePropertyNameAsync("AttributeName");
                await w.WriteStringAsync(attr.Type);
                await w.WritePropertyNameAsync("Name");
                await w.WriteStringAsync(attr.Name);
                await w.WritePropertyNameAsync("Amount");
                await w.WriteFloatAsync(attr.Amount);
                await w.WritePropertyNameAsync("Operation");
                await w.WriteIntegerAsync((int) attr.Action);
                if (attr.Slot != null)
                {
                    await w.WritePropertyNameAsync("Slot");
                    await w.WriteStringAsync(attr.Slot ?? "mainhand");
                }

                await w.WritePropertyNameAsync("UUID");
                await w.WriteUuidArrayAsync(Guid.NewGuid());
                await w.WriteEndCompoundAsync();
            }

            await w.WriteEndArrayAsync();
        }
        // end AttributeModifiers tag

        // begin unbreakable tag
        if (Unbreakable != null)
        {
            await w.WritePropertyNameAsync("Unbreakable");
            await w.WriteBoolAsync(Unbreakable.Value);
        }
        // end unbreakable tag

        // begin PickupDelay tag
        if (PickupDelay != null)
        {
            await w.WritePropertyNameAsync("PickupDelay");
            await w.WriteIntegerAsync(PickupDelay ?? 0);
        }
        // end PickupDelay tag

        // begin Age tag
        if (Age != null)
        {
            await w.WritePropertyNameAsync("Age");
            await w.WriteIntegerAsync(Age ?? 0);
        }
        // end Age tag

        // begin CustomModelData tag
        if (CustomModelData != null)
        {
            await w.WritePropertyNameAsync("CustomModelData");
            await w.WriteIntegerAsync(CustomModelData ?? 0x00000);
        }
        // end CustomModelData tag

        // external meta
        await WriteExternalMetaData(w);

        await w.WriteEndCompoundAsync();
        return sw.ToString();
    }

    /// <summary>
    ///     Writes external meta data to the writer as nbt
    /// </summary>
    /// <param name="w">Writer to which external meta data should be written</param>
    internal abstract Task WriteExternalMetaData(INbtWriter w);
}