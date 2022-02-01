using System.Reflection;
using CopperSharp.Block.Data;
using CopperSharp.Data.SNbt;
using CopperSharp.Item;
using CopperSharp.Registry;

namespace CopperSharp.Block;

/// <summary>
/// An abstract superclass for all block states
/// </summary>
public sealed class BlockState
{
    /// <summary>
    /// Creates a new block state
    /// </summary>
    /// <param name="id">Material ID of block</param>
    public BlockState(Material id)
    {
        Id = id.Id;
        if (id.BlockType != null)
            BlockData = id.BlockType.GetConstructors(BindingFlags.Instance)[0].Invoke(null) as IBlockData;
    }

    /// <summary>
    /// Extra data on this block
    /// </summary>
    public IBlockData? BlockData { get; set; }

    private Identifier Id { get; set; }

    /// <summary>
    /// Serializes this block state into stringified NBT
    /// </summary>
    /// <returns>Stringified NBT of this block state</returns>
    public string Serialize()
    {
        using var sw = new StringWriter();
        using var w = new StringNbtWriter(sw);

        w.WriteBeginCompound();
        w.WriteString("Name", Id.ToString());
        w.WriteRawValue("Properties", BlockData?.Serialize() ?? "{}");
        w.WriteEndCompound();

        return sw.ToString();
    }
}