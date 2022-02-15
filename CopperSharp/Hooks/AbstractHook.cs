using CopperSharp.Functions;
using CopperSharp.Modules;

namespace CopperSharp.Hooks;

/// <summary>
/// A global abstract class for hooks
/// </summary>
public abstract class AbstractHook
{
    /// <summary>
    /// An executor for this hook
    /// </summary>
    // the executor is set through runtime with reflection
#pragma warning disable CS8618
    public MinecraftDelegate Executor { get; internal set; }
#pragma warning restore CS8618
    
    /// <summary>
    /// Configures this hook for provided module
    /// </summary>
    /// <param name="mod">Module to be used</param>
    public abstract void Configure(Module mod);
}