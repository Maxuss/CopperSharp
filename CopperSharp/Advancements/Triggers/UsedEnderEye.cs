using CopperSharp.Utils;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
/// Triggers when the player uses an eye of ender
/// (in a world where strongholds generate).
/// </summary>
[CriterionName("used_ender_eye")]
public sealed class UsedEnderEye : TriggerCondition
{
    /// <summary>
    /// Sets the horizontal distance between the player and the stronghold.
    /// </summary>
    /// <param name="range">Distance to be set</param>
    /// <returns>This trigger</returns>
    public UsedEnderEye StrongholdDistance(StrictRange range)
    {
        Ranges["distance"] = range;
        return this;
    }
}