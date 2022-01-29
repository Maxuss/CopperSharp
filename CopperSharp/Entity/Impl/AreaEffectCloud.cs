using CopperSharp.Data.Effects;
using CopperSharp.Data.SNbt;
using CopperSharp.Text;

namespace CopperSharp.Entity.Impl;

/// <summary>
/// Represents an Area Effect Cloud entity
/// </summary>
public sealed class AreaEffectCloud : AbstractEntity
{
    internal AreaEffectCloud() : base(EntityType.AreaEffectCloud)
    {
    }

    private List<PotionEffect> Effects { get; set; } = new();

    /// <summary>
    /// Age of this AEC
    /// </summary>
    /// <param name="ticks">Amount of time in ticks</param>
    /// <returns>This AEC</returns>
    public AreaEffectCloud Age(int ticks)
    {
        Ints["Age"] = ticks;
        return this;
    }

    /// <summary>
    /// Sets color of this AEC
    /// </summary>
    /// <param name="color">Color to be set</param>
    /// <returns>This AEC</returns>
    public AreaEffectCloud Colored(ITextColor color)
    {
        Ints["Color"] = color.ToHexInteger();
        return this;
    }

    /// <summary>
    /// Sets duration of effect of this AEC
    /// </summary>
    /// <param name="duration">Amount of time in ticks</param>
    /// <returns>This AEC</returns>
    public AreaEffectCloud EffectDuration(int duration)
    {
        Ints["DurationOnUse"] = duration;
        return this;
    }

    /// <summary>
    /// Adds provided effects to this AEC
    /// </summary>
    /// <param name="effects">Effects to be added</param>
    /// <returns>This AEC</returns>
    public AreaEffectCloud AddEffects(params PotionEffect[] effects)
    {
        Effects.AddRange(effects);
        return this;
    }

    /// <summary>
    /// Sets type of particles emitted by this AEC
    /// </summary>
    /// <param name="particle">Type of particle to set</param>
    /// <returns>This AEC</returns>
    public AreaEffectCloud Particles(string particle)
    {
        Strings["Particle"] = particle;
        return this;
    }

    /// <summary>
    /// Sets radius of this AEC
    /// </summary>
    /// <param name="radius">Radius to be set</param>
    /// <returns>This AEC</returns>
    public AreaEffectCloud Radius(float radius)
    {
        Doubles["Radius"] = radius;
        return this;
    }

    /// <inheritdoc />
    protected override void SerializeExtra(StringNbtWriter sw)
    {
        base.SerializeExtra(sw);

        if (!Effects.Any())
            return;

        sw.WritePropertyName("Effects");
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