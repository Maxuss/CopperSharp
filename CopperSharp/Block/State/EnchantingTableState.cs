using CopperSharp.Item;

namespace CopperSharp.Block.State;

/// <summary>
/// Represents an enchanting table block state
/// </summary>
public sealed class EnchantingTableState : BlockState
{
    internal EnchantingTableState(Material id) : base(id)
    {
    }
}