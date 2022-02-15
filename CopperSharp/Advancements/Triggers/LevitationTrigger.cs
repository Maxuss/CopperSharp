using CopperSharp.Advancements.Predicates;
using CopperSharp.Utils;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
///     Triggers when the player has the levitation status effect
/// </summary>
[CriterionName("levitation")]
public sealed class LevitationTrigger : TriggerCondition
{
    /// <summary>
    ///     Sets the distance levitated
    /// </summary>
    /// <param name="dist">Distance to be set</param>
    /// <returns>This trigger</returns>
    public LevitationTrigger Distance(DistancePredicate dist)
    {
        Distances["distance"] = dist;
        return this;
    }

    /// <summary>
    ///     Sets the duration of levitation in ticks
    /// </summary>
    /// <param name="dur">Duration to be set</param>
    /// <returns>This trigger</returns>
    public LevitationTrigger EffectDuration(StrictRange dur)
    {
        Ranges["duration"] = dur;
        return this;
    }
}