using CopperSharp.Data.SNbt;
using CopperSharp.Item.Meta;

namespace CopperSharp.Item.Impl;

/// <summary>
/// Default item meta implementation
/// </summary>
public sealed class DefaultItemMeta : ItemMeta
{
    /// <summary>
    /// Constructs a new default item meta
    /// </summary>
    /// <param name="type">Material of this item's meta</param>
    public DefaultItemMeta(Material type) : base(type)
    {
    }

    /// <inheritdoc />
    protected override void WriteExternalMetaData(StringNbtWriter w)
    {
    }
}