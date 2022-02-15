using CopperSharp.Data.Effects;
using CopperSharp.Utils;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
///     Triggers after the player takes any item out of a brewing stand.
/// </summary>
[CriterionName("brewed_potion")]
public sealed class BrewedPotion : TriggerCondition
{
    /// <summary>
    ///     Sets type of potion to be displayed
    /// </summary>
    /// <param name="type">Type of potion</param>
    /// <returns>This trigger</returns>
    public BrewedPotion PotionType(NamedPotion type)
    {
        Data["potion"] = type.GetName().ToSnakeCase();
        return this;
    }
}

/// <summary>
///     Represents a type of potion name.
///     Not to be confused with <see cref="StatusEffect" />
/// </summary>
public enum NamedPotion
{
    /// <summary>
    ///     Uncraftable
    /// </summary>
    Uncraftable,

    /// <summary>
    ///     Water bottle
    /// </summary>
    Water,

    /// <summary>
    ///     Mundane
    /// </summary>
    Mundane,

    /// <summary>
    ///     Thick
    /// </summary>
    Thick,

    /// <summary>
    ///     Awkward
    /// </summary>
    Awkward,

    /// <summary>
    ///     Night Vision
    /// </summary>
    NightVision,

    /// <summary>
    ///     Invisibility
    /// </summary>
    Invisibility,

    /// <summary>
    ///     Leaping
    /// </summary>
    Leaping,

    /// <summary>
    ///     Fire Resistance
    /// </summary>
    FireResistance,

    /// <summary>
    ///     Swiftness
    /// </summary>
    Swiftness,

    /// <summary>
    ///     Slowness
    /// </summary>
    Slowness,

    /// <summary>
    ///     Water Breathing
    /// </summary>
    WaterBreathing,

    /// <summary>
    ///     Healing
    /// </summary>
    Healing,

    /// <summary>
    ///     Harming
    /// </summary>
    Harming,

    /// <summary>
    ///     Poison
    /// </summary>
    Poison,

    /// <summary>
    ///     Regeneration
    /// </summary>
    Regeneration,

    /// <summary>
    ///     Strength
    /// </summary>
    Strength,

    /// <summary>
    ///     Weakness
    /// </summary>
    Weakness,

    /// <summary>
    ///     Luck
    /// </summary>
    Luck,

    /// <summary>
    ///     Turtle Master
    /// </summary>
    TurtleMaster,

    /// <summary>
    ///     Slow Falling
    /// </summary>
    SlowFalling,

    /// <summary>
    ///     Strong Leaping
    /// </summary>
    StrongLeaping,

    /// <summary>
    ///     Strong Swiftness
    /// </summary>
    StrongSwiftness,

    /// <summary>
    ///     Strong Slowness
    /// </summary>
    StrongSlowness,

    /// <summary>
    ///     Strong Healing
    /// </summary>
    StrongHealing,

    /// <summary>
    ///     Strong Harming
    /// </summary>
    StrongHarming,

    /// <summary>
    ///     Strong Poison
    /// </summary>
    StrongPoison,

    /// <summary>
    ///     Strong regeneration
    /// </summary>
    StrongRegeneration,

    /// <summary>
    ///     Strong Strength
    /// </summary>
    StrongStrength,

    /// <summary>
    ///     Strong Turtle Master
    /// </summary>
    StrongTurtleMaster,

    /// <summary>
    ///     Long Night Vision
    /// </summary>
    LongNightVision,

    /// <summary>
    ///     Long Invisibility
    /// </summary>
    LongInvisibility,

    /// <summary>
    ///     Long Leaping
    /// </summary>
    LongLeaping,

    /// <summary>
    ///     Long Fire Resistance
    /// </summary>
    LongFireResistance,

    /// <summary>
    ///     Long Swiftness
    /// </summary>
    LongSwiftness,

    /// <summary>
    ///     Long Slowness
    /// </summary>
    LongSlowness,

    /// <summary>
    ///     Long Water Breathing
    /// </summary>
    LongWaterBreathing,

    /// <summary>
    ///     Long Poison
    /// </summary>
    LongPoison,

    /// <summary>
    ///     Long Regeneration
    /// </summary>
    LongRegeneration,

    /// <summary>
    ///     Long Strength
    /// </summary>
    LongStrength,

    /// <summary>
    ///     Long Weakness
    /// </summary>
    LongWeakness,

    /// <summary>
    ///     Long Turtle Master
    /// </summary>
    LongTurtleMaster,

    /// <summary>
    ///     Long Slow Falling
    /// </summary>
    LongSlowFalling
}