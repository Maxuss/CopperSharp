namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents a strider entity
/// </summary>
public sealed class Strider : BreedableEntity
{
    internal Strider() : base(EntityType.Strider)
    {
    }

    /// <summary>
    ///     Whether this strider has a saddle equipped
    /// </summary>
    /// <param name="has">Marker</param>
    /// <returns>This strider</returns>
    public Strider HasSaddle(bool has = true)
    {
        Bools["Saddle"] = has;
        return this;
    }
}