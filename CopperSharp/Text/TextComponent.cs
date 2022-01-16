// ReSharper disable RedundantCast

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
    public ITextColor Color { get; } = NamedTextColor.White;

    /// <summary>
    /// Creates a new text component from provided text
    /// </summary>
    /// <param name="text">Text to be put in component</param>
    public TextComponent(string text)
    {
        Text = text;
    }

    private TextComponent(string text, List<IComponent> children, TextFormatting formatting, ITextColor color)
    {
        Text = text;
        Children = children;
        Formatting = formatting;
        Color = color;
    }

    /// <inheritdoc />
    public IComponent Colored(ITextColor color)
    {
        return new TextComponent(Text, Children, Formatting, color) as IComponent;
    }

    /// <inheritdoc />
    public IComponent Formatted(TextFormatting format)
    {
        return new TextComponent(Text, Children, format, Color) as IComponent;
    }

    /// <inheritdoc />
    public IComponent Child(params IComponent[] components)
    {
        Children.AddRange(components);
        return new TextComponent(Text, Children, Formatting, Color) as IComponent;
    }

    /// <inheritdoc />
    public object Clone()
    {
        return new TextComponent(Text, Children, Formatting, Color) as object;
    }
}