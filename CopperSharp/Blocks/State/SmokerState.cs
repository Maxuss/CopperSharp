using CopperSharp.Item;

namespace CopperSharp.Blocks.State;

/// <summary>
///     Represents a smoke block state
/// </summary>
public sealed class SmokerState : FurnaceState
{
    /// <inheritdoc />
    public SmokerState(Material id) : base(id)
    {
    }
}