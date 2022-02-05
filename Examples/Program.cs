using CopperSharp.Blocks.State;
using CopperSharp.Contexts;
using CopperSharp.Data.Locations;
using CopperSharp.Item;
using Newtonsoft.Json;

JsonConvert.SerializeObject("");
var startTime = DateTime.UtcNow;

var world = new WorldContext();

// doing an extra release here just to display the differences
var block = world.SetBlock(Material.Chest, new Location(10, 3, 10));
block.GenerateState();
block.Release();

block.Lock(world);
var state = (ChestState) block.State!;
state.Inventory.AddItem(new ItemStack(Material.Diamond, 65));
state.Inventory.SetItem(new ItemStack(Material.Diamond, 65), 10);
block.State = state;
block.Release();

world.Flush(Console.Out);

var diff = DateTime.UtcNow - startTime;
Console.WriteLine($"Took {diff.TotalMilliseconds}ms");