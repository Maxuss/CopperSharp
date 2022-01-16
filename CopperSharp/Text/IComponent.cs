//https://minecraft.fandom.com/wiki/Raw_JSON_text_format#Java_Edition
// ReSharper disable RedundantCast

namespace CopperSharp.Text;

/// <summary>
/// Represents a text component that can be sent to chat or attached to item etc.
/// </summary>
public interface IComponent : ICloneable
{
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
    public TextFormatting Formatting { get; }

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
    /// <param name="format">Formatting to be applied</param>
    /// <returns>Copy of this component</returns>
    public IComponent Formatted(TextFormatting format);

    /// <summary>
    /// Applies a formatting to this component and returns its copy
    /// </summary>
    /// <param name="format">Type of formatting to be applied</param>
    /// <param name="flag">Toggles formatting on if true, and off if false</param>
    /// <returns>Copy of this component</returns>
    public IComponent Formatted(FormattingType format, bool flag = true)
        => Formatted(new TextFormatting(format, flag));

    /// <summary>
    /// Adds provided components to this component as children and returns copy of this component
    /// </summary>
    /// <param name="components">Components to be added to this component as children</param>
    /// <returns>Copy of this component</returns>
    public IComponent Child(params IComponent[] components);

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
    /// Creates a new <see cref="TranslatableComponent"/>
    /// </summary>
    /// <param name="key">Key to be stored as localizable string inside component</param>
    /// <returns>A new instance of translatable component</returns>
    public static IComponent Translatable(string key)
    {
        return new TranslatableComponent(key) as IComponent;
    }
}