using CopperSharp.Data.SNbt;
using Newtonsoft.Json;

JsonConvert.SerializeObject("");
var startTime = DateTime.UtcNow;

var nbt = new NbtCompound
{
    {
        "array", new List<object>
        {
            "hello",
            "world",
            "something",
        }
    },
    {
        "nestedCompound", new NbtCompound
        {
            {"sus", true}
        }
    }
};

Console.WriteLine(nbt.Serialize());

var diff = DateTime.UtcNow - startTime;
Console.WriteLine($"Took {diff.TotalMilliseconds}ms");