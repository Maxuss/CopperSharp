using CopperSharp.Utils;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
/// Triggers after the player changes the structure
/// of a beacon. (When the beacon updates itself).
/// </summary>
[CriterionName("construct_beacon")]
public sealed class ConstructBeacon : TriggerCondition
{
    /// <summary>
    /// Sets the required level of this beacon
    /// </summary>
    /// <param name="level">Level to be set</param>
    /// <returns>This trigger</returns>
    public ConstructBeacon Level(StrictRange level)
    {
        Ranges["level"] = level;
        return this;
    }
}