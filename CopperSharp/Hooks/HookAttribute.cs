using System.Reflection;

namespace CopperSharp.Hooks;

/// <summary>
///     Represents a hook that is invoked each time some kind of event is called
/// </summary>
[AttributeUsage(AttributeTargets.Method, Inherited = false)]
public sealed class HookAttribute : Attribute
{
    /// <summary>
    /// Constructs a new hook
    /// </summary>
    /// <param name="hook">Hook to be constructed</param>
    public HookAttribute(AbstractHook hook)
    {
        Hook = hook;
    }

    internal AbstractHook Hook { get; }
}