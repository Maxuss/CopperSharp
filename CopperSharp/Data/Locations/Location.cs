namespace CopperSharp.Data.Locations;

/// <summary>
///     Represents a location in world space
/// </summary>
public readonly struct Location
{
    /// <summary>
    ///     X position of this location
    /// </summary>
    public Coordinate X { get; }

    /// <summary>
    ///     Y position of this location
    /// </summary>
    public Coordinate Y { get; }

    /// <summary>
    ///     Z position of this location
    /// </summary>
    public Coordinate Z { get; }

    /// <summary>
    ///     Constructs a new location with provided coordinates
    /// </summary>
    /// <param name="x">X position</param>
    /// <param name="y">Y position</param>
    /// <param name="z">Z position</param>
    public Location(double x, double y, double z)
    {
        X = Coordinate.Simple(x);
        Y = Coordinate.Simple(y);
        Z = Coordinate.Simple(z);
    }

    /// <summary>
    ///     Constructs a new location with provided pre-built coordinates
    /// </summary>
    /// <param name="x">X coordinate</param>
    /// <param name="y">Y coordinate</param>
    /// <param name="z">Z coordinate</param>
    public Location(Coordinate x, Coordinate y, Coordinate z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    /// <summary>
    ///     Parses a location from string
    /// </summary>
    /// <param name="str">String, that contains location</param>
    /// <returns>Serialized location</returns>
    public static Location FromString(string str)
    {
        var locs = str.Trim().Split(" ", 3);
        return new Location(
            Coordinate.FromString(locs[0]),
            Coordinate.FromString(locs[1]),
            Coordinate.FromString(locs[2]));
    }

    /// <inheritdoc />
    public override string ToString()
    {
        return $"{X} {Y} {Z}";
    }
}