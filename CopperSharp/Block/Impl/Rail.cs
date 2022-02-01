using CopperSharp.Utils;

namespace CopperSharp.Block.Impl;

/// <summary>
/// Represents a rail blocks
/// </summary>
public class Rail : AbstractBlockData, IWaterlogged
{
    /// <summary>
    /// Represents shape of rails
    /// </summary>
    public enum Shape
    {
        /// <summary>
        /// East-west
        /// </summary>
        [EnumData("east_west")] EastWest,

        /// <summary>
        /// North-east
        /// </summary>
        [EnumData("north_east")] NorthEast,

        /// <summary>
        /// North-south
        /// </summary>
        [EnumData("north_south")] NorthSouth,

        /// <summary>
        /// North-west
        /// </summary>
        [EnumData("north_west")] NorthWest,

        /// <summary>
        /// South-east
        /// </summary>
        [EnumData("south_east")] SouthEast,

        /// <summary>
        /// South-west
        /// </summary>
        [EnumData("south_west")] SouthWest,

        /// <summary>
        /// Ascending east
        /// </summary>
        [EnumData("ascending_east")] AscendingEast,

        /// <summary>
        /// Ascending north
        /// </summary>
        [EnumData("ascending north")] AscendingNorth,

        /// <summary>
        /// Ascending south
        /// </summary>
        [EnumData("ascending_south")] AscendingSouth,

        /// <summary>
        /// Ascending west
        /// </summary>
        [EnumData("ascending_west")] AscendingWest
    }

    /// <inheritdoc />
    public IWaterlogged Waterlogged(bool logged)
    {
        Data["waterlogged"] = logged;
        return this;
    }

    /// <summary>
    /// Sets shape of these rails
    /// </summary>
    /// <param name="shape">Shape to be set</param>
    /// <returns>These rails</returns>
    public Rail Shaped(Shape shape)
    {
        Data["shape"] = shape.GetData() ?? "north_south";
        return this;
    }
}