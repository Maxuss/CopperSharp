using CopperSharp.Contexts;
using CopperSharp.Functions;
using CopperSharp.Modules;

namespace CopperSharp.Registry;

/// <summary>
/// Represents a global function registry
/// </summary>
public sealed class FunctionRegistry : Registry<IFunction>
{
    internal FunctionRegistry()
    {
        
    }

    /// <inheritdoc />
    protected override string Name => "functions";

    /// <summary>
    /// Registers a new function
    /// </summary>
    /// <param name="element">Function to be registered</param>
    public void Register(IFunction element) => Register(element, Identifier.Of("null", "null"));

    /// <inheritdoc />
    public override IFunction Register(IFunction element, Identifier id)
    {
        // Function handlers dont have a default UUID
        Stack.Push((element, Identifier.Of("null", "null")));
        FunctionManager.Register(element);
        return element;
    }

    /// <inheritdoc />
    public override async Task Write((IFunction, Identifier) element, ModuleOutputStream stream)
    {
        var (fn, id) = element;
        var handlers = FunctionManager.Lookup(fn);
        if (handlers == null)
            return;

        foreach(var (mtd, handle) in handlers)
        {
            var ctx = new WorldContext();
            ctx.EnableMinecraftTranslating();
            mtd.Invoke(fn, new object?[] {ctx});
            ctx.DisableMinecraftTranslating();
            ctx.Cache.Add($"\n# Built with CopperSharp v{CopperSharp.Version}");
            ctx.Flush(stream.Open($"{handle.FunctionName}.mcfunction"));
        }
    }
}