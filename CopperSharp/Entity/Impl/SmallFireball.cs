using CopperSharp.Data.SNbt;
using CopperSharp.Item;

namespace CopperSharp.Entity.Impl;

/// <summary>
/// Represents a small fireball projectile
/// </summary>
public sealed class SmallFireball : AbstractFireball
{
    private ItemStack? Item { get; set; }

    /// <summary>
    /// Sets item, as which this fireball is rendered
    /// </summary>
    /// <param name="item">Item to be set</param>
    /// <returns>This small fireball</returns>
    public SmallFireball RenderAs(ItemStack item)
    {
        Item = item;
        return this;
    }
    
    internal SmallFireball() : base(EntityType.SmallFireball)
    {
    }

    protected override void SerializeExtra(StringNbtWriter sw)
    {
        base.SerializeExtra(sw);

        if (Item == null)
            return;
        
        sw.WritePropertyName("Item");
        sw.WriteItem(Item);
    }
}