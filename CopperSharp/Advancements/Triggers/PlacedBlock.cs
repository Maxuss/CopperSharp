using CopperSharp.Advancements.Predicates;
using CopperSharp.Blocks;
using CopperSharp.Data.SNbt;
using CopperSharp.Item;
using Newtonsoft.Json;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
///     Triggers when the player places a block.
/// </summary>
[CriterionName("placed_block")]
public sealed class PlacedBlock : TriggerCondition
{
    private NbtCompound? States { get; set; }

    /// <summary>
    ///     Sets the type of block placed
    /// </summary>
    /// <param name="id">Type of block to be set</param>
    /// <returns>This trigger</returns>
    public PlacedBlock Block(Material id)
    {
        Data["block"] = id.Id.ToString();
        return this;
    }

    /// <summary>
    ///     Sets the location of the placed block
    /// </summary>
    /// <param name="loc">Location to be set</param>
    /// <returns>This trigger</returns>
    public PlacedBlock BlockLocation(LocationPredicate loc)
    {
        Data["location"] = loc;
        return this;
    }

    /// <summary>
    ///     Sets the item that was consumed and placed
    /// </summary>
    /// <param name="item">Item to be set</param>
    /// <returns>This trigger</returns>
    public PlacedBlock PlacedItem(ItemPredicate item)
    {
        Items["item"] = item;
        return this;
    }

    /// <summary>
    ///     Sets the extra state of the block placed
    /// </summary>
    /// <param name="state">Block state to be set</param>
    /// <returns>This trigger</returns>
    public PlacedBlock State(BlockState state)
    {
        States = state.BlockData?.Data;
        return this;
    }

    /// <inheritdoc />
    protected override async Task SerializeExtra(JsonTextWriter w)
    {
        await base.SerializeExtra(w);

        if (States != null)
        {
            await w.WritePropertyNameAsync("state");
            await w.WriteStartObjectAsync();
            foreach (var entry in States)
            {
                await w.WritePropertyNameAsync(entry.Key);
                entry.Value.SerializeInto(w);
            }

            await w.WriteEndObjectAsync();
        }
    }
}