using CopperSharp.Functions;

namespace CopperSharp.Registry.Impl;

internal class FunctionRegistryImpl : IFunctionRegistry
{
    private List<IFunction> RegisteredFunctions { get; } = new();

    public void Register(IFunction element)
    {
        RegisteredFunctions.Add(element);
    }

    public void WriteTo(RegistryOutputStream<IFunction> stream)
    {
        if (stream is not FunctionOutputStream fout)
            return;

        foreach (var element in RegisteredFunctions) fout.Write(element);
    }

    public void Flush()
    {
        RegisteredFunctions.Clear();
    }
}