using CopperSharp.Item;
using CopperSharp.Utils;

namespace CopperSharp.Entity;

/// <summary>
/// A super interface for all villagers
/// </summary>
public interface IVillagerEntity
{
    /// <summary>
    /// Allows a villager to gossip
    /// </summary>
    /// <param name="on">Player target about which to gossip</param>
    /// <param name="type">Type of gossip</param>
    /// <param name="weight">Value of this gossip</param>
    /// <returns>This villager entity</returns>
    public IVillagerEntity Gossip(Guid on, VillagerGossip type, int weight);

    /// <summary>
    /// Adds an offer to this villager's sell lists
    /// </summary>
    /// <param name="buy">Item the villager buys</param>
    /// <param name="sell">Item the villager sells</param>
    /// <param name="maxUses">Max amount of times this trade can be used</param>
    /// <param name="demand">Demand for this item. Increases it's price.</param>
    /// <param name="priceMultiplier">Extra multiplier for demand.</param>
    /// <param name="rewardExp">Whether to reward player with experience after the trade is completed.</param>
    /// <param name="villagerExp">Amount of experience the villager gets from this trade.</param>
    /// <param name="buyExtra">Second item this villager buys. Optional.</param>
    /// <returns>This villager entity</returns>
    public IVillagerEntity Offer(
        ItemStack buy,
        ItemStack sell,
        int maxUses,
        int demand = 1,
        float priceMultiplier = 1f,
        bool rewardExp = true,
        int villagerExp = 1,
        ItemStack? buyExtra = null);

    /// <summary>
    /// Sets a new level from 
    /// </summary>
    /// <param name="level"></param>
    /// <returns></returns>
    public IVillagerEntity Level(VillagerLevel level);

    /// <summary>
    /// Sets type of this villager
    /// </summary>
    /// <param name="skin">Type to be set</param>
    /// <returns>This villager entity</returns>
    public IVillagerEntity Skin(VillagerType skin);

    /// <summary>
    /// Sets the amount of experience this villager has
    /// </summary>
    /// <param name="experience">Experience amount to be set</param>
    /// <returns>This villager entity</returns>
    public IVillagerEntity Experience(int experience);

    /// <summary>
    /// Sets profession of this villager
    /// </summary>
    /// <param name="prof">Profession to be set</param>
    /// <returns>This villager entity</returns>
    public IVillagerEntity Profession(VillagerProfession prof);
}

/// <summary>
/// Represents a profession of the villager
/// </summary>
public enum VillagerProfession
{
    /// <summary>
    /// Armorer profession
    /// </summary>
    Armorer,

    /// <summary>
    /// Butcher profession
    /// </summary>
    Butcher,

    /// <summary>
    /// Cartographer profession
    /// </summary>
    Cartographer,

    /// <summary>
    /// Cleric profession
    /// </summary>
    Cleric,

    /// <summary>
    /// Farmer profession
    /// </summary>
    Farmer,

    /// <summary>
    /// Fisherman profession
    /// </summary>
    Fisherman,

    /// <summary>
    /// Fletcher profession
    /// </summary>
    Fletcher,

    /// <summary>
    /// Leatherworker profession
    /// </summary>
    Leatherworker,

    /// <summary>
    /// Librarian profession
    /// </summary>
    Librarian,

    /// <summary>
    /// Nitwit profession
    /// </summary>
    Nitwit,

    /// <summary>
    /// Unemployed profession
    /// </summary>
    Unemployed,

    /// <summary>
    /// Mason profession
    /// </summary>
    Mason,

    /// <summary>
    /// Shepherd profession
    /// </summary>
    Shepherd,

    /// <summary>
    /// Toolsmith profession
    /// </summary>
    Toolsmith,

    /// <summary>
    /// Weaponsmith profession
    /// </summary>
    Weaponsmith
}

/// <summary>
/// Type of villager's skin
/// </summary>
public enum VillagerType
{
    /// <summary>
    /// Desert villager
    /// </summary>
    Desert,

    /// <summary>
    /// Jungle villager (not used in game)
    /// </summary>
    Jungle,

    /// <summary>
    /// Default plains villager
    /// </summary>
    Plains,

    /// <summary>
    /// Savanna villager
    /// </summary>
    Savanna,

    /// <summary>
    /// Snowy villager
    /// </summary>
    Snow,

    /// <summary>
    /// Swamp villager (not used in game)
    /// </summary>
    Swamp,

    /// <summary>
    /// Taiga villager
    /// </summary>
    Taiga
}

/// <summary>
/// Level of villager's profession
/// </summary>
public enum VillagerLevel
{
    /// <summary>
    /// Novice level
    /// </summary>
    Novice = 1,

    /// <summary>
    /// Apprentice level
    /// </summary>
    Apprentice = 2,

    /// <summary>
    /// Journeyman level
    /// </summary>
    Journeyman = 3,

    /// <summary>
    /// Expert level
    /// </summary>
    Expert = 4,

    /// <summary>
    /// Master level
    /// </summary>
    Master = 5
}

/// <summary>
/// Type of gossip a villager can spread
/// </summary>
public enum VillagerGossip
{
    /// <summary>
    /// Weight -5. Max 100.
    /// </summary>
    [EnumData("major_negative")] MajorNegative,

    /// <summary>
    /// Weight -1. Max 200.
    /// </summary>
    [EnumData("minor_negative")] MinorNegative,

    /// <summary>
    /// Weight 1. Max 25.
    /// </summary>
    [EnumData("trading")] Trading,

    /// <summary>
    /// Weight 1. Max 200.
    /// </summary>
    [EnumData("minor_positive")] MinorPositive,

    /// <summary>
    /// Weight 5. Max 100
    /// </summary>
    [EnumData("major_positive")] MajorPositive
}