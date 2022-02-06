using CopperSharp.Functions;

namespace CopperSharp.Registry;

/// <summary>
/// Represents a global function registry
/// </summary>
public sealed class FunctionRegistry : Registry<IFunction>
{
    internal FunctionRegistry()
    {
        
    }

    /// <inheritdoc />
    protected override string Transform(IFunction element)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public override IFunction Register(IFunction element, Identifier id)
    {
        Stack.Push((element, id));
        return element;
    }
}