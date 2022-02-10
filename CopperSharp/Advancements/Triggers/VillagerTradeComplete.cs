using CopperSharp.Advancements.Predicates;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
/// Triggers after the player
/// trades with a villager or a wandering trader.
/// </summary>
public sealed class VillagerTradeComplete : TriggerCondition
{
    /// <summary>
    /// Sets the item purchased.
    /// </summary>
    /// <param name="item">Item to be set</param>
    /// <returns>This trigger</returns>
    public VillagerTradeComplete Purchase(ItemPredicate item)
    {
        Items["item"] = item;
        return this;
    }

    /// <summary>
    /// Sets the villager with which was trade.
    /// </summary>
    /// <param name="entity">Entity to be set</param>
    /// <returns>This trigger</returns>
    public VillagerTradeComplete Villager(EntityPredicate entity)
    {
        Entities["villager"] = entity;
        return this;
    }
}