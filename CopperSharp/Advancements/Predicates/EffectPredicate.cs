using CopperSharp.Data.Effects;
using CopperSharp.Utils;
using Newtonsoft.Json;

namespace CopperSharp.Advancements.Predicates;

/// <summary>
///     Represents an effect for use in conditions
/// </summary>
public struct EffectPredicate
{
    /// <summary>
    ///     Constructs a new conditional effect
    /// </summary>
    /// <param name="type">Type of effect</param>
    public EffectPredicate(StatusEffect type)
    {
        Type = type;
        EAmplifier = null;
        EDuration = null;
    }

    /// <summary>
    ///     Type of this effect
    /// </summary>
    public StatusEffect Type { get; }

    private Dictionary<string, object> Data { get; } = new();
    private StrictRange? EAmplifier { get; set; }
    private StrictRange? EDuration { get; set; }

    /// <summary>
    ///     Marks that the effect should be ambient
    /// </summary>
    /// <returns>This effect condition</returns>
    public EffectPredicate Ambient(bool ambient = true)
    {
        Data["ambient"] = ambient;
        return this;
    }

    /// <summary>
    ///     Marks that the effect should be visible
    /// </summary>
    /// <returns>This effect condition</returns>
    public EffectPredicate Visible(bool visible = true)
    {
        Data["visible"] = visible;
        return this;
    }

    /// <summary>
    ///     Marks that the effect should have a certain level
    /// </summary>
    /// <param name="value">Level the effect should have</param>
    /// <returns>This effect condition</returns>
    public EffectPredicate Level(StrictRange value)
    {
        EAmplifier = value;
        return this;
    }

    /// <summary>
    ///     Marks that the effect should have a certain duration
    /// </summary>
    /// <param name="value">Duration the effect should have</param>
    /// <returns>This effect condition</returns>
    public EffectPredicate Duration(StrictRange value)
    {
        EDuration = value;
        return this;
    }

    /// <summary>
    ///     Serializes this effect into provided text writer
    /// </summary>
    /// <param name="w">Writer to be used for serialization</param>
    public async Task SerializeInto(JsonTextWriter w)
    {
        await w.WritePropertyNameAsync(Type.GetData() ?? "minecraft:null");
        await w.WriteStartObjectAsync();
        foreach (var (key, value) in Data)
        {
            await w.WritePropertyNameAsync(key);
            await w.WriteValueAsync(value);
        }

        await (EAmplifier?.SerializeInto(w, "amplifier") ?? Task.CompletedTask);
        await (EDuration?.SerializeInto(w, "duration") ?? Task.CompletedTask);
        await w.WriteEndObjectAsync();
    }
}