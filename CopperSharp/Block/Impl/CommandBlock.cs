namespace CopperSharp.Block.Impl;

/// <summary>
/// Represents a command block
/// </summary>
public sealed class CommandBlock : AbstractBlockData, IDirectional
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
    /// Makes this command block conditional
    /// </summary>
    /// <param name="cond">Whether this command block is conditional</param>
    /// <returns>This command block</returns>
    public CommandBlock Conditional(bool cond = true)
    {
        Data["conditional"] = cond;
        return this;
    }
}