using CopperSharp.Advancements.Predicates;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
/// Triggers after the player throws an item
/// and another entity picks it up.
/// </summary>
[CriterionName("thrown_item_picked_up_by_entity")]
public sealed class EntityPickUpItem : TriggerCondition
{
    /// <summary>
    /// Sets the item that was picked up
    /// </summary>
    /// <param name="item">Item to be set</param>
    /// <returns>This trigger</returns>
    public EntityPickUpItem Item(ItemPredicate item)
    {
        Items["item"] = item;
        return this;
    }
    
    /// <summary>
    /// Sets the entity which picked up the item.
    /// </summary>
    /// <param name="entity">Entity to be set</param>
    /// <returns>This trigger</returns>
    public EntityPickUpItem Entity(EntityPredicate entity)
    {
        Entities["entity"] = entity;
        return this;
    }
}