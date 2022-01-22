using CopperSharp.Data.Locations;

var startTime = DateTime.UtcNow;

var loc = Location.FromString("~ ~ ~");
Console.WriteLine(loc.ToString());

var took = (DateTime.UtcNow - startTime).TotalMilliseconds;
Console.WriteLine($"Took {took}ms");