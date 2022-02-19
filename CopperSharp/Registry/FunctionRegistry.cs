using CopperSharp.Contexts;
using CopperSharp.Functions;
using CopperSharp.Modules;

namespace CopperSharp.Registry;

/// <summary>
///     Represents a global function registry
/// </summary>
public sealed class FunctionRegistry : Registry<IFunction>
{
    internal FunctionRegistry()
    {
    }

    /// <inheritdoc />
    protected override string Name => "functions";

    /// <summary>
    ///     Registers a new function
    /// </summary>
    /// <param name="element">Function to be registered</param>
    public void Register(IFunction element)
    {
        Register(element, Identifier.Of("null", "null"));
    }

    internal void RegisterSynthetic(string path)
    {
        Register(new NullFunction(), Identifier.Of("null", path));
    }

    /// <inheritdoc />
    public override IFunction Register(IFunction element, Identifier id)
    {
        // Function handlers dont have a default UUID
        Stack.Push((element, id));
        FunctionManager.Register(element);
        return element;
    }

    /// <summary>
    ///     Registers a raw handler
    /// </summary>
    /// <param name="del">Handler to be registered</param>
    /// <param name="path">Name of the function</param>
    public void RegisterRawHandler(string path, MinecraftDelegate del)
    {
        var hash = new EmptyFunction();
        Stack.Push((hash, Identifier.Of("null", path)));
        FunctionManager.RegisterHashed(del, hash, path);
    }

    /// <summary>
    ///     Registers a raw async handler
    /// </summary>
    /// <param name="del">Handler to be registered</param>
    /// <param name="path">Name of the function</param>
    public void RegisterRawAsyncHandler(string path, AsyncMinecraftDelegate del)
    {
        var hash = new EmptyFunction();
        Stack.Push((hash, Identifier.Of("null", path)));
        FunctionManager.RegisterAsyncHashed(del, hash, path);
    }


    /// <inheritdoc />
    public override async Task Write((IFunction, Identifier) element, ModuleOutputStream stream)
    {
        var (fn, id) = element;
        if (fn is NullFunction)
            return;
        var handlers = FunctionManager.Lookup(fn);
        var asyncHandlers = FunctionManager.LookupAsyncs(fn);

        if (asyncHandlers != null)
            foreach (var (mtd, handle) in asyncHandlers)
            {
                var ctx = new WorldContext();
                ctx.EnableMinecraftTranslating();
                try
                {
                    await mtd(ctx);
                }
                catch (Exception e)
                {
                    ModuleLoader.GlobalLoader.EmitWarning($"Could not execute minecraft delegate! {e.Message}");
                }

                ctx.DisableMinecraftTranslating();
                ctx.Cache.Add($"\n# Built with CopperSharp v{CopperSharp.Version}");
                ctx.Flush(stream.Open($"{handle.FunctionName}.mcfunction"));
            }

        if (handlers == null)
            return;

        foreach (var (mtd, handle) in handlers)
        {
            var ctx = new WorldContext();
            ctx.EnableMinecraftTranslating();
            mtd(ctx);
            ctx.DisableMinecraftTranslating();
            ctx.Cache.Add($"\n# Built with CopperSharp v{CopperSharp.Version}");
            ctx.Flush(stream.Open($"{handle.FunctionName}.mcfunction"));
        }
    }
}