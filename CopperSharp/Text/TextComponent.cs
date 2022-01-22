// ReSharper disable RedundantCast

using CopperSharp.Text.Impl;

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

    /// <inheritdoc />
    public object Clone()
    {
        return new TextComponent(Text, Children, Formatting, Color, HoverEvent, ClickEvent, InsertionText) as object;
    }
}