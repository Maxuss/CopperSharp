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
    protected override async Task SerializeExtra(INbtWriter sw)
    {
        await base.SerializeExtra(sw);

        if (WanderTarget != null)
            await sw.WritePositionAsync(WanderTarget ?? default);

        if (!Offers.Any()) return;
        await sw.WritePropertyNameAsync("Offers");
        await sw.WriteBeginCompoundAsync();
        await sw.WritePropertyNameAsync("Recipes");
        await sw.WriteBeginArrayAsync();
        foreach (var of in Offers)
        {
            await sw.WriteBeginCompoundAsync();
            await sw.WritePropertyNameAsync("buy");
            await sw.WriteItem(of.Buy);
            await sw.WritePropertyNameAsync("sell");
            await sw.WriteItem(of.Sell);
            if (of.BuyB != null)
            {
                await sw.WritePropertyNameAsync("buyB");
                await sw.WriteItem(of.BuyB ?? default);
            }

            await sw.WriteIntegerAsync("uses", of.MaxUses);
            await sw.WriteBoolAsync("rewardExp", of.RewardExp);
            await sw.WriteEndCompoundAsync();
        }

        await sw.WriteEndArrayAsync();
        await sw.WriteEndCompoundAsync();
    }
}