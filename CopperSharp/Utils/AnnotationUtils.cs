using CopperSharp.Item;

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
/// Attribute for enchant enum to store string data inside
/// </summary>
[AttributeUsage(AttributeTargets.Field)]
public sealed class EnchantDataAttribute : Attribute
{
    /// <summary>
    /// Creates a new enchantment data attribute
    /// </summary>
    /// <param name="id">Path part of the Identifier of this enchantment</param>
    /// <param name="maxLevel">Max level of this enchantment</param>
    public EnchantDataAttribute(string id, int maxLevel)
    {
        Id = id;
        MaxLevel = maxLevel;
    }

    /// <summary>
    /// Namespaced id of this enchant
    /// </summary>
    public string Id { get; }

    /// <summary>
    /// Maximum level of this enchantment
    /// </summary>
    public int MaxLevel { get; }
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

    /// <summary>
    /// Gets enchantment data for this enchant
    /// </summary>
    /// <param name="en">Enchantment to look data for</param>
    /// <returns>Data of this enchant, or null, if something went wrong</returns>
    public static EnchantDataAttribute? GetEnchantData(this Enchant en)
    {
        var type = typeof(Enchant);
        var fieldInfo = type.GetField(Enum.GetName(en) ?? "NullEnchant");
        var attribs =
            fieldInfo?.GetCustomAttributes(typeof(EnchantDataAttribute), false) as EnchantDataAttribute[];
        return attribs?.Length > 0 ? attribs[0] : null;
    }
}