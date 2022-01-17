using Newtonsoft.Json;

namespace CopperSharp.Text.Impl;

/// <summary>
/// An abstract container for components to be serialized into JSON strings
/// </summary>
public abstract class AbstractComponentContainer : IHoverEventContainer
{
    /// <summary>
    /// Children of this component container
    /// </summary>
    [JsonProperty("extra")]
    public abstract List<AbstractComponentContainer> Children { get; }

    /// <summary>
    /// Color of this component container
    /// </summary>
    [JsonProperty("color")]
    public abstract string Color { get; }

    /// <summary>
    /// Whether this component is bold
    /// </summary>
    [JsonProperty("bold")]
    public bool IsBold { get; }

    /// <summary>
    /// Whether this component is bold
    /// </summary>
    [JsonProperty("italic")]
    public bool IsItalic { get; }

    /// <summary>
    /// Whether this component is obfuscated
    /// </summary>
    [JsonProperty("obfuscated")]
    public bool IsObfuscated { get; }

    /// <summary>
    /// Whether this component is underlined
    /// </summary>
    [JsonProperty("underlined")]
    public bool IsUnderlined { get; }

    /// <summary>
    /// Whether this component is striked through
    /// </summary>
    [JsonProperty("strikethrough")]
    public bool IsStrikethrough { get; }

    /// <summary>
    /// Insertion text to be inserted when this component is shift clicked
    /// </summary>
    [JsonProperty("insertion")]
    public abstract string InsertionText { get; }

    /// <summary>
    /// An event handler for component click event
    /// </summary>
    [JsonProperty("clickEvent")]
    public abstract ComponentClickEvent ClickEvent { get; }

    /// <summary>
    /// An event handler for component hover event
    /// </summary>
    [JsonProperty("hoverEvent")]
    public abstract ComponentHoverEvent HoverEvent { get; }
}