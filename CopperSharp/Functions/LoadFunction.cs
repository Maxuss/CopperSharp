using CopperSharp.Contexts;

namespace CopperSharp.Functions;

internal struct LoadFunction : IFunction
{
    private List<AsyncMinecraftDelegate> Load { get; }

    public void AddDelegate(AsyncMinecraftDelegate del)
    {
        Load?.Add(del);
    }

    public LoadFunction()
    {
        Load = new List<AsyncMinecraftDelegate>();
    }

    public LoadFunction(AsyncMinecraftDelegate del)
    {
        Load = new List<AsyncMinecraftDelegate> {del};
    }

    [FunctionHandler("load")]
    public async Task OnTick(WorldContext ctx)
    {
        foreach (var fn in Load) await fn(ctx);
    }
}