using CopperSharp.Item.Meta;

namespace CopperSharp.Entity.Impl;

/// <summary>
/// Represents a tropical fish entity
/// </summary>
public sealed class TropicalFish : LivingEntity
{
    /// <summary>
    /// Represents a fishes pattern
    /// </summary>
    public enum Pattern : byte
    {
        /// <summary>
        /// Small fish
        /// </summary>
        Kob = 0,

        /// <summary>
        /// Small fish
        /// </summary>
        Sunstreak = 1,

        /// <summary>
        /// Small fish
        /// </summary>
        Snooper = 2,

        /// <summary>
        /// Small fish
        /// </summary>
        Dasher = 3,

        /// <summary>
        /// Small fish
        /// </summary>
        Brinely = 4,

        /// <summary>
        /// Small fish
        /// </summary>
        Spotty = 5,

        /// <summary>
        /// Big fish
        /// </summary>
        Flopper = 10,

        /// <summary>
        /// Big fish
        /// </summary>
        Stripey = 11,

        /// <summary>
        /// Big fish
        /// </summary>
        Gitter = 12,

        /// <summary>
        /// Big fish
        /// </summary>
        Blockfish = 13,

        /// <summary>
        /// Big fish
        /// </summary>
        Betty = 14,

        /// <summary>
        /// Big fish
        /// </summary>
        Clayfish = 15,

        /// <summary>
        /// No pattern
        /// </summary>
        None = 16,
    }

    internal TropicalFish() : base(EntityType.TropicalFish)
    {
    }

    /// <summary>
    /// Whether this fish was released from bucket
    /// </summary>
    /// <param name="from">Marker</param>
    /// <returns>This tropical fish</returns>
    public TropicalFish FromBucket(bool from = true)
    {
        Bools["FromBucket"] = from;
        return this;
    }

    /// <summary>
    /// Sets variant of this tropical fish
    /// </summary>
    /// <param name="pattern">Pattern to be used</param>
    /// <param name="bodyColor">Color of the fishes body</param>
    /// <param name="patternColor">Color of the fishes pattern</param>
    /// <returns></returns>
    public TropicalFish Variant(
        Pattern pattern,
        NumberedColor bodyColor,
        NumberedColor patternColor)
    {
        var isBig = pattern > Pattern.Spotty;
        var big = (byte) (isBig ? 1 : 0);
        var pat = (byte) (isBig ? (byte) pattern - 10 : (byte) pattern);
        var bdc = (byte) bodyColor;
        var ptc = (byte) patternColor;
        Ints["Variant"] = BitConverter.ToInt32(new byte[] {big, pat, bdc, ptc});
        return this;
    }
}