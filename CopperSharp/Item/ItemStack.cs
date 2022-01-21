namespace CopperSharp.Item;

/// <summary>
/// Represents some amount of items
/// </summary>
public struct ItemStack : IStack
{
    /// <inheritdoc />
    public int Amount { get; set; } = 1;

    /// <inheritdoc />
    public Material Material { get; }

    /// <inheritdoc />
    public ItemMeta? Meta { get; set; } = null;

    /// <summary>
    /// Constructs a new item stack from provided parameters
    /// </summary>
    /// <param name="material">Material to use</param>
    /// <param name="amount">Amount of item in this stack</param>
    /// <param name="meta">Meta information on item</param>
    public ItemStack(Material material, int amount = 1, ItemMeta? meta = null)
    {
        Material = material;
        Amount = amount;
        Meta = meta;
    }
}