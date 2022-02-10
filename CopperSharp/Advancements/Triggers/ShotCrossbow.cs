using CopperSharp.Advancements.Predicates;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
/// Triggers when the player shoots a crossbow.
/// </summary>
public sealed class ShotCrossbow : TriggerCondition
{
    /// <summary>
    /// Sets the item that was used to shoot, e.g. crossbow
    /// </summary>
    /// <param name="item">Item to be set</param>
    /// <returns>This trigger</returns>
    public ShotCrossbow Item(ItemPredicate item)
    {
        Items["item"] = item;
        return this;
    }
}