namespace CopperSharp.Data.Attributes;

/// <summary>
/// A global interface for attribute types
/// </summary>
public interface IAttributeType
{
    /// <summary>
    /// Name of the attribute type provider
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Default base value of the attribute type
    /// </summary>
    public double DefaultBase { get; }

    /// <summary>
    /// Maximum value of this attribute
    /// </summary>
    public double Maximum { get; }
}