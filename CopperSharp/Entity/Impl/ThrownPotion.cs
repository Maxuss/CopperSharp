using CopperSharp.Data.SNbt;
using CopperSharp.Item;
using CopperSharp.Item.Meta;

namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents a thrown potion projectile0
/// </summary>
public sealed class ThrownPotion : AbstractThrownItem
{
    internal ThrownPotion() : base(EntityType.Potion)
    {
    }

    private PotionMeta? Meta { get; set; }

    /// <summary>
    ///     Gets data from provided potion meta
    /// </summary>
    /// <param name="meta">Meta from which to get potion data</param>
    /// <returns>This thrown potion</returns>
    private ThrownPotion GetDataFrom(PotionMeta meta)
    {
        Meta = meta;
        return this;
    }

    /// <summary>
    ///     Gets data from provided potion meta
    /// </summary>
    /// <param name="pot">Potion from which to get potion data</param>
    /// <returns>This thrown potion</returns>
    /// <exception cref="Exception">If provided item does not have <see cref="PotionMeta" /></exception>
    private ThrownPotion GetDataFrom(ItemStack pot)
    {
        var m = pot.Meta;
        if (m is not PotionMeta pm)
            throw new Exception("Provided item does not have PotionMeta!");
        Meta = pm;
        return this;
    }

    /// <inheritdoc />
    protected override void SerializeExtra(StringNbtWriter sw)
    {
        base.SerializeExtra(sw);
        Meta?.WriteExternalMetaData(sw);
    }
}