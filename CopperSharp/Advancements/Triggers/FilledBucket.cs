using CopperSharp.Advancements.Predicates;
using CopperSharp.Item;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
/// Triggers after the player fills a bucket
/// </summary>
public sealed class FilledBucket : TriggerCondition
{
    /// <summary>
    /// Sets the item got from the filling of bucket.
    /// E.g. <see cref="Material.CodBucket"/> or <see cref="Material.WaterBucket"/>
    /// </summary>
    /// <param name="item">Item to be set</param>
    /// <returns>This trigger</returns>
    public FilledBucket ItemFilled(ItemPredicate item)
    {
        Items["item"] = item;
        return this;
    }
}