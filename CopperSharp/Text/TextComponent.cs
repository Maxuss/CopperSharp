// ReSharper disable RedundantCast

using CopperSharp.Text.Impl;

namespace CopperSharp.Text;

/// <summary>
/// A text based component for raw strings
/// </summary>
public readonly struct TextComponent : IComponent
{
    private string Text { get; }

    /// <inheritdoc />
    public ComponentType ComponentType => ComponentType.Text;

    /// <inheritdoc />
    public List<IComponent> Children { get; } = new();

    /// <inheritdoc />
    public TextFormatting Formatting { get; } = new(FormattingType.Italic, false);


    /// <inheritdoc />
    public IHoverEvent? HoverEvent { get; }

    /// <inheritdoc />
    public ClickEvent? ClickEvent { get; }

    /// <inheritdoc />
    public ITextColor Color { get; } = NamedTextColor.White;

    /// <summary>
    /// Creates a new text component from provided text
    /// </summary>
    /// <param name="text">Text to be put in component</param>
    public TextComponent(string text)
    {
        Text = text;
        HoverEvent = null;
        ClickEvent = null;
    }

    private TextComponent(string text, List<IComponent> children, TextFormatting formatting, ITextColor color,
        IHoverEvent? hover, ClickEvent? click)
    {
        Text = text;
        Children = children;
        Formatting = formatting;
        Color = color;
        HoverEvent = hover;
        ClickEvent = click;
    }

    /// <inheritdoc />
    public IComponent Colored(ITextColor color)
    {
        return new TextComponent(Text, Children, Formatting, color, HoverEvent, ClickEvent) as IComponent;
    }

    /// <inheritdoc />
    public IComponent Formatted(TextFormatting format)
    {
        return new TextComponent(Text, Children, format, Color, HoverEvent, ClickEvent) as IComponent;
    }

    /// <inheritdoc />
    public IComponent Child(params IComponent[] components)
    {
        Children.AddRange(components);
        return new TextComponent(Text, Children, Formatting, Color, HoverEvent, ClickEvent) as IComponent;
    }

    /// <inheritdoc />
    public IComponent OnClick(ClickEvent click)
    {
        return new TextComponent(Text, Children, Formatting, Color, HoverEvent, click) as IComponent;
    }

    /// <inheritdoc />
    public IComponent OnHover(IHoverEvent hover)
    {
        return new TextComponent(Text, Children, Formatting, Color, hover, ClickEvent) as IComponent;
    }

    /// <inheritdoc />
    public AbstractComponentContainer Contain()
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public object Clone()
    {
        return new TextComponent(Text, Children, Formatting, Color, HoverEvent, ClickEvent) as object;
    }
}