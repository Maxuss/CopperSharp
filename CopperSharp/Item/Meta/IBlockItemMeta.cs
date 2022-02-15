using CopperSharp.Blocks;
using CopperSharp.Blocks.Data;
using CopperSharp.Registry;

namespace CopperSharp.Item.Meta;

/// <summary>
///     Represents an item that can be placed as a block
/// </summary>
public interface IBlockItemMeta
{
    /// <summary>
    ///     Blocks this item can be placed on
    /// </summary>
    public List<Identifier> CanPlaceOn { get; set; }

    /// <summary>
    ///     Extra block state tag for this item
    /// </summary>
    public IState? BlockStateTag { get; set; }

    /// <summary>
    ///     Extra block entity tag for this item
    /// </summary>
    public IBlockData? BlockEntityTag { get; set; }
}