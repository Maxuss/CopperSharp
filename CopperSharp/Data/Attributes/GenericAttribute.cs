namespace CopperSharp.Data.Attributes;

/// <summary>
///     Represents a generic attribute
/// </summary>
public readonly struct GenericAttribute : IAttributeType
{
    private GenericAttribute(string name, double defaultBase, double maximum)
    {
        Name = name;
        DefaultBase = defaultBase;
        Maximum = maximum;
    }

    /// <inheritdoc />
    public string Name { get; }

    /// <inheritdoc />
    public double DefaultBase { get; }

    /// <inheritdoc />
    public double Maximum { get; }

    /// <summary>
    ///     The maximum health of this mob (in half-hearts);<br />
    ///     determines the highest health they may be healed to.<br />
    /// </summary>
    public static GenericAttribute MaxHealth { get; } = new("generic.max_health", 20d, 1024d);

    /// <summary>
    ///     The range in blocks within which a mob with this attribute<br />
    ///     targets players or other mobs to track. Exiting this range<br />
    ///     causes the mob to cease following the player/mob. Actual<br />
    ///     value used by most mobs is 16; for zombies it is 40.
    /// </summary>
    public static GenericAttribute FollowRange { get; } = new("generic.follow_range", 32d, 2048d);

    /// <summary>
    ///     The scale of horizontal knockback resisted from attacks and<br />
    ///     projectiles. Vertical knockback is not affected. Does not affect<br />
    ///     explosions. 1.0 is 100% knockback resistance. 0.4 means 60% of<br />
    ///     knockback is applied.
    /// </summary>
    public static GenericAttribute KnockbackResistance { get; } = new("generic.knockback_resistance", 0d, 1d);

    /// <summary>
    ///     Speed of movement in some unknown metric.<br />
    ///     The mob's maximum speed in blocks/second is a<br />
    ///     bit over <b>43 times this value</b>, but can be<br />
    ///     affected by various conditions, such as:
    ///     <list type="bullet">
    ///         <item>
    ///             Being ridden (if a horse)
    ///         </item>
    ///         <item>
    ///             Sprinting/fleeing (if a passive mob)
    ///         </item>
    ///         <item>
    ///             Attacking (if an Enderman or Zombified Piglin)
    ///         </item>
    ///         <item>
    ///             Being led by a leash
    ///         </item>
    ///         <item>
    ///             Being under the effect of a Speed or Slowness potion
    ///         </item>
    ///         <item>
    ///             Being a baby zombie
    ///         </item>
    ///         <item>
    ///             Being a witch and drinking a potion
    ///         </item>
    ///     </list>
    /// </summary>
    public static GenericAttribute MovementSpeed { get; } = new("generic.movement_speed", 0.7d, 1024d);

    /// <summary>
    ///     Damage dealt by attacks, in half-hearts. This attribute is<br />
    ///     not found on passive mobs and <b>golems</b>.
    /// </summary>
    public static GenericAttribute AttackDamage { get; } = new("generic.attack_damage", 2.0d, 2048d);

    /// <summary>
    ///     Armor defense points.
    /// </summary>
    public static GenericAttribute Armor { get; } = new("generic.armor", 0d, 30d);

    /// <summary>
    ///     Armor toughness.
    /// </summary>
    public static GenericAttribute ArmorToughness { get; } = new("generic.armor_toughness", 0d, 20d);

    /// <summary>
    ///     Knockback applied to attacks.<br />
    ///     Applies only to mobs with physical attacks.
    /// </summary>
    public static GenericAttribute AttackKnockback { get; } = new("generic.attack_knockback", 0d, 5d);
}