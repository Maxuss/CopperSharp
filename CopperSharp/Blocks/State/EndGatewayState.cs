using CopperSharp.Data.Locations;
using CopperSharp.Item;

namespace CopperSharp.Blocks.State;

/// <summary>
///     Represents an end gateway block state
/// </summary>
public sealed class EndGatewayState : BlockState
{
    internal EndGatewayState(Material id) : base(id)
    {
    }

    /// <summary>
    ///     Sets exit location for this end gateway
    /// </summary>
    /// <param name="exit">Exit location for this end gateway</param>
    /// <param name="teleportExactly">Whether to teleport exactly at the exit location, and not near it.</param>
    /// <returns>This end gateway</returns>
    public EndGatewayState ExitLocation(Location exit, bool teleportExactly = false)
    {
        Data["ExitPortal"] = exit;
        Data["ExactTeleport"] = teleportExactly;
        return this;
    }
}