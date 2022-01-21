using CopperSharp.Utils;

namespace CopperSharp.Item;

/// <summary>
/// Represents an equipable slot for items
/// </summary>
public enum ItemSlot
{
    /// <summary>
    /// An item stored in main hand slot
    /// </summary>
    [EnumData("mainhand")] MainHand,

    /// <summary>
    /// An item stored in off hand slot
    /// </summary>
    [EnumData("offhand")] OffHand,

    /// <summary>
    /// An item stored in helmet slot
    /// </summary>
    [EnumData("head")] Head,

    /// <summary>
    /// An item stored in chestplate slot
    /// </summary>
    [EnumData("chest")] Chestplate,

    /// <summary>
    /// An item stored in leggings slot
    /// </summary>
    [EnumData("legs")] Leggings,

    /// <summary>
    /// An item stored in boots slot
    /// </summary>
    [EnumData("feet")] Boots
}