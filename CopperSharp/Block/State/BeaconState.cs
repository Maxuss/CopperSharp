using CopperSharp.Data.Effects;
using CopperSharp.Item;

namespace CopperSharp.Block.State;

/// <summary>
/// Represents a beacon block state
/// </summary>
public sealed class BeaconState : BlockState, ILockable
{
    internal BeaconState(Material id) : base(id)
    {
    }

    /// <summary>
    /// Sets amount of beacon levels
    /// </summary>
    /// <param name="value">Levels to be set</param>
    /// <returns>This beacon state</returns>
    public BeaconState Levels(int value)
    {
        Data["Levels"] = value;
        return this;
    }

    /// <summary>
    /// Sets primary effect of this beacon
    /// </summary>
    /// <param name="effect">Effect to be set</param>
    /// <returns>This beacon state</returns>
    public BeaconState PrimaryEffect(StatusEffect effect)
    {
        Data["Primary"] = (int) effect;
        return this;
    }

    /// <summary>
    /// Sets secondary effect of this beacon. Requires a secondary effect.
    /// </summary>
    /// <param name="effect">Effect to be set</param>
    /// <returns>This beacon state</returns>
    public BeaconState SecondaryEffect(StatusEffect effect)
    {
        Data["Secondary"] = (int) effect;
        return this;
    }

    /// <inheritdoc />
    public ILockable Allow(string name)
    {
        Data["lock"] = name;
        return this;
    }
}