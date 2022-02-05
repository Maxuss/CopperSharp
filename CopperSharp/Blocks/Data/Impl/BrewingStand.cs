namespace CopperSharp.Blocks.Data.Impl;

/// <summary>
/// Represents a brewing stand tile entity
/// </summary>
public class BrewingStand : AbstractBlockData
{
    /// <summary>
    /// Sets bottle at provided slot
    /// </summary>
    /// <param name="at">Slot, from 0 to 2</param>
    /// <param name="has">Whether to set the bottle</param>
    /// <returns>This brewing stand</returns>
    public BrewingStand Bottle(int at, bool has = true)
    {
        Data[$"has_bottle_{Math.Clamp(at, 0, 2)}"] = has;
        return this;
    }
}