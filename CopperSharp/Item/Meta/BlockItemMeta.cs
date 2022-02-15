using CopperSharp.Blocks;
using CopperSharp.Blocks.Data;
using CopperSharp.Data.SNbt;
using CopperSharp.Registry;

namespace CopperSharp.Item.Meta;

/// <summary>
///     Represents a block-item meta
/// </summary>
public class BlockItemMeta : ItemMeta, IBlockItemMeta
{
    /// <inheritdoc />
    public BlockItemMeta(Material type) : base(type)
    {
    }

    /// <inheritdoc />
    public List<Identifier> CanPlaceOn { get; set; } = new();

    /// <inheritdoc />
    public IState? BlockStateTag { get; set; }

    /// <inheritdoc />
    public IBlockData? BlockEntityTag { get; set; }

    internal override void WriteExternalMetaData(StringNbtWriter w)
    {
        if (CanPlaceOn.Any())
        {
            w.WritePropertyName("CanPlaceOn");
            w.WriteBeginArray();
            foreach (var v in CanPlaceOn) w.WriteString(v.ToString());
            w.WriteEndArray();
        }

        if (BlockStateTag != null)
        {
            w.WritePropertyName("BlockStateTag");
            w.WriteRawValue(BlockStateTag.Serialize());
        }

        if (BlockEntityTag == null) return;
        w.WritePropertyName("BlockEntityTag");
        w.WriteRawValue(BlockEntityTag.Serialize());
    }
}