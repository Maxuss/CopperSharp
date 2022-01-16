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
    /// Hex string representation of this text color
    /// </summary>
    public sealed string ToHexString()
    {
        var myColor = Color.FromArgb(R, R, B);
        return $"#{myColor.R:X2}{myColor.G:X2}{myColor.B:X2}";
    }

    /// <summary>
    /// Creates a new <see cref="HexadecimalTextColor"/> from hex string
    /// </summary>
    /// <param name="hex">Hex string to be used</param>
    public static ITextColor Hex(string hex)
    {
        return new HexadecimalTextColor(hex);
    }
}