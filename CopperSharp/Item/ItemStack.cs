using CopperSharp.Item.Impl;
using CopperSharp.Item.Meta;

namespace CopperSharp.Item;

/// <summary>
/// Represents some amount of items
/// </summary>
public struct ItemStack : IStack
{
    /// <inheritdoc />
    public sbyte Amount { get; set; } = 1;

    /// <inheritdoc />
    public Material Material { get; }

    /// <inheritdoc />
    public ItemMeta? Meta { get; set; }

    /// <summary>
    /// Constructs a new item stack from provided parameters
    /// </summary>
    /// <param name="material">Material to use</param>
    /// <param name="amount">Amount of item in this stack</param>
    public ItemStack(Material material, sbyte amount = 1)
    {
        Material = material;
        Amount = amount;
        if (material.Id.Path.Contains("banner"))
        {
            Meta = new BannerMeta(material);
            return;
        }

        Meta = material.Id.Path switch
        {
            "player_head" => new SkullMeta(material),
            _ => new DefaultItemMeta(material)
        };
    }

    /// <summary>
    /// Serializes this item into minecraft-readable format
    /// </summary>
    /// <returns>Serialized item</returns>
    public string Serialize()
    {
        return $"{Material.Id}{Meta?.ToSNbt()} {Amount}";
    }
}