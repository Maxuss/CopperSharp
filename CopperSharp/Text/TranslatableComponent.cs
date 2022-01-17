// ReSharper disable RedundantCast

using CopperSharp.Text.Impl;

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
    public IHoverEvent? HoverEvent { get; }

    /// <inheritdoc />
    public ClickEvent? ClickEvent { get; }

    /// <inheritdoc />
    public ITextColor Color { get; } = NamedTextColor.White;

    /// <summary>
    /// Creates a new translatable component from provided text
    /// </summary>
    /// <param name="key">Localization key to be put in component</param>
    public TranslatableComponent(string key)
    {
        Key = key;
        HoverEvent = null;
        ClickEvent = null;
    }

    private TranslatableComponent(string text, List<IComponent> children, TextFormatting formatting, ITextColor color,
        IHoverEvent? hover, ClickEvent? click)
    {
        Key = text;
        Children = children;
        Formatting = formatting;
        Color = color;
        HoverEvent = hover;
        ClickEvent = click;
    }

    /// <inheritdoc />
    public IComponent Colored(ITextColor color)
    {
        return new TranslatableComponent(Key, Children, Formatting, color, HoverEvent, ClickEvent) as IComponent;
    }

    /// <inheritdoc />
    public IComponent Formatted(TextFormatting format)
    {
        return new TranslatableComponent(Key, Children, format, Color, HoverEvent, ClickEvent) as IComponent;
    }

    /// <inheritdoc />
    public IComponent Child(params IComponent[] components)
    {
        Children.AddRange(components);
        return new TranslatableComponent(Key, Children, Formatting, Color, HoverEvent, ClickEvent) as IComponent;
    }

    /// <inheritdoc />
    public IComponent OnClick(ClickEvent click)
    {
        return new TranslatableComponent(Key, Children, Formatting, Color, HoverEvent, click) as IComponent;
    }

    /// <inheritdoc />
    public IComponent OnHover(IHoverEvent hover)
    {
        return new TranslatableComponent(Key, Children, Formatting, Color, hover, ClickEvent) as IComponent;
    }

    /// <inheritdoc />
    public AbstractComponentContainer Contain()
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public object Clone()
    {
        return new TranslatableComponent(Key, Children, Formatting, Color, HoverEvent, ClickEvent) as object;
    }
}