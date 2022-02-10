using CopperSharp.Advancements.Predicates;
using CopperSharp.Registry;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
/// Triggers when the player shoots a target block
/// </summary>
public sealed class TargetHit : TriggerCondition
{
    /// <summary>
    /// Sets the redstone signal that will come out of the block
    /// </summary>
    /// <param name="strength">Strength to be set</param>
    /// <returns>This trigger</returns>
    public TargetHit SignalStrength(int strength)
    {
        Data["signal_strength"] = strength;
        return this;
    }

    /// <summary>
    /// Sets the type of projectile to hit the block
    /// </summary>
    /// <param name="type">Type of projectile to be set</param>
    /// <returns>This trigger</returns>
    public TargetHit Projectile(Identifier type)
    {
        Data["projectile"] = type.ToString();
        return this;
    }

    /// <summary>
    /// Sets the player who shot or threw the projectile
    /// </summary>
    /// <param name="shooter">Entity to be set</param>
    /// <returns>This trigger</returns>
    public TargetHit Shooter(EntityPredicate shooter)
    {
        Entities["shooter"] = shooter;
        return this;
    }
}