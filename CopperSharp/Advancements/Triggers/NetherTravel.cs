using CopperSharp.Advancements.Predicates;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
/// Triggers when the player travels to the Nether
/// and then <b>returns</b> to the Overworld
/// </summary>
[CriterionName("nether_travel")]
public sealed class NetherTravel : TriggerCondition
{
    /// <summary>
    /// Sets the location where the player entered the Nether
    /// </summary>
    /// <param name="entered">Location to be set</param>
    /// <returns>This trigger</returns>
    public NetherTravel Entrance(LocationPredicate entered)
    {
        Locations["entered"] = entered;
        return this;
    }

    /// <summary>
    /// The location where the player exited the Nether
    /// </summary>
    /// <param name="exit">Location to be set</param>
    /// <returns>This trigger</returns>
    public NetherTravel Exit(LocationPredicate exit)
    {
        Locations["exited"] = exit;
        return this;
    }

    /// <summary>
    /// Sets the <b>overworld-based</b> distance travelled
    /// between the entrance and the exit
    /// </summary>
    /// <param name="dist">Distance to be set</param>
    /// <returns>This trigger</returns>
    public NetherTravel Travelled(DistancePredicate dist)
    {
        Distances["distance"] = dist;
        return this;
    }
}