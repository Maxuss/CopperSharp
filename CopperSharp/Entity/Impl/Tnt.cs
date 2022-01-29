namespace CopperSharp.Entity.Impl;

/// <summary>
/// Represents a fused TNT entity
/// </summary>
public sealed class Tnt : AbstractEntity
{
    internal Tnt() : base(EntityType.Tnt)
    {
    }

    /// <summary>
    /// Sets fuse timer of this TNT, until this TNT explodes
    /// </summary>
    /// <param name="ticks">Amount of time in ticks</param>
    /// <returns>This TNT</returns>
    public Tnt FuseTimer(short ticks)
    {
        Ints["Fuse"] = ticks;
        return this;
    }
}