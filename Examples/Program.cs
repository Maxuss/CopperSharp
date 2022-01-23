using CopperSharp.Text;
using Newtonsoft.Json;

JsonConvert.SerializeObject("");
var startTime = DateTime.UtcNow;

var linear = new TextComponent("##################").LinearGradient(ITextColor.Hex(0x0), ITextColor.Hex(0xFFFFFF));
var quadraticFast =
    new TextComponent("##################").QuadraticGradient(ITextColor.Hex(0x0), ITextColor.Hex(0xFFFFFF), true);
var quadraticSlow =
    new TextComponent("##################").QuadraticGradient(ITextColor.Hex(0x0), ITextColor.Hex(0xFFFFFF), false);

Console.WriteLine(linear.Serialize());
Console.WriteLine(quadraticFast.Serialize());
Console.WriteLine(quadraticSlow.Serialize());

var diff = DateTime.UtcNow - startTime;
Console.WriteLine($"Took {diff.TotalMilliseconds}ms");