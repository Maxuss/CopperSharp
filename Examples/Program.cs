using CopperSharp.Modules;
using Examples;
using Newtonsoft.Json;

JsonConvert.SerializeObject("");
var startTime = DateTime.UtcNow;
ModuleLoader.GlobalLoader.SetOutputDirectory("/home/maxus/.local/share/multimc/instances/Fabulously Optimized/minecraft/saves/CopperSharp Testing/datapacks");
ModuleLoader.GlobalLoader.SetResourcepackDirectory("/home/maxus/.local/share/multimc/instances/Fabulously Optimized/minecraft/resourcepacks");

await ModuleLoader.GlobalLoader.LoadAsync(new ExampleModule());

var diff = DateTime.UtcNow - startTime;
Console.WriteLine($"Took {diff.TotalMilliseconds}ms");


