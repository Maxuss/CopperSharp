namespace CopperSharp.Block;

/// <summary>
/// Represents a block entity that has different directions
/// </summary>
public interface IDirectional : IBlockData
{
    /// <summary>
    /// Sets facing rotation of this directional entity
    /// </summary>
    /// <param name="face">Face to be set</param>
    /// <returns>This directional entity</returns>
    public IDirectional Facing(BlockFace face);
}

/// <summary>
/// Represents side the block is facing
/// </summary>
public readonly struct BlockFace
{
    /// <summary>
    /// String representation of this block face
    /// </summary>
    public readonly string Name;

    /// <summary>
    /// Index of this block face
    /// </summary>
    public readonly int Mod;

    /// <summary>
    /// Whether this block face is one of units in 3D Cartesian space
    /// </summary>
    public readonly bool Cartesian;

    private BlockFace(int mod, bool cartesian, string name = "")
    {
        Name = name;
        Mod = mod;
        Cartesian = cartesian;
    }

    /// <summary>
    /// Cartesian face down
    /// </summary>
    public static readonly BlockFace Down = new(-1, true, "down");

    /// <summary>
    /// Cartesian rotation east
    /// </summary>
    public static readonly BlockFace East = new(12, true, "east");

    /// <summary>
    /// Rotation east-north-east
    /// </summary>
    public static readonly BlockFace EastNorthEast = new(11, false);

    /// <summary>
    /// Rotation east-south-east
    /// </summary>
    public static readonly BlockFace EastSouthEast = new(13, false);

    /// <summary>
    /// Cartesian rotation north
    /// </summary>
    public static readonly BlockFace North = new(8, true, "north");

    /// <summary>
    /// Rotation north-east
    /// </summary>
    public static readonly BlockFace NorthEast = new(10, false);

    /// <summary>
    /// Rotation north-north-east
    /// </summary>
    public static readonly BlockFace NorthNorthEast = new(9, false);

    /// <summary>
    /// Rotation north-north-west
    /// </summary>
    public static readonly BlockFace NorthNorthWest = new(7, false);

    /// <summary>
    /// Rotation north-west
    /// </summary>
    public static readonly BlockFace NorthWest = new(6, false);

    /// <summary>
    /// Cartesian face self
    /// </summary>
    public static readonly BlockFace Self = new(-1, true, "self");

    /// <summary>
    /// Cartesian rotation south
    /// </summary>
    public static readonly BlockFace South = new(0, true, "south");

    /// <summary>
    /// Rotation south-east
    /// </summary>
    public static readonly BlockFace SouthEast = new(14, false);

    /// <summary>
    /// Rotation south-south-east
    /// </summary>
    public static readonly BlockFace SouthSouthEast = new(15, false);

    /// <summary>
    /// Rotation south-south-west
    /// </summary>
    public static readonly BlockFace SouthSouthWest = new(1, false);

    /// <summary>
    /// Rotation south-west
    /// </summary>
    public static readonly BlockFace SouthWest = new(2, false);

    /// <summary>
    /// Cartesian face up
    /// </summary>
    public static readonly BlockFace Up = new(-1, true, "down");

    /// <summary>
    /// Cartesian rotation west
    /// </summary>
    public static readonly BlockFace West = new(4, true, "west");

    /// <summary>
    /// Rotation west-north-west
    /// </summary>
    public static readonly BlockFace WestNorthWest = new(5, false);

    /// <summary>
    /// Rotation west-south-west
    /// </summary>
    public static readonly BlockFace WestSouthWest = new(3, false);
}