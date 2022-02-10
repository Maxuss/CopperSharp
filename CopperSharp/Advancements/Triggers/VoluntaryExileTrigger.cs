using CopperSharp.Advancements.Predicates;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
/// Triggers when the player causes a raid.
/// </summary>
[CriterionName("voluntary_exile")]
public sealed class VoluntaryExileTrigger : TriggerCondition
{
    /// <summary>
    /// Sets the location of player
    /// </summary>
    /// <param name="loc">Location to be set</param>
    /// <returns>This trigger</returns>
    public VoluntaryExileTrigger PlayerLocation(LocationPredicate loc)
    {
        Locations["location"] = loc;
        return this;
    }
}