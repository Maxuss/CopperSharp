namespace CopperSharp.Text;

/// <summary>
/// Represents a text color, that is represented by hex string, e.g. <c>#FF0000</c>
/// </summary>
public readonly struct HexadecimalTextColor : ITextColor
{
    /// <summary>
    /// Constructs a new hexadecimal text color from int color values
    /// </summary>
    /// <param name="r">Red value of the color</param>
    /// <param name="g">Green value of the color</param>
    /// <param name="b">Blue value of the color</param>
    public HexadecimalTextColor(int r, int g, int b)
    {
        B = b;
        G = g;
        R = r;
    }

    /// <summary>
    /// Constructs a new hexadecimal text color from hex string
    /// </summary>
    /// <param name="hexString">Hex string to be used</param>
    public HexadecimalTextColor(string hexString)
    {
        var stripped = hexString.ToLower().Replace("#", "").Replace("0x", "");
        var hex = Convert.ToInt32(stripped, 16);
        R = hex >> 16;
        G = hex >> 8;
        B = hex >> 0;
    }

    /// <inheritdoc />
    public int R { get; }

    /// <inheritdoc />
    public int G { get; }

    /// <inheritdoc />
    public int B { get; }

    /// <summary>
    /// Converts this text color to hex string
    /// </summary>
    /// <returns>Hex string of this color</returns>
    public override string ToString()
    {
        return ((ITextColor) this).ToHexString();
    }
}