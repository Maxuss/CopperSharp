namespace CopperSharp.Functions;

/// <summary>
/// A player from function, that can operate with items, etc.
/// </summary>
public class FunctionPlayer
{
    /// <summary>
    /// Creates a new function player from this function
    /// </summary>
    /// <param name="function"></param>
    public FunctionPlayer(IFunction function)
    {
        Function = function;
    }

    /// <summary>
    /// Reference to function, in scope of which the player is located
    /// </summary>
    public IFunction Function { get; }
}