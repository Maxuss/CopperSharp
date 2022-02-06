namespace CopperSharp.Blocks.Data.Impl;

/// <summary>
///     Represents a hopper block
/// </summary>
public sealed class Hopper : AbstractBlockData, IDirectional
{
    /// <inheritdoc />
    public IDirectional Facing(BlockFace face)
    {
        if (!face.Cartesian)
            return this;

        Data["facing"] = face.Name;
        return this;
    }

    /// <summary>
    ///     Sets whether this hopper is enabled
    /// </summary>
    /// <param name="enabled">Marker</param>
    /// <returns>This hopper</returns>
    public Hopper Enabled(bool enabled = true)
    {
        Data["enabled"] = enabled;
        return this;
    }
}