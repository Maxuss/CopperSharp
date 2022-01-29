using System.Drawing;

namespace CopperSharp.Text;

/// <summary>
/// A global interface for text colors
/// </summary>
public interface ITextColor
{
    /// <summary>
    /// Blue value of this text color
    /// </summary>
    public int R { get; }

    /// <summary>
    /// Green value of this text color
    /// </summary>
    public int G { get; }

    /// <summary>
    /// Blue value of this text color
    /// </summary>
    public int B { get; }

    /// <summary>
    /// Converts this color to a hex integer
    /// </summary>
    /// <returns>Converted hex integer</returns>
    public sealed int ToHexInteger()
    {
        return Convert.ToInt32(ToHexString().Replace("#", ""), 16);
    }

    /// <summary>
    /// Hex string representation of this text color
    /// </summary>
    public sealed string ToHexString()
    {
        return $"#{R:X2}{G:X2}{B:X2}";
    }

    /// <summary>
    /// Creates a new <see cref="HexadecimalTextColor"/> from hex string
    /// </summary>
    /// <param name="hex">Hex string to be used</param>
    public static ITextColor Hex(string hex)
    {
        return new HexadecimalTextColor(hex);
    }

    /// <summary>
    /// Creates a new <see cref="HexadecimalTextColor"/> from provided red green and blue values
    /// </summary>
    /// <param name="r">Red amount</param>
    /// <param name="g">Green amount</param>
    /// <param name="b">Blue amount</param>
    public static ITextColor Hex(int r, int g, int b)
    {
        return new HexadecimalTextColor(r, g, b);
    }

    /// <summary>
    /// Creates a new <see cref="HexadecimalTextColor"/> from provided red green and blue values
    /// </summary>
    /// <param name="r">Red amount</param>
    /// <param name="g">Green amount</param>
    /// <param name="b">Blue amount</param>
    public static ITextColor Hex(double r, double g, double b)
    {
        return new HexadecimalTextColor((int) r, (int) g, (int) b);
    }


    /// <summary>
    /// Creates a new <see cref="HexadecimalTextColor"/> from provided hex integer
    /// </summary>
    /// <param name="hex">Hex integer, containing red, green and blue values</param>
    public static ITextColor Hex(int hex)
    {
        return new HexadecimalTextColor((hex >> 16) & 0xFF, (hex >> 8) & 0xFF, (hex >> 0) & 0xFF);
    }

    /// <summary>
    /// Converts this color to string.
    /// </summary>
    /// <returns>String representation of this text color</returns>
    public string ToString()
    {
        return ToHexString();
    }
}