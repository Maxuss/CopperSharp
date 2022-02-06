namespace CopperSharp.Blocks.Data.Impl;

/// <summary>
///     Represents a glass pane block
/// </summary>
public sealed class GlassPane : AbstractBlockData, IMultipleFacing, IWaterlogged
{
    /// <inheritdoc />
    public IMultipleFacing SetFace(BlockFace face, bool has = true)
    {
        if (!face.Cartesian)
            return this;

        Data[face.Name] = has;
        return this;
    }

    /// <inheritdoc />
    public IWaterlogged Waterlogged(bool logged)
    {
        Data["waterlogged"] = logged;
        return this;
    }
}