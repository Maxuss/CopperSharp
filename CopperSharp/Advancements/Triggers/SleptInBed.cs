using CopperSharp.Advancements.Predicates;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
/// Triggers when the player enters a bed.
/// </summary>
public sealed class SleptInBed : TriggerCondition
{
    /// <summary>
    /// Sets the location in which the player slept
    /// </summary>
    /// <param name="at">Location to be set</param>
    /// <returns>This trigger</returns>
    public SleptInBed Location(LocationPredicate at)
    {
        Locations["location"] = at;
        return this;
    }
}