using CopperSharp.Advancements.Predicates;
using CopperSharp.Utils;
using Newtonsoft.Json;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
/// Triggers after the player kills
/// a mob or player using a crossbow in ranged combat
/// </summary>
[CriterionName("killed_by_crossbow")]
public sealed class KilledByCrossbow : TriggerCondition
{
    private List<EntityPredicate> Vic { get; set; } = new();

    /// <summary>
    /// Sets the amount of unique entity types killed
    /// </summary>
    /// <param name="types">Amount to be set</param>
    /// <returns>This trigger</returns>
    public KilledByCrossbow UniqueEntities(StrictRange types)
    {
        Ranges["unique_entity_types"] = types;
        return this;
    }

    /// <summary>
    /// Sets the predicate for a single victim
    /// </summary>
    /// <param name="entity">Predicate to be set</param>
    /// <returns>This trigger</returns>
    public KilledByCrossbow Victims(EntityPredicate entity)
    {
        Vic.Clear();
        Entities["victims"] = entity;
        return this;
    }

    /// <summary>
    /// Sets the predicates for multiple victims
    /// </summary>
    /// <param name="entities">Predicates to be set</param>
    /// <returns>This trigger</returns>
    public KilledByCrossbow Victims(params EntityPredicate[] entities)
    {
        if(Entities.ContainsKey("victims"))
            Entities.Remove("victims");
        Vic.AddRange(entities);
        return this;
    }

    /// <inheritdoc />
    protected override async Task SerializeExtra(JsonTextWriter w)
    {
        await base.SerializeExtra(w);

        if (Vic.Any())
        {
            await w.WritePropertyNameAsync("victims");
            await w.WriteStartArrayAsync();
            foreach (var v in Vic)
            {
                await v.SerializeInto(w);
            }
            await w.WriteEndArrayAsync();
        }
    }
}