using CopperSharp.Data.Locations;
using CopperSharp.Entity.Impl;
using CopperSharp.Item;

namespace CopperSharp.Block.State;

/// <summary>
/// Represents a beehive block
/// </summary>
public sealed class BeehiveState : EntityBlockState<Bee>
{
    /// <summary>
    /// Sets location of the flower for the bees
    /// </summary>
    /// <param name="pos">Position to be set</param>
    /// <returns>This beehive state</returns>
    public BeehiveState FlowerLocation(Location pos)
    {
        Data["FlowerPos"] = pos;
        return this;
    }
    
    /// <inheritdoc />
    public BeehiveState(Material id) : base(id)
    {
    }

    /// <inheritdoc />
    protected override string EntityName { get; set; } = "Bees";
}