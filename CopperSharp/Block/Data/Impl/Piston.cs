namespace CopperSharp.Block.Data.Impl;

/// <summary>
/// Represents a piston block
/// </summary>
public sealed class Piston : AbstractBlockData, IDirectional
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
    /// Whether this piston's head is currently extended
    /// </summary>
    /// <param name="extend">Whether this piston is extended</param>
    /// <returns>This piston</returns>
    public Piston Extended(bool extend = true)
    {
        Data["extended"] = extend;
        return this;
    }
}