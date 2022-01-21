using CopperSharp.Data.Attributes;
using CopperSharp.Text;

namespace CopperSharp.Item;

/// <summary>
/// NBT Tag for items
/// </summary>
public struct ItemTag
{
    /// <summary>
    /// Material of this item
    /// </summary>
    public Material Type { get; }

    /// <summary>
    /// Attribute modifiers on this item
    /// </summary>
    public List<AttributeModifier> AttributeModifiers { get; }

    /// <summary>
    /// All enchantments applied to this item
    /// </summary>
    public List<Enchantment> Enchantments { get; } = new();

    /// <summary>
    /// Name of this item's display
    /// </summary>
    public IComponent Name { get; set; }

    /// <summary>
    /// Lore of this item's display
    /// </summary>
    public List<IComponent> Lore { get; set; }

    /// <summary>
    /// Adds specific enchantments to this item
    /// </summary>
    /// <param name="enchants">Enchantments to be added</param>
    /// <returns>This item meta</returns>
    public ItemTag Enchant(params Enchantment[] enchants)
    {
        Enchantments.AddRange(enchants);
        return this;
    }

    /// <summary>
    /// Appends provided components to item's lore display
    /// </summary>
    /// <param name="lore">Lines to be appended to item lore</param>
    /// <returns>This item meta</returns>
    public ItemTag AppendLore(params IComponent[] lore)
    {
        Lore.AddRange(lore);
        return this;
    }

    /// <summary>
    /// Adds attribute modifiers to this item's meta
    /// </summary>
    /// <param name="modifiers">Modifiers to be applied to this item</param>
    /// <returns>This item meta</returns>
    public ItemTag AddAttributes(params AttributeModifier[] modifiers)
    {
        AttributeModifiers.AddRange(modifiers);
        return this;
    }
}