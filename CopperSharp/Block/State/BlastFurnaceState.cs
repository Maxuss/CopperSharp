using CopperSharp.Item;

namespace CopperSharp.Block.State;

/// <summary>
/// Represents a blast furnace block state
/// </summary>
public sealed class BlastFurnaceState : FurnaceState
{
    internal BlastFurnaceState(Material id) : base(id)
    {
    }
}