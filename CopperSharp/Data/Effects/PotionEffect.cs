namespace CopperSharp.Data.Effects;

/// <summary>
///     Represents an applicable potion effect
/// </summary>
public readonly struct PotionEffect
{
    /// <summary>
    ///     Whether the effect is ambient
    /// </summary>
    public bool Ambient { get; }

    /// <summary>
    ///     Zero-based level of this effect
    /// </summary>
    public byte Level { get; }

    /// <summary>
    ///     Duration of this effect in ticks
    /// </summary>
    public int Duration { get; }

    /// <summary>
    ///     Byte id of this effect
    /// </summary>
    public byte Id { get; }

    /// <summary>
    ///     Whether to show icon
    /// </summary>
    public bool ShowIcon { get; }

    /// <summary>
    ///     Whether to show particles
    /// </summary>
    public bool ShowParticles { get; }

    /// <summary>
    ///     Constructs a new potion effect
    /// </summary>
    /// <param name="effect">Type of status effect</param>
    /// <param name="duration">Duration of effect in ticks</param>
    /// <param name="level">Zero-based level of this effect</param>
    /// <param name="showParticles">Whether to show particles on this effect</param>
    /// <param name="showIcon">Whether to show icon of this effect</param>
    /// <param name="ambient">Whether the effect is ambient</param>
    public PotionEffect(
        StatusEffect effect,
        int duration,
        byte level = 0,
        bool showParticles = true,
        bool showIcon = true,
        bool ambient = false)
    {
        Ambient = ambient;
        ShowIcon = showIcon;
        ShowParticles = showParticles;
        Duration = duration;
        Id = (byte) effect;
        Level = level;
    }
}