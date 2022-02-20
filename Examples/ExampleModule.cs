using CopperSharp.Contexts;
using CopperSharp.Data.Attributes;
using CopperSharp.Data.Locations;
using CopperSharp.Entity;
using CopperSharp.Functions;
using CopperSharp.Item;
using CopperSharp.Item.Meta;
using CopperSharp.Models;
using CopperSharp.Modules;
using CopperSharp.Registry;
using CopperSharp.Text;

namespace Examples;

[ModuleAuthor("maxus")]
[ModuleInfo("ExampleModule", Description = "A cool example module")]
public class ExampleModule : Module
{
    private Disguise IronGold { get; set; }
    private ExampleHandler? Handler { get; set; }
    public override void Startup()
    {
        Console.WriteLine("Module loaded!");
        Handler = new ExampleHandler();

        Registries.Functions.Register(Handler);
    }

    public override async Task WorldLoad(WorldContext ctx)
    {
        await ctx.GetPlayer("Xtremum").Inventory.AddDisguise(IronGold);
    }
}

public sealed class ExampleHandler : IFunction
{
    [FunctionHandler("first")]
    public async Task First(WorldContext ctx)
    {
        await ctx.Announce(Component.Text("First function was called!").Colored(NamedTextColor.Gray));
    }

    [FunctionHandler("second")]
    public async Task Second(WorldContext ctx)
    {
        await ctx.Announce(Component.Text("Second function was called!").Colored(NamedTextColor.Gray));
    }

    [FunctionHandler("player_test")]
    public async Task PlayerTest(WorldContext ctx)
    {
        var item = new ItemStack(Material.PlayerHead);
        var meta = item.Meta as SkullMeta;
        meta!.SetBase64Texture("eyJ0ZXh0dXJlcyI6eyJTS0lOIjp7InVybCI6Imh0dHA6Ly90ZXh0dXJlcy5taW5lY3JhZnQubmV0L3RleHR1cmUvODkxOGVmNjAwODQwYzBlZGE3MmM5NTg4ZDEwYWU4NWFiM2QxODRjZjA3ZjAyYTRhZjYzNjU2YTZiMTFkNjY0MiJ9fX0=");
        item.Meta = meta;
        await ctx.GetPlayer("Xtremum").Inventory.AddItem(item);
    }
}