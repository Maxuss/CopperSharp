using CopperSharp.Item;

namespace CopperSharp.Blocks.State;

/// <summary>
/// Represents a trapped chest block state
/// </summary>
public sealed class TrappedChestState : ChestState
{
    internal TrappedChestState(Material id) : base(id)
    {
    }
}