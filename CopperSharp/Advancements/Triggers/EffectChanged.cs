using CopperSharp.Advancements.Predicates;
using Newtonsoft.Json;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
///     Triggers after the player gets a status effect applied or taken from them
/// </summary>
[CriterionName("effects_changed")]
public sealed class EffectChanged : TriggerCondition
{
    private List<EffectPredicate> Predicates { get; } = new();

    /// <summary>
    ///     Adds provided effects to this condition
    /// </summary>
    /// <param name="effects">Predicates to be added</param>
    /// <returns>This trigger condition</returns>
    public EffectChanged Effects(params EffectPredicate[] effects)
    {
        Predicates.AddRange(effects);
        return this;
    }

    /// <summary>
    ///     Sets the source of this effect change
    /// </summary>
    /// <param name="entity">Entity to be used</param>
    /// <returns>This trigger</returns>
    public EffectChanged Source(EntityPredicate entity)
    {
        Entities["source"] = entity;
        return this;
    }

    /// <inheritdoc />
    protected override async Task SerializeExtra(JsonTextWriter w)
    {
        await base.SerializeExtra(w);

        if (Predicates.Any())
        {
            await w.WritePropertyNameAsync("effects");
            await w.WriteStartObjectAsync();
            foreach (var pred in Predicates) await pred.SerializeInto(w);

            await w.WriteEndObjectAsync();
        }
    }
}