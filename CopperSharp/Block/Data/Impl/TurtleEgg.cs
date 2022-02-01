namespace CopperSharp.Block.Data.Impl;

/// <summary>
/// Represents a turtle egg block
/// </summary>
public sealed class TurtleEgg : AbstractBlockData
{
    /// <summary>
    /// Sets amount of eggs
    /// </summary>
    /// <param name="eggs">Amount of eggs in range of 1 to 4</param>
    /// <returns>This turtle egg</returns>
    public TurtleEgg Eggs(int eggs)
    {
        Data["eggs"] = Math.Clamp(eggs, 1, 4);
        return this;
    }

    /// <summary>
    /// Sets state of egg's hatch.
    /// </summary>
    /// <param name="state">State in range of 0 to 2. Hatches when overpasses 2</param>
    /// <returns>This turtle egg</returns>
    public TurtleEgg HatchState(int state)
    {
        Data["hatch"] = Math.Clamp(state, 0, 2);
        return this;
    }
}