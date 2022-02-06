using CopperSharp.Data.SNbt;
using CopperSharp.Item.Meta;
using CopperSharp.Text;

namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents an arrow projectile
/// </summary>
public sealed class Arrow : AbstractArrow
{
    internal Arrow() : base(EntityType.Arrow)
    {
    }

    private PotionMeta? Meta { get; set; }

    /// <summary>
    ///     Adds effects from provided potion meta
    /// </summary>
    /// <param name="from">Effects to be added</param>
    /// <returns>This arrow</returns>
    public Arrow AddEffects(PotionMeta from)
    {
        Meta = from;
        return this;
    }

    /// <summary>
    ///     Sets color of this arrow
    /// </summary>
    /// <param name="color">Color to be used</param>
    /// <returns>This arrow</returns>
    public Arrow Colored(ITextColor color)
    {
        Ints["Color"] = color.R << (16 + color.G) << (8 + color.B);
        return this;
    }

    /// <inheritdoc />
    protected override void SerializeExtra(StringNbtWriter sw)
    {
        base.SerializeExtra(sw);
        Meta?.WriteExternalMetaData(sw);
    }
}