using CopperSharp.Advancements.Predicates;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
/// Triggers after an entity has been summoned.
/// Works with iron golems (pumpkin and iron blocks),
/// snow golems (pumpkin and snow blocks),
/// the ender dragon (end crystals) and the wither
/// (wither skulls and soul sand/soul soil).
///
/// Using dispensers to place the wither skulls
/// or pumpkins will still activate this trigger.
///
/// Spawn eggs, commands and mob spawners will not work however.
/// </summary>
public sealed class SummonedEntity : TriggerCondition
{
    /// <summary>
    /// Sets the summoned entity
    /// </summary>
    /// <param name="entity">Entity to be set</param>
    /// <returns>This trigger</returns>
    public SummonedEntity Entity(EntityPredicate entity)
    {
        Entities["entity"] = entity;
        return this;
    }
}