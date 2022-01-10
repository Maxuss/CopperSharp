using CopperSharp.Registry;

namespace CopperSharp.Functions;

/// <summary>
/// Represents a function, that can be converted to Minecraft's .mcfunction format
/// </summary>
public interface IFunction : IRegistrable
{
    /// <summary>
    /// Actions to be executed in current function
    /// </summary>
    public Stack<IAction> Actions { get; }

    /// <summary>
    /// Adds an action to this functions completion steps
    /// </summary>
    /// <param name="action"><see cref="IAction"/> to be added to this function</param>
    public void Push(IAction action);

    /// <summary>
    /// Pops this function's stack, removing and returning latest action in it
    /// </summary>
    /// <returns>Last pushed action to this function, or null, if the stack is empty</returns>
    public IAction? Pop();

    /// <summary>
    /// Builds the function ready to be written to file
    /// </summary>
    /// <returns>Built function represented by string</returns>
    string IRegistrable.Build() => string.Join("\n", Actions.Select(it => it.ToAction()));
}

/// <summary>
/// A simple default function implementation
/// </summary>
public sealed class DefaultFunction : IFunction
{
    /// <inheritdoc />
    public Stack<IAction> Actions { get; } = new();

    /// <inheritdoc />
    public void Push(IAction action) => Actions.Push(action);

    /// <inheritdoc />
    public IAction? Pop() => Actions.Count <= 0 ? null : Actions.Pop();
}