using CopperSharp.Entity;
using CopperSharp.Item;
using Newtonsoft.Json;

namespace CopperSharp.Text;

/// <summary>
/// An abstract super class for hover events
/// </summary>
public abstract class HoverEvent
{
    /// <summary>
    /// Action of this hover event
    /// </summary>
    protected abstract string Action { get; }

    /// <summary>
    /// Serializes event's value to provided writer
    /// </summary>
    /// <param name="jw">Writer to be used</param>
    protected abstract Task SerializeValue(JsonTextWriter jw);
    
    /// <summary>
    /// Serializes this hover event into provided writer
    /// </summary>
    /// <param name="jw">Writer to be used</param>
    public async Task SerializeInto(JsonTextWriter jw)
    {
        await jw.WriteStartObjectAsync();

        await jw.WritePropertyNameAsync("action");
        await jw.WriteValueAsync(Action);

        await jw.WritePropertyNameAsync("contents");
        await SerializeValue(jw);
        
        await jw.WriteEndObjectAsync();
    }

    /// <summary>
    /// Creates a new text hover event
    /// </summary>
    /// <param name="text">Text to be displayed</param>
    /// <returns>New component hover event</returns>
    public static HoverEvent Text(Component text)
        => new ComponentHoverEvent(text);
    
    /// <summary>
    /// Creates a new item hover event
    /// </summary>
    /// <param name="item">Item to be displayed</param>
    /// <returns>New item hover event</returns>
    public static HoverEvent Item(ItemStack item)
        => new ItemHoverEvent(item);
    
    /// <summary>
    /// Creates a new entity hover event
    /// </summary>
    /// <param name="name">Optional. Name of entity to be displayed.</param>
    /// <param name="type">Type of entity to be displayed.</param>
    /// <param name="id">Optional. UUID of the entity</param>
    /// <returns>New entity hover event</returns>
    public static HoverEvent Entity(EntityType type, Guid? id = null, Component? name = null)
        => new EntityHoverEvent(type, id, name);
}

/// <summary>
/// Displays text on hover
/// </summary>
public sealed class ComponentHoverEvent : HoverEvent
{
    /// <inheritdoc />
    protected override string Action => "show_text";
    
    private Component TextD { get; }
    
    /// <summary>
    /// Constructs a new component hover event
    /// </summary>
    /// <param name="comp">Component to be displayed on hover</param>
    public ComponentHoverEvent(Component comp)
    {
        TextD = comp;
    }

    /// <inheritdoc />
    protected override async Task SerializeValue(JsonTextWriter jw)
    {
        await TextD.SerializeInto(jw);
    }
}

/// <summary>
/// Displays an item on hover
/// </summary>
public sealed class ItemHoverEvent : HoverEvent
{
    private ItemStack ItemD { get; }
    
    /// <summary>
    /// Constructs a new item hover event
    /// </summary>
    /// <param name="item">Item to be displayed on hover</param>
    public ItemHoverEvent(ItemStack item)
    {
        ItemD = item;
    }
    
    /// <inheritdoc />
    protected override string Action => "show_item";

    /// <inheritdoc />
    protected override async Task SerializeValue(JsonTextWriter jw)
    {
        await jw.WriteStartObjectAsync();

        await jw.WritePropertyNameAsync("id");
        await jw.WriteValueAsync(ItemD.Material.Id.ToString());

        await jw.WritePropertyNameAsync("count");
        await jw.WriteValueAsync(ItemD.Amount);

        await jw.WritePropertyNameAsync("tag");
        await jw.WriteValueAsync(ItemD.Meta.Serialize());
        
        await jw.WriteEndObjectAsync();
    }
}

/// <summary>
/// Displays entity data on hover
/// </summary>
public sealed class EntityHoverEvent : HoverEvent
{
    private EntityType Type { get; }
    private Guid? Id { get; }
    private Component? Name { get; }

    /// <inheritdoc />
    protected override string Action => "show_entity";

    /// <summary>
    /// Constructs a new entity hover event
    /// </summary>
    /// <param name="name">Optional. Name of entity to be displayed.</param>
    /// <param name="type">Type of entity to be displayed.</param>
    /// <param name="id">Optional. UUID of the entity</param>
    public EntityHoverEvent(EntityType type, Guid? id = null, Component? name = null)
    {
        Type = type;
        Id = id;
        Name = name;
    }

    /// <inheritdoc />
    protected override async Task SerializeValue(JsonTextWriter jw)
    {
        await jw.WriteStartObjectAsync();

        await jw.WritePropertyNameAsync("type");
        await jw.WriteValueAsync(Type.Id);

        if (Name != null)
        {
            await jw.WritePropertyNameAsync("name");
            await Name.SerializeInto(jw);
        }

        if (Id != null)
        {
            await jw.WritePropertyNameAsync("id");
            await jw.WriteValueAsync(Id);
        }

        await jw.WriteEndObjectAsync();
    }
}