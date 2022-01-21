namespace CopperSharp.Data.Attributes;

/// <summary>
/// Represents attributes, only applicable to horses
/// </summary>
public readonly struct HorseAttribute : IAttributeType
{
    private HorseAttribute(string name, double defaultBase, double maximum)
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
    /// Horse jump strength in some unknown metric. 
    /// </summary>
    public static HorseAttribute JumpStrength { get; } = new("horse.jump_strength", 0.7d, 2d);
}