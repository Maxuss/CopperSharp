namespace CopperSharp.Entity.Impl;

/// <summary>
/// Represents a vindicator
/// </summary>
public sealed class Vindicator : RaidEntity
{
    internal Vindicator() : base(EntityType.Vindicator)
    {
    }

    /// <summary>
    /// Adds Johnny behaviour to this vindicator
    /// </summary>
    /// <param name="attack">Whether to make this vindicator attack every mob</param>
    /// <returns>This vindicator</returns>
    public Vindicator AttackEverything(bool attack = true)
    {
        Bools["AttackEverything"] = attack;
        return this;
    }
}