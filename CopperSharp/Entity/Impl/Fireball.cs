using CopperSharp.Data.SNbt;
using CopperSharp.Item;

namespace CopperSharp.Entity.Impl;

/// <summary>
/// Represents a fireball projectile
/// </summary>
public sealed class Fireball : AbstractFireball
{
    internal Fireball() : base(EntityType.Fireball)
    {
    }

    private ItemStack? Item { get; set; }

    /// <summary>
    /// Sets an item, this fireball is rendered as
    /// </summary>
    /// <param name="item">Item to be set</param>
    /// <returns>This fireball</returns>
    public Fireball RenderAs(ItemStack item)
    {
        Item = item;
        return this;
    }

    /// <summary>
    /// Sets explosion power of this fireball
    /// </summary>
    /// <param name="power">Power to be set</param>
    /// <returns>This fireball</returns>
    public Fireball Power(byte power)
    {
        Bytes["ExplosionPower"] = power;
        return this;
    }

    /// <inheritdoc />
    protected override void SerializeExtra(StringNbtWriter sw)
    {
        base.SerializeExtra(sw);

        if (Item == null)
            return;
        sw.WritePropertyName("Item");
        sw.WriteItem(Item);
    }
}