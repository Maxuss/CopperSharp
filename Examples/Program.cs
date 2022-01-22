using CopperSharp.Entity;
using CopperSharp.Text;

var startTime = DateTime.UtcNow;

var entity =
    new SimpleEntity(EntityType.Blaze)
        .Glow()
        .DisableGravity()
        .Name(new TextComponent("Epic Name").Colored(NamedTextColor.Gold).Formatted(FormattingType.Bold), true)
        .AddPassengers(new SimpleEntity(EntityType.Boat))
        .VisualFire()
        .Invulnerability();
var serialized = entity.Serialize();
Console.WriteLine(serialized);

var took = (DateTime.UtcNow - startTime).TotalMilliseconds;
Console.WriteLine($"Took {took}ms");