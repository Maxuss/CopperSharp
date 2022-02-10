using CopperSharp.Advancements.Predicates;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
/// Triggers when the player cures a zombie villager
/// </summary>
[CriterionName("cured_zombie_villager")]
public class CuredZombieVillager : TriggerCondition
{
    /// <summary>
    /// Sets the villager that was converted from zombie
    /// </summary>
    /// <param name="entity">Villager to be set</param>
    /// <returns>This trigger</returns>
    public CuredZombieVillager Villager(EntityPredicate entity)
    {
        Entities["villager"] = entity;
        return this;
    }
    
    /// <summary>
    /// Sets the zombie that was cured
    /// </summary>
    /// <param name="entity">Zombie to be set</param>
    /// <returns>This trigger</returns>
    public CuredZombieVillager Zombie(EntityPredicate entity)
    {
        Entities["zombie"] = entity;
        return this;
    }
}