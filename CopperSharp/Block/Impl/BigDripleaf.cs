namespace CopperSharp.Block.Impl;

/// <summary>
/// Represents a big drip leaf
/// </summary>
public sealed class BigDripleaf : AbstractBlockData, IDripleaf
{
    /// <summary>
    /// Tilt of dripleaf
    /// </summary>
    public enum Tilt
    {
        /// <summary>
        /// Fully tilted
        /// </summary>
        Full,

        /// <summary>
        /// Partially tilted
        /// </summary>
        Partial,

        /// <summary>
        /// Unstable
        /// </summary>
        Unstable,

        /// <summary>
        /// No tilt
        /// </summary>
        None
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
    /// Sets tilting of this dripleaf
    /// </summary>
    /// <param name="tilt">Type of tilt</param>
    /// <returns>This big dripleaf</returns>
    public BigDripleaf Tilted(Tilt tilt)
    {
        Data["tilt"] = Enum.GetName(tilt)?.ToLower() ?? "none";
        return this;
    }
}