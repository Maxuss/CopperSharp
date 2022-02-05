using CopperSharp.Item;

namespace CopperSharp.Blocks.State;

/// <summary>
/// Represents a conduit block state
/// </summary>
public sealed class ConduitState : BlockState
{
    internal ConduitState(Material id) : base(id)
    {
    }

    /// <summary>
    /// Sets target this conduit is attacking
    /// </summary>
    /// <param name="target">Target to be set</param>
    /// <returns>This conduit block state</returns>
    public ConduitState AttackTarget(Guid target)
    {
        Data["Target"] = target;
        return this;
    }
}