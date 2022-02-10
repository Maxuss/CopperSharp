using CopperSharp.Advancements.Predicates;
using Newtonsoft.Json;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
/// Triggers when a player lands after falling
/// </summary>
[CriterionName("fall_from_height")]
public sealed class FallFromHeight : TriggerCondition
{
    /// <summary>
    /// Sets the distance fallen
    /// </summary>
    /// <param name="dist">Distance to be set</param>
    /// <returns>This trigger</returns>
    public FallFromHeight Distance(DistancePredicate dist)
    {
        Distances["distance"] = dist;
        return this;
    }
    
    /// <summary>
    /// Sets the start position of fall
    /// </summary>
    /// <param name="loc">Position to be set</param>
    /// <returns>This trigger</returns>
    public FallFromHeight StartPosition(LocationPredicate loc)
    {
        Locations["start_position"] = loc;
        return this;
    }
}