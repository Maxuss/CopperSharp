namespace CopperSharp.Entity.Impl;

/// <summary>
/// Represents a salmon entity
/// </summary>
public class Salmon : LivingEntity
{
    internal Salmon() : base(EntityType.Salmon)
    {
    }

    /// <summary>
    /// Whether this salmon was released from bucket
    /// </summary>
    /// <param name="from">Marker</param>
    /// <returns>This salmon</returns>
    public Salmon FromBucket(bool from)
    {
        Bools["FromBucket"] = from;
        return this;
    }
}