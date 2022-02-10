using CopperSharp.Advancements.Predicates;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
/// Triggers every 20 ticks (1 second) and checks where the player is
/// </summary>
public sealed class LocationTrigger : TriggerCondition
{
    /// <summary>
    /// Sets the location of the player
    /// </summary>
    /// <param name="loc">Location to be set</param>
    /// <returns>This trigger condition</returns>
    public LocationTrigger Location(LocationPredicate loc)
    {
        Locations["location"] = loc;
        return this;
    }
}