using System.Reflection;
using Newtonsoft.Json;

namespace CopperSharp.Advancements;

/// <summary>
/// Represents a criterion that must be
/// completed to grant advancement.
/// </summary>
public sealed class Criterion
{
    /// <summary>
    /// Trigger to be used
    /// </summary>
    public TriggerCondition Trigger { get; }
    /// <summary>
    /// Name of this criterion to be used
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Creates a new criterion for the advancement
    /// </summary>
    /// <param name="name">Name of the criterion</param>
    /// <param name="trigger">Trigger to be used</param>
    public Criterion(string name, TriggerCondition trigger)
    {
        Name = name;
        Trigger = trigger;
    }

    /// <summary>
    /// Serializes this criterion to provided json writer
    /// </summary>
    /// <param name="jw">Writer to be used</param>
    public async Task SerializeInto(JsonTextWriter jw)
    {
        var triggerName =
            $"minecraft:{Trigger.GetType().GetCustomAttribute<CriterionNameAttribute>()?.CriterionName ?? "impossible"}";
        await jw.WritePropertyNameAsync(Name);
        await jw.WriteStartObjectAsync();
        await jw.WritePropertyNameAsync("trigger");
        await jw.WritePropertyNameAsync(triggerName);
        await jw.WritePropertyNameAsync("conditions");
        await Trigger.SerializeInto(jw);
        await jw.WriteEndObjectAsync();
    }
}