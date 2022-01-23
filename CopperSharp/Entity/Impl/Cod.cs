namespace CopperSharp.Entity.Impl;

/// <summary>
/// Represents a cod mob
/// </summary>
public sealed class Cod : LivingEntity
{
    internal Cod() : base(EntityType.Cod)
    {
    }

    /// <summary>
    /// Marks that this cod originates from bucket
    /// </summary>
    /// <param name="from">Whether the cod was from bucket</param>
    /// <returns>This cod</returns>
    public Cod FromBucket(bool from)
    {
        Bools["FromBucket"] = from;
        return this;
    }
}