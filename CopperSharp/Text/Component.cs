//https://minecraft.fandom.com/wiki/Raw_JSON_text_format#Java_Edition
// ReSharper disable RedundantCast

using CopperSharp.Data.Locations;
using CopperSharp.Entity;
using CopperSharp.Registry;
using CopperSharp.Utils;
using Newtonsoft.Json;

namespace CopperSharp.Text;

/// <summary>
///     Represents a text component that can be sent to chat or attached to item etc.
/// </summary>
public abstract class Component
{
    /// <summary>
    ///     Type of current component
    /// </summary>
    public abstract ComponentType ComponentType { get; }

    /// <summary>
    ///     Children of current component
    /// </summary>
    protected List<Component> Children { get; set; } = new();

    /// <summary>
    ///     Formatting of this component
    /// </summary>
    protected Dictionary<FormattingType, bool> Formatting { get; set; } = new();

    /// <summary>
    ///     Event handler for component hover
    /// </summary>
    protected HoverEvent? HoverEvent { get; set; }

    /// <summary>
    ///     Event handler for component click
    /// </summary>
    protected ClickEvent? ClickEvent { get; set; }

    /// <summary>
    ///     Text to be inserted when this component is shift-clicked
    /// </summary>
    protected string? InsertionText { get; set; }

    /// <summary>
    ///     Color of this component
    /// </summary>
    protected ITextColor? Color { get; set; }
    
    /// <summary>
    ///     Applies a coloring to this component
    /// </summary>
    /// <param name="color">Color to be applied</param>
    /// <returns>This component</returns>
    public Component Colored(ITextColor color)
    {
        Color = color;
        return this;
    }

    /// <summary>
    ///     Applies a formatting to this component
    /// </summary>
    /// <param name="format">Type of formatting to be applied</param>
    /// <param name="flag">Toggles formatting on if true, and off if false</param>
    /// <returns>This component</returns>
    public Component Formatted(FormattingType format, bool flag = true)
    {
        Formatting[format] = flag;
        return this;
    }

    /// <summary>
    ///     Adds provided components to this component as children
    /// </summary>
    /// <param name="components">Components to be added to this component as children</param>
    /// <returns>This component</returns>
    public Component Child(params Component[] components)
    {
        Children.AddRange(components);
        return this;
    }

    /// <summary>
    ///     Adds provided click event handler to this component
    /// </summary>
    /// <param name="click">Click event handler to be added to this component</param>
    /// <returns>This component</returns>
    public Component OnClick(ClickEvent click)
    {
        ClickEvent = click;
        return this;
    }

    /// <summary>
    ///     Adds provided hover event handler to this component
    /// </summary>
    /// <param name="hover">Hover event handler to be added to this component</param>
    /// <returns>This component</returns>
    public Component OnHover(HoverEvent hover)
    {
        HoverEvent = hover;
        return this;
    }

    /// <summary>
    ///     Adds an insertion text to be inserted into chat when the component is shift clicked
    /// </summary>
    /// <param name="insertion">Insertion to be provided</param>
    /// <returns>This component</returns>
    public Component Insertion(string insertion)
    {
        InsertionText = insertion;
        return this;
    }
    
    /// <summary>
    ///     Removes italic formatting from this component
    /// </summary>
    /// <returns>This component</returns>
    public Component NoItalic()
    {
        return Formatted(FormattingType.Italic, false);
    }

    /// <summary>
    /// Serializes this component into provided writer
    /// </summary>
    /// <param name="jw">Writer to be used</param>
    /// <param name="indent">Whether to indent the component</param>
    public async Task SerializeInto(JsonTextWriter jw, bool indent = false)
    {
        jw.Formatting = indent ? Newtonsoft.Json.Formatting.Indented : Newtonsoft.Json.Formatting.None;
        
        await jw.WriteStartObjectAsync();
        
        await SerializeExtra(jw);
        if (Children.Any())
        {
            await jw.WritePropertyNameAsync("extra");
            await jw.WriteStartArrayAsync();
            foreach (var child in Children)
                await child.SerializeInto(jw);
            
            await jw.WriteEndArrayAsync();
        }

        if (Color != null)
        {
            await jw.WritePropertyNameAsync("color");
            await jw.WriteValueAsync(Color.ToString());
        }

        if (InsertionText != null)
        {
            await jw.WritePropertyNameAsync("insertion");
            await jw.WriteValueAsync(InsertionText);
        }

        foreach (var (key, value) in Formatting)
        {
            await jw.WritePropertyNameAsync(Enum.GetName(key)?.ToLower() ?? "null");
            await jw.WriteValueAsync(value);
        }

        if (ClickEvent != null)
        {
            await jw.WritePropertyNameAsync("clickEvent");
            await jw.WriteStartObjectAsync();
            await jw.WritePropertyNameAsync("action");
            await jw.WriteValueAsync(ClickEvent?.EventType.GetData() ?? "null");
            await jw.WritePropertyNameAsync("value");
            await jw.WriteValueAsync(ClickEvent?.Value ?? "null");
            await jw.WriteEndObjectAsync();
        }

        if (HoverEvent != null)
        {
            await HoverEvent.SerializeInto(jw);
        }

        await jw.WriteEndObjectAsync();
    }
    
    /// <summary>
    ///     Serializes this component to JSON string
    /// </summary>
    /// <param name="indent">Whether to indent this component</param>
    /// <returns>String, that can be parsed by minecraft as component</returns>
    public async Task<string> Serialize(bool indent = false)
    {
        await using var sw = new StringWriter();
        using var jw = new JsonTextWriter(sw);
        
        await SerializeInto(jw);
        
        return sw.ToString();
    }

    /// <summary>
    ///     Constructs a quadratic gradient between two colors
    /// </summary>
    /// <param name="from">From color</param>
    /// <param name="to">To color</param>
    /// <param name="fast">Whether to speed up gradient interpolation over time</param>
    /// <returns>This component</returns>
    /// <exception cref="NotSupportedException">This component implementation does not support gradients.</exception>
    /// <exception cref="Exception">Provided colors are named text colors, which are not supported</exception>
    public virtual Component QuadraticGradient(ITextColor from, ITextColor to, bool fast = true)
    {
        throw new NotSupportedException("This component does not support gradients.");
    }

    /// <summary>
    ///     Constructs a linear gradient between two colors
    /// </summary>
    /// <param name="from">From color</param>
    /// <param name="to">To color</param>
    /// <returns>This component</returns>
    /// <exception cref="NotSupportedException">This component implementation does not support gradients.</exception>
    /// <exception cref="Exception">Provided colors are named text colors, which are not supported</exception>
    public virtual Component LinearGradient(ITextColor from, ITextColor to)
    {
        throw new NotSupportedException("This component does not support gradients.");
    }


    /// <summary>
    /// Serializes extra data for this component
    /// </summary>
    /// <param name="jw">Writer to be used for serializing</param>
    protected virtual Task SerializeExtra(JsonTextWriter jw)
    {
        return Task.CompletedTask;
    }

    /// <summary>
    /// Constructs a new text component
    /// </summary>
    /// <param name="text">Text to be displayed</param>
    /// <returns>New text component</returns>
    public static TextComponent Text(string text) 
        => new(text);
    
    /// <summary>
    /// Constructs a new entity component
    /// </summary>
    /// <param name="entity">Entity to be displayed</param>
    /// <returns>New entity component</returns>
    public static EntityComponent Entity(Selector entity) 
        => new(entity);

    /// <summary>
    /// Constructs a new keybind component
    /// </summary>
    /// <param name="key">Keybind to be displayed</param>
    /// <returns>New keybind component</returns>
    public static KeybindComponent Keybind(Keybind key) 
        => new(key);

    /// <summary>
    /// Constructs a new scoreboard component
    /// </summary>
    /// <param name="obj">Name of the objective</param>
    /// <param name="holder">Holder of the objective to be displayed. By default displays data for each receiver individually.</param>
    /// <returns>New scoreboard component</returns>
    public static ScoreboardComponent Score(string obj, Selector? holder = null) =>
        new(obj, holder ?? new Selector("*"));

    /// <summary>
    /// Constructs a new block-based nbt component
    /// </summary>
    /// <param name="path">NBT path</param>
    /// <param name="loc">Location of the block</param>
    /// <returns>New nbt component</returns>
    public static NbtComponent Nbt(string path, Location loc) 
        => new(path, loc);
    
    /// <summary>
    /// Constructs a new entity-based nbt component
    /// </summary>
    /// <param name="path">NBT path</param>
    /// <param name="sel">Selector for the entity</param>
    /// <returns>New nbt component</returns>
    public static NbtComponent Nbt(string path, Selector sel) 
        => new(path, sel);
    
    /// <summary>
    /// Constructs a new storage-based nbt component
    /// </summary>
    /// <param name="path">NBT path</param>
    /// <param name="id">ID of the command storage</param>
    /// <returns>New nbt component</returns>
    public static NbtComponent Nbt(string path, Identifier id) 
        => new(path, id);

    /// <summary>
    ///     Creates a new <see cref="TranslatableComponent" />
    /// </summary>
    /// <param name="key">Key to be stored as localizable string inside component</param>
    /// <returns>A new instance of translatable component</returns>
    public static TranslatableComponent Translatable(string key) => new(key);
}