using CopperSharp.Modules;
using Examples;
using Newtonsoft.Json;

JsonConvert.SerializeObject("");
var startTime = DateTime.UtcNow;

await ModuleLoader.GlobalLoader.LoadAsync(new ExampleModule());

var diff = DateTime.UtcNow - startTime;
Console.WriteLine($"Took {diff.TotalMilliseconds}ms");


