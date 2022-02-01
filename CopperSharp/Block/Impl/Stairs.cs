using CopperSharp.Utils;

namespace CopperSharp.Block.Impl;

/// <summary>
/// Represents a stairs block
/// </summary>
public sealed class Stairs :
    AbstractBlockData,
    IBisected,
    IDirectional,
    IWaterlogged
{
    /// <summary>
    /// Represents shape of the stairs
    /// </summary>
    public enum Shape
    {
        /// <summary>
        /// Inner left
        /// </summary>
        [EnumData("inner_left")] InnerLeft,

        /// <summary>
        /// Inner right
        /// </summary>
        [EnumData("inner_right")] InnerRight,

        /// <summary>
        /// Outer left
        /// </summary>
        [EnumData("outer_left")] OuterLeft,

        /// <summary>
        /// Outer right
        /// </summary>
        [EnumData("outer_right")] OuterRight,

        /// <summary>
        /// Straight
        /// </summary>
        [EnumData("straight")] Straight
    }

    /// <inheritdoc />
    public IBisected SetHalf(IBisected.Half half)
    {
        Data["half"] = Enum.GetName(half)?.ToLower() ?? "lower";
        return this;
    }

    /// <inheritdoc />
    public IDirectional Facing(BlockFace face)
    {
        if (!face.Cartesian)
            return this;

        Data["facing"] = face.Name;
        return this;
    }

    /// <inheritdoc />
    public IWaterlogged Waterlogged(bool logged)
    {
        Data["waterlogged"] = logged;
        return this;
    }

    /// <summary>
    /// Sets shape of these stairs
    /// </summary>
    /// <param name="shape">Shape to be set</param>
    /// <returns>These stairs</returns>
    public Stairs SetShape(Shape shape)
    {
        Data["shape"] = shape.GetData() ?? "straight";
        return this;
    }
}