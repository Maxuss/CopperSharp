using CopperSharp.Data.Effects;
using CopperSharp.Data.SNbt;
using CopperSharp.Text;

namespace CopperSharp.Item.Meta;

/// <summary>
///     A container for potion metadata
/// </summary>
public sealed class PotionMeta : ItemMeta
{
    /// <inheritdoc />
    public PotionMeta(Material type) : base(type)
    {
    }

    private int? CustomPotionColor { get; set; }
    internal List<PotionEffect> Effects { get; set; } = new();

    /// <summary>
    ///     Adds a custom potion color to this meta
    /// </summary>
    /// <param name="color">Color to be set</param>
    /// <returns>This potion meta</returns>
    public PotionMeta Color(ITextColor color)
    {
        CustomPotionColor = color.ToHexInteger();
        return this;
    }

    /// <summary>
    ///     Adds extra potion effects to this meta
    /// </summary>
    /// <param name="effects">Effects to be added</param>
    /// <returns>This potion meta</returns>
    public PotionMeta AddEffects(params PotionEffect[] effects)
    {
        Effects.AddRange(effects);
        return this;
    }

    /// <summary>
    ///     Adds a new potion effect to this meta
    /// </summary>
    /// <param name="effect">Type of status effect</param>
    /// <param name="duration">Duration of effect in ticks</param>
    /// <param name="level">Zero-based level of this effect</param>
    /// <param name="showParticles">Whether to show particles on this effect</param>
    /// <param name="showIcon">Whether to show icon of this effect</param>
    /// <param name="ambient">Whether the effect is ambient</param>
    /// <returns>This potion meta</returns>
    public PotionMeta AddEffect(StatusEffect effect,
        int duration,
        byte level = 0,
        bool showParticles = true,
        bool showIcon = true,
        bool ambient = false)
    {
        Effects.Add(new PotionEffect(effect, duration, level, showParticles, showIcon, ambient));
        return this;
    }

    internal override async Task WriteExternalMetaData(INbtWriter sw)
    {
        if (CustomPotionColor != null)
            await sw.WriteIntegerAsync("CustomPotionColor", CustomPotionColor ?? 0);

        if (!Effects.Any())
            return;

        await sw.WritePropertyNameAsync("CustomPotionEffects");
        await sw.WriteBeginArrayAsync();
        foreach (var eff in Effects)
        {
            await sw.WriteBeginCompoundAsync();
            await sw.WriteByteAsync("Id", eff.Id);
            await sw.WriteByteAsync("Amplifier", eff.Level);
            await sw.WriteIntegerAsync("Duration", eff.Duration);
            await sw.WriteBoolAsync("Ambient", eff.Ambient);
            await sw.WriteBoolAsync("ShowParticles", eff.ShowParticles);
            await sw.WriteBoolAsync("ShowIcon", eff.ShowIcon);
            await sw.WriteEndCompoundAsync();
        }

        await sw.WriteEndArrayAsync();
    }
}