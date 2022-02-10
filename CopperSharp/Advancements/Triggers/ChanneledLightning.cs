using CopperSharp.Advancements.Predicates;
using Newtonsoft.Json;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
/// Triggers after the player successfully uses the
/// Channeling enchantment on an entity or a lightning rod
/// </summary>
[CriterionName("channeled_lightning")]
public sealed class ChanneledLightning : TriggerCondition
{
    private List<EntityPredicate> Victim { get; } = new();

    /// <summary>
    /// Adds required victims for this trigger
    /// </summary>
    /// <param name="victims">Victims to be added</param>
    /// <returns>This trigger</returns>
    public ChanneledLightning Victims(params EntityPredicate[] victims)
    {
        Victim.AddRange(victims);
        return this;
    }

    /// <inheritdoc />
    protected override async Task SerializeExtra(JsonTextWriter w)
    {
        await base.SerializeExtra(w);
        if (Victim.Any())
        {
            await w.WritePropertyNameAsync("victims");
            await w.WriteStartArrayAsync();
            foreach (var vic in Victim)
            {
                await vic.SerializeInto(w);
            }
            await w.WriteEndArrayAsync();
        }
    }
}