using CopperSharp.Data.Locations;
using CopperSharp.Data.SNbt;
using CopperSharp.Item;

namespace CopperSharp.Entity.Impl;
// kind of surprised this one is not actually a villager

/// <summary>
///     Represents a wandering trader entity
/// </summary>
public class WanderingTrader : BreedableEntity
{
    internal WanderingTrader() : base(EntityType.WanderingTrader)
    {
    }

    private List<TradeOffer> Offers { get; } = new();
    private Location? WanderTarget { get; set; }

    /// <summary>
    ///     Sets amount of time until this wandering trader despawns
    /// </summary>
    /// <param name="ticks">Amount of time in ticks</param>
    /// <returns>This wandering trader</returns>
    public WanderingTrader DespawnIn(int ticks)
    {
        Ints["DespawnDelay"] = ticks;
        return this;
    }

    /// <summary>
    ///     Sets location to which this trader wanders
    /// </summary>
    /// <param name="to">Location to be set</param>
    /// <returns>This wandering trader</returns>
    public WanderingTrader WanderTo(Location to)
    {
        WanderTarget = to;
        return this;
    }

    /// <summary>
    ///     Adds an offer to trades list of this trader
    /// </summary>
    /// <param name="buy">Item this trader buys</param>
    /// <param name="sell">Item this trader sells</param>
    /// <param name="maxUses">Max amount of time this trader can sell this item</param>
    /// <param name="rewardExp">Whether to reward player with experience</param>
    /// <param name="buyExtra">An extra item this trader buys. Optional.</param>
    /// <returns>This wandering trader</returns>
    public WanderingTrader Offer(ItemStack buy, ItemStack sell, int maxUses,
        bool rewardExp = true, ItemStack? buyExtra = null)
    {
        Offers.Add(new TradeOffer(buy, sell, buyExtra, maxUses, -1, -1, rewardExp, -1));
        return this;
    }

    /// <inheritdoc />
    protected override void SerializeExtra(StringNbtWriter sw)
    {
        base.SerializeExtra(sw);

        if (WanderTarget != null)
            sw.WritePosition(WanderTarget ?? default);

        if (!Offers.Any()) return;
        sw.WritePropertyName("Offers");
        sw.WriteBeginCompound();
        sw.WritePropertyName("Recipes");
        sw.WriteBeginArray();
        foreach (var of in Offers)
        {
            sw.WriteBeginCompound();
            sw.WritePropertyName("buy");
            sw.WriteItem(of.Buy);
            sw.WritePropertyName("sell");
            sw.WriteItem(of.Sell);
            if (of.BuyB != null)
            {
                sw.WritePropertyName("buyB");
                sw.WriteItem(of.BuyB ?? default);
            }

            sw.WriteInteger("uses", of.MaxUses);
            sw.WriteBool("rewardExp", of.RewardExp);
            sw.WriteEndCompound();
        }

        sw.WriteEndArray();
        sw.WriteEndCompound();
    }
}