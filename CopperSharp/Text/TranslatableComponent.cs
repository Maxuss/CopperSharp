// ReSharper disable RedundantCast

namespace CopperSharp.Text;

/// <summary>
/// A translatable component, that can be localized client-side
/// </summary>
public readonly struct TranslatableComponent : IComponent
{
    private string Key { get; }

    /// <inheritdoc />
    public ComponentType ComponentType => ComponentType.Translatable;

    /// <inheritdoc />
    public List<IComponent> Children { get; } = new();

    /// <inheritdoc />
    public TextFormatting Formatting { get; } = new(FormattingType.Italic, false);

    /// <inheritdoc />
    public ITextColor Color { get; } = NamedTextColor.White;

    /// <summary>
    /// Creates a new translatable component from provided text
    /// </summary>
    /// <param name="key">Localization key to be put in component</param>
    public TranslatableComponent(string key)
    {
        Key = key;
    }

    private TranslatableComponent(string text, List<IComponent> children, TextFormatting formatting, ITextColor color)
    {
        Key = text;
        Children = children;
        Formatting = formatting;
        Color = color;
    }

    /// <inheritdoc />
    public IComponent Colored(ITextColor color)
    {
        return new TranslatableComponent(Key, Children, Formatting, color) as IComponent;
    }

    /// <inheritdoc />
    public IComponent Formatted(TextFormatting format)
    {
        return new TranslatableComponent(Key, Children, format, Color) as IComponent;
    }

    /// <inheritdoc />
    public IComponent Child(params IComponent[] components)
    {
        Children.AddRange(components);
        return new TranslatableComponent(Key, Children, Formatting, Color) as IComponent;
    }

    /// <inheritdoc />
    public object Clone()
    {
        return new TranslatableComponent(Key, Children, Formatting, Color) as object;
    }
}