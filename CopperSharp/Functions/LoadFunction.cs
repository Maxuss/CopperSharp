using CopperSharp.Contexts;

namespace CopperSharp.Functions;

internal readonly struct LoadFunction : IFunction
{
    private MinecraftDelegate Load { get; }

    public LoadFunction(MinecraftDelegate load)
    {
        Load = load;
    }

    [FunctionHandler("load")]
    public void OnTick(WorldContext ctx)
    {
        Load.Invoke(ctx);
    }
}