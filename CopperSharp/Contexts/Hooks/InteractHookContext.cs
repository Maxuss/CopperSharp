using System.Reflection;
using CopperSharp.Hooks;
using CopperSharp.Predicates;
using CopperSharp.Predicates.Conditions;
using CopperSharp.Utils;

namespace CopperSharp.Contexts.Hooks;

/// <summary>
/// Represents a context for interaction hooks
/// </summary>
public sealed class InteractHookContext : HookContext, IRequestable
{
    /// <summary>
    /// Type of interaction
    /// </summary>
    public ClickType ClickType { get; }

    /// <summary>
    /// The item used in this context
    /// </summary>
    public ItemConditionProvider Item { get; }

    internal InteractHookContext(ClickType click)
    {
        World = new WorldContext();
        ClickType = click;
        Item = new ItemConditionProvider(World);
    }
    
    /// <inheritdoc />
    protected override Type DelegateType => typeof(Func<InteractHookContext, Task>);

    /// <inheritdoc />
    public async Task Require(ICondition condition)
    {
        if (condition is not IRetranslatingCondition)
            return;
        await condition.Operate(World);
    }
}

/// <summary>
/// Represents type of click
/// </summary>
public enum ClickType
{
    /// <summary>
    /// Right click
    /// </summary>
    RightClick,
    /// <summary>
    /// Left click
    /// </summary>
    LeftClick
}