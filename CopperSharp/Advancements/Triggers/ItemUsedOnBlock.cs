using CopperSharp.Advancements.Predicates;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
/// Triggers when the player uses their hand or an item on a block
/// </summary>
public sealed class ItemUsedOnBlock : TriggerCondition
{
    /// <summary>
    /// Sets the center of block this item was used on
    /// </summary>
    /// <param name="loc">Location to be set</param>
    /// <returns>This trigger</returns>
    public ItemUsedOnBlock Location(LocationPredicate loc)
    {
        Locations["location"] = loc;
        return this;
    }

    /// <summary>
    /// Sets the item used on block
    /// </summary>
    /// <param name="item">Item to be set</param>
    /// <returns>This trigger</returns>
    public ItemUsedOnBlock ItemUsed(ItemPredicate item)
    {
        Items["item"] = item;
        return this;
    }
}