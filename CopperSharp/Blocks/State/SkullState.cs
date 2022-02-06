using CopperSharp.Data.SNbt;
using CopperSharp.Item;
using CopperSharp.Item.Meta;

namespace CopperSharp.Blocks.State;

/// <summary>
///     Represents a skull block state
/// </summary>
public sealed class SkullState : BlockState
{
    internal SkullState(Material id) : base(id)
    {
    }

    private SkullMeta? Meta { get; set; }

    /// <summary>
    ///     Sets a simple owner of this skull
    /// </summary>
    /// <param name="owner">Name of the player to be displayed</param>
    /// <returns>This skull state</returns>
    public SkullState SimpleOwner(string owner)
    {
        Data["ExtraType"] = owner;
        return this;
    }

    /// <summary>
    ///     Gets meta from the provided skull meta
    /// </summary>
    /// <param name="meta">Meta from which to get data</param>
    /// <returns>This skull state</returns>
    public SkullState GetMeta(SkullMeta meta)
    {
        Meta = meta;
        return this;
    }

    /// <inheritdoc />
    protected override void SerializeExtra(StringNbtWriter sw)
    {
        base.SerializeExtra(sw);

        Meta?.WriteExternalMetaData(sw);
    }
}