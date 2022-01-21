using CopperSharp.Data.Attributes;
using CopperSharp.Registry;
using CopperSharp.Text;

namespace CopperSharp.Item;

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
        Name = IComponent.Material(type);
        Type = type;
    }

    /// <summary>
    /// Material of this item
    /// </summary>
    public Material Type { get; }

    /// <summary>
    /// Attribute modifiers on this item
    /// </summary>
    public List<AttributeModifier> AttributeModifiers { get; } = new();

    /// <summary>
    /// All enchantments applied to this item
    /// </summary>
    public List<Enchantment> Enchantments { get; } = new();

    /// <summary>
    /// Item flags to be hidden
    /// </summary>
    public List<ItemFlag> HiddenFlags { get; } = new();

    /// <summary>
    /// Whether this item is unbreakable
    /// </summary>
    public bool Unbreakable { get; } = false;

    /// <summary>
    /// Name of this item's display
    /// </summary>
    public IComponent Name { get; set; }

    /// <summary>
    /// Lore of this item's display
    /// </summary>
    public List<IComponent> Lore { get; set; } = new();

    /// <summary>
    /// Represents blocks this item can/can not destroy
    /// </summary>
    public List<string> Destroyable { get; } = new();

    /// <summary>
    /// Time required to pick this item up in ticks (when dropped)
    /// </summary>
    public long? PickupDelay { get; set; } = null;

    /// <summary>
    /// Time it takes this item to disappear in ticks (when dropped)
    /// </summary>
    public long? Age { get; set; } = null;

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
}