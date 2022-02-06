using CopperSharp.Item;

namespace CopperSharp.Blocks.State;

/// <summary>
///     Represents campfire's inventory
/// </summary>
public sealed class CampfireInventory : Inventory
{
    /// <inheritdoc />
    protected override int MaxSize => 4;
}