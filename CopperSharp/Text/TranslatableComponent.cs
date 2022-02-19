// ReSharper disable RedundantCast

using Newtonsoft.Json;

namespace CopperSharp.Text;

/// <summary>
///     A translatable component, that can be localized client-side
/// </summary>
public sealed class TranslatableComponent : Component
{
    /// <summary>
    ///     Creates a new translatable component from provided text
    /// </summary>
    /// <param name="key">Localization key to be put in component</param>
    public TranslatableComponent(string key)
    {
        Key = key;
        HoverEvent = null;
        ClickEvent = null;
        InsertionText = null;
        Color = null;
    }

    /// <summary>
    ///     Translation key for this component
    /// </summary>
    private string Key { get; }

    /// <summary>
    ///     Extra slots to fit into formatting
    /// </summary>
    private List<Component> ExtraSlots { get; } = new();

    /// <inheritdoc />
    public override ComponentType ComponentType => ComponentType.Translatable;

    /// <summary>
    ///     Adds an extra formatting slot, to fit into the component formatting
    /// </summary>
    /// <param name="slot">Slot to be put</param>
    /// <returns>This component</returns>
    public Component Slot(Component slot)
    {
        ExtraSlots.Add(slot);
        return this;
    }

    /// <inheritdoc />
    protected override async Task SerializeExtra(JsonTextWriter jw)
    {
        await jw.WritePropertyNameAsync("translate");
        await jw.WriteValueAsync(Key);
        if (!ExtraSlots.Any()) return;
        await jw.WritePropertyNameAsync("with");
        await jw.WriteStartArrayAsync();
        foreach (var c in ExtraSlots) await c.SerializeInto(jw);
        await jw.WriteEndArrayAsync();
    }
}