using System.Reflection;
using CopperSharp.Contexts;

namespace CopperSharp.Hooks;

/// <summary>
/// An abstract super class for hook context scopes
/// </summary>
public abstract class HookContext : IWorldReference
{
    // the world is initialized by the hook itself
#pragma warning disable CS8618
    public WorldContext World { get; protected set; }
#pragma warning restore CS8618

    /// <summary>
    /// Type of delegate to be created
    /// </summary>
    protected abstract Type DelegateType { get; }

    /// <summary>
    /// Binds provided module to the delegate function
    /// </summary>
    /// <param name="mtd">Method to be bound</param>
    /// <param name="firstParam">The instance of hook handler</param>
    /// <returns>Bound delegate</returns>
    protected Delegate BindDelegate(MethodInfo mtd, object firstParam)
    {
        return Delegate.CreateDelegate(DelegateType, firstParam, mtd);
    }
}