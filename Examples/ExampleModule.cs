using CopperSharp.Contexts;
using CopperSharp.Data.Effects;
using CopperSharp.Data.Locations;
using CopperSharp.Functions;
using CopperSharp.Item;
using CopperSharp.Models;
using CopperSharp.Modules;
using CopperSharp.Registry;
using CopperSharp.Text;
using CopperSharp.Utils;

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
        IronGold = new Disguise(Material.IronIngot, Material.GoldIngot);
        Registries.Disguises.Register(IronGold);
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
        var player = ctx.GetPlayer("Xtremum");
        await player.SendMessage(
            Component
                .Text("Hello!")
                .Colored(NamedTextColor.Gold)
                .Formatted(FormattingType.Bold));
        await player.SendTitle(Component.Text("Title"), Component.Text("Subtitle"));
        await player.SendActionBar(Component.Text("Actionbar"));
        player.GrantAdvancement(Identifier.Minecraft("adventure/adventuring_time"));
        player.PlaySound("entity.axolotl.attack", location: Location.FromString("~ ~ ~"));
        player.AddEffect(new PotionEffect(StatusEffect.Glowing, 200));
        player.DisplayParticle("dust",
            Location.FromString("~ ~ ~"),
            new Vec3(1, 0, 1),
            1.0f,
            50,
            options: new DustOptions(ITextColor.Hex(0xFFAAFF)));

        var inv = player.Inventory;
        await inv.AddItem(new ItemStack(Material.DiamondSword));
        await inv.SetHelmet(new ItemStack(Material.DiamondBlock));
        await inv.SetHotbarItem(new ItemStack(Material.NetherStar), 5);
    }
}