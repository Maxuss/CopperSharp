using CopperSharp.Advancements.Predicates;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
/// Triggers when the player interacts with an entity.
/// </summary>
public sealed class PlayerInteractEntity : TriggerCondition
{
    /// <summary>
    /// Sets the item that was in the player's hand during interaction
    /// </summary>
    /// <param name="item">Item to be set</param>
    /// <returns>This trigger</returns>
    public PlayerInteractEntity HandItem(ItemPredicate item)
    {
        Items["item"] = item;
        return this;
    }

    /// <summary>
    /// Sets the entity which was interacted with.
    /// </summary>
    /// <param name="entity">Entity to be set</param>
    /// <returns>This trigger</returns>
    public PlayerInteractEntity Entity(EntityPredicate entity)
    {
        Entities["entity"] = entity;
        return this;
    }
}