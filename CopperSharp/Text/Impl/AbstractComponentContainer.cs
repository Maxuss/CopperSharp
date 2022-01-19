using Newtonsoft.Json;

namespace CopperSharp.Text.Impl;

/// <summary>
/// An abstract container for components to be serialized into JSON strings
/// </summary>
[JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
public abstract class AbstractComponentContainer : IHoverEventContainer
{
    /// <summary>
    /// Initializes basic fields in this component container
    /// </summary>
    /// <param name="parent">IComponent from which to take fields</param>
    protected AbstractComponentContainer(IComponent parent)
    {
        Children = !parent.Children.Any() ? null : parent.Children.Select(it => it.Contain()).ToList();
        Color = parent.Color.ToString();
        InsertionText = parent.InsertionText;
        ClickEvent = parent.ClickEvent?.Contain();
        HoverEvent = parent.HoverEvent?.Contain();
        IsBold = parent.Formatting.ContainsKey(FormattingType.Bold) ? parent.Formatting[FormattingType.Bold] : null;
        IsItalic = parent.Formatting.ContainsKey(FormattingType.Italic)
            ? parent.Formatting[FormattingType.Italic]
            : null;
        IsObfuscated = parent.Formatting.ContainsKey(FormattingType.Obfuscated)
            ? parent.Formatting[FormattingType.Obfuscated]
            : null;
        IsUnderlined = parent.Formatting.ContainsKey(FormattingType.Underlined)
            ? parent.Formatting[FormattingType.Underlined]
            : null;
        IsStrikethrough = parent.Formatting.ContainsKey(FormattingType.Strikethrough)
            ? parent.Formatting[FormattingType.Strikethrough]
            : null;
    }

    /// <summary>
    /// Children of this component container
    /// </summary>
    [JsonProperty("extra")]
    public List<AbstractComponentContainer>? Children { get; protected set; }

    /// <summary>
    /// Color of this component container
    /// </summary>
    [JsonProperty("color")]
    public string? Color { get; protected set; }

    /// <summary>
    /// Whether this component is bold
    /// </summary>
    [JsonProperty("bold")]
    public bool? IsBold { get; protected set; }

    /// <summary>
    /// Whether this component is bold
    /// </summary>
    [JsonProperty("italic")]
    public bool? IsItalic { get; protected set; }

    /// <summary>
    /// Whether this component is obfuscated
    /// </summary>
    [JsonProperty("obfuscated")]
    public bool? IsObfuscated { get; protected set; }

    /// <summary>
    /// Whether this component is underlined
    /// </summary>
    [JsonProperty("underlined")]
    public bool? IsUnderlined { get; protected set; }

    /// <summary>
    /// Whether this component is striked through
    /// </summary>
    [JsonProperty("strikethrough")]
    public bool? IsStrikethrough { get; protected set; }

    /// <summary>
    /// Insertion text to be inserted when this component is shift clicked
    /// </summary>
    [JsonProperty("insertion")]
    public string? InsertionText { get; protected set; }

    /// <summary>
    /// An event handler for component click event
    /// </summary>
    [JsonProperty("clickEvent")]
    public ComponentClickEvent? ClickEvent { get; protected set; }

    /// <summary>
    /// An event handler for component hover event
    /// </summary>
    [JsonProperty("hoverEvent")]
    public ComponentHoverEvent? HoverEvent { get; protected set; }
}