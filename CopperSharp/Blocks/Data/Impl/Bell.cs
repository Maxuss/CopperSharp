using CopperSharp.Utils;

namespace CopperSharp.Blocks.Data.Impl;

/// <summary>
/// Represents a bell tile entity
/// </summary>
public sealed class Bell : AbstractBlockData, IDirectional, IPowerable
{
    /// <summary>
    /// Type of bell's attachment
    /// </summary>
    public enum Attachment
    {
        /// <summary>
        /// Attached to the ceiling
        /// </summary>
        [EnumData("ceiling")] Ceiling,

        /// <summary>
        /// Two walls
        /// </summary>
        [EnumData("double_wall")] DoubleWall,

        /// <summary>
        /// Floor
        /// </summary>
        [EnumData("floor")] Floor,

        /// <summary>
        /// One wall
        /// </summary>
        [EnumData("single_wall")] SingleWall
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
    public IPowerable Powered(bool power)
    {
        Data["powered"] = power;
        return this;
    }

    /// <summary>
    /// Sets type of this bell's attachment
    /// </summary>
    /// <param name="attach">Type of attachment to be set</param>
    /// <returns>This bell</returns>
    public Bell Attached(Attachment attach)
    {
        Data["attachment"] = attach.GetData() ?? "floor";
        return this;
    }
}