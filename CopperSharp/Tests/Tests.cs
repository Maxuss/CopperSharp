using CopperSharp.Registry;
using CopperSharp.Text;
using Newtonsoft.Json;
using Xunit;
using Xunit.Abstractions;

namespace CopperSharp.Tests;

/// <summary>
///     Test classes
/// </summary>
public class Tests
{
    private readonly ITestOutputHelper _testOutputHelper;

    /// <summary>
    /// </summary>
    /// <param name="testOutputHelper"></param>
    public Tests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    /// <summary>
    /// </summary>
    [Fact]
    public void RawComponentSerialization()
    {
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
        _testOutputHelper.WriteLine(JsonConvert.SerializeObject(component.Contain()));
        var endTime = DateTime.Now - beginTime;
        _testOutputHelper.WriteLine($"Finished in {endTime.TotalMilliseconds}ms");
    }
}