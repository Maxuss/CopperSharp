namespace CopperSharp.Block.Data.Impl;

/// <summary>
/// Represents a lectern block
/// </summary>
public sealed class Lectern : AbstractBlockData, IDirectional, IPowerable
{
    /// <inheritdoc />
    public IDirectional Facing(BlockFace face)
    {
        if (!face.Cartesian)
            return this;

        Data["facing"] = face;
        return this;
    }

    /// <inheritdoc />
    public IPowerable Powered(bool power)
    {
        Data["powered"] = power;
        return this;
    }

    /// <summary>
    /// Whether this lectern has a book
    /// </summary>
    /// <param name="has">Marker</param>
    /// <returns>This lectern</returns>
    public Lectern HasBook(bool has = true)
    {
        Data["has_book"] = has;
        return this;
    }
}