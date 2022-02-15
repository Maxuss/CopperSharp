using CopperSharp.Advancements.Predicates;
using CopperSharp.Item;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
///     Bee nest destroyed trigger condition
/// </summary>
[CriterionName("bee_nest_destroyed")]
public sealed class BeeNestDestroyed : TriggerCondition
{
    /// <summary>
    ///     Sets destroyed block
    /// </summary>
    /// <param name="block">Type of bee nest destroyed</param>
    /// <returns>This trigger</returns>
    public BeeNestDestroyed DestroyedBlock(Material block)
    {
        Data["block"] = block.Id.ToString();
        return this;
    }

    /// <summary>
    ///     Sets item used
    /// </summary>
    /// <param name="item">Item to be set</param>
    /// <returns>This trigger</returns>
    public BeeNestDestroyed UsedItem(ItemPredicate item)
    {
        Items["item"] = item;
        return this;
    }

    /// <summary>
    ///     Sets amount of bees inside
    /// </summary>
    /// <param name="bees">Amount of bees</param>
    /// <returns>This trigger</returns>
    public BeeNestDestroyed AmountOfBeesInside(int bees)
    {
        Data["num_bees_inside"] = bees;
        return this;
    }
}