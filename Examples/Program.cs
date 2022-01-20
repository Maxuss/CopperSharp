// See https://aka.ms/new-console-template for more information

using CopperSharp.Registry;
using CopperSharp.Text;
using Newtonsoft.Json;

var beginTime = DateTime.Now;
var component = new TextComponent("Hello, World!")
    .Colored(ITextColor.Hex(153, 0, 201))
    .Formatted(FormattingType.Bold)
    .Insertion("Hello, Insertion!")
    .OnClick(ClickEvent.OpenUrl("https://copper.maxus.space"))
    .OnHover(
        IHoverEvent.Text(
            new TextComponent("Hello, Hover!")
                .Formatted(FormattingType.Italic)
                .Colored(NamedTextColor.Gold)))
    .Child(
        new TranslatableComponent("item.minecraft.diamond_sword")
            .Colored(ITextColor.Hex(0xbf4f4a))
            .OnHover(IHoverEvent.Item(Identifier.Minecraft("diamond_ore"), 12)));

var endTime = DateTime.Now - beginTime;
Console.WriteLine(JsonConvert.SerializeObject(component.Contain()));
Console.WriteLine($"Finished in {endTime.TotalMilliseconds}ms");