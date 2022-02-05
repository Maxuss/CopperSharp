using CopperSharp.Item;

namespace CopperSharp.Blocks.State;

/// <summary>
/// Represents a dispenser/dropper inventory
/// </summary>
public sealed class DispenserInventory : Inventory
{
    /// <inheritdoc />
    protected override int MaxSize => 9;
}