using CopperSharp.Contexts;
using CopperSharp.Data.SNbt;
using CopperSharp.Item;
using CopperSharp.Modules;

namespace CopperSharp.Predicates.Conditions;

internal sealed class IdentityCondition : ICondition
{
    public ItemStack? Identity { get; set; }
    private string Storage { get; set; }
    
    internal IdentityCondition(string dataStorage)
    {
        Storage = dataStorage;
    }

    async Task ICondition.Operate(WorldContext world)
    {
        if (Identity != null)
        {
            await using var w = new StringWriter();
            await using var sw = new StringNbtWriter(w);
            await sw.WriteItem(Identity);
            var serIdentity = w.ToString();
            world.RunUnsafe($"execute at @s as @s if data storage {Storage} item{{{serIdentity}}} run function {ModuleLoader.CurrentModule!.Namespace}:internals/identity_{WorldContext.RetranslationIndex}");
            world.StartRetranslation(Path.Join("internals", $"identity_{WorldContext.RetranslationIndex}"));
        }
    }
}