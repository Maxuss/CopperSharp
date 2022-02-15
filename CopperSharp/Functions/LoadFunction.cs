using CopperSharp.Contexts;

namespace CopperSharp.Functions;

internal struct LoadFunction : IFunction
{
    private List<MinecraftDelegate> Load { get; }

    public void AddDelegate(MinecraftDelegate del)
    {
        Load?.Add(del);
    }

    public LoadFunction()
    {
        Load = new List<MinecraftDelegate>();
    }
    
    public LoadFunction(MinecraftDelegate del)
    {
        Load = new List<MinecraftDelegate> {del};
    }

    [FunctionHandler("load")]
    public void OnTick(WorldContext ctx)
    {
        foreach (var fn in Load)
        {
            fn(ctx);
        }
    }
}