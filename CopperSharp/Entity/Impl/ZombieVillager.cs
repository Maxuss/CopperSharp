using CopperSharp.Data.SNbt;
using CopperSharp.Item;
using CopperSharp.Utils;

namespace CopperSharp.Entity.Impl;

/// <summary>
/// Represents a zombie villager entity
/// </summary>
public sealed class ZombieVillager : ZombieEntity, IVillagerEntity
{
    internal ZombieVillager() : base(EntityType.ZombieVillager)
    {
    }

    private List<Gossip> Gossips { get; set; } = new();
    private List<TradeOffer> Offers { get; set; } = new();

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
    /// Sets the player curing this villager
    /// </summary>
    /// <param name="player">Player, that is curing this villager</param>
    /// <returns>This zombie villager</returns>
    public ZombieVillager CuringPlayer(Guid player)
    {
        Ids["ConversionPlayer"] = player;
        return this;
    }

    /// <summary>
    /// Sets time until this zombie villager converts to normal villager
    /// </summary>
    /// <param name="ticks">Amount of time in ticks</param>
    /// <returns>This zombie villager</returns>
    public ZombieVillager TimeUntilConversion(int ticks)
    {
        Ints["ConversionTime"] = ticks;
        return this;
    }


    /// <inheritdoc />
    protected override void SerializeExtra(StringNbtWriter sw)
    {
        base.SerializeExtra(sw);

        if (Gossips.Any())
        {
            sw.WritePropertyName("Gossips");
            sw.WriteBeginArray();
            foreach (var g in Gossips)
            {
                sw.WriteBeginCompound();
                sw.WriteInteger("Value", g.Weight);
                sw.WriteUuidArray("Target", g.On);
                sw.WriteString("Type", g.Type.GetData() ?? "null");
                sw.WriteEndCompound();
            }

            sw.WriteEndArray();
        }

        if (Offers.Any())
        {
            sw.WritePropertyName("Offers");
            sw.WriteBeginCompound();
            sw.WritePropertyName("Recipes");
            sw.WriteBeginArray();
            foreach (var o in Offers)
            {
                sw.WriteBeginCompound();
                sw.WritePropertyName("buy");
                sw.WriteItem(o.Buy);
                if (o.BuyB != null)
                {
                    sw.WritePropertyName("buyB");
                    sw.WriteItem(o.BuyB);
                }

                sw.WriteInteger("demand", o.Demand);
                sw.WriteInteger("maxUses", o.MaxUses);
                sw.WriteFloat("priceMultiplier", o.PriceMultiplier);
                sw.WriteBool("rewardExp", o.RewardExp);
                sw.WritePropertyName("sell");
                sw.WriteItem(o.Sell);
                sw.WriteInteger("xp", o.VillagerExp);
                sw.WriteEndCompound();
            }

            sw.WriteEndArray();
            sw.WriteEndCompound();
        }

        sw.WritePropertyName("VillagerData");
        sw.WriteBeginCompound();
        sw.WriteInteger("level", VLevel);
        if (VProf != null)
            sw.WriteString("profession", VProf);
        if (VSkin != null)
            sw.WriteString("type", VSkin);
        sw.WriteEndCompound();
    }
}