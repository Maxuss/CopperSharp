namespace CopperSharp.Entity.Impl;

/// <summary>
/// Represents bat entity
/// </summary>
public sealed class Bat : LivingEntity
{
    internal Bat() : base(EntityType.Bat)
    {
    }

    /// <summary>
    /// Marks that the bat is hanging upside-down
    /// </summary>
    /// <param name="upside">Whether the bat is upside down</param>
    /// <returns>This bat</returns>
    public Bat UpsideDown(bool upside)
    {
        Bools["BatFlags"] = upside;
        return this;
    }
}