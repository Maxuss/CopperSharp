using CopperSharp.Contexts;

namespace CopperSharp.Functions;

internal readonly struct TickFunction : IFunction
{
    private List<AsyncMinecraftDelegate> Load { get; } = new();

    public void AddDelegate(AsyncMinecraftDelegate del)
    {
        Load.Add(del);
    }

    public TickFunction()
    {
        Load = new List<AsyncMinecraftDelegate>();
    }

    public TickFunction(AsyncMinecraftDelegate del)
    {
        Load.Add(del);
    }

    [FunctionHandler("tick")]
    public async Task OnTick(WorldContext ctx)
    {
        foreach (var fn in Load) await fn(ctx);
    }
}