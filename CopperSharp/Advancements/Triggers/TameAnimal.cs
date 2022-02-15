using CopperSharp.Advancements.Predicates;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
///     Triggers after the player tames an animal.
/// </summary>
[CriterionName("tame_animal")]
public sealed class TameAnimal : TriggerCondition
{
    /// <summary>
    ///     Sets the entity that was tamed
    /// </summary>
    /// <param name="entity">Entity to be set</param>
    /// <returns>This trigger</returns>
    public TameAnimal Entity(EntityPredicate entity)
    {
        Entities["entity"] = entity;
        return this;
    }
}