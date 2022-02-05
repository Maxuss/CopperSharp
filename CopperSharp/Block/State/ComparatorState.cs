using CopperSharp.Item;

namespace CopperSharp.Block.State;

/// <summary>
/// Represents comparator block state
/// </summary>
public sealed class ComparatorState : BlockState
{
    internal ComparatorState(Material id) : base(id)
    {
    }

    /// <summary>
    /// Sets strength of the output analog signal
    /// </summary>
    /// <param name="strength">Strength of the signal</param>
    /// <returns>This comparator state</returns>
    public ComparatorState OutputSignal(int strength)
    {
        Data["OutputSignal"] = Math.Clamp(strength, 0, 15);
        return this;
    }
}