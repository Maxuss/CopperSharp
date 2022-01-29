using CopperSharp.Data.SNbt;

namespace CopperSharp.Item.Meta;

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
    internal override void WriteExternalMetaData(StringNbtWriter w)
    {
    }
}