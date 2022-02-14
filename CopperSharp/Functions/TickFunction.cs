using CopperSharp.Contexts;

namespace CopperSharp.Functions;

internal readonly struct TickFunction : IFunction
{
    private MinecraftDelegate Tick { get; }
    
    public TickFunction(MinecraftDelegate tick)
    {
        Tick = tick;
    }

    [FunctionHandler("tick")]
    public void OnTick(WorldContext ctx)
    {
        Tick.Invoke(ctx);
    }
}