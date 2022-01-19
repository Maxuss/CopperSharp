namespace CopperSharp.Utils;

/// <summary>
/// Attribute for enum to store string data inside
/// </summary>
[AttributeUsage(AttributeTargets.Field)]
public sealed class EnumDataAttribute : Attribute
{
    /// <summary>
    /// Creates a new enum data attribute
    /// </summary>
    /// <param name="data">Data stored inside the enum</param>
    public EnumDataAttribute(string data)
    {
        Data = data;
    }

    /// <summary>
    /// Data stored in this enum data
    /// </summary>
    public string Data { get; }
}

/// <summary>
/// Utils for annotation
/// </summary>
public static class AnnotationUtils
{
    /// <summary>
    /// Gets data from this enum value
    /// </summary>
    /// <param name="en">Enum that holds string data inside <see cref="EnumDataAttribute"/></param>
    /// <returns>Data gotten from this enum, or null, if it does not have <see cref="EnumDataAttribute"/> attribute</returns>
    public static string? GetData(this Enum en)
    {
        var type = en.GetType();
        var fieldInfo = type.GetField(en.ToString());
        var attribs =
            fieldInfo?.GetCustomAttributes(typeof(EnumDataAttribute), false) as EnumDataAttribute[];
        return attribs?.Length > 0 ? attribs[0].Data : null;
    }
}