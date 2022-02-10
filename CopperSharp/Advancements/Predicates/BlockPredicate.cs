using CopperSharp.Blocks;
using CopperSharp.Data.SNbt;
using CopperSharp.Item;
using Newtonsoft.Json;

namespace CopperSharp.Advancements.Predicates;

/// <summary>
/// Represents a block to be used in condition
/// </summary>
public struct BlockPredicate
{
    private List<Material> Types { get; } = new();
    private string? Nbt { get; set; }

    /// <summary>
    /// Sets types for this block condition
    /// </summary>
    /// <param name="types">Types to be set</param>
    /// <returns>This block condition</returns>
    public BlockPredicate OfTypes(params Material[] types)
    {
        Types.AddRange(types);
        return this;
    }

    /// <summary>
    /// Sets extra nbt data for this block condition
    /// </summary>
    /// <param name="data">Data to be set</param>
    /// <returns>This block condition</returns>
    public BlockPredicate WithNbt(NbtCompound data)
    {
        Nbt = data.Serialize();
        return this;
    }

    /// <summary>
    /// Sets block state for this block condition. Removes previous NBT data
    /// set with <see cref="WithNbt"/>, if had any.
    /// </summary>
    /// <param name="state">State to be set</param>
    /// <returns>This block condition</returns>
    public BlockPredicate WithState(BlockState state)
    {
        Nbt = state.Serialize();
        return this;
    }

    /// <summary>
    /// Serializes this entity condition into writer
    /// </summary>
    /// <param name="w">Writer to be used</param>
    public async Task SerializeInto(JsonTextWriter w)
    {
        await w.WriteStartObjectAsync();

        if (Types.Any())
        {
            await w.WritePropertyNameAsync("blocks");
            await w.WriteStartArrayAsync();
            foreach (var type in Types)
            {
                await w.WriteValueAsync(type.Id.ToString());
            }
            await w.WriteEndArrayAsync();
        }

        if (Nbt != null)
        {
            await w.WritePropertyNameAsync("nbt");
            await w.WriteValueAsync(Nbt);
        }
        
        await w.WriteEndObjectAsync();
    }
}