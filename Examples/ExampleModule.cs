using CopperSharp.Contexts;
using CopperSharp.Functions;
using CopperSharp.Modules;
using CopperSharp.Registry;
using CopperSharp.Text;

namespace Examples;

[ModuleAuthor("maxus")]
[ModuleInfo("ExampleModule", Description = "A cool example module")]
public class ExampleModule : Module
{
    public override void Startup()
    {
        Console.WriteLine("Module loaded!");

        Registries.Functions.Register(new ExampleHandler());
    }
}

public sealed class ExampleHandler : IFunction
{
    [FunctionHandler("first")]
    public void First(WorldContext ctx)
    {
        ctx.Announce(IComponent.Text("First function was called!").Colored(NamedTextColor.Gray));
    }

    [FunctionHandler("second")]
    public void Second(WorldContext ctx)
    {
        ctx.Announce(IComponent.Text("Second function was called!").Colored(NamedTextColor.Gray));
    }
}