using CopperSharp.Item;
using CopperSharp.Item.Meta;
using CopperSharp.Text;
using Newtonsoft.Json;

JsonConvert.SerializeObject("");
var startTime = DateTime.UtcNow;

var meta = new FireworkMeta(Material.FireworkRocket).AddExplosions(
    new FireworkExplosion()
        .Flicker()
        .Trail()
        .Type(ExplosionType.Creeper)
        .MainColors(NamedTextColor.Black, NamedTextColor.Gray)
        .FadingColors(NamedTextColor.Gray, NamedTextColor.Gold),
    new FireworkExplosion()
        .Flicker()
        .Trail()
        .Type(ExplosionType.Burst)
        .MainColors(NamedTextColor.Gold, NamedTextColor.Gray)
        .FadingColors(NamedTextColor.Gray, NamedTextColor.Red
        )).FlightDuration(10);;

Console.WriteLine(meta.Serialize());

var diff = DateTime.UtcNow - startTime;
Console.WriteLine($"Took {diff.TotalMilliseconds}ms");