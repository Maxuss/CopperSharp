using System.Diagnostics;
using CopperSharp.Modules;
using Examples;
using Newtonsoft.Json;

JsonConvert.SerializeObject("");

ModuleLoader.GlobalLoader.SetOutputDirectory("/home/maxus/.local/share/multimc/instances/Fabulously Optimized/minecraft/saves/CopperSharp Testing/datapacks");
ModuleLoader.GlobalLoader.SetResourcepackDirectory("/home/maxus/.local/share/multimc/instances/Fabulously Optimized/minecraft/resourcepacks");

await ModuleLoader.GlobalLoader.LoadModule(new ExampleModule());


