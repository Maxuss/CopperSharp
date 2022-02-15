using CopperSharp.Advancements.Predicates;
using Newtonsoft.Json;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
///     Triggers after the player hurts a mob or player.
/// </summary>
[CriterionName("player_hurt_entity")]
public sealed class PlayerDamageEntity : TriggerCondition
{
    private DamagePredicate? Dmg { get; set; }

    /// <summary>
    ///     Sets the damage that was dealt
    /// </summary>
    /// <param name="dmg">Damage to be set</param>
    /// <returns>This trigger</returns>
    public PlayerDamageEntity Damage(DamagePredicate dmg)
    {
        Dmg = dmg;
        return this;
    }

    /// <summary>
    ///     Sets the entity that was damaged
    /// </summary>
    /// <param name="entity">Entity to be set</param>
    /// <returns>This trigger</returns>
    public PlayerDamageEntity DamagedEntity(EntityPredicate entity)
    {
        Entities["entity"] = entity;
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