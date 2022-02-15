using CopperSharp.Advancements.Predicates;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
///     Triggers when a lightning bolt disappears from the world,
///     only for players within a 256 block radius of the lightning bolt
/// </summary>
[CriterionName("lightning_strike")]
public sealed class LightningStrikeTrigger : TriggerCondition
{
    /// <summary>
    ///     Sets the lightning bolt that disappeared
    /// </summary>
    /// <param name="entity">Predicate to be set</param>
    /// <returns>This trigger</returns>
    public LightningStrikeTrigger Lightning(EntityPredicate entity)
    {
        Entities["lightning"] = entity;
        return this;
    }

    /// <summary>
    ///     Sets the entity not hurt by the lightning strike
    ///     but in a certain area around it
    /// </summary>
    /// <param name="entity">Entity to be set</param>
    /// <returns>This trigger</returns>
    public LightningStrikeTrigger Bystander(EntityPredicate entity)
    {
        Entities["bystander"] = entity;
        return this;
    }
}