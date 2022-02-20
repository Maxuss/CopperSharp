using CopperSharp.Contexts;

namespace CopperSharp.Predicates.Conditions;

/// <summary>
/// Represents a condition which can be tested for
/// </summary>
public interface ICondition
{
    internal Task Operate(WorldContext ctx);
}