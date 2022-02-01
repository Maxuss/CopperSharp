using CopperSharp.Utils;

namespace CopperSharp.Block.Data.Impl;

/// <summary>
/// Represents a pointed dripstone block
/// </summary>
public sealed class PointedDripstone : AbstractBlockData, IWaterlogged
{
    /// <summary>
    /// Thickness of this dripstone
    /// </summary>
    public enum Thickness
    {
        /// <summary>
        /// Tip of dripstone
        /// </summary>
        [EnumData("tip")] Tip,

        /// <summary>
        /// Merging tip of dripstone
        /// </summary>
        [EnumData("tip_merge")] TipMerge,

        /// <summary>
        /// Frustum part
        /// </summary>
        [EnumData("frustum")] Frustum,

        /// <summary>
        /// Middle part
        /// </summary>
        [EnumData("middle")] Middle,

        /// <summary>
        /// Base (the thickest)
        /// </summary>
        [EnumData("base")] Base
    }

    /// <inheritdoc />
    public IWaterlogged Waterlogged(bool logged)
    {
        Data["waterlogged"] = logged;
        return this;
    }

    /// <summary>
    /// Sets whether this dripstone is facing up or down
    /// </summary>
    /// <param name="up">True for up, false for down</param>
    /// <returns>This pointed dripstone</returns>
    public PointedDripstone FacingUp(bool up = true)
    {
        Data["vertical_direction"] = up ? "up" : "down";
        return this;
    }

    /// <summary>
    /// Sets thickness of this pointed dripstone
    /// </summary>
    /// <param name="thick">Thickness to be set</param>
    /// <returns>This pointed dripstone</returns>
    public PointedDripstone SetThickness(Thickness thick)
    {
        Data["thickness"] = thick.GetData() ?? "tip";
        return this;
    }
}