using CopperSharp.Item;
using CopperSharp.Item.Meta;

var skull = new ItemStack(Material.PlayerHead);
var meta = (SkullMeta) skull.Meta;
meta.SetBase64Texture(
    "MyZDc0NWRjNjk5NzllNzVkOWM5ZmMwNDVhZDBmN2YzMDY0NTVmNWMzODU4MzhjMmNiZjc0MmM4MGNiMDIxYyJ9fX0");
skull.Meta = meta;
Console.WriteLine(skull.Serialize());