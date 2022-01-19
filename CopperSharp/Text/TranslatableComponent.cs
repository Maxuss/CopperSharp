// ReSharper disable RedundantCast

using CopperSharp.Text.Impl;

namespace CopperSharp.Text;

/// <summary>
/// A translatable component, that can be localized client-side
/// </summary>
public readonly struct TranslatableComponent : IComponent
{
    /// <summary>
    /// Translation key for this component
    /// </summary>
    public string Key { get; }

    /// <summary>
    /// Extra slots to fit into formatting
    /// </summary>
    public List<IComponent> ExtraSlots { get; } = new();

    /// <inheritdoc />
    public ComponentType ComponentType => ComponentType.Translatable;

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
        InsertionText = null;
    }

    private TranslatableComponent(string text, List<IComponent> children, Dictionary<FormattingType, bool> formatting,
        ITextColor color,
        IHoverEvent? hover, ClickEvent? click, string? insertion, List<IComponent> slots)
    {
        Key = text;
        Children = children;
        Formatting = formatting;
        Color = color;
        HoverEvent = hover;
        ClickEvent = click;
        InsertionText = insertion;
        ExtraSlots = slots;
    }

    /// <inheritdoc />
    public IComponent Colored(ITextColor color)
    {
        return new TranslatableComponent(Key, Children, Formatting, color, HoverEvent, ClickEvent, InsertionText,
            ExtraSlots) as IComponent;
    }

    /// <inheritdoc />
    public IComponent Formatted(FormattingType type, bool toggle = true)
    {
        Formatting[type] = toggle;
        return new TranslatableComponent(Key, Children, Formatting, Color, HoverEvent, ClickEvent, InsertionText,
            ExtraSlots) as IComponent;
    }

    /// <inheritdoc />
    public IComponent Child(params IComponent[] components)
    {
        Children.AddRange(components);
        return new TranslatableComponent(Key, Children, Formatting, Color, HoverEvent, ClickEvent, InsertionText,
            ExtraSlots) as IComponent;
    }

    /// <inheritdoc />
    public IComponent OnClick(ClickEvent click)
    {
        return new TranslatableComponent(Key, Children, Formatting, Color, HoverEvent, click, InsertionText, ExtraSlots)
            as IComponent;
    }

    /// <inheritdoc />
    public IComponent OnHover(IHoverEvent hover)
    {
        return new TranslatableComponent(Key, Children, Formatting, Color, hover, ClickEvent, InsertionText, ExtraSlots)
            as IComponent;
    }

    /// <inheritdoc />
    public IComponent Insertion(string insertion)
    {
        return new TranslatableComponent(Key, Children, Formatting, Color, HoverEvent, ClickEvent, insertion,
            ExtraSlots) as IComponent;
    }

    /// <summary>
    /// Adds an extra slot, to fit into the component formatting
    /// </summary>
    /// <param name="slot">Slot to be put</param>
    /// <returns>Copy of this component</returns>
    public IComponent Slot(IComponent slot)
    {
        ExtraSlots.Add(slot);
        return new TranslatableComponent(Key, Children, Formatting, Color, HoverEvent, ClickEvent, InsertionText,
            ExtraSlots) as IComponent;
    }

    /// <inheritdoc />
    public AbstractComponentContainer Contain()
    {
        return new TranslatableComponentContainer(this);
    }

    /// <inheritdoc />
    public object Clone()
    {
        return new TranslatableComponent(Key, Children, Formatting, Color, HoverEvent, ClickEvent, InsertionText,
            ExtraSlots) as object;
    }
}