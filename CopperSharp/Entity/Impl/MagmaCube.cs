namespace CopperSharp.Entity.Impl;

/// <summary>
/// Represents a magma cube
/// </summary>
public sealed class MagmaCube : LivingEntity
{
    internal MagmaCube() : base(EntityType.MagmaCube)
    {
    }

    /// <summary>
    /// Sets zero-based size of this magma cube
    /// </summary>
    /// <param name="size">New size of this magma cube</param>
    /// <returns>This magma cube</returns>
    public MagmaCube Sized(int size)
    {
        Ints["Size"] = size;
        return this;
    }

    /// <summary>
    /// Whether this cube was on ground
    /// </summary>
    /// <param name="ground">Marker</param>
    /// <returns>This magma cube</returns>
    public MagmaCube OnGround(bool ground)
    {
        Bools["wasOnGround"] = ground;
        return this;
    }
}