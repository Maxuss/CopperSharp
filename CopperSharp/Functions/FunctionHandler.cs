namespace CopperSharp.Functions;

/// <summary>
///     A marker for function handler
/// </summary>
[AttributeUsage(AttributeTargets.Method, Inherited = false)]
public sealed class FunctionHandlerAttribute : Attribute
{
    /// <summary>
    ///     Constructs a new function handler
    /// </summary>
    /// <param name="functionName">Name of function</param>
    public FunctionHandlerAttribute(string functionName)
    {
        FunctionName = functionName;
    }

    /// <summary>
    ///     Name of function
    /// </summary>
    public string FunctionName { get; }
}