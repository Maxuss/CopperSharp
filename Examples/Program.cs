// See https://aka.ms/new-console-template for more information

using CopperSharp.Data.SNbt;
using CopperSharp.Text;
using Newtonsoft.Json;

using var sw = new StringWriter();
using var nbt = new StringNbtWriter(sw);
nbt.WriteBeginCompound();
nbt.WritePropertyName("display");
nbt.WriteBeginCompound();
nbt.WritePropertyName("Name");
nbt.WriteString(JsonConvert.SerializeObject(new TextComponent("HELLO' WORLD!").Contain()));
nbt.WriteEndCompound();
nbt.WriteEndCompound();
Console.WriteLine(sw.ToString());