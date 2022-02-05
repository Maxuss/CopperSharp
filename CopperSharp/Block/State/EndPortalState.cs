using CopperSharp.Item;

namespace CopperSharp.Block.State;

/// <summary>
/// Represents an end portal block state
/// </summary>
public sealed class EndPortalState : BlockState
{
    internal EndPortalState(Material id) : base(id)
    {
    }
}