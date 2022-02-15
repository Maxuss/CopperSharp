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
    public string Serialize()
    {
        using var sw = new StringWriter();
        using var w = new StringNbtWriter(sw);

        w.WriteBeginCompound();
        w.WriteString("Name", Id.ToString());
        w.WriteRawValue("Properties", BlockData?.Serialize() ?? "{}");
        Data.SerializeInto(w, false);
        SerializeExtra(w);
        w.WriteEndCompound();

        return sw.ToString();
    }

    /// <summary>
    ///     Sets custom name of this block state
    /// </summary>
    /// <param name="name">Name to be set</param>
    /// <returns>This block state</returns>
    public BlockState CustomName(IComponent name)
    {
        Data["CustomName"] = name.Serialize();
        return this;
    }

    /// <summary>
    ///     Writes extra data of this block state
    /// </summary>
    /// <param name="sw">Writes extra data here</param>
    internal virtual void SerializeExtra(StringNbtWriter sw)
    {
    }
}