namespace CopperSharp.Blocks.Data.Impl;

/// <summary>
///     Represents an amethyst cluster block
/// </summary>
public sealed class AmethystCluster : AbstractBlockData, IDirectional, IWaterlogged
{
    /// <inheritdoc />
    public IDirectional Facing(BlockFace face)
    {
        if (!face.Cartesian)
            return this;
        Data["facing"] = face.Name;
        return this;
    }

    /// <inheritdoc />
    public IWaterlogged Waterlogged(bool logged = true)
    {
        Data["waterlogged"] = logged;
        return this;
    }
}