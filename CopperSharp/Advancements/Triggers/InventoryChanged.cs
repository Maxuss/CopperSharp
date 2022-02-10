using CopperSharp.Advancements.Predicates;
using CopperSharp.Utils;
using Newtonsoft.Json;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
/// Triggers after any changes happen to the player's inventory
/// </summary>
public sealed class InventoryChanged : TriggerCondition
{
    private List<ItemPredicate> Inv { get; set; } = new();
    private Dictionary<string, StrictRange> Slots { get; set; } = new();
    
    /// <summary>
    /// Sets the items in player's inventory
    /// </summary>
    /// <param name="items">Items to be set</param>
    /// <returns>This trigger</returns>
    public InventoryChanged InventoryItems(params ItemPredicate[] items)
    {
        Inv.AddRange(items);
        return this;
    }

    /// <summary>
    /// The amount of slots empty in the inventory.
    /// </summary>
    /// <param name="slots">Amount to be set</param>
    /// <returns>This trigger</returns>
    public InventoryChanged EmptySlots(StrictRange slots)
    {
        Slots["empty"] = slots;
        return this;
    }
    
    /// <summary>
    /// The amount of slots completely filled in the inventory.
    /// </summary>
    /// <param name="slots">Amount to be set</param>
    /// <returns>This trigger</returns>
    public InventoryChanged FullSlots(StrictRange slots)
    {
        Slots["full"] = slots;
        return this;
    }
    
    /// <summary>
    /// The amount of slots occupied in the inventory.
    /// </summary>
    /// <param name="slots">Amount to be set</param>
    /// <returns>This trigger</returns>
    public InventoryChanged OccupiedSlots(StrictRange slots)
    {
        Slots["occupied"] = slots;
        return this;
    }

    /// <inheritdoc />
    protected override async Task SerializeExtra(JsonTextWriter w)
    {
        await base.SerializeExtra(w);

        if (Inv.Any())
        {
            await w.WritePropertyNameAsync("items");
            await w.WriteStartArrayAsync();
            foreach (var item in Inv)
            {
                await item.SerializeInto(w);
            }
            await w.WriteEndArrayAsync();
        }

        if (Slots.Any())
        {
            await w.WritePropertyNameAsync("slots");
            await w.WriteStartObjectAsync();
            foreach (var (k, v) in Slots)
            {
                await v.SerializeInto(w, k);
            }
            await w.WriteEndObjectAsync();
        }
    }
}