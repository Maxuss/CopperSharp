using CopperSharp.Advancements.Predicates;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
///     Triggers when the player defeats a raid.
/// </summary>
[CriterionName("hero_of_the_village")]
public sealed class HeroOfTheVillage : TriggerCondition
{
    /// <summary>
    ///     Sets the required player location
    /// </summary>
    /// <param name="loc">Location to be set</param>
    /// <returns>This trigger</returns>
    public HeroOfTheVillage PlayerLocation(LocationPredicate loc)
    {
        Locations["location"] = loc;
        return this;
    }
}