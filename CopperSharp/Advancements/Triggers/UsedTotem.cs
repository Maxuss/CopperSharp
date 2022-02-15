using CopperSharp.Advancements.Predicates;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
///     Triggers when the player uses a totem.
/// </summary>
[CriterionName("used_totem")]
public sealed class UsedTotem : TriggerCondition
{
    /// <summary>
    ///     Sets the totem item used
    /// </summary>
    /// <param name="totem">Item to be set</param>
    /// <returns>This trigger</returns>
    public UsedTotem Totem(ItemPredicate totem)
    {
        Items["item"] = totem;
        return this;
    }
}