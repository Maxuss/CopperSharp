namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents a TNT minecart vehicle
/// </summary>
public sealed class TntMinecart : AbstractMinecart
{
    internal TntMinecart() : base(EntityType.TntMinecart)
    {
    }

    /// <summary>
    ///     Sets fuse timer, until this TNT explodes.
    ///     Set to-1 if deactivated.
    /// </summary>
    /// <param name="ticks">Amount of time in ticks</param>
    /// <returns>This TNT minecart</returns>
    public TntMinecart FuseTimer(int ticks)
    {
        Ints["TNTFuse"] = ticks;
        return this;
    }
}