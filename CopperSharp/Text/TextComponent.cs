// ReSharper disable RedundantCast

using CopperSharp.Text.Impl;
using CopperSharp.Utils;

namespace CopperSharp.Text;

/// <summary>
/// A text based component for raw strings
/// </summary>
public readonly struct TextComponent : IComponent
{
    /// <summary>
    /// Text stored inside this component
    /// </summary>
    public string Text { get; }

    /// <inheritdoc />
    public ComponentType ComponentType => ComponentType.Text;

    /// <inheritdoc />
    public List<IComponent> Children { get; } = new();

    /// <inheritdoc />
    public Dictionary<FormattingType, bool> Formatting { get; } = new();

    /// <inheritdoc />
    public IHoverEvent? HoverEvent { get; }

    /// <inheritdoc />
    public ClickEvent? ClickEvent { get; }

    /// <inheritdoc />
    public string? InsertionText { get; }

    /// <inheritdoc />
    public ITextColor? Color { get; }

    /// <summary>
    /// Creates a new text component from provided text
    /// </summary>
    /// <param name="text">Text to be put in component</param>
    public TextComponent(string text)
    {
        Text = text;
        HoverEvent = null;
        ClickEvent = null;
        InsertionText = null;
        Color = null;
    }

    private TextComponent(string text, List<IComponent> children, Dictionary<FormattingType, bool> formatting,
        ITextColor? color,
        IHoverEvent? hover, ClickEvent? click, string? insertion)
    {
        Text = text;
        Children = children;
        Formatting = formatting;
        Color = color;
        HoverEvent = hover;
        ClickEvent = click;
        InsertionText = insertion;
    }

    /// <inheritdoc />
    public IComponent Colored(ITextColor color)
    {
        return new TextComponent(Text, Children, Formatting, color, HoverEvent, ClickEvent,
            InsertionText) as IComponent;
    }

    /// <inheritdoc />
    public IComponent Formatted(FormattingType type, bool toggle = true)
    {
        Formatting[type] = toggle;
        return new TextComponent(Text, Children, Formatting, Color, HoverEvent, ClickEvent,
            InsertionText) as IComponent;
    }

    /// <inheritdoc />
    public IComponent Child(params IComponent[] components)
    {
        Children.AddRange(components);
        return new TextComponent(Text, Children, Formatting, Color, HoverEvent, ClickEvent,
            InsertionText) as IComponent;
    }

    /// <inheritdoc />
    public IComponent OnClick(ClickEvent click)
    {
        return new TextComponent(Text, Children, Formatting, Color, HoverEvent, click, InsertionText) as IComponent;
    }

    /// <inheritdoc />
    public IComponent OnHover(IHoverEvent hover)
    {
        return new TextComponent(Text, Children, Formatting, Color, hover, ClickEvent, InsertionText) as IComponent;
    }

    /// <inheritdoc />
    public IComponent Insertion(string insertion)
    {
        return new TextComponent(Text, Children, Formatting, Color, HoverEvent, ClickEvent, insertion) as IComponent;
    }

    /// <inheritdoc />
    public AbstractComponentContainer Contain()
    {
        return new TextComponentContainer(this);
    }

    /// <summary>
    /// Constructs a quadratic gradient between two colors
    /// </summary>
    /// <param name="from">From color</param>
    /// <param name="to">To color</param>
    /// <param name="fast">Whether to speed up gradient interpolation over time</param>
    /// <returns>Modified copy of this component</returns>
    /// <exception cref="Exception">Provided colors are named text colors, which are not supported</exception>
    public IComponent QuadraticGradient(ITextColor from, ITextColor to, bool fast = true)
    {
        if (from is NamedTextColor || to is NamedTextColor)
            throw new Exception("Can not build gradient from named text colors!");

        var red = MathUtils.QuadraticInterpolation(from.R, to.R, Text.Length, fast);
        var green = MathUtils.QuadraticInterpolation(from.G, to.G, Text.Length, fast);
        var blue = MathUtils.QuadraticInterpolation(from.B, to.B, Text.Length, fast);

        var empty = new TextComponent(Text[0].ToString()).Colored(ITextColor.Hex(red[0], green[0], blue[0]));
        for (var i = 1; i < Text.Length; i++)
        {
            empty = empty.Child(
                new TextComponent(Text[i].ToString()).Colored(ITextColor.Hex(red[i], green[i], blue[i])));
        }

        return empty;
    }

    /// <summary>
    /// Constructs a linear gradient between two colors
    /// </summary>
    /// <param name="from">From color</param>
    /// <param name="to">To color</param>
    /// <returns>Modified copy of this component</returns>
    /// <exception cref="Exception">Provided colors are named text colors, which are not supported</exception>
    public IComponent LinearGradient(ITextColor from, ITextColor to)
    {
        if (from is NamedTextColor || to is NamedTextColor)
            throw new Exception("Can not build gradient from named text colors!");

        var red = MathUtils.LinearInterpolation(from.R, to.R, Text.Length);
        var green = MathUtils.LinearInterpolation(from.G, to.G, Text.Length);
        var blue = MathUtils.LinearInterpolation(from.B, to.B, Text.Length);

        var empty = new TextComponent(Text[0].ToString()).Colored(ITextColor.Hex(red[0], green[0], blue[0]));
        for (var i = 1; i < Text.Length; i++)
        {
            empty = empty.Child(
                new TextComponent(Text[i].ToString()).Colored(ITextColor.Hex(red[i], green[i], blue[i])));
        }

        return empty;
    }

    /// <inheritdoc />
    public object Clone()
    {
        return new TextComponent(Text, Children, Formatting, Color, HoverEvent, ClickEvent, InsertionText) as object;
    }
}