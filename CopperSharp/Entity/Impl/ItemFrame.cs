using CopperSharp.Item;

namespace CopperSharp.Entity.Impl;

/// <summary>
/// Represents an item frame entity
/// </summary>
public sealed class ItemFrame : AbstractEntity
{
    internal ItemFrame() : base(EntityType.ItemFrame)
    {
    }

    private ItemStack? Item { get; set; }

    /// <summary>
    /// Whether this item frame will not break if block, it is placed on breaks
    /// </summary>
    /// <param name="fix">Whether to make it fixed</param>
    /// <returns>This item frame</returns>
    public ItemFrame Fixed(bool fix = true)
    {
        Bools["Fixed"] = fix;
        return this;
    }

    /// <summary>
    /// Whether this item frame is invisible
    /// </summary>
    /// <param name="invis">Marker</param>
    /// <returns>This item frame</returns>
    public ItemFrame Invisible(bool invis = true)
    {
        Bools["Invisible"] = invis;
        return this;
    }

    /// <summary>
    /// Amount of times item inside this frame was rotated
    /// </summary>
    /// <param name="times"></param>
    /// <returns>This item frame</returns>
    public ItemFrame Rotation(byte times)
    {
        Bytes["ItemRotation"] = times;
        return this;
    }

    /// <summary>
    /// Drop chance of item when the frame breaks. 1.0 by default
    /// </summary>
    /// <param name="chance">Chance to drop item</param>
    /// <returns>This item frame</returns>
    public ItemFrame DropChance(float chance)
    {
        ExtraData["ItemDropChance"] = chance;
        return this;
    }

    /// <summary>
    /// Sets item stored inside this frame
    /// </summary>
    /// <param name="item">Item to be set</param>
    /// <returns>This item frame</returns>
    public ItemFrame StoredItem(ItemStack item)
    {
        Item = item;
        return this;
    }
}