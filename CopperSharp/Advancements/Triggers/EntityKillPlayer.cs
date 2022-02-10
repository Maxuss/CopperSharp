using CopperSharp.Advancements.Predicates;
using Newtonsoft.Json;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
/// Triggers after a living entity kills a player
/// </summary>
[CriterionName("entity_killed_player")]
public sealed class EntityKillPlayer : TriggerCondition
{
    private DamagePredicate? Dmg { get; set; }

    /// <summary>
    /// Sets the killer of player
    /// </summary>
    /// <param name="killer">Predicate to be set</param>
    /// <returns>This trigger</returns>
    public EntityKillPlayer Killer(EntityPredicate killer)
    {
        Entities["entity"] = killer;
        return this;
    }
    
    /// <summary>
    /// Sets the type of damage taken before death
    /// </summary>
    /// <param name="dmg">Damage predicate</param>
    /// <returns>This trigger</returns>
    public EntityKillPlayer Damage(DamagePredicate dmg)
    {
        Dmg = dmg;
        return this;
    }

    /// <inheritdoc />
    protected override async Task SerializeExtra(JsonTextWriter w)
    {
        await base.SerializeExtra(w);

        if (Dmg != null)
        {
            await w.WritePropertyNameAsync("damage");
            await Dmg.SerializeInto(w);
        }
    }

}