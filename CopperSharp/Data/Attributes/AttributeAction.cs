namespace CopperSharp.Data.Attributes;

/// <summary>
/// Represents an action to be done with an attribute
/// </summary>
public enum AttributeAction
{
    /// <summary>
    /// Adds positive and subtracts negative value<br/>
    /// From attribute value amount
    /// </summary>
    Add,

    /// <summary>
    /// For every modifier, multiplies the current value<br/>
    /// of the attribute by <c>(1 + x)</c>, where x is the amount<br/>
    /// of the particular modifier
    /// </summary>
    Multiply,

    /// <summary>
    /// Multiplies the current value of the attribute by<br/>
    /// <c>(1 + x)</c>, where x is the sum of the modifiers' amounts
    /// </summary>
    MultiplyBase
}