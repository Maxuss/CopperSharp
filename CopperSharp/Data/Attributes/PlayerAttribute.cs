namespace CopperSharp.Data.Attributes;

/// <summary>
///     Represents attribute type applicable only to players
/// </summary>
public readonly struct PlayerAttribute : IAttributeType
{
    private PlayerAttribute(string name, double defaultBase, double maximum)
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
    ///     Determines recharging rate of attack strength.<br />
    ///     Value is the number of full-strength attacks per second.
    /// </summary>
    public static PlayerAttribute AttackSpeed { get; } = new("generic.attack_speed", 4d, 1024d);

    /// <summary>
    ///     Affects the results of loot tables using the quality<br />
    ///     or bonus_rolls tag (e.g. when opening chests or chest minecarts,<br />
    ///     fishing, and killing mobs).
    /// </summary>
    public static PlayerAttribute Luck { get; } = new("generic.luck", 0d, 1024d);
}