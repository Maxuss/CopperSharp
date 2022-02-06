namespace CopperSharp.Data.Attributes;

/// <summary>
///     Represents an attribute, only applicable to bees and parrots
/// </summary>
public readonly struct FlyingEntityAttribute
{
    private FlyingEntityAttribute(string name, double defaultBase, double maximum)
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
    ///     Flight speed modifier in some unknown metric.<br />
    ///     Set to 0.6 for bees and 0.4 for parrots.
    /// </summary>
    public static FlyingEntityAttribute FlightSpeed { get; } = new("generic.flying_speed", 0.4d, 1024d);
}