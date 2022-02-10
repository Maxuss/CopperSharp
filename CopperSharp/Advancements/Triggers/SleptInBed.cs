using CopperSharp.Advancements.Predicates;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
/// Triggers when the player enters a bed.
/// </summary>
[CriterionName("slept_in_bed")]
public sealed class SleptInBed : TriggerCondition
{
    /// <summary>
    /// Sets the location in which the player slept
    /// </summary>
    /// <param name="at">Location to be set</param>
    /// <returns>This trigger</returns>
    public SleptInBed BedLocation(LocationPredicate at)
    {
        Locations["location"] = at;
        return this;
    }
}