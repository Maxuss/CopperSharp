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
        Color = parent.Color?.ToString();
        InsertionText = parent.InsertionText;
        ClickEvent = parent.ClickEvent?.Contain();
        HoverEvent = parent.HoverEvent?.Contain();
        Formattings = parent.Formatting;
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
    /// Formatting of this component container
    /// </summary>
    public Dictionary<FormattingType, bool> Formattings { get; protected set; }

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

    /// <summary>
    /// Writes extra data to the json
    /// </summary>
    /// <param name="w">Writer to which data should be written</param>
    protected abstract void WriteExtraData(JsonTextWriter w);

    /// <summary>
    /// Serializes this component to JSON string
    /// </summary>
    /// <returns>String, that can be parsed by minecraft as component</returns>
    public string Serialize()
    {
        using var sw = new StringWriter();
        using var w = new JsonTextWriter(sw);
        w.WriteStartObject();
        WriteExtraData(w);
        if (Children != null)
        {
            w.WritePropertyName("extra");
            w.WriteStartArray();
            foreach (var child in Children)
            {
                w.WriteRawValue(child.Serialize());
            }

            w.WriteEndArray();
        }

        if (Color != null)
        {
            w.WritePropertyName("color");
            w.WriteValue(Color);
        }

        if (InsertionText != null)
        {
            w.WritePropertyName("insertion");
            w.WriteValue(InsertionText);
        }

        foreach (var (key, value) in Formattings)
        {
            w.WritePropertyName(Enum.GetName(key)?.ToLower() ?? "null");
            w.WriteValue(value);
        }

        if (ClickEvent != null)
        {
            w.WritePropertyName("clickEvent");
            w.WriteStartObject();
            w.WritePropertyName("action");
            w.WriteValue(ClickEvent?.Action ?? "null");
            w.WritePropertyName("value");
            w.WriteValue(ClickEvent?.Value ?? "null");
            w.WriteEndObject();
        }

        if (HoverEvent != null)
        {
            w.WritePropertyName("hoverEvent");
            w.WriteStartObject();
            w.WritePropertyName("action");
            w.WriteValue(HoverEvent?.Action ?? "null");
            w.WritePropertyName("contents");
            switch (HoverEvent?.Contents)
            {
                case AbstractComponentContainer comp:
                    w.WriteRawValue(comp.Serialize());
                    break;
                case ShowItemHoverEvent item:
                    w.WriteStartObject();
                    w.WritePropertyName("id");
                    w.WriteValue(item.Id);
                    if (item.Count != null)
                    {
                        w.WritePropertyName("count");
                        w.WriteValue(item.Count ?? 0);
                    }

                    if (item.Tag != null)
                    {
                        w.WritePropertyName("tag");
                        w.WriteValue(item.Tag ?? "null");
                    }

                    w.WriteEndObject();
                    break;
                case ShowEntityHoverEvent entity:
                    w.WriteStartObject();
                    w.WritePropertyName("id");
                    w.WriteValue(entity.EntityId);
                    w.WritePropertyName("type");
                    w.WriteValue(entity.EntityType);
                    if (entity.Name != null)
                    {
                        w.WritePropertyName("name");
                        w.WriteRawValue(entity.Name.Serialize());
                    }

                    w.WriteEndObject();
                    break;
                default:
                    w.WriteValue("null");
                    break;
            }

            w.WriteEndObject();
        }

        w.WriteEndObject();

        return sw.ToString();
    }
}