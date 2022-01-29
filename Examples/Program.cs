using CopperSharp.Contexts;
using CopperSharp.Data.Effects;
using CopperSharp.Data.Locations;
using CopperSharp.Entity;
using CopperSharp.Item;
using Newtonsoft.Json;

JsonConvert.SerializeObject("");
var startTime = DateTime.UtcNow;

var ctx = new WorldContext();
var entity = (LivingEntity) ctx.GenerateEntity(EntityType.WitherSkeleton, Location.FromString("~ ~1 ~"));

// first modifications:
entity.Helmet(new ItemStack(Material.CrimsonPlanks));

entity.Release();

ctx.Flush(Console.Out);

// second modifications:
entity.Lock(ctx);

entity.Boots(new ItemStack(Material.NetheriteBoots))
    .MainHand(new ItemStack(Material.NetheriteSword))
    .Chestplate(new ItemStack(Material.Elytra))
    .AddEffect(StatusEffect.Speed, 1000, 25)
    .CanUseElytra();

entity.Release();

ctx.Flush(Console.Out);

var diff = DateTime.UtcNow - startTime;
Console.WriteLine($"Took {diff.TotalMilliseconds}ms");