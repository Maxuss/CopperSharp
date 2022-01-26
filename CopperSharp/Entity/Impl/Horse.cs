namespace CopperSharp.Entity.Impl;

/// <summary>
/// Represents a horse
/// </summary>
public sealed class Horse : HorseEntity
{
    /// <summary>
    /// Base color of the horse
    /// </summary>
    public enum Color
    {
        /// <summary>
        /// Plain White
        /// </summary>
        White = 0,

        /// <summary>
        /// Creamy
        /// </summary>
        Creamy = 1,

        /// <summary>
        /// Light Brown
        /// </summary>
        Chestnut = 2,

        /// <summary>
        /// Dark Brown
        /// </summary>
        Brown = 3,

        /// <summary>
        /// Black
        /// </summary>
        Black = 4,

        /// <summary>
        /// Gray
        /// </summary>
        Gray = 5
    }

    /// <summary>
    /// Extra markings on the horse
    /// </summary>
    public enum Markings
    {
        /// <summary>
        /// No markings
        /// </summary>
        None = 0,

        /// <summary>
        /// White socks
        /// </summary>
        White = 256,

        /// <summary>
        /// White fields
        /// </summary>
        WhiteField = 512,

        /// <summary>
        /// White dots
        /// </summary>
        WhiteDots = 768,

        /// <summary>
        /// Black dots
        /// </summary>
        BlackDots = 1024
    }

    internal Horse() : base(EntityType.Horse)
    {
    }

    /// <summary>
    /// Sets color variant of the horse
    /// </summary>
    /// <param name="color">Main color of the horse</param>
    /// <param name="markings">Extra markings on the horse</param>
    /// <returns></returns>
    public Horse Variant(
        Color color = Color.White,
        Markings markings = Markings.None)
    {
        Ints["Variant"] = (int) color + (int) markings;
        return this;
    }
}