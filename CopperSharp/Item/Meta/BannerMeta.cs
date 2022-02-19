using CopperSharp.Data.SNbt;
using CopperSharp.Text;

namespace CopperSharp.Item.Meta;

/// <summary>
///     Metadata container for banners
/// </summary>
public sealed class BannerMeta : BlockItemMeta
{
    internal bool WriteBlockEntityTag = true;

    /// <inheritdoc />
    public BannerMeta(Material type) : base(type)
    {
        if (!type.Id.ToString().Contains("banner"))
            throw new Exception($"Material of type {type.Id} can not be used as a banner!");
    }

    private Component? BannerName { get; set; }
    private List<BannerPattern> Patterns { get; } = new();

    /// <summary>
    ///     The name of this banner as component,<br />
    ///     which appears when attempting to open it,<br />
    ///     while it is locked.
    /// </summary>
    /// <param name="comp">New custom name</param>
    /// <returns>This banner meta</returns>
    public BannerMeta CustomBannerName(Component comp)
    {
        BannerName = comp;
        return this;
    }

    /// <summary>
    ///     Decorates this banner with provided pattern type and color
    /// </summary>
    /// <param name="type">Type of the pattern to be applied</param>
    /// <param name="color">Color of the pattern</param>
    /// <returns>This banner meta</returns>
    public BannerMeta Decorate(PatternType type, NumberedColor color)
    {
        Patterns.Add(new BannerPattern(color, type));
        return this;
    }

    /// <summary>
    ///     Decorates this banner with provided patterns
    /// </summary>
    /// <param name="patterns">Patterns to be applied to the banner</param>
    /// <returns>This banner meta</returns>
    public BannerMeta Decorate(params BannerPattern[] patterns)
    {
        Patterns.AddRange(patterns);
        return this;
    }

    /// <inheritdoc />
    internal override async Task WriteExternalMetaData(INbtWriter w)
    {
        if (WriteBlockEntityTag)
        {
            await w.WritePropertyNameAsync("BlockEntityTag");
            await w.WriteBeginCompoundAsync();
        }

        if (BannerName != null)
        {
            await w.WritePropertyNameAsync("CustomName");
            await w.WriteStringAsync(await BannerName.Serialize());
        }

        if (!Patterns.Any())
        {
            await w.WriteEndCompoundAsync();
            return;
        }

        await w.WritePropertyNameAsync("Patterns");
        await w.WriteBeginArrayAsync();
        foreach (var pat in Patterns)
        {
            await w.WriteBeginCompoundAsync();
            await w.WritePropertyNameAsync("Color");
            await w.WriteIntegerAsync((int) pat.Color);
            await w.WritePropertyNameAsync("Pattern");
            await w.WriteStringAsync(pat.Pattern.Name);
            await w.WriteEndCompoundAsync();
        }

        await w.WriteEndArrayAsync();
        if (WriteBlockEntityTag)
            await w.WriteEndCompoundAsync();
    }
}

/// <summary>
///     A pattern to store inside a banner
/// </summary>
public readonly struct BannerPattern
{
    /// <summary>
    ///     Initializes a new banner pattern
    /// </summary>
    /// <param name="color">Color of this pattern</param>
    /// <param name="pattern">Type of this pattern</param>
    public BannerPattern(NumberedColor color, PatternType pattern)
    {
        Color = color;
        Pattern = pattern;
    }

    /// <summary>
    ///     Color of this banner's pattern
    /// </summary>
    public NumberedColor Color { get; }

    /// <summary>
    ///     Pattern of the banner
    /// </summary>
    public PatternType Pattern { get; }
}

/// <summary>
///     Represents a type of banner pattern
/// </summary>
public readonly struct PatternType
{
    /// <summary>
    ///     Short internal code for this pattern type
    /// </summary>
    public readonly string Name;

    private PatternType(string name)
    {
        Name = name;
    }

    /// <summary>
    ///     Fully color Field
    /// </summary>
    public static PatternType Base { get; } = new("b");

    /// <summary>
    ///     Base
    /// </summary>
    public static PatternType BottomStripe { get; } = new("bs");

    /// <summary>
    ///     Chief
    /// </summary>
    public static PatternType TopStripe { get; } = new("ts");

    /// <summary>
    ///     Pale dexter
    /// </summary>
    public static PatternType LeftStripe { get; } = new("ls");

    /// <summary>
    ///     Pale sinister
    /// </summary>
    public static PatternType RightStripe { get; } = new("rs");

    /// <summary>
    ///     Pale
    /// </summary>
    public static PatternType CenterStripe { get; } = new("cs");

    /// <summary>
    ///     Fess
    /// </summary>
    public static PatternType MiddleStripe { get; } = new("ms");

    /// <summary>
    ///     Bend
    /// </summary>
    public static PatternType DownRightStripe { get; } = new("drs");

    /// <summary>
    ///     Bend sinister
    /// </summary>
    public static PatternType DownLeftStripe { get; } = new("dls");

    /// <summary>
    ///     Paly
    /// </summary>
    public static PatternType SmallVerticalStripes { get; } = new("ss");

    /// <summary>
    ///     Saltire
    /// </summary>
    public static PatternType DiagonalCross { get; } = new("cr");

    /// <summary>
    ///     Cross
    /// </summary>
    public static PatternType SquareCross { get; } = new("cs");

    /// <summary>
    ///     Per bend sinister
    /// </summary>
    public static PatternType LeftOfDiagonal { get; } = new("ld");

    /// <summary>
    ///     Per bend
    /// </summary>
    public static PatternType RightOfReversedDiagonal { get; } = new("rud");

    /// <summary>
    ///     Per bend inverted
    /// </summary>
    public static PatternType LeftOfReversedDiagonal { get; } = new("lud");

    /// <summary>
    ///     Per bend sinister inverted
    /// </summary>
    public static PatternType RightOfDiagonal { get; } = new("rd");

    /// <summary>
    ///     Per pale
    /// </summary>
    public static PatternType LeftVerticalHalf { get; } = new("vh");

    /// <summary>
    ///     Per pale inverted
    /// </summary>
    public static PatternType RightVerticalHalf { get; } = new("vhr");

    /// <summary>
    ///     Per fess
    /// </summary>
    public static PatternType TopHorizontalHalf { get; } = new("hh");

    /// <summary>
    ///     Per fess inverted
    /// </summary>
    public static PatternType BottomHorizontalHalf { get; } = new("hhb");

    /// <summary>
    ///     Base dexter canton
    /// </summary>
    public static PatternType BottomLeftCorner { get; } = new("bl");

    /// <summary>
    ///     Base sinister canton
    /// </summary>
    public static PatternType BottomRightCorner { get; } = new("br");

    /// <summary>
    ///     Chief dexter canton
    /// </summary>
    public static PatternType TopLeftCorner { get; } = new("tl");

    /// <summary>
    ///     Chief sinister canton
    /// </summary>
    public static PatternType TopRightCorner { get; } = new("tr");

    /// <summary>
    ///     Chevron
    /// </summary>
    public static PatternType BottomTriangle { get; } = new("bt");

    /// <summary>
    ///     Inverted chevron
    /// </summary>
    public static PatternType TopTriangle { get; } = new("tt");

    /// <summary>
    ///     Base indented
    /// </summary>
    public static PatternType BottomTriangleSawtooth { get; } = new("bts");

    /// <summary>
    ///     Chief indented
    /// </summary>
    public static PatternType TopTriangleSawtooth { get; } = new("tts");

    /// <summary>
    ///     Roundel
    /// </summary>
    public static PatternType MiddleCircle { get; } = new("mc");

    /// <summary>
    ///     Lozenge
    /// </summary>
    public static PatternType MiddleRhombus { get; } = new("mr");

    /// <summary>
    ///     Bordure
    /// </summary>
    public static PatternType Border { get; } = new("bo");

    /// <summary>
    ///     Bordure indented
    /// </summary>
    public static PatternType CurlyBorder { get; } = new("cbo");

    /// <summary>
    ///     Field masoned
    /// </summary>
    public static PatternType Bricks { get; } = new("bri");

    /// <summary>
    ///     Gradient
    /// </summary>
    public static PatternType Gradient { get; } = new("gra");

    /// <summary>
    ///     Base gradient
    /// </summary>
    public static PatternType GradientUpsideDown { get; } = new("gru");

    /// <summary>
    ///     Creeper charge
    /// </summary>
    public static PatternType Creeper { get; } = new("cre");

    /// <summary>
    ///     Skull charge
    /// </summary>
    public static PatternType Skull { get; } = new("sku");

    /// <summary>
    ///     Flower charge
    /// </summary>
    public static PatternType Flower { get; } = new("flo");

    /// <summary>
    ///     Thing
    /// </summary>
    public static PatternType Mojang { get; } = new("moj");

    /// <summary>
    ///     Globe
    /// </summary>
    public static PatternType Globe { get; } = new("glb");

    /// <summary>
    ///     Snout
    /// </summary>
    public static PatternType Piglin { get; } = new("pig");
}