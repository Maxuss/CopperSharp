using CopperSharp.Advancements.Predicates;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
/// Triggers after the player successfully catches an
/// item with a fishing rod or pulls an entity with
/// a fishing rod
/// </summary>
[CriterionName("fishing_rod_hooked")]
public sealed class FishingRodHooked : TriggerCondition
{
    /// <summary>
    /// Sets the required fishing rod to be used
    /// </summary>
    /// <param name="rod">Rod to be set</param>
    /// <returns>This trigger</returns>
    public FishingRodHooked RodUsed(ItemPredicate rod)
    {
        Items["rod"] = rod;
        return this;
    }
    
    /// <summary>
    /// Sets the entity pulled with a hook
    /// </summary>
    /// <param name="entity">Predicate to be set</param>
    /// <returns>This trigger</returns>
    public FishingRodHooked Hooked(EntityPredicate entity)
    {
        Entities["entity"] = entity;
        return this;
    }
    
    /// <summary>
    /// Sets the item caught
    /// </summary>
    /// <param name="item">Item to be set</param>
    /// <returns>This trigger</returns>
    public FishingRodHooked Caught(ItemPredicate item)
    {
        Items["item"] = item;
        return this;
    }
}