namespace CopperSharp.Block.Data.Impl;

/// <summary>
/// Represents a beehive block 
/// </summary>
public sealed class Beehive : AbstractBlockData, IDirectional
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
    /// Sets honey level inside this beehive
    /// </summary>
    /// <param name="level">New honey level</param>
    /// <returns>This beehive</returns>
    public Beehive HoneyLevel(int level)
    {
        Data["honey_level"] = Math.Clamp(level, 0, 5);
        return this;
    }
}