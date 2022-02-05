using CopperSharp.Item;

namespace CopperSharp.Block.State;

/// <summary>
/// Represents campfire's inventory
/// </summary>
public sealed class CampfireInventory : Inventory
{
    /// <inheritdoc />
    protected override int MaxSize => 4;
}