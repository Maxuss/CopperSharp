using CopperSharp.Data.SNbt;
using CopperSharp.Text;

namespace CopperSharp.Item.Meta;

/// <summary>
/// Represents metadata of a firework item
/// </summary>
public sealed class FireworkMeta : ItemMeta
{
    /// <inheritdoc />
    public FireworkMeta(Material type) : base(type)
    {
        if (type.Id.ToString() != Material.FireworkRocket.Id.ToString())
            throw new Exception("Invalid material provided");
    }

    private List<FireworkExplosion> Explosions { get; set; } = new();
    private sbyte Flight { get; set; } = 1;

    /// <summary>
    /// Adds explosions to this firework
    /// </summary>
    /// <param name="explosions">Explosions to be added</param>
    /// <returns>This firework meta</returns>
    public FireworkMeta AddExplosions(params FireworkExplosion[] explosions)
    {
        Explosions.AddRange(explosions);
        return this;
    }

    /// <summary>
    /// Sets duration of the flight of this firework
    /// </summary>
    /// <param name="duration">Duration to be used</param>
    /// <returns>This firework meta</returns>
    public FireworkMeta FlightDuration(sbyte duration)
    {
        Flight = duration;
        return this;
    }

    /// <inheritdoc />
    internal override void WriteExternalMetaData(StringNbtWriter sw)
    {
        sw.WritePropertyName("Fireworks");
        sw.WriteBeginCompound();
        sw.WritePropertyName("Flight");
        sw.WriteSByte(Flight);
        sw.WritePropertyName("Explosions");
        sw.WriteBeginArray();
        foreach (var e in Explosions)
        {
            e.Serialize(sw);
        }

        sw.WriteEndArray();
        sw.WriteEndCompound();
    }
}

/// <summary>
/// Represents a firework explosion
/// </summary>
public sealed class FireworkExplosion
{
    private List<int> Main { get; set; } = new();
    private List<int> Fade { get; set; } = new();
    private bool Flickering { get; set; } = false;
    private bool Trailing { get; set; } = false;
    private byte ExplosionType { get; set; } = 0;

    /// <summary>
    /// Adds main colors to this firework's explosion
    /// </summary>
    /// <param name="colors">Colors to be added</param>
    /// <returns>This firework explosion</returns>
    public FireworkExplosion MainColors(params ITextColor[] colors)
    {
        Main.AddRange(colors.Select(it => it.ToHexInteger()));
        return this;
    }

    /// <summary>
    /// Adds fading colors to this firework's explosion
    /// </summary>
    /// <param name="colors">Colors to be added</param>
    /// <returns>This firework explosion</returns>
    public FireworkExplosion FadingColors(params ITextColor[] colors)
    {
        Fade.AddRange(colors.Select(it => it.ToHexInteger()));
        return this;
    }

    /// <summary>
    /// Adds twinkle effect to this explosion
    /// </summary>
    /// <param name="flicker">Whether to make this explosion flicker</param>
    /// <returns>This firework explosion</returns>
    public FireworkExplosion Flicker(bool flicker = true)
    {
        Flickering = flicker;
        return this;
    }

    /// <summary>
    /// Adds trailing effect to this explosion
    /// </summary>
    /// <param name="trail">Whether to make this explosion leave trail</param>
    /// <returns>This firework explosion</returns>
    public FireworkExplosion Trail(bool trail = true)
    {
        Trailing = trail;
        return this;
    }

    /// <summary>
    /// Sets type of this explosion
    /// </summary>
    /// <param name="type">Explosion type to be set</param>
    /// <returns>This firework explosion</returns>
    public FireworkExplosion Type(ExplosionType type)
    {
        ExplosionType = (byte) type;
        return this;
    }

    internal void Serialize(StringNbtWriter sw)
    {
        sw.WriteBeginCompound();
        sw.WritePropertyName("Colors");
        sw.WriteBeginArray();
        sw.WriteArrayIdentifier("I");
        foreach (var color in Main)
        {
            sw.WriteInteger(color);
        }

        sw.WriteEndArray();
        sw.WritePropertyName("FadeColors");
        sw.WriteBeginArray();
        sw.WriteArrayIdentifier("I");
        foreach (var color in Fade)
        {
            sw.WriteInteger(color);
        }

        sw.WriteEndArray();
        sw.WriteBool("Flicker", Flickering);
        sw.WriteBool("Trail", Trailing);
        sw.WriteByte("Type", ExplosionType);
        sw.WriteEndCompound();
    }
}

/// <summary>
/// Represents a firework explosion type
/// </summary>
public enum ExplosionType : byte
{
    /// <summary>
    /// Small ball explosion
    /// </summary>
    SmallBall = 0,

    /// <summary>
    /// Large ball explosion
    /// </summary>
    LargeBall = 1,

    /// <summary>
    /// Star-shaped explosion
    /// </summary>
    Star = 2,

    /// <summary>
    /// Creeper-shaped explosion
    /// </summary>
    Creeper = 3,

    /// <summary>
    /// Bursting explosion
    /// </summary>
    Burst = 4
}