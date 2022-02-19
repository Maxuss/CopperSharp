using System.Diagnostics;
using CopperSharp.Modules;
using Examples;
using Newtonsoft.Json;

JsonConvert.SerializeObject("");

ModuleLoader.GlobalLoader.SetOutputDirectory("/home/maxus/.local/share/multimc/instances/Fabulously Optimized/minecraft/saves/CopperSharp Testing/datapacks");
ModuleLoader.GlobalLoader.SetResourcepackDirectory("/home/maxus/.local/share/multimc/instances/Fabulously Optimized/minecraft/resourcepacks");

ModuleLoader.GlobalLoader.RegisterTask("Inject an internal task", mod =>
{
    ModuleLoader.GlobalLoader.CacheResource(Path.Join("pack", "data", "minecraft", "functions", "injected.mcfunction"),
        "tellraw @a \"Injected text!\"");
    return Task.CompletedTask;
});

await ModuleLoader.GlobalLoader.LoadModule(new ExampleModule());


