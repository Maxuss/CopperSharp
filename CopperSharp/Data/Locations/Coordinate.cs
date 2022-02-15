using System.Globalization;

namespace CopperSharp.Data.Locations;

/// <summary>
///     Represents a single coordinate position
/// </summary>
public readonly struct Coordinate
{
    private static readonly char[] AllowedExtraChars = {'~', '^'};

    /// <summary>
    ///     Value stored inside this coordinate
    /// </summary>
    public double Value { get; }

    private char? ExtraChar { get; }

    private Coordinate(double val, char? extra = null)
    {
        Value = val;
        ExtraChar = extra;
    }

    /// <summary>
    ///     Constructs a new simple coordinate
    /// </summary>
    /// <param name="val">Value of the coordinate</param>
    /// <returns>A simple coordinate</returns>
    public static Coordinate Simple(double val)
    {
        return new Coordinate(val);
    }

    /// <summary>
    ///     Constructs a new relative coordinate
    /// </summary>
    /// <param name="val">Value of the coordinate</param>
    /// <returns>A relative coordinate</returns>
    public static Coordinate Relative(double val)
    {
        return new Coordinate(val, '~');
    }

    /// <summary>
    ///     Constructs a new local coordinate
    /// </summary>
    /// <param name="val">Value of the coordinate</param>
    /// <returns>A local coordinate</returns>
    public static Coordinate Local(double val)
    {
        return new Coordinate(val, '^');
    }

    /// <summary>
    ///     Creates a new coordinate from provided string
    /// </summary>
    /// <param name="str">String to be parsed</param>
    /// <returns>A new parsed coordinate</returns>
    /// <exception cref="Exception">Invalid coordinate format provided</exception>
    public static Coordinate FromString(string str)
    {
        var trim = str.Trim();
        if (AllowedExtraChars.Contains(trim[0]))
        {
            var replaced = trim.Remove(0, 1);
            if (replaced.Length == 0)
                return new Coordinate(0, trim[0]);
            if (!double.TryParse(replaced, out var d))
                throw new Exception("Invalid coordinate provided!");
            return new Coordinate(d, trim[0]);
        }

        if (!double.TryParse(trim, out var dp))
            throw new Exception("Invalid coordinate provided!");

        return new Coordinate(dp);
    }

    /// <inheritdoc />
    public override string ToString()
    {
        return
            $"{ExtraChar.ToString() ?? ""}{(Value == 0 ? "" : Value.ToString(CultureInfo.InvariantCulture))}";
    }
}