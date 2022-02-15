using CopperSharp.Modules;
using CopperSharp.Registry;

namespace CopperSharp.Hooks;

/// <summary>
/// A hook that is ran each right click
/// </summary>
public sealed class RightClickHook : AbstractHook
{
    /// <summary>
    /// Constructs a new right click hook
    /// </summary>
    public RightClickHook()
    {
        Usages++;
    }

    internal static int Usages { get; set; } = 0;

    /// <inheritdoc />
    public override void Configure(Module mod)
    {
        mod.GlobalLoad.AddDelegate(ctx => ctx.RunUnsafe($"scoreboard objectives add right_click_{Usages} minecraft.used:minecraft.carrot_on_a_stick"));
        Registries.Functions.RegisterRawHandler($"hooks/right_click/internal_{Usages}",ctx => Executor.Invoke(ctx));
        mod.GlobalTick.AddDelegate(ctx =>
        {
            ctx.RunUnsafe($"execute as @a[scores={{right_click_{Usages}=1..}}] at @s run function {mod.Namespace}:hooks/right_click/internal_{Usages}");
            ctx.RunUnsafe($"scoreboard players reset @a[scores={{right_click_{Usages}=1..}}] right_click_{Usages}");
        });
        
    }
}