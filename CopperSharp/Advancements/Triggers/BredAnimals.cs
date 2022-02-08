using CopperSharp.Advancements.Predicates;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
/// Triggers after the player breeds 2 animals.
/// </summary>
public sealed class BredAnimals : TriggerCondition
{
    /// <summary>
    /// Sets the child
    /// </summary>
    /// <param name="entity">Child to be set</param>
    /// <returns>This trigger</returns>
    public BredAnimals Child(EntityPredicate entity)
    {
        Entities["child"] = entity;
        return this;
    }
    
    /// <summary>
    /// Sets the parent
    /// </summary>
    /// <param name="entity">Parent to be set</param>
    /// <returns>This trigger</returns>
    public BredAnimals Parent(EntityPredicate entity)
    {
        Entities["parent"] = entity;
        return this;
    }
    
    /// <summary>
    /// Sets the second parent, or partner
    /// </summary>
    /// <param name="entity">Partner to be set</param>
    /// <returns>This trigger</returns>
    public BredAnimals Partner(EntityPredicate entity)
    {
        Entities["partner"] = entity;
        return this;
    }
}