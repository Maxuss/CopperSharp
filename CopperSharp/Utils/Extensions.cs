using System.Text;

namespace CopperSharp.Utils;

/// <summary>
///     A static class containing several extensions
/// </summary>
public static class Extensions
{
    /// <summary>
    ///     Converts this string to snake_case representation
    /// </summary>
    /// <param name="text">String to be converted</param>
    /// <returns>snake_cased string</returns>
    /// <exception cref="ArgumentNullException">Provided string is null</exception>
    public static string ToSnakeCase(this string text)
    {
        if (text == null) throw new ArgumentNullException(nameof(text));
        if (text.Length < 2) return text;
        var sb = new StringBuilder();
        sb.Append(char.ToLowerInvariant(text[0]));
        for (var i = 1; i < text.Length; ++i)
        {
            var c = text[i];
            if (char.IsUpper(c))
            {
                sb.Append('_');
                sb.Append(char.ToLowerInvariant(c));
            }
            else
            {
                sb.Append(c);
            }
        }

        return sb.ToString();
    }

    /// <inheritdoc cref="Enum.GetName" />
    public static string GetName<TEnum>(this TEnum @enum) where TEnum : struct, Enum
    {
        return Enum.GetName(@enum) ?? "NULL";
    }
}