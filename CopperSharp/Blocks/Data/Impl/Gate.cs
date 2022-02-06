namespace CopperSharp.Blocks.Data.Impl;

/// <summary>
///     Represents a fence gate block
/// </summary>
public sealed class Gate :
    AbstractBlockData,
    IDirectional,
    IOpenable,
    IPowerable
{
    /// <inheritdoc />
    public IDirectional Facing(BlockFace face)
    {
        Data["facing"] = face.Name;
        return this;
    }

    /// <inheritdoc />
    public IOpenable Open(bool open)
    {
        Data["open"] = open;
        return this;
    }

    /// <inheritdoc />
    public IPowerable Powered(bool power)
    {
        Data["powered"] = power;
        return this;
    }

    /// <summary>
    ///     Makes the gate as attached to a wall
    /// </summary>
    /// <param name="inside">Whether the gate is inside the wall</param>
    /// <returns>This gate</returns>
    public Gate Wall(bool inside = true)
    {
        Data["in_wall"] = inside;
        return this;
    }
}