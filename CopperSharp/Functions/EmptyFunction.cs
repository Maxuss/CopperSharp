namespace CopperSharp.Functions;

internal readonly struct EmptyFunction : IFunction
{
    internal readonly int _hashNum = Random.Shared.Next();
}