using CopperSharp.Utils;

namespace CopperSharp.Item;

/// <summary>
///     Represents an equipable slot for items
/// </summary>
public enum ItemSlot
{
    /// <summary>
    ///     An item stored in main hand slot
    /// </summary>
    [EnumData("mainhand")] MainHand = 0,

    /// <summary>
    ///     An item stored in off hand slot
    /// </summary>
    [EnumData("offhand")] OffHand = 5,

    /// <summary>
    ///     An item stored in helmet slot
    /// </summary>
    [EnumData("head")] Head = 4,

    /// <summary>
    ///     An item stored in chestplate slot
    /// </summary>
    [EnumData("chest")] Chestplate = 3,

    /// <summary>
    ///     An item stored in leggings slot
    /// </summary>
    [EnumData("legs")] Leggings = 2,

    /// <summary>
    ///     An item stored in boots slot
    /// </summary>
    [EnumData("feet")] Boots = 1
}