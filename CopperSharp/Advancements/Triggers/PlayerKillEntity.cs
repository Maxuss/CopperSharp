using CopperSharp.Advancements.Predicates;
using Newtonsoft.Json;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
///     Triggers after a player is the
///     source of a mob or player being killed.
/// </summary>
[CriterionName("player_killed_entity")]
public sealed class PlayerKillEntity : TriggerCondition
{
    private DamagePredicate? Dmg { get; set; }

    /// <summary>
    ///     Sets the entity that was killed
    /// </summary>
    /// <param name="entity">Entity to be set</param>
    /// <returns>This trigger</returns>
    public PlayerKillEntity KilledEntity(EntityPredicate entity)
    {
        Entities["entity"] = entity;
        return this;
    }

    /// <summary>
    ///     Sets the damage that that killed the entity
    /// </summary>
    /// <param name="dmg">Damage to be set</param>
    /// <returns>This trigger</returns>
    public PlayerKillEntity KillingDamage(DamagePredicate dmg)
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
            await w.WritePropertyNameAsync("killing_blow");
            await Dmg.SerializeInto(w);
        }
    }
}