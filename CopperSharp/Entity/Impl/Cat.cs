using CopperSharp.Item.Meta;

namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents a cat entity
/// </summary>
public sealed class Cat : TameableEntity
{
    internal Cat() : base(EntityType.Cat)
    {
    }

    /// <summary>
    ///     Sets type of cat's skin
    /// </summary>
    /// <param name="type">Type of skin</param>
    /// <returns>This cat</returns>
    public Cat CatType(CatType type)
    {
        Ints["CatType"] = (int) type;
        return this;
    }

    /// <summary>
    ///     Sets color of cat's collar
    /// </summary>
    /// <param name="color">Color of collar</param>
    /// <returns>This cat</returns>
    public Cat CollarColor(NumberedColor color)
    {
        Ints["CollarColor"] = (byte) color;
        return this;
    }
}

/// <summary>
///     Represents type of cat's skin
/// </summary>
public enum CatType
{
    /// <summary>
    ///     Brown
    /// </summary>
    Tabby,

    /// <summary>
    ///     Black and white
    /// </summary>
    Tuxedo,

    /// <summary>
    ///     Plain orange
    /// </summary>
    Red,

    /// <summary>
    ///     Creme white and black
    /// </summary>
    Siamese,

    /// <summary>
    ///     Light gray
    /// </summary>
    BritishShorthair,

    /// <summary>
    ///     Creme yellow and brown
    /// </summary>
    Calico,

    /// <summary>
    ///     Light orange
    /// </summary>
    Persian,

    /// <summary>
    ///     Creme white
    /// </summary>
    Ragdoll,

    /// <summary>
    ///     White
    /// </summary>
    White,

    /// <summary>
    ///     Jellie (white and gray)
    /// </summary>
    Jellie,

    /// <summary>
    ///     Black
    /// </summary>
    Black
}