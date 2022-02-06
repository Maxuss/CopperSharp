namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents a rabbit entity
/// </summary>
public sealed class Rabbit : BreedableEntity
{
    /// <summary>
    ///     Represents color type of rabbit
    /// </summary>
    public enum Color
    {
        /// <summary>
        ///     Brown
        /// </summary>
        Brown = 0,

        /// <summary>
        ///     White
        /// </summary>
        White = 1,

        /// <summary>
        ///     Black
        /// </summary>
        Black = 2,

        /// <summary>
        ///     Black and white
        /// </summary>
        BlackAndWhite = 3,

        /// <summary>
        ///     Gold
        /// </summary>
        Gold = 4,

        /// <summary>
        ///     Brown and white
        /// </summary>
        SaltAndPepper = 5,

        /// <summary>
        ///     The killer bunny
        /// </summary>
        Killer = 99
    }

    internal Rabbit() : base(EntityType.Rabbit)
    {
    }

    /// <summary>
    ///     Sets color type of this rabbit
    /// </summary>
    /// <param name="type">Color type of this rabbit</param>
    /// <returns>This rabbit</returns>
    public Rabbit Variant(Color type)
    {
        Ints["RabbitType"] = (int) type;
        return this;
    }
}