using CopperSharp.Data.Effects;
using CopperSharp.Data.SNbt;
using CopperSharp.Text;

namespace CopperSharp.Entity.Impl;

/// <summary>
/// Represents an arrow projectile
/// </summary>
public sealed class Arrow : AbstractArrow, IPotionContainer
{
    internal Arrow() : base(EntityType.Arrow)
    {
    }

    private List<PotionEffect> Effects { get; set; } = new();

    /// <inheritdoc />
    public IPotionContainer AddEffect(PotionEffect effect)
    {
        Effects.Add(effect);
        return this;
    }

    /// <inheritdoc />
    public IPotionContainer PotionColor(ITextColor color)
    {
        Ints["CustomPotionColor"] = color.R << 16 + color.G << 8 + color.B;
        return this;
    }

    /// <summary>
    /// Equal to <see cref="PotionColor"/>, except works on fired arrows
    /// </summary>
    /// <param name="color">Color to be used</param>
    /// <returns>This arrow</returns>
    public Arrow Colored(ITextColor color)
    {
        Ints["Color"] = color.R << 16 + color.G << 8 + color.B;
        return this;
    }

    /// <inheritdoc />
    protected override void SerializeExtra(StringNbtWriter sw)
    {
        base.SerializeExtra(sw);

        if (Effects.Any())
        {
            sw.WritePropertyName("CustomPotionEffects");
            sw.WriteBeginArray();
            foreach (var eff in Effects)
            {
                sw.WriteBeginCompound();
                sw.WriteByte("Id", eff.Id);
                sw.WriteByte("Amplifier", eff.Level);
                sw.WriteInteger("Duration", eff.Duration);
                sw.WriteBool("Ambient", eff.Ambient);
                sw.WriteBool("ShowParticles", eff.ShowParticles);
                sw.WriteBool("ShowIcon", eff.ShowIcon);
                sw.WriteEndCompound();
            }

            sw.WriteEndArray();
        }
    }
}