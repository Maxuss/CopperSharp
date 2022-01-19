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
[JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
public readonly struct ComponentHoverEvent
{
    /// <summary>
    /// Represents a hover event for component
    /// </summary>
    /// <param name="action">Type of action</param>
    /// <param name="contents">Contents of this component hover event</param>
    public ComponentHoverEvent(string action, IHoverEventContainer contents)
    {
        Action = action;
        Contents = contents;
    }

    /// <summary>Type of action</summary>
    [JsonProperty("action")]
    public string Action { get; init; }

    /// <summary>Contents of this component hover event</summary>
    [JsonProperty("contents")]
    public IHoverEventContainer Contents { get; init; }
}

/// <summary>
/// A container for <see cref="ComponentHoverEvent" />
/// </summary>
[JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
public readonly struct ShowItemHoverEvent : IHoverEventContainer
{
    /// <summary>
    /// A container for <see cref="ComponentHoverEvent" />
    /// </summary>
    /// <param name="id">ID of item. E.g. minecraft:diamond</param>
    /// <param name="count">Count of item. Optional.</param>
    /// <param name="tag">NBT Tag of item. Optional.</param>
    public ShowItemHoverEvent(string id, int? count = null, string? tag = null)
    {
        Id = id;
        Count = count;
        Tag = tag;
    }

    /// <summary>ID of item. E.g. minecraft:diamond</summary>
    [JsonProperty("id")]
    public string Id { get; init; }

    /// <summary>Count of item. Optional.</summary>
    [JsonProperty("count")]
    public int? Count { get; init; }

    /// <summary>NBT Tag of item. Optional.</summary>
    [JsonProperty("tag")]
    public string? Tag { get; init; }
}

/// <summary>
/// A container for <see cref="ComponentHoverEvent" />
/// </summary>
[JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
public readonly struct ShowEntityHoverEvent : IHoverEventContainer
{
    /// <summary>
    /// A container for <see cref="ComponentHoverEvent" />
    /// </summary>
    /// <param name="name">Name of the entity. Optional.</param>
    /// <param name="entityType">Type of the entity. E.g. minecraft:pig</param>
    /// <param name="entityId">UUID of entity</param>
    public ShowEntityHoverEvent(string entityType, string entityId, AbstractComponentContainer? name = null)
    {
        this.EntityType = entityType;
        this.EntityId = entityId;
        this.Name = name;
    }

    /// <summary>Type of the entity. E.g. minecraft:pig</summary>
    [JsonProperty("type")]
    public string EntityType { get; init; }

    /// <summary>UUID of entity</summary>
    [JsonProperty("id")]
    public string EntityId { get; init; }

    /// <summary>Name of the entity. Optional.</summary>
    [JsonProperty("name")]
    public AbstractComponentContainer? Name { get; init; }
}