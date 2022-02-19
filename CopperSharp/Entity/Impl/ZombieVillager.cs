using CopperSharp.Data.SNbt;
using CopperSharp.Item;
using CopperSharp.Utils;

namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents a zombie villager entity
/// </summary>
public sealed class ZombieVillager : ZombieEntity, IVillagerEntity
{
    internal ZombieVillager() : base(EntityType.ZombieVillager)
    {
    }

    private List<Gossip> Gossips { get; } = new();
    private List<TradeOffer> Offers { get; } = new();

    private int VLevel { get; set; } = 1;
    private string? VSkin { get; set; }
    private string? VProf { get; set; }

    /// <inheritdoc />
    public IVillagerEntity Gossip(Guid on, VillagerGossip type, int weight)
    {
        Gossips.Add(new Gossip(on, type, weight));
        return this;
    }

    /// <inheritdoc />
    public IVillagerEntity Offer(ItemStack buy, ItemStack sell, int maxUses, int demand = 1, float priceMultiplier = 1,
        bool rewardExp = true, int villagerExp = 1, ItemStack? buyExtra = null)
    {
        Offers.Add(new TradeOffer(buy, sell, buyExtra, maxUses, demand, priceMultiplier, rewardExp, villagerExp));
        return this;
    }

    /// <inheritdoc />
    public IVillagerEntity Level(VillagerLevel level)
    {
        VLevel = (int) level;
        return this;
    }

    /// <inheritdoc />
    public IVillagerEntity Skin(VillagerType skin)
    {
        VSkin = Enum.GetName(skin) ?? "null";
        return this;
    }

    /// <inheritdoc />
    public IVillagerEntity Experience(int experience)
    {
        Ints["Xp"] = experience;
        return this;
    }

    /// <inheritdoc />
    public IVillagerEntity Profession(VillagerProfession prof)
    {
        VProf = $"minecraft:{Enum.GetName(prof)}";
        return this;
    }

    /// <summary>
    ///     Sets the player curing this villager
    /// </summary>
    /// <param name="player">Player, that is curing this villager</param>
    /// <returns>This zombie villager</returns>
    public ZombieVillager CuringPlayer(Guid player)
    {
        Ids["ConversionPlayer"] = player;
        return this;
    }

    /// <summary>
    ///     Sets time until this zombie villager converts to normal villager
    /// </summary>
    /// <param name="ticks">Amount of time in ticks</param>
    /// <returns>This zombie villager</returns>
    public ZombieVillager TimeUntilConversion(int ticks)
    {
        Ints["ConversionTime"] = ticks;
        return this;
    }


    /// <inheritdoc />
    protected override async Task SerializeExtra(INbtWriter sw)
    {
        await base.SerializeExtra(sw);

        if (Gossips.Any())
        {
            await sw.WritePropertyNameAsync("Gossips");
            await sw.WriteBeginArrayAsync();
            foreach (var g in Gossips)
            {
                await sw.WriteBeginCompoundAsync();
                await sw.WriteIntegerAsync("Value", g.Weight);
                await sw.WriteUuidArrayAsync("Target", g.On);
                await sw.WriteStringAsync("Type", g.Type.GetData() ?? "null");
                await sw.WriteEndCompoundAsync();
            }

            await sw.WriteEndArrayAsync();
        }

        if (Offers.Any())
        {
            await sw.WritePropertyNameAsync("Offers");
            await sw.WriteBeginCompoundAsync();
            await sw.WritePropertyNameAsync("Recipes");
            await sw.WriteBeginArrayAsync();
            foreach (var o in Offers)
            {
                await sw.WriteBeginCompoundAsync();
                await sw.WritePropertyNameAsync("buy");
                await sw.WriteItem(o.Buy);
                if (o.BuyB != null)
                {
                    await sw.WritePropertyNameAsync("buyB");
                    await sw.WriteItem(o.BuyB);
                }

                await sw.WriteIntegerAsync("demand", o.Demand);
                await sw.WriteIntegerAsync("maxUses", o.MaxUses);
                sw.WriteFloat("priceMultiplier", o.PriceMultiplier);
                await sw.WriteBoolAsync("rewardExp", o.RewardExp);
                await sw.WritePropertyNameAsync("sell");
                await sw.WriteItem(o.Sell);
                await sw.WriteIntegerAsync("xp", o.VillagerExp);
                await sw.WriteEndCompoundAsync();
            }

            await sw.WriteEndArrayAsync();
            await sw.WriteEndCompoundAsync();
        }

        await sw.WritePropertyNameAsync("VillagerData");
        await sw.WriteBeginCompoundAsync();
        await sw.WriteIntegerAsync("level", VLevel);
        if (VProf != null)
            await sw.WriteStringAsync("profession", VProf);
        if (VSkin != null)
            await sw.WriteStringAsync("type", VSkin);
        await sw.WriteEndCompoundAsync();
    }
}