using CopperSharp.Item;

namespace CopperSharp.Blocks.State;

/// <summary>
/// Represents chest's inventory
/// </summary>
public sealed class ChestInventory : Inventory
{
    /// <inheritdoc />
    protected override int MaxSize => 27;
}