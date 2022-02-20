using CopperSharp.Predicates.Conditions;
using CopperSharp.Utils;

namespace CopperSharp.Contexts.Hooks;

/// <summary>
/// Represents an interface that can request something to be true
/// </summary>
public interface IRequestable
{
    /// <summary>
    /// Requires some condition to pass
    /// </summary>
    public Task Require(ICondition condition);
}