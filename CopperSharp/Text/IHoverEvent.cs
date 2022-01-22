using System.Runtime.CompilerServices;
using CopperSharp.Item.Meta;
using CopperSharp.Registry;
using CopperSharp.Text.Impl;

// ReSharper disable RedundantCast

namespace CopperSharp.Text;

/// <summary>
/// Represents a hover event
/// </summary>
public interface IHoverEvent
{
    /// <summary>
    /// Creates a new text hover event.
    /// </summary>
    /// <param name="txt">Component to be displayed on hover.</param>
    /// <returns>New hover event instance</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IHoverEvent Text(IComponent txt)
        => new DisplayTextHover(txt) as IHoverEvent;

    /// <summary>
    /// Creates a new item display hover event
    /// </summary>
    /// <param name="id">Identifier of item.</param>
    /// <param name="count">Amount of items. Optional.</param>
    /// <param name="tag">Extra NBT tag of item. Optional.</param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IHoverEvent Item(Identifier id, int? count = null, ItemMeta? tag = null)
        => new DisplayItemHover(id, count, tag) as IHoverEvent;

    /// <summary>
    /// Creates a new entity display hover event
    /// </summary>
    /// <param name="id">Identifier of entity.</param>
    /// <param name="uuid">Custom (or random) UUID of entity.</param>
    /// <param name="name">Name of entity. Optional.</param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IHoverEvent Entity(Identifier id, Guid uuid, IComponent? name = null)
        => new DisplayEntityHover(id, uuid, name) as IHoverEvent;

    /// <summary>
    /// Converts this hover event to parseable container
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ComponentHoverEvent Contain();
}

/// <summary>
/// Displays provided component on hover
/// </summary>
public readonly struct DisplayTextHover : IHoverEvent
{
    private readonly IComponent _component;

    /// <summary>
    /// Displays provided component on hover
    /// </summary>
    /// <param name="component">Component to be displayed on hover</param>
    public DisplayTextHover(IComponent component)
    {
        _component = component;
    }

    /// <inheritdoc />
    public ComponentHoverEvent Contain()
        => new("show_text", _component.Contain());
}

/// <summary>
/// Displays provided item data on hover
/// </summary>
public readonly struct DisplayItemHover : IHoverEvent
{
    private readonly Identifier _id;
    private readonly int? _count;
    private readonly ItemMeta? _tag;

    /// <summary>
    /// Displays provided item data on hover
    /// </summary>
    /// <param name="id">Type of item. E.g. minecraft:diamond</param>
    /// <param name="count">Count of items. Optional.</param>
    /// <param name="nbt">NBT Item tag. Optional.</param>
    public DisplayItemHover(Identifier id, int? count = null, ItemMeta? nbt = null)
    {
        _id = id;
        _count = count;
        _tag = nbt;
    }

    /// <inheritdoc />
    public ComponentHoverEvent Contain()
        => new("show_item", new ShowItemHoverEvent(_id.ToString(), _count, _tag?.ToString()));
}

/// <summary>
/// Displays provided entity data on hover
/// </summary>
public readonly struct DisplayEntityHover : IHoverEvent
{
    private readonly Identifier _id;
    private readonly Guid _uuid;
    private readonly IComponent? _name;

    /// <summary>
    /// Displays provided entity data on hover
    /// </summary>
    /// <param name="id">Type of entity. E.g. minecraft:pig</param>
    /// <param name="uuid">UUID of entity. Can be random.</param>
    /// <param name="name">Name component of the entity. Optional.</param>
    public DisplayEntityHover(Identifier id, Guid uuid, IComponent? name)
    {
        _id = id;
        _uuid = uuid;
        _name = name;
    }

    /// <inheritdoc />
    public ComponentHoverEvent Contain()
        => new("show_entity", new ShowEntityHoverEvent(_id.ToString(), _uuid.ToString(), _name?.Contain()));
}