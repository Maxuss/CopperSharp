namespace CopperSharp.Entity.Impl;

/// <summary>
/// Represents a pig entity
/// </summary>
public sealed class Pig : BreedableEntity
{
    internal Pig() : base(EntityType.Pig)
    {
    }

    /// <summary>
    /// Sets whether this pig has saddle
    /// </summary>
    /// <param name="has">Marker</param>
    /// <returns>This pig</returns>
    public Pig HasSaddle(bool has = true)
    {
        Bools["Saddle"] = has;
        return this;
    }
}