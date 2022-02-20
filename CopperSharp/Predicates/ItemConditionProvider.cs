using CopperSharp.Contexts;
using CopperSharp.Contexts.Hooks;
using CopperSharp.Item;
using CopperSharp.Predicates.Conditions;
using CopperSharp.Registry;
using CopperSharp.Utils;

namespace CopperSharp.Predicates;

/// <summary>
/// A provider which can supply item related condition
/// </summary>
public sealed class ItemConditionProvider : IWorldReference
{
    /// <inheritdoc />
    public WorldContext World { get; }

    private static int Count { get; set; } = 0;

    internal ItemConditionProvider(WorldContext world)
    {
        World = world;
    }

    /// <summary>
    /// Checks if this item is identical to provided item
    /// </summary>
    /// <param name="other">Item to be tested against</param>
    /// <returns>Identity condition</returns>
    public ICondition Identical(ItemStack other)
    {
        Count++;
        return new IdentityCondition($"coppersharp:identity_{Count}")
        {
            Identity = other
        };
    }

    /// <summary>
    /// Checks provided predicate on this item
    /// </summary>
    /// <param name="predicate">Predicate to be used</param>
    /// <returns>Predicate condition</returns>
    public ICondition TestPredicate(Identifier predicate)
    {
        Count++;
        return new PredicateCondition
        {
            Predicates = predicate.ToString()
        };
    }
}