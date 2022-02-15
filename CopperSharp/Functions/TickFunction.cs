using CopperSharp.Contexts;

namespace CopperSharp.Functions;

internal readonly struct TickFunction : IFunction
{
    private List<MinecraftDelegate> Load { get; } = new();

    public void AddDelegate(MinecraftDelegate del)
    {
        Load.Add(del);
    }

    public TickFunction()
    {
        Load = new List<MinecraftDelegate>();
    }

    public TickFunction(MinecraftDelegate del)
    {
        Load.Add(del);
    }

    [FunctionHandler("tick")]
    public void OnTick(WorldContext ctx)
    {
        foreach (var fn in Load)
        {
            fn(ctx);
        }
    }
}