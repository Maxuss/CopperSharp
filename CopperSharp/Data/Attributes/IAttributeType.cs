namespace CopperSharp.Data.Attributes;

/// <summary>
///     A global interface for attribute types.<br />
///     To get static attribute values, check<br />
///     implementations below:
/// </summary>
/// <seealso cref="GenericAttribute" />
/// <seealso cref="PlayerAttribute" />
/// <seealso cref="ZombieAttribute" />
/// <seealso cref="HorseAttribute" />
/// <seealso cref="FlyingEntityAttribute" />
public interface IAttributeType
{
    /// <summary>
    ///     Name of the attribute type provider
    /// </summary>
    public string Name { get; }

    /// <summary>
    ///     Default base value of the attribute type
    /// </summary>
    public double DefaultBase { get; }

    /// <summary>
    ///     Maximum value of this attribute
    /// </summary>
    public double Maximum { get; }
}