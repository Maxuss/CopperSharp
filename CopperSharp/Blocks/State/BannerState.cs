using CopperSharp.Data.SNbt;
using CopperSharp.Item;
using CopperSharp.Item.Meta;

namespace CopperSharp.Blocks.State;

/// <summary>
///     Represents a banner block state
/// </summary>
public sealed class BannerState : BlockState
{
    internal BannerState(Material id) : base(id)
    {
    }

    private BannerMeta? Meta { get; set; }

    /// <summary>
    ///     Adds banner meta to this banner block
    /// </summary>
    /// <param name="meta">Meta to be added</param>
    /// <returns>This banner</returns>
    public BannerState AddMeta(BannerMeta meta)
    {
        meta.WriteBlockEntityTag = false;
        Meta = meta;
        return this;
    }

    /// <inheritdoc />
    internal override void SerializeExtra(StringNbtWriter sw)
    {
        Meta?.WriteExternalMetaData(sw);
    }
}