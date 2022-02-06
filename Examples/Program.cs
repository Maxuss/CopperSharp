using Newtonsoft.Json;

JsonConvert.SerializeObject("");
var startTime = DateTime.UtcNow;


var diff = DateTime.UtcNow - startTime;
Console.WriteLine($"Took {diff.TotalMilliseconds}ms");