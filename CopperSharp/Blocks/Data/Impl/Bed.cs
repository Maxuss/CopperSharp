namespace CopperSharp.Blocks.Data.Impl;

/// <summary>
///     Represents a bed block
/// </summary>
public sealed class Bed : AbstractBlockData, IDirectional
{
    /// <summary>
    ///     Part of bed
    /// </summary>
    public enum Part
    {
        /// <summary>
        ///     Foot part
        /// </summary>
        Foot,

        /// <summary>
        ///     Head part
        /// </summary>
        Head
    }

    /// <inheritdoc />
    public IDirectional Facing(BlockFace face)
    {
        if (!face.Cartesian)
            return this;

        Data["facing"] = face.Name;
        return this;
    }

    /// <summary>
    ///     Sets part of this bed
    /// </summary>
    /// <param name="part">Part to be set</param>
    /// <returns>This bed</returns>
    public Bed SetPart(Part part)
    {
        Data["part"] = Enum.GetName(part)?.ToLower() ?? "foot";
        return this;
    }
}