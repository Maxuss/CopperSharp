using CopperSharp.Advancements.Predicates;
using CopperSharp.Utils;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
/// Triggers after the player enchants an item through
/// an enchanting table (does not get triggered through
/// an anvil, or through commands).
/// </summary>
[CriterionName("enchanted_item")]
public sealed class EnchantedItem : TriggerCondition
{
    /// <summary>
    /// Sets the enchanted item. All desired
    /// enchantments must be specified inside of it.
    /// </summary>
    /// <param name="item">Item predicate to be set</param>
    /// <returns>This trigger</returns>
    public EnchantedItem Item(ItemPredicate item)
    {
        Items["item"] = item;
        return this;
    }

    /// <summary>
    /// Sets the amount of levels spent on enchantment
    /// </summary>
    /// <param name="levels">Levels spent</param>
    /// <returns>This trigger</returns>
    public EnchantedItem LevelsSpent(StrictRange levels)
    {
        Ranges["levels"] = levels;
        return this;
    }
}