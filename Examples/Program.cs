using CopperSharp.Advancements;
using CopperSharp.Advancements.Predicates;
using CopperSharp.Item;
using CopperSharp.Registry;
using CopperSharp.Text;
using Newtonsoft.Json;

JsonConvert.SerializeObject("");
var startTime = DateTime.UtcNow;

var adv = new Advancement()
    .GroupRoot(
        new AdvancementGroup(Identifier.Minecraft("textures/gui/advancements/backgrounds/stone.png")))
    .Title(IComponent.Text("Amazing Advancements!").Colored(NamedTextColor.Gold))
    .Description(IComponent.Text("Wow, what cool advancements!\n")
        .Child(
            IComponent.Text("WOW!")
                .Formatted(FormattingType.Bold)
                .Colored(NamedTextColor.Green)))
    .Type(AdvancementType.Challenge)
    .DisplayItem(new ItemStack(Material.DiamondAxe))
    .Criteria(
        new Criterion("stuff", TriggerCondition.ConsumeItem
            .Item(ItemPredicate.Simple(Material.SuspiciousStew))));

Registries.Advancements.Register(adv, Identifier.Of("maxus", "first"));

var adv2 = new Advancement()
    .Parent(adv)
    .Hidden()
    .Criteria(new Criterion("something", TriggerCondition.PlaceBlock.Block(Material.DiamondBlock)));

var first = await adv.Serialize();
var second = await adv2.Serialize();

Console.WriteLine($"FIRST: {first}");
Console.WriteLine($"SECOND: {second}");

var diff = DateTime.UtcNow - startTime;
Console.WriteLine($"Took {diff.TotalMilliseconds}ms");