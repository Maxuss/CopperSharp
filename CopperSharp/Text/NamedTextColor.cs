namespace CopperSharp.Text;

/// <summary>
///     Represents a named text color, e.g. blue, red, gold, etc.
/// </summary>
public readonly struct NamedTextColor : ITextColor
{
    /// <summary>
    ///     Black named color
    /// </summary>
    public static readonly NamedTextColor Black = new("black", 0x000000);

    /// <summary>
    ///     Dark blue named color
    /// </summary>
    public static readonly NamedTextColor DarkBlue = new("dark_blue", 0x0000AA);

    /// <summary>
    ///     Dark green named color
    /// </summary>
    public static readonly NamedTextColor DarkGreen = new("dark_green", 0x00AA00);

    /// <summary>
    ///     Dark aqua named color
    /// </summary>
    public static readonly NamedTextColor DarkAqua = new("dark_aqua", 0x00AAAA);

    /// <summary>
    ///     Dark red named color
    /// </summary>
    public static readonly NamedTextColor DarkRed = new("dark_red", 0xAA0000);

    /// <summary>
    ///     Dark purple named
    /// </summary>
    public static readonly NamedTextColor DarkPurple = new("dark_purple", 0xAA00AA);

    /// <summary>
    ///     Gold named color
    /// </summary>
    public static readonly NamedTextColor Gold = new("gold", 0xFFAA00);

    /// <summary>
    ///     Gray named color
    /// </summary>
    public static readonly NamedTextColor Gray = new("gray", 0xAAAAAA);

    /// <summary>
    ///     Dark gray named color
    /// </summary>
    public static readonly NamedTextColor DarkGray = new("dark_gray", 0x555555);

    /// <summary>
    ///     Blue named color
    /// </summary>
    public static readonly NamedTextColor Blue = new("blue", 0x5555FF);

    /// <summary>
    ///     Green named color
    /// </summary>
    public static readonly NamedTextColor Green = new("green", 0x55FF55);

    /// <summary>
    ///     Aqua named color
    /// </summary>
    public static readonly NamedTextColor Aqua = new("aqua", 0x55FFFF);

    /// <summary>
    ///     Red named color
    /// </summary>
    public static readonly NamedTextColor Red = new("red", 0xFF5555);

    /// <summary>
    ///     Light purple named color
    /// </summary>
    public static readonly NamedTextColor LightPurple = new("light_purple", 0xFF55FF);

    /// <summary>
    ///     Yellow named color
    /// </summary>
    public static readonly NamedTextColor Yellow = new("yellow", 0xFFFF55);

    /// <summary>
    ///     White named color
    /// </summary>
    public static readonly NamedTextColor White = new("white", 0xFFFFFF);

    /// <summary>
    ///     Resets current color
    /// </summary>
    public static readonly NamedTextColor Reset = new("reset", -1);


    private NamedTextColor(string name, int hex)
    {
        Name = name;
        R = (hex >> 16) & 0xFF;
        G = (hex >> 8) & 0xFF;
        B = (hex >> 0) & 0xFF;
    }

    private string Name { get; }

    /// <inheritdoc />
    public int R { get; }

    /// <inheritdoc />
    public int G { get; }

    /// <inheritdoc />
    public int B { get; }

    /// <summary>
    ///     Converts this text color to string by its name
    /// </summary>
    /// <returns>Name of current named text color</returns>
    public override string ToString()
    {
        return Name;
    }
}