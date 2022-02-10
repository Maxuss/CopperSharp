using CopperSharp.Advancements.Predicates;
using CopperSharp.Utils;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
/// Triggers after any item in the inventory has
/// been damaged in any form. 
/// </summary>
[CriterionName("item_durability_changed")]
public sealed class ItemDurabilityChanged : TriggerCondition
{
    /// <summary>
    /// Sets the change in durability
    /// </summary>
    /// <param name="delta">Delta durability change</param>
    /// <returns>This trigger</returns>
    public ItemDurabilityChanged Changed(StrictRange delta)
    {
        Ranges["delta"] = delta;
        return this;
    }

    /// <summary>
    /// Sets the remaining durability of item
    /// </summary>
    /// <param name="durability">Remaining durability</param>
    /// <returns>This trigger</returns>
    public ItemDurabilityChanged Remaining(StrictRange durability)
    {
        Ranges["durability"] = durability;
        return this;
    }

    /// <summary>
    /// Sets the item that lost the durability
    /// </summary>
    /// <param name="item">Item to be set</param>
    /// <returns>This trigger</returns>
    public ItemDurabilityChanged Item(ItemPredicate item)
    {
        Items["item"] = item;
        return this;
    }
}