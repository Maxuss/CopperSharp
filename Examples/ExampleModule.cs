using CopperSharp.Contexts;
using CopperSharp.Data.Effects;
using CopperSharp.Data.Locations;
using CopperSharp.Entity;
using CopperSharp.Functions;
using CopperSharp.Item;
using CopperSharp.Modules;
using CopperSharp.Registry;
using CopperSharp.Text;
using CopperSharp.Utils;

namespace Examples;

[ModuleAuthor("maxus")]
[ModuleInfo("ExampleModule", Description = "A cool example module")]
public class ExampleModule : Module
{
    private ExampleHandler Handler { get; set; }
    public override void Startup()
    {
        Console.WriteLine("Module loaded!");
        Handler = new ExampleHandler();

        Registries.Functions.Register(Handler);
    }

    public override void OnTick(WorldContext ctx)
    {
        ctx.Delegate(c => c.Announce(IComponent.Text("TEST")));
    }

    public override void WorldLoad(WorldContext ctx)
    {
        // ctx.RunUnsafe("function examplemodule:player_test");
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
    
    [FunctionHandler("player_test")]
    public void PlayerTest(WorldContext ctx)
    {
        var player = ctx.GetPlayer("Xtremum");
        player.SendMessage(
            IComponent
                .Text("Hello!")
                .Colored(NamedTextColor.Gold)
                .Formatted(FormattingType.Bold));
        player.SendTitle(IComponent.Text("Title"), IComponent.Text("Subtitle"));
        player.SendActionBar(IComponent.Text("Actionbar"));
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
        inv.AddItem(new ItemStack(Material.DiamondSword));
        inv.SetHelmet(new ItemStack(Material.DiamondBlock));
        inv.SetHotbarItem(new ItemStack(Material.NetherStar), 5);
    }
}