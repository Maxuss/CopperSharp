using CopperSharp.Advancements.Predicates;
using Newtonsoft.Json;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
///     Triggers after a player gets hurt,
///     even without a source entity (idk why it is named like that, ask mojang)
/// </summary>
[CriterionName("entity_hurt_player")]
public sealed class EntityDamagePlayer : TriggerCondition
{
    private DamagePredicate? Dmg { get; set; }

    /// <summary>
    ///     Sets the type of damage taken
    /// </summary>
    /// <param name="dmg">Damage predicate</param>
    /// <returns>This trigger</returns>
    public EntityDamagePlayer Damage(DamagePredicate dmg)
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