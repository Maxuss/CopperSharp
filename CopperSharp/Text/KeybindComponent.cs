using CopperSharp.Utils;
using Newtonsoft.Json;

namespace CopperSharp.Text;

/// <summary>
/// A component, which contains a keybind
/// </summary>
public sealed class KeybindComponent : Component
{
    /// <inheritdoc />
    public override ComponentType ComponentType => ComponentType.Keybind;

    private Keybind Key;
    
    /// <summary>
    /// Constructs a new keybind component
    /// </summary>
    /// <param name="key">Key to be set</param>
    public KeybindComponent(Keybind key)
    {
        Key = key;
    }

    /// <inheritdoc />
    protected override async Task SerializeExtra(JsonTextWriter jw)
    {
        await jw.WritePropertyNameAsync("keybind");
        await jw.WriteValueAsync(Key.GetData() ?? "key.null");
    }
}