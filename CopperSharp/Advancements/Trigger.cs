using CopperSharp.Advancements.Predicates;
using CopperSharp.Utils;
using Newtonsoft.Json;

namespace CopperSharp.Advancements;

/// <summary>
/// Represents an advancement trigger
/// </summary>
public readonly struct Trigger
{
    /// <summary>
    /// Name of this trigger
    /// </summary>
    public string Name { get; }
    /// <summary>
    /// Conditions for this trigger
    /// </summary>
    public TriggerCondition Condition { get; }

    internal Trigger(string name, TriggerCondition condition)
    {
        Name = name;
        Condition = condition;
    }
}

/// <summary>
/// Represents a condition of an advancement trigger
/// </summary>
public abstract class TriggerCondition
{
    /// <summary>
    /// Extra ranges to be stored
    /// </summary>
    protected Dictionary<string, StrictRange> Ranges { get; set; } = new();
    /// <summary>
    /// Extra data for this trigger condition
    /// </summary>
    protected Dictionary<string, object> Data { get; set; } = new();
    /// <summary>
    /// Extra item slots to be used
    /// </summary>
    protected Dictionary<string, ItemPredicate> Items { get; set; } = new();
    /// <summary>
    /// Extra entity slots to be used
    /// </summary>
    protected Dictionary<string, EntityPredicate> Entities { get; set; } = new();

    protected EntityPredicate? PlayerData { get; set; }

    /// <summary>
    /// Makes this trigger require certain player data
    /// </summary>
    /// <param name="player">Player data to be used</param>
    /// <returns>This trigger condition</returns>
    public TriggerCondition RequirePlayer(EntityPredicate player)
    {
        PlayerData = player;
        return this;
    }
    
    /// <summary>
    /// Writes extra data to the text writer
    /// </summary>
    /// <param name="w">Writer to which to write data</param>
    protected virtual async Task SerializeExtra(JsonTextWriter w)
    {
        await Task.CompletedTask;
    }
    
    /// <summary>
    /// Serializes this condition into provided json text writer
    /// </summary>
    /// <param name="w">Writer into which to write all data</param>
    public async Task SerializeInto(JsonTextWriter w)
    {
        if (!Data.Any()) return;
        
        foreach (var (key, value) in Data)
        {
            await w.WritePropertyNameAsync(key);
            await w.WriteValueAsync(value);
        }
        
        foreach (var (key, value) in Items)
        {
            await w.WritePropertyNameAsync(key);
            await value.SerializeInto(w);
        }
        
        foreach (var (key, value) in Entities)
        {
            await w.WritePropertyNameAsync(key);
            await value.SerializeInto(w);
        }
        
        foreach (var (key, value) in Ranges)
        {
            await value.SerializeInto(w, key);
        }

        if (PlayerData != null)
        {
            await w.WritePropertyNameAsync("player");
            await (PlayerData?.SerializeInto(w) ?? Task.CompletedTask);
        }
        

        await SerializeExtra(w);
    }
}