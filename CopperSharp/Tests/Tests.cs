using CopperSharp.Item;
using CopperSharp.Text;
using Xunit;
using Xunit.Abstractions;

namespace CopperSharp.Tests;

/// <summary>
///     Test classes
/// </summary>
public class Tests
{
    private readonly ITestOutputHelper tout;

    /// <summary>
    /// </summary>
    /// <param name="testOutputHelper"></param>
    public Tests(ITestOutputHelper testOutputHelper)
    {
        tout = testOutputHelper;
    }

    /// <summary>
    /// </summary>
    [Fact]
    public async Task RawComponentSerialization()
    {
        var beginTime = DateTime.Now;
        var component = new TextComponent("Hello, World!")
            .Colored(ITextColor.Hex(153, 0, 201))
            .Formatted(FormattingType.Bold)
            .Insertion("Hello, Insertion!")
            .OnClick(ClickEvent.OpenUrl("https://copper.maxus.space"))
            .OnHover(
                HoverEvent.Text(
                    new TextComponent("Hello, Hover!")
                        .Formatted(FormattingType.Italic)
                        .Colored(NamedTextColor.Gold)))
            .Child(
                new TranslatableComponent("item.minecraft.diamond_sword")
                    .Colored(ITextColor.Hex(0xbf4f4a))
                    .OnHover(HoverEvent.Item(new ItemStack(Material.DiamondOre))));
        tout.WriteLine(await component.Serialize());
        var endTime = DateTime.Now - beginTime;
        tout.WriteLine($"Finished in {endTime.TotalMilliseconds}ms");
    }
}