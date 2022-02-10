using CopperSharp.Advancements.Predicates;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
/// Triggers when the player consumes an item
/// </summary>
[CriterionName("consume_item")]
public sealed class ConsumeItem : TriggerCondition
{
    /// <summary>
    /// Sets the item that was consumed
    /// </summary>
    /// <param name="item">Item to be set</param>
    /// <returns>This consume item condition</returns>
    public ConsumeItem Item(ItemPredicate item)
    {
        Items["item"] = item;
        return this;
    }
}