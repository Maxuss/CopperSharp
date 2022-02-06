using CopperSharp.Utils;

namespace CopperSharp.Item;

/// <summary>
///     Represents type of enchant
/// </summary>
public enum Enchant
{
    /// <summary>
    ///     A null enchantment, that should not be used.
    /// </summary>
    [EnchantData("null", -1)] NullEnchant,

    /// <summary>
    ///     Increases underwater mining speed.
    /// </summary>
    [EnchantData("aqua_affinity", 1)] AquaAffinity,

    /// <summary>
    ///     Increases damage and applies Slowness IV<br />
    ///     to arthropod mobs (spiders, cave spiders,<br />
    ///     silverfish, endermites and bees).
    /// </summary>
    [EnchantData("bane_of_arthropods", 5)] BaneOfArthropods,

    /// <summary>
    ///     Reduces explosion damage and knockback.
    /// </summary>
    [EnchantData("blast_protection", 4)] BlastProtection,

    /// <summary>
    ///     Trident "channels" a bolt of lightning toward a hit entity.<br />
    ///     Functions only during thunderstorms and if target<br />
    ///     is unobstructed with opaque blocks.
    /// </summary>
    [EnchantData("channeling", 1)] Channeling,

    /// <summary>
    ///     Items cannot be removed from armor slots,<br />
    ///     except in Creative mode or due to death or breaking.
    /// </summary>
    [EnchantData("curse_of_binding", 1)] CurseOfBinding,

    /// <summary>
    ///     Item destroyed on death.
    /// </summary>
    [EnchantData("curse_of_vanishing", 1)] CurseOfVanishing,

    /// <summary>
    ///     Increases underwater movement speed.
    /// </summary>
    [EnchantData("depth_strider", 3)] DepthStrider,

    /// <summary>
    ///     Increases tool speed. When applied to<br />
    ///     an Axe it increases the chance that<br />
    ///     the axe may stun a shield, with the base<br />
    ///     chance being 25% and a 5% increase for each<br />
    ///     level of efficiency.
    /// </summary>
    [EnchantData("efficiency", 5)] Efficiency,

    /// <summary>
    ///     Reduces fall damage.
    /// </summary>
    [EnchantData("feather_falling", 4)] FeatherFalling,

    /// <summary>
    ///     Sets target on fire.
    /// </summary>
    [EnchantData("fire_aspect", 2)] FireAspect,

    /// <summary>
    ///     Reduces fire damage and burn time.<br />
    ///     Mutually exclusive with other protections.
    /// </summary>
    [EnchantData("fire_protection", 4)] FireProtection,

    /// <summary>
    ///     Arrows set the target on fire, and ignite TNT if hit.
    /// </summary>
    [EnchantData("flame", 1)] Flame,

    /// <summary>
    ///     Increases certain block drops. Higher levels increase chances.
    /// </summary>
    [EnchantData("fortune", 3)] Fortune,

    /// <summary>
    ///     Turns water beneath the player into frosted ice and<br />
    ///     prevents the damage the player would take from standing<br />
    ///     on magma blocks.
    /// </summary>
    [EnchantData("frost_walker", 2)] FrostWalker,

    /// <summary>
    ///     Trident deals additional damage to mobs that spawn naturally<br />
    ///     in the ocean. In Bedrock Edition, having impaling on a trident<br />
    ///     also deals extra damage to players or mobs in water or rain.
    /// </summary>
    [EnchantData("impaling", 5)] Impaling,

    /// <summary>
    ///     Shooting consumes no regular arrows. Does not<br />
    ///     include Tipped Arrows or Spectral Arrows.
    /// </summary>
    [EnchantData("infinity", 1)] Infinity,

    /// <summary>
    ///     Increases knockback.
    /// </summary>
    [EnchantData("knockback", 2)] Knockback,

    /// <summary>
    ///     Increases mob loot. Higher levels increase loot dropped.
    /// </summary>
    [EnchantData("looting", 3)] Looting,

    /// <summary>
    ///     Trident returns after being thrown. Higher levels reduce return time.
    /// </summary>
    [EnchantData("loyalty", 3)] Loyalty,

    /// <summary>
    ///     Increases rate of good loot (enchanting books, etc.).<br />
    ///     Higher Levels Increase chance.
    /// </summary>
    [EnchantData("luck_of_the_sea", 3)] LuckOfTheSea,

    /// <summary>
    ///     Decreases wait time until fish/junk/loot "bites". <br />
    ///     Higher Levels decrease wait time.
    /// </summary>
    [EnchantData("lure", 3)] Lure,

    /// <summary>
    ///     XP orbs gained are used to repair the item instead of<br />
    ///     adding experience to bar.
    /// </summary>
    [EnchantData("mending", 1)] Mending,

    /// <summary>
    ///     Shoot 3 arrows in a spread at the cost of one; only<br />
    ///     one arrow can be recovered.
    /// </summary>
    [EnchantData("multishot", 1)] Multishot,

    /// <summary>
    ///     Arrows pass through multiple entities and Shields; arrows<br />
    ///     can be recovered after passing through entities.
    /// </summary>
    /// <remarks>
    ///     Available only to the crossbow.
    /// </remarks>
    [EnchantData("piercing", 4)] Piercing,

    /// <summary>
    ///     Increases arrow damage.
    /// </summary>
    [EnchantData("power", 5)] Power,

    /// <summary>
    ///     Reduces projectile damage such as damage from arrows,<br />
    ///     thrown tridents, ghast and blaze fireballs, etc.
    /// </summary>
    [EnchantData("projectile_protection", 4)]
    ProjectileProtection,

    /// <summary>
    ///     Reduces most types of damage by 4% for each level.
    /// </summary>
    [EnchantData("protection", 4)] Protection,

    /// <summary>
    ///     Increases arrow knockback.
    /// </summary>
    [EnchantData("punch", 2)] Punch,

    /// <summary>
    ///     Decreases crossbow charging time.
    /// </summary>
    [EnchantData("quick_charge", 3)] QuickCharge,

    /// <summary>
    ///     Extends underwater breathing time. Stacks with a Turtle Shell
    /// </summary>
    [EnchantData("respiration", 3)] Respiration,

    /// <summary>
    ///     Trident launches player with itself when thrown.<br />
    ///     Functions only in water or rain.
    /// </summary>
    [EnchantData("riptide", 3)] Riptide,

    /// <summary>
    ///     Increases damage for melee weapons.
    /// </summary>
    [EnchantData("sharpness", 5)] Sharpness,

    /// <summary>
    ///     Mined blocks drop themselves, with a few exceptions.
    /// </summary>
    [EnchantData("silk_touch", 1)] SilkTouch,

    /// <summary>
    ///     Increases damage to undead mobs.
    /// </summary>
    [EnchantData("smite", 5)] Smite,

    /// <summary>
    ///     Increases walking speed on Soul Sand or Soul Soil,<br />
    ///     but damages the Boots over time
    /// </summary>
    [EnchantData("soul_speed", 3)] SoulSpeed,

    /// <summary>
    ///     Increases sweeping attack damage.
    /// </summary>
    [EnchantData("sweeping_edge", 3)] SweepingEdge,

    /// <summary>
    ///     Reflects some of the damage taken when hit, at the cost<br />
    ///     of reducing durability with each proc.
    /// </summary>
    [EnchantData("thorns", 3)] Thorns,

    /// <summary>
    ///     Reduces the chance of an item taking damage.<br />
    ///     Higher levels reduce the chance further.
    /// </summary>
    [EnchantData("unbreaking", 3)] Unbreaking
}