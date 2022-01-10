using CopperSharp.Registry;

namespace CopperSharp.Modules;

/// <summary>
/// Represents a registry, that can be used to register items for Modules.
/// <br/><br/>
/// Implements all the Registry interfaces.
/// </summary>
/// <seealso cref="IFunctionRegistry"/>
public sealed class ModuleRegistry
{
    private ModuleRegistry()
    {
        OwnerModule = null;
    }

    internal ModuleRegistry(Module mod)
    {
        OwnerModule = mod;
    }

    /// <summary>
    /// Module-owner of current registry. Null by default.
    /// <br/>
    /// If you want to use shared registry, check out <see cref="ModuleRegistry.Shared"/>
    /// </summary>
    // ReSharper disable once MemberCanBePrivate.Global
    public Module? OwnerModule { get; }

    /// <summary>
    /// Registry, that is shared between all the Modules in the CopperSharp.
    /// Might be useful for Combining modules into single datapack.
    /// <br/><br/>
    /// This registry has always null <see cref="OwnerModule"/>!
    /// </summary>
    public static ModuleRegistry Shared { get; } = new();
}