// Thanks to Minecraft Wiki
// https://minecraft.fandom.com/wiki/Effect#Effect_IDs

using CopperSharp.Utils;

namespace CopperSharp.Data.Effects;

/// <summary>
///     Represents a type of status effect, applicable to living entities
/// </summary>
public enum StatusEffect : byte
{
    /// <summary>
    ///     Increases walking speed; higher levels make<br />
    ///     the affected entity faster and increases the<br />
    ///     player's field of view when affected.
    /// </summary>
    [EnumData("speed")] Speed = 1,

    /// <summary>
    ///     Decreases walking speed; higher levels make the<br />
    ///     affected entity slower and decreases the player's<br />
    ///     field of view when affected
    /// </summary>
    [EnumData("slowness")] Slowness = 2,

    /// <summary>
    ///     Increases mining and attack speed, higher levels<br />
    ///     increase the player's mining and attack speed
    /// </summary>
    [EnumData("haste")] Haste = 3,

    /// <summary>
    ///     Decreases mining and attack speed, higher levels<br />
    ///     decrease the player's mining and attack speed
    /// </summary>
    [EnumData("mining_fatigue")] MiningFatigue = 4,

    /// <summary>
    ///     Increases melee damage, higher levels make the<br />
    ///     affected entity do more melee damage
    /// </summary>
    [EnumData("strength")] Strength = 5,

    /// <summary>
    ///     Instantly heals living entities, damages undead,<br />
    ///     higher levels heal more health and do more damage
    /// </summary>
    [EnumData("instant_health")] InstantHealth = 6,

    /// <summary>
    ///     Instantly damages living entities, heals undead, higher<br />
    ///     levels do more damage and heal more health
    /// </summary>
    [EnumData("instant_damage")] InstantDamage = 7,

    /// <summary>
    ///     Increases jump height and reduces fall damage,<br />
    ///     higher levels make the affected entity jump<br />
    ///     higher and reduces more fall damage
    /// </summary>
    [EnumData("jump_boost")] JumpBoost = 8,

    /// <summary>
    ///     Wobbles and warps the screen
    /// </summary>
    [EnumData("nausea")] Nausea = 9,

    /// <summary>
    ///     Regenerates health over time, higher levels<br />
    ///     make health regenerate quicker
    /// </summary>
    [EnumData("regeneration")] Regeneration = 10,

    /// <summary>
    ///     Reduces damage, higher levels reduce more damage
    /// </summary>
    [EnumData("resistance")] Resistance = 11,

    /// <summary>
    ///     Prevents the affected entity from taking damage<br />
    ///     due to Fire, lava and other sources of fire damage
    /// </summary>
    [EnumData("fire_resistance")] FireResistance = 12,

    /// <summary>
    ///     Prevents drowning and lets the affected<br />
    ///     entity breathe underwater
    /// </summary>
    [EnumData("water_breathing")] WaterBreathing = 13,

    /// <summary>
    ///     Grants invisibility, making the affected entity<br />
    ///     invisible (but not the item they hold or the armor<br />
    ///     they wear), and reduces other mobs' detection range<br />
    ///     for the affected entity, higher levels reduce other<br />
    ///     mobs' detection range more
    /// </summary>
    [EnumData("invisibility")] Invisibility = 14,

    /// <summary>
    ///     Impairs vision and disables the ability to<br />
    ///     sprint and critical hit
    /// </summary>
    [EnumData("blindness")] Blindness = 15,

    /// <summary>
    ///     Lets the player see well in darkness and underwater
    /// </summary>
    [EnumData("night_vision")] NightVision = 16,

    /// <summary>
    ///     Increases food exhaustion, higher levels cause the<br />
    ///     player to starve quicker
    /// </summary>
    [EnumData("hunger")] Hunger = 17,

    /// <summary>
    ///     Decreases melee damage, higher levels decrease<br />
    ///     more melee damage
    /// </summary>
    [EnumData("weakness")] Weakness = 18,

    /// <summary>
    ///     Inflicts damage over time (but can't kill),<br />
    ///     higher levels do more damage per second,<br />
    ///     doesn't affect undead
    /// </summary>
    [EnumData("poison")] Poison = 19,

    /// <summary>
    ///     Inflicts damage over time (can kill),<br />
    ///     higher levels do more damage per second
    /// </summary>
    [EnumData("wither")] Wither = 20,

    /// <summary>
    ///     Increases maximum health, higher levels<br />
    ///     give the affected entity more maximum health
    /// </summary>
    [EnumData("health_boost")] HealthBoost = 21,

    /// <summary>
    ///     Adds damage absorption (additional hearts<br />
    ///     that can't be regenerated), higher levels<br />
    ///     give more absorption
    /// </summary>
    [EnumData("absorption")] Absorption = 22,

    /// <summary>
    ///     Restores hunger and saturation
    /// </summary>
    [EnumData("saturation")] Saturation = 23,

    /// <summary>
    ///     Outlines the affected entity<br />
    ///     (can be seen through blocks)
    /// </summary>
    [EnumData("glowing")] Glowing = 24,

    /// <summary>
    ///     Floats the affected entity upward
    /// </summary>
    [EnumData("levitation")] Levitation = 25,

    /// <summary>
    ///     Can increase chances of high-quality and more<br />
    ///     loot, higher levels increase the chances of better loot
    /// </summary>
    [EnumData("luck")] Luck = 26,

    /// <summary>
    ///     Can reduce chances of high-quality and more loot,<br />
    ///     higher levels reduce the chance of good loot
    /// </summary>
    [EnumData("unluck")] Unluck = 27,

    /// <summary>
    ///     Decreases falling speed and negates fall damage
    /// </summary>
    [EnumData("slow_falling")] SlowFalling = 28,

    /// <summary>
    ///     Increases underwater visibility and mining<br />
    ///     speed, prevents drowning
    /// </summary>
    [EnumData("conduit_power")] ConduitPower = 29,

    /// <summary>
    ///     Increases swimming speed (normally only obtainable<br />
    ///     from dolphins)
    /// </summary>
    [EnumData("dolphins_grace")] DolphinGrace = 30,

    /// <summary>
    ///     Causes an illager raid to start upon entering a<br />
    ///     village (only received from an Illager captain upon<br />
    ///     its death), higher levels cause a more difficult raid
    /// </summary>
    [EnumData("bad_omen")] BadOmen = 31,

    /// <summary>
    ///     Gives discounts on trades with villagers, and makes<br />
    ///     villagers throw items at the player depending on<br />
    ///     their profession
    /// </summary>
    [EnumData("hero_of_the_village")] VillageHero = 32
}