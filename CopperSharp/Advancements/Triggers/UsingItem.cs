using CopperSharp.Advancements.Predicates;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
/// Triggers for every tick that the player uses an
/// item that is used continuously.
///
/// It is known to trigger for bows, crossbows, honey bottles,
/// milk buckets, potions, shields, spyglasses, tridents,
/// food items and eyes of ender. Most items that activate
/// from a single click, such as fishing rods,
/// do not affect this trigger.
/// </summary>
public sealed class UsingItem : TriggerCondition
{
    /// <summary>
    /// Sets the item used
    /// </summary>
    /// <param name="item">Item to be set</param>
    /// <returns>This trigger</returns>
    public UsingItem Item(ItemPredicate item)
    {
        Items["item"] = item;
        return this;
    }
}