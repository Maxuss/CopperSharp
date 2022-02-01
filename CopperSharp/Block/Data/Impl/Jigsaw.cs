using CopperSharp.Utils;

namespace CopperSharp.Block.Data.Impl;

/// <summary>
/// Represents a jigsaw block
/// </summary>
public sealed class Jigsaw : AbstractBlockData
{
    /// <summary>
    /// The direction the jigsaw block is facing.
    /// </summary>
    public enum Orientation
    {
        /// <summary>
        /// Down east
        /// </summary>
        [EnumData("down_east")] DownEast,

        /// <summary>
        /// Down north
        /// </summary>
        [EnumData("down_north")] DownNorth,

        /// <summary>
        /// Down south
        /// </summary>
        [EnumData("down_south")] DownSouth,

        /// <summary>
        /// Down west
        /// </summary>
        [EnumData("down_west")] DownWest,

        /// <summary>
        /// East up
        /// </summary>
        [EnumData("east_up")] EastUp,

        /// <summary>
        /// North up
        /// </summary>
        [EnumData("north_up")] NorthUp,

        /// <summary>
        /// South up
        /// </summary>
        [EnumData("south_up")] SouthUp,

        /// <summary>
        /// Up east
        /// </summary>
        [EnumData("up_east")] UpEast,

        /// <summary>
        /// Up north
        /// </summary>
        [EnumData("up_north")] UpNorth,

        /// <summary>
        /// Up south
        /// </summary>
        [EnumData("up_south")] UpSouth,

        /// <summary>
        /// Up west
        /// </summary>
        [EnumData("up_west")] UpWest,

        /// <summary>
        /// West up
        /// </summary>
        [EnumData("west_up")] WestUp
    }

    /// <summary>
    /// Sets the direction this jigsaw block is facing
    /// </summary>
    /// <param name="orient">Type of orientation</param>
    /// <returns>This jigsaw</returns>
    public Jigsaw SetOrientation(Orientation orient)
    {
        Data["orientation"] = orient.GetData() ?? "north_up";
        return this;
    }
}