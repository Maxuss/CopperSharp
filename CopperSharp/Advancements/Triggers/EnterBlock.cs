using CopperSharp.Blocks;
using CopperSharp.Data.SNbt;
using CopperSharp.Item;
using Newtonsoft.Json;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
///     Triggers when the player stands in a block.
///     Checks every tick and will try to trigger
///     for each successful match (up to 8 times,
///     the maximum amount of blocks a player can stand in),
///     which only works if the advancement is revoked
///     from within the advancement using a function reward
/// </summary>
[CriterionName("enter_block")]
public sealed class EnterBlock : TriggerCondition
{
    private NbtCompound? States { get; set; }

    /// <summary>
    ///     Sets the type of block
    /// </summary>
    /// <param name="block">Block to be set</param>
    /// <returns>This trigger</returns>
    public EnterBlock Block(Material block)
    {
        Data["block"] = block.Id.ToString();
        return this;
    }

    /// <summary>
    ///     Sets the extra block state of this block
    /// </summary>
    /// <param name="state">State to be set</param>
    /// <returns>This block data</returns>
    public EnterBlock State(BlockState state)
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