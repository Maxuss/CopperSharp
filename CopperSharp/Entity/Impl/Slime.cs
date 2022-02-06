namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents a slime entity
/// </summary>
public sealed class Slime : LivingEntity
{
    internal Slime() : base(EntityType.Slime)
    {
    }

    /// <summary>
    ///     Sets zero-based size of this slime
    /// </summary>
    /// <param name="size">New size of this slime</param>
    /// <returns>This slime</returns>
    public Slime Sized(int size)
    {
        Ints["Size"] = size;
        return this;
    }

    /// <summary>
    ///     Whether this slime was on ground
    /// </summary>
    /// <param name="ground">Marker</param>
    /// <returns>This slime</returns>
    public Slime OnGround(bool ground)
    {
        Bools["wasOnGround"] = ground;
        return this;
    }
}