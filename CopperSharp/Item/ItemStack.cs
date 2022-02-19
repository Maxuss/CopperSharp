using CopperSharp.Data.SNbt;
using CopperSharp.Item.Meta;

namespace CopperSharp.Item;

/// <summary>
///     Represents some amount of items
/// </summary>
public struct ItemStack : IStack
{
    /// <summary>
    ///     Represents an empty air stack
    /// </summary>
    public static ItemStack AirStack => new(Material.Air);

    /// <inheritdoc />
    public sbyte Amount { get; set; } = 1;

    /// <inheritdoc />
    public Material Material { get; }

    /// <inheritdoc />
    public ItemMeta Meta { get; set; }

    /// <summary>
    ///     Constructs a new item stack from provided parameters
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

        if (material.Id.Path.Contains("potion"))
        {
            Meta = new PotionMeta(material);
            return;
        }


        Meta = material.Id.Path switch
        {
            "firework_rocket" => new FireworkMeta(material),
            "player_head" => new SkullMeta(),
            _ => material.BlockType != null ? new BlockItemMeta(material) : new DefaultItemMeta(material)
        };
    }

    /// <summary>
    ///     Constructs a new item stack from provided parameters
    /// </summary>
    /// <param name="material">Material to use</param>
    /// <param name="meta">Meta operations</param>
    /// <param name="amount">Amount of item in this stack</param>
    public ItemStack(Material material, Func<ItemMeta, ItemMeta> meta, sbyte amount = 1)
    {
        Material = material;
        Amount = amount;
        if (material.Id.Path.Contains("banner"))
        {
            Meta = new BannerMeta(material);
            return;
        }

        if (material.Id.Path.Contains("potion"))
        {
            Meta = new PotionMeta(material);
            return;
        }

        Meta = material.Id.Path switch
        {
            "firework_rocket" => new FireworkMeta(material),
            "player_head" => new SkullMeta(),
            _ => new DefaultItemMeta(material)
        };

        Meta = meta(Meta);
    }

    /// <summary>
    ///     Serializes this item into minecraft-readable format
    /// </summary>
    /// <returns>Serialized item</returns>
    public async Task<string> Serialize()
    {
        return $"{Material.Id}{await Meta.Serialize()} {Amount}";
    }
}