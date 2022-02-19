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

    internal override async Task WriteExternalMetaData(INbtWriter w)
    {
        if (CanPlaceOn.Any())
        {
            await w.WritePropertyNameAsync("CanPlaceOn");
            await w.WriteBeginArrayAsync();
            foreach (var v in CanPlaceOn) await w.WriteStringAsync(v.ToString());
            await w.WriteEndArrayAsync();
        }

        if (BlockStateTag != null)
        {
            await w.WritePropertyNameAsync("BlockStateTag");
            await w.WriteRawValueAsync(await BlockStateTag.Serialize());
        }

        if (BlockEntityTag == null) return;
        await w.WritePropertyNameAsync("BlockEntityTag");
        await w.WriteRawValueAsync(await BlockEntityTag.Serialize());
    }
}