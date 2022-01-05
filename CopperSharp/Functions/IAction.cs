namespace CopperSharp.Functions;

/// <summary>
/// Represents a function completion step. Requires the implementer to be able to convert to command string. 
/// </summary>
public interface IAction
{
    /// <summary>
    /// Converts the current <see cref="IAction"/> to command string.
    /// </summary>
    /// <returns>Converted string from current action</returns>
    public string ToAction();
}