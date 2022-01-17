using Newtonsoft.Json;

namespace CopperSharp.Text.Impl;

/// <summary>
/// A container for component click event
/// </summary>
/// <param name="Action">Action to be performed when the component is clicked/hovered over</param>
/// <param name="Value">Value for the action</param>
public record ComponentClickEvent(
    [JsonProperty("action")] string Action,
    [JsonProperty("value")] string Value);