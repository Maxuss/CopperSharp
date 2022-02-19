using CopperSharp.Data.SNbt;
using CopperSharp.Item;

namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents a small fireball projectile
/// </summary>
public sealed class SmallFireball : AbstractFireball
{
    internal SmallFireball() : base(EntityType.SmallFireball)
    {
    }

    private ItemStack? Item { get; set; }

    /// <summary>
    ///     Sets item, as which this fireball is rendered
    /// </summary>
    /// <param name="item">Item to be set</param>
    /// <returns>This small fireball</returns>
    public SmallFireball RenderAs(ItemStack item)
    {
        Item = item;
        return this;
    }

    /// <inheritdoc />
    protected override async Task SerializeExtra(INbtWriter sw)
    {
        await base.SerializeExtra(sw);

        if (Item == null)
            return;

        await sw.WritePropertyNameAsync("Item");
        await sw.WriteItem(Item);
    }
}