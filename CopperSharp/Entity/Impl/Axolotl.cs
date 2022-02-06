namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents an axolotl entity
/// </summary>
public sealed class Axolotl : BreedableEntity
{
    internal Axolotl() : base(EntityType.Axolotl)
    {
    }

    /// <summary>
    ///     Marks that the axolotl was released from bucket
    /// </summary>
    /// <param name="from">Whether the axolotl was released from bucket</param>
    /// <returns>This axolotl</returns>
    public Axolotl FromBucket(bool from)
    {
        Bools["FromBucket"] = from;
        return this;
    }

    /// <summary>
    ///     Sets a unique variant (color) of this axolotl
    /// </summary>
    /// <param name="color">Variant of color</param>
    /// <returns>This axolotl</returns>
    public Axolotl Variant(AxolotlColor color)
    {
        Ints["Variant"] = (int) color;
        return this;
    }
}

/// <summary>
///     Represents a color of axolotl
/// </summary>
public enum AxolotlColor
{
    /// <summary>
    ///     Pink
    /// </summary>
    Lucy,

    /// <summary>
    ///     Brown
    /// </summary>
    Wild,

    /// <summary>
    ///     Gold
    /// </summary>
    Gold,

    /// <summary>
    ///     Cyan
    /// </summary>
    Cyan,

    /// <summary>
    ///     Blue
    /// </summary>
    Blue
}