using CopperSharp.Data.SNbt;
using CopperSharp.Item;
using CopperSharp.Utils;

namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents a villager entity
/// </summary>
public sealed class Villager : BreedableEntity, IVillagerEntity
{
    internal Villager() : base(EntityType.Villager)
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
    ///     Sets date of last restock
    /// </summary>
    /// <param name="ticks">Date in ticks</param>
    /// <returns>This villager</returns>
    public Villager LastRestock(int ticks)
    {
        Ints["LastRestock"] = ticks;
        return this;
    }

    /// <summary>
    ///     Sets date of last gossip
    /// </summary>
    /// <param name="ticks">Date in ticks</param>
    /// <returns>This villager</returns>
    public Villager LastGossip(int ticks)
    {
        Ints["LastGossipDelay"] = ticks;
        return this;
    }

    /// <summary>
    ///     Sets amount of restocks villager has done in 10 minutes from the last restock
    /// </summary>
    /// <param name="restocks">Amount of restocks</param>
    /// <returns>This villager</returns>
    public Villager RestocksToday(int restocks)
    {
        Ints["RestocksToday"] = restocks;
        return this;
    }

    /// <summary>
    ///     Sets whether this villager is ready to mate
    /// </summary>
    /// <param name="ready">Marker</param>
    /// <returns>This villager</returns>
    public Villager ReadyToMate(bool ready)
    {
        Bools["Willing"] = ready;
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

internal readonly struct Gossip
{
    public Guid On { get; }
    public VillagerGossip Type { get; }
    public int Weight { get; }

    public Gossip(Guid on, VillagerGossip type, int weight)
    {
        On = on;
        Type = type;
        Weight = weight;
    }
}

internal readonly struct TradeOffer
{
    public ItemStack Buy { get; }
    public ItemStack Sell { get; }
    public ItemStack? BuyB { get; }
    public int MaxUses { get; }
    public int Demand { get; }
    public float PriceMultiplier { get; }
    public bool RewardExp { get; }
    public int VillagerExp { get; }

    public TradeOffer(ItemStack buy, ItemStack sell, ItemStack? buyB, int maxUses, int demand, float priceMultiplier,
        bool rewardExp, int villagerExp)
    {
        Buy = buy;
        Sell = sell;
        BuyB = buyB;
        MaxUses = maxUses;
        Demand = demand;
        PriceMultiplier = priceMultiplier;
        RewardExp = rewardExp;
        VillagerExp = villagerExp;
    }
}