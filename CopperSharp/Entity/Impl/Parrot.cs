namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents a parrot entity
/// </summary>
public sealed class Parrot : TameableEntity
{
    /// <summary>
    ///     Represents a type of parrot's color
    /// </summary>
    public enum Variant
    {
        /// <summary>
        ///     Red
        /// </summary>
        Red = 0,

        /// <summary>
        ///     Blue
        /// </summary>
        Blue = 1,

        /// <summary>
        ///     Green
        /// </summary>
        Green = 2,

        /// <summary>
        ///     Cyan
        /// </summary>
        Cyan = 3,

        /// <summary>
        ///     Gray
        /// </summary>
        Gray = 4
    }

    internal Parrot() : base(EntityType.Parrot)
    {
    }

    /// <summary>
    ///     Sets color of this parrot
    /// </summary>
    /// <param name="color">Color to be set</param>
    /// <returns>This parrot</returns>
    public Parrot Color(Variant color)
    {
        Ints["Variant"] = (int) color;
        return this;
    }
}