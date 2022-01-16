namespace CopperSharp.Text;

/// <summary>
/// Represents a named text color, e.g. blue, red, gold, etc.
/// </summary>
public readonly struct NamedTextColor : ITextColor
{
    /// <summary>
    /// Black named color
    /// </summary>
    public static readonly NamedTextColor Black = new("black");

    /// <summary>
    /// Dark blue named color
    /// </summary>
    public static readonly NamedTextColor DarkBlue = new("dark_blue");

    /// <summary>
    /// Dark green named color
    /// </summary>
    public static readonly NamedTextColor DarkGreen = new("dark_green");

    /// <summary>
    /// Dark aqua named color
    /// </summary>
    public static readonly NamedTextColor DarkAqua = new("dark_aqua");

    /// <summary>
    /// Dark red named color
    /// </summary>
    public static readonly NamedTextColor DarkRed = new("dark_red");

    /// <summary>
    /// Dark purple named
    /// </summary>
    public static readonly NamedTextColor DarkPurple = new("dark_purple");

    /// <summary>
    /// Gold named color
    /// </summary>
    public static readonly NamedTextColor Gold = new("gold");

    /// <summary>
    /// Gray named color
    /// </summary>
    public static readonly NamedTextColor Gray = new("gray");

    /// <summary>
    /// Dark gray named color
    /// </summary>
    public static readonly NamedTextColor DarkGray = new("dark_gray");

    /// <summary>
    /// Blue named color
    /// </summary>
    public static readonly NamedTextColor Blue = new("blue");

    /// <summary>
    /// Green named color
    /// </summary>
    public static readonly NamedTextColor Green = new("green");

    /// <summary>
    /// Aqua named color
    /// </summary>
    public static readonly NamedTextColor Aqua = new("aqua");

    /// <summary>
    /// Red named color
    /// </summary>
    public static readonly NamedTextColor Red = new("red");

    /// <summary>
    /// Light purple named color
    /// </summary>
    public static readonly NamedTextColor LightPurple = new("light_purple");

    /// <summary>
    /// Yellow named color
    /// </summary>
    public static readonly NamedTextColor Yellow = new("yellow");

    /// <summary>
    /// White named color
    /// </summary>
    public static readonly NamedTextColor White = new("white");

    /// <summary>
    /// Resets current color
    /// </summary>
    public static readonly NamedTextColor Reset = new("reset");


    private NamedTextColor(string name)
    {
        Name = name;
    }

    private string Name { get; }

    /// <summary>
    /// Always -1, because this text color is named
    /// </summary>
    public int R => -1;

    /// <summary>
    /// Always -1, because this text color is named
    /// </summary>
    public int G => -1;

    /// <summary>
    /// Always -1, because this text color is named
    /// </summary>
    public int B => -1;

    /// <summary>
    /// Converts this text color to string by its name
    /// </summary>
    /// <returns>Name of current named text color</returns>
    public override string ToString()
    {
        return Name;
    }
}