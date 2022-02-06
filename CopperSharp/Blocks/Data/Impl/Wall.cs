namespace CopperSharp.Blocks.Data.Impl;

/// <summary>
///     Represents a wall block
/// </summary>
public sealed class Wall : AbstractBlockData, IWaterlogged
{
    /// <summary>
    ///     Represents wall's height
    /// </summary>
    public enum Height
    {
        /// <summary>
        ///     The wall does not extend
        /// </summary>
        None,

        /// <summary>
        ///     The wall extends a bit
        /// </summary>
        Low,

        /// <summary>
        ///     The wall extends by a lot
        /// </summary>
        Tall
    }

    /// <inheritdoc />
    public IWaterlogged Waterlogged(bool logged = true)
    {
        Data["waterlogged"] = logged;
        return this;
    }

    /// <summary>
    ///     Sets how the wall extends at provided block face
    /// </summary>
    /// <param name="face">Face at which the wall extends</param>
    /// <param name="extends">Sets amount of the wall's extend</param>
    /// <returns>This wall</returns>
    public Wall HeightAt(BlockFace face, Height extends)
    {
        if (!face.Cartesian)
            return this;

        Data[face.Name] = Enum.GetName(extends)?.ToLower() ?? "none";
        return this;
    }

    /// <summary>
    ///     Sets whether this wall has a center post
    /// </summary>
    /// <param name="up">Marker</param>
    /// <returns>This wall</returns>
    public Wall CenterPost(bool up = true)
    {
        Data["up"] = up;
        return this;
    }
}