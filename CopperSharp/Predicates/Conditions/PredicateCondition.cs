using CopperSharp.Contexts;
using CopperSharp.Modules;
using CopperSharp.Utils;

namespace CopperSharp.Predicates.Conditions;

internal sealed class PredicateCondition : IRetranslatingCondition
{
    public string? Predicates { get; set; }

    async Task ICondition.Operate(WorldContext world)
    {
        if (Predicates != null)
        {
            world.RunUnsafe($"execute at @s as @s if predicate {Predicates} run function {ModuleLoader.CurrentModule!.Namespace}:internals/predicate_{WorldContext.RetranslationIndex}");
            world.StartRetranslation(Path.Join("internals", $"predicate_{WorldContext.RetranslationIndex}"));
        }
    }

}