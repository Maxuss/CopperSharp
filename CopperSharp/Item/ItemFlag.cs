namespace CopperSharp.Item;

/// <summary>
///     Represents an item flag, that can be hidden
/// </summary>
public enum ItemFlag
{
    /// <summary>
    ///     Hides item's enchantments
    /// </summary>
    Enchantments = 1,

    /// <summary>
    ///     Hides item's attribute modifiers
    /// </summary>
    AttributeModifiers = 2,

    /// <summary>
    ///     Hides the item being unbreakable
    /// </summary>
    Unbreakable = 4,

    /// <summary>
    ///     Hides which blocks the item can destroy
    /// </summary>
    CanDestroy = 8,

    /// <summary>
    ///     Hides on which blocks the item can be placed
    /// </summary>
    CanPlaceOn = 16,

    /// <summary>
    ///     Hides different effects of item
    /// </summary>
    Effects = 32,

    /// <summary>
    ///     Hides the dye color of item
    /// </summary>
    Dyes = 64
}