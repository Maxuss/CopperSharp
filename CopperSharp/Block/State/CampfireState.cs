using CopperSharp.Item;

namespace CopperSharp.Block.State;

/// <summary>
/// Represents a campfire block state
/// </summary>
public class CampfireState : InventoryBlock<CampfireInventory>
{
    internal CampfireState(Material id) : base(id)
    {
        Inventory = new CampfireInventory();
    }
}