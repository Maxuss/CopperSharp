//https://minecraft.fandom.com/wiki/Raw_JSON_text_format#Java_Edition
// ReSharper disable RedundantCast

using CopperSharp.Item;
using CopperSharp.Text.Impl;

namespace CopperSharp.Text;

/// <summary>
/// Represents a text component that can be sent to chat or attached to item etc.
/// </summary>
public interface IComponent : ICloneable
{
    private static readonly List<string> BlockIdentifiers = new() {"ore", "block", "banner", "glass", "head", "skull"};

    /// <summary>
    /// Type of current component
    /// </summary>
    public ComponentType ComponentType { get; }

    /// <summary>
    /// Children of current component
    /// </summary>
    public List<IComponent> Children { get; }

    /// <summary>
    /// Formatting of this component
    /// </summary>
    public Dictionary<FormattingType, bool> Formatting { get; }

    /// <summary>
    /// Event handler for component hover
    /// </summary>
    public IHoverEvent? HoverEvent { get; }

    /// <summary>
    /// Event handler for component click
    /// </summary>
    public ClickEvent? ClickEvent { get; }

    /// <summary>
    /// Text to be inserted when this component is shift-clicked
    /// </summary>
    public string? InsertionText { get; }

    /// <summary>
    /// Color of this component
    /// </summary>
    public ITextColor Color { get; }

    /// <summary>
    /// Applies a coloring to this component and returns its copy
    /// </summary>
    /// <param name="color">Color to be applied</param>
    /// <returns>Copy of this component</returns>
    public IComponent Colored(ITextColor color);

    /// <summary>
    /// Applies a formatting to this component and returns its copy
    /// </summary>
    /// <param name="format">Type of formatting to be applied</param>
    /// <param name="flag">Toggles formatting on if true, and off if false</param>
    /// <returns>Copy of this component</returns>
    public IComponent Formatted(FormattingType format, bool flag = true);

    /// <summary>
    /// Adds provided components to this component as children and returns copy of this component
    /// </summary>
    /// <param name="components">Components to be added to this component as children</param>
    /// <returns>Copy of this component</returns>
    public IComponent Child(params IComponent[] components);

    /// <summary>
    /// Adds provided click event handler to this component
    /// </summary>
    /// <param name="click">Click event handler to be added to this component</param>
    /// <returns>Copy of this component</returns>
    public IComponent OnClick(ClickEvent click);

    /// <summary>
    /// Adds provided hover event handler to this component
    /// </summary>
    /// <param name="hover">Hover event handler to be added to this component</param>
    /// <returns>Copy of this component</returns>
    public IComponent OnHover(IHoverEvent hover);

    /// <summary>
    /// Adds an insertion text to be inserted into chat when the component is shift clicked
    /// </summary>
    /// <param name="insertion">Insertion to be provided</param>
    /// <returns>Copy of this component</returns>
    public IComponent Insertion(string insertion);

    /// <summary>
    /// Converts this component to parseable container
    /// </summary>
    public AbstractComponentContainer Contain();

    /// <summary>
    /// Removes italic formatting from this component
    /// </summary>
    /// <returns>Copy of this component</returns>
    public IComponent NoItalic()
        => Formatted(FormattingType.Italic, false);

    /// <summary>
    /// Serializes this component to JSON string
    /// </summary>
    /// <returns>String, that can be parsed by minecraft as component</returns>
    public string Serialize()
        => Contain().Serialize();

    /// <summary>
    /// Creates a new <see cref="TextComponent"/>
    /// </summary>
    /// <param name="text">Text to be stored inside the component</param>
    /// <returns>A new instance of text component</returns>
    public static IComponent Text(string text)
    {
        return new TextComponent(text) as IComponent;
    }

    /// <summary>
    /// Constructs a new component representing provided material
    /// </summary>
    /// <param name="material">Material to convert into component</param>
    /// <returns>Translatable component of this material</returns>
    public static IComponent Material(Material material)
    {
        var prefix = "item";
        if (BlockIdentifiers.Any(it => material.Id.Path.Contains(it)))
            prefix = "block";
        return new TranslatableComponent($"{prefix}.{material.Id.Namespace}.{material.Id.Path}").Formatted(
            FormattingType.Italic, false);
    }

    /// <summary>
    /// Creates a new <see cref="TranslatableComponent"/>
    /// </summary>
    /// <param name="key">Key to be stored as localizable string inside component</param>
    /// <returns>A new instance of translatable component</returns>
    public static IComponent Translatable(string key)
    {
        return new TranslatableComponent(key) as IComponent;
    }
}