using Newtonsoft.Json;

namespace CopperSharp.Text.Impl;

/// <summary>
/// A simple interface to distinguish hover event handlers
/// </summary>
public interface IHoverEventContainer
{
}

/// <summary>
/// Represents a hover event for component
/// </summary>
/// <param name="Action">Type of action</param>
/// <param name="Contents">Contents of this component hover event</param>
[JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
public record ComponentHoverEvent(
    [JsonProperty("action")] string Action,
    [JsonProperty("contents")] IHoverEventContainer Contents);

/// <summary>
/// A container for <see cref="ComponentHoverEvent" />
/// </summary>
/// <param name="Id">ID of item. E.g. minecraft:diamond</param>
/// <param name="Count">Count of item. Optional.</param>
/// <param name="Tag">NBT Tag of item. Optional.</param>
[JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
public record ShowItemHoverEvent(
    [JsonProperty("id")] string Id,
    [JsonProperty("count")] int? Count = null,
    [JsonProperty("tag")] string? Tag = null) : IHoverEventContainer;

/// <summary>
/// A container for <see cref="ComponentHoverEvent" />
/// </summary>
/// <param name="Name">Name of the entity. Optional.</param>
/// <param name="EntityType">Type of the entity. E.g. minecraft:pig</param>
/// <param name="EntityId">UUID of entity</param>
[JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
public record ShowEntityHoverEvent(
    [JsonProperty("type")] string EntityType,
    [JsonProperty("id")] string EntityId,
    [JsonProperty("name")] AbstractComponentContainer? Name = null) : IHoverEventContainer;