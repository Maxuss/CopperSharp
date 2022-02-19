using System.Reflection;

namespace CopperSharp.Hooks;

/// <summary>
///     Represents a hook that is invoked each time some kind of event is called
/// </summary>
[AttributeUsage(AttributeTargets.Method, Inherited = false)]
public sealed class HookAttribute : Attribute
{
    /// Constructs a new hook
    public HookAttribute(Type hook)
    {
        Hook =
            hook.GetConstructor(BindingFlags.Public | BindingFlags.Instance, Array.Empty<Type>())
                ?.Invoke(null) as AbstractHook
            ?? throw new Exception("Provided type was not a hook!");
    }

    internal AbstractHook Hook { get; }
}