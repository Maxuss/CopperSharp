using Newtonsoft.Json;

namespace CopperSharp.Text.Impl;

/// <summary>
///     A container for component click event
/// </summary>
public readonly struct ComponentClickEvent
{
    /// <summary>
    ///     A container for component click event
    /// </summary>
    /// <param name="action">Action to be performed when the component is clicked/hovered over</param>
    /// <param name="value">Value for the action</param>
    public ComponentClickEvent(string action, string value)
    {
        Action = action;
        Value = value;
    }

    /// <summary>Action to be performed when the component is clicked/hovered over</summary>
    [JsonProperty("action")]
    public string Action { get; init; }

    /// <summary>Value for the action</summary>
    [JsonProperty("value")]
    public string Value { get; init; }
}