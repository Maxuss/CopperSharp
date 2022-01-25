using CopperSharp.Data.Attributes;
using CopperSharp.Data.SNbt;
using CopperSharp.Registry;
using CopperSharp.Text;
using CopperSharp.Utils;

namespace CopperSharp.Item.Meta;

/// <summary>
/// NBT Tag for items
/// </summary>
public abstract class ItemMeta
{
    /// <summary>
    /// Instantiates a new item meta class
    /// </summary>
    /// <param name="type"></param>
    protected ItemMeta(Material type)
    {
        Type = type;
    }

    /// <summary>
    /// Material of this item
    /// </summary>
    private Material Type { get; }

    /// <summary>
    /// Attribute modifiers on this item
    /// </summary>
    private List<AttributeModifier> AttributeModifiers { get; } = new();

    /// <summary>
    /// All enchantments applied to this item
    /// </summary>
    private List<Enchantment> Enchantments { get; } = new();

    /// <summary>
    /// Item flags to be hidden
    /// </summary>
    private List<ItemFlag> HiddenFlags { get; } = new();

    /// <summary>
    /// Whether this item is unbreakable
    /// </summary>
    public bool? Unbreakable { get; set; } = null;

    /// <summary>
    /// Name of this item's display
    /// </summary>
    private IComponent? Name { get; set; } = null;

    /// <summary>
    /// Lore of this item's display
    /// </summary>
    private List<IComponent> Lore { get; } = new();

    /// <summary>
    /// Represents blocks this item can/can not destroy
    /// </summary>
    private List<string> Destroyable { get; } = new();

    /// <summary>
    /// Time required to pick this item up in ticks (when dropped)
    /// </summary>
    public int? PickupDelay { get; set; } = null;

    /// <summary>
    /// Time it takes this item to disappear in ticks (when dropped)
    /// </summary>
    public int? Age { get; set; } = null;

    /// <summary>
    /// Adds specific enchantments to this item
    /// </summary>
    /// <param name="enchants">Enchantments to be added</param>
    /// <returns>This item meta</returns>
    public ItemMeta Enchant(params Enchantment[] enchants)
    {
        Enchantments.AddRange(enchants);
        return this;
    }

    /// <summary>
    /// Appends provided components to item's lore display
    /// </summary>
    /// <param name="lore">Lines to be appended to item lore</param>
    /// <returns>This item meta</returns>
    public ItemMeta AppendLore(params IComponent[] lore)
    {
        Lore.AddRange(lore);
        return this;
    }

    /// <summary>
    /// Adds a custom name to this item's lore display
    /// </summary>
    /// <param name="name">New custom name of the item</param>
    /// <returns>This item meta</returns>
    public ItemMeta CustomName(IComponent name)
    {
        Name = name;
        return this;
    }

    /// <summary>
    /// Adds attribute modifiers to this item's meta
    /// </summary>
    /// <param name="modifiers">Modifiers to be applied to this item</param>
    /// <returns>This item meta</returns>
    public ItemMeta AddAttributes(params AttributeModifier[] modifiers)
    {
        AttributeModifiers.AddRange(modifiers);
        return this;
    }

    /// <summary>
    /// Hides provided item flags from item meta
    /// </summary>
    /// <param name="flags">Item flags to be hidden on this item</param>
    /// <returns>This item meta</returns>
    public ItemMeta HideFlags(params ItemFlag[] flags)
    {
        HiddenFlags.AddRange(flags);
        return this;
    }

    /// <summary>
    /// Adds provided ids as blocks, this item can destroy
    /// </summary>
    /// <param name="ids">Blocks that can be destroyed</param>
    /// <returns>This item meta</returns>
    public ItemMeta CanDestroy(params Identifier[] ids)
    {
        Destroyable.AddRange(ids.Select(it => it.ToString()));
        return this;
    }

    /// <summary>
    /// Converts this item meta to Stringified NBT
    /// </summary>
    /// <returns>Serialized StringNBT</returns>
    public string ToSNbt(int? slot = null)
    {
        using var sw = new StringWriter();
        using var w = new StringNbtWriter(sw);
        w.WriteBeginCompound();
        // begin display tag
        if (slot != null)
            w.WriteInteger("Slot", slot ?? -1);

        if (Name != null || Lore.Any())
        {
            w.WritePropertyName("display");
            w.WriteBeginCompound();

            if (Name != null)
            {
                w.WritePropertyName("Name");
                w.WriteString(Name.Serialize());
            }

            if (Lore.Any())
            {
                w.WritePropertyName("Lore");
                w.WriteBeginArray();
                foreach (var component in Lore)
                {
                    w.WriteString(component.Serialize());
                }

                w.WriteEndArray();
            }

            w.WriteEndCompound();
        }
        // end display tag

        // begin enchantments tag
        if (Enchantments.Any())
        {
            w.WritePropertyName("Enchantments");
            w.WriteBeginArray();
            foreach (var enchant in Enchantments)
            {
                var edata = enchant.Enchant.GetEnchantData() ??
                            throw new Exception("Invalid enchantment data provided!");
                var lvl = enchant.Level;
                if (Enchantments.IndexOf(enchant) != 0)
                    w.WriteComma();
                w.WriteBeginCompound();
                w.WritePropertyName("id");
                w.WriteString($"minecraft:{edata.Id}");
                w.WritePropertyName("lvl");
                w.WriteInteger(lvl);
                w.WriteEndCompound();
            }

            w.WriteEndArray();
            w.WriteComma();
        }
        // end enchantments tag

        // begin CanDestroy tag
        if (Destroyable.Any())
        {
            w.WritePropertyName("CanDestroy");
            w.WriteBeginArray();
            foreach (var dest in Destroyable)
            {
                w.WriteString(dest);
            }

            w.WriteEndArray();
            w.WriteComma();
        }
        // end CanDestroy tag

        // begin HideFlags tag
        if (HiddenFlags.Any())
        {
            w.WritePropertyName("HideFlags");
            w.WriteInteger(HiddenFlags.Sum(it => (int) it));
        }
        // end HideFlags tag

        // begin AttributeModifiers tag
        if (AttributeModifiers.Any())
        {
            w.WritePropertyName("AttributeModifiers");
            w.WriteBeginArray();
            foreach (var attr in AttributeModifiers)
            {
                if (AttributeModifiers.IndexOf(attr) != 0)
                    w.WriteComma();
                w.WriteBeginCompound();
                w.WritePropertyName("AttributeName");
                w.WriteString(attr.Type);
                w.WritePropertyName("Name");
                w.WriteString(attr.Name);
                w.WritePropertyName("Amount");
                w.WriteFloat(attr.Amount);
                w.WritePropertyName("Operation");
                w.WriteInteger((int) attr.Action);
                if (attr.Slot != null)
                {
                    w.WritePropertyName("Slot");
                    w.WriteString(attr.Slot ?? "mainhand");
                }

                w.WritePropertyName("UUID");
                w.WriteUuidArray(Guid.NewGuid());
                w.WriteEndCompound();
            }

            w.WriteEndArray();
        }
        // end AttributeModifiers tag

        // begin unbreakable tag
        if (Unbreakable != null)
        {
            w.WritePropertyName("Unbreakable");
            w.WriteBool(Unbreakable.Value);
        }
        // end unbreakable tag

        // begin PickupDelay tag
        if (PickupDelay != null)
        {
            w.WritePropertyName("PickupDelay");
            w.WriteInteger(PickupDelay ?? 0);
        }
        // end PickupDelay tag

        // begin Age tag
        if (Age != null)
        {
            w.WritePropertyName("Age");
            w.WriteInteger(Age ?? 0);
        }
        // end Age tag

        // external meta
        WriteExternalMetaData(w);

        w.WriteEndCompound();
        return sw.ToString();
    }

    /// <summary>
    /// Writes external meta data to the writer as nbt
    /// </summary>
    /// <param name="w">Writer to which external meta data should be written</param>
    protected abstract void WriteExternalMetaData(StringNbtWriter w);
}