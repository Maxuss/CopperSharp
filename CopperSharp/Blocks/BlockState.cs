using CopperSharp.Blocks.Data;
using CopperSharp.Data.SNbt;
using CopperSharp.Item;
using CopperSharp.Registry;
using CopperSharp.Text;

namespace CopperSharp.Blocks;

/// <summary>
///     An abstract superclass for all block states
/// </summary>
public abstract class BlockState : IState
{
    /// <summary>
    ///     Creates a new block state
    /// </summary>
    /// <param name="id">Material ID of block</param>
    protected BlockState(Material id)
    {
        Id = id.Id;
        if (id.BlockType != null)
            BlockData = id.BlockType.GetConstructors()[0].Invoke(null) as IBlockData;
    }

    private Identifier Id { get; }

    /// <summary>
    ///     Extra NBT data for this block state
    /// </summary>
    protected NbtCompound Data { get; set; } = new();

    /// <inheritdoc />
    public virtual IBlockData? BlockData { get; set; }

    /// <inheritdoc />
    public async Task<string> Serialize()
    {
        await using var sw = new StringWriter();
        await using var w = new StringNbtWriter(sw);

        await w.WriteBeginCompoundAsync();
        await w.WriteStringAsync("Name", Id.ToString());
        if (BlockData != null) await w.WriteRawValueAsync("Properties", await BlockData.Serialize());

        await Data.SerializeInto(w, false);
        await SerializeExtra(w);
        await w.WriteEndCompoundAsync();

        return sw.ToString();
    }

    /// <summary>
    ///     Sets custom name of this block state
    /// </summary>
    /// <param name="name">Name to be set</param>
    /// <returns>This block state</returns>
    public async Task<BlockState> CustomName(Component name)
    {
        Data["CustomName"] = await name.Serialize();
        return this;
    }

    /// <summary>
    ///     Writes extra data of this block state
    /// </summary>
    /// <param name="sw">Writes extra data here</param>
    internal virtual Task SerializeExtra(INbtWriter sw)
    {
        return Task.CompletedTask;
    }
}