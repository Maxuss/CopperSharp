using CopperSharp.Registry;
using CopperSharp.Utils;
using Newtonsoft.Json;

namespace CopperSharp.Advancements.Predicates;

/// <summary>
/// Represents an enchantment for use in conditions
/// </summary>
public struct EnchantmentPredicate
{
    /// <summary>
    /// Generates a new enchantment condition
    /// </summary>
    /// <param name="enchant">ID of the enchantment</param>
    public EnchantmentPredicate(Identifier enchant)
    {
        Name = enchant.Path;
        LevelRange = null;
    }
    
    private StrictRange? LevelRange { get; set; }

    /// <summary>
    /// Sets the range of levels for this enchantment
    /// </summary>
    /// <param name="range">Range to be set</param>
    /// <returns>This enchantment condition</returns>
    public EnchantmentPredicate Level(StrictRange range)
    {
        LevelRange = range;
        return this;
    }

    private string Name { get; }

    /// <summary>
    /// Serializes this enchantment
    /// </summary>
    /// <param name="w">Writer to use</param>
    public async Task SerializeInto(JsonTextWriter w)
    {
        await w.WriteStartObjectAsync();
        await w.WritePropertyNameAsync("enchantment");
        await w.WriteValueAsync(Name);
        await (LevelRange?.SerializeInto(w, "levels") ?? Task.CompletedTask);
        await w.WriteEndObjectAsync();
    }
}