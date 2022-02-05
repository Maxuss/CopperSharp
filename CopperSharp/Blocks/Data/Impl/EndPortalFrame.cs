namespace CopperSharp.Blocks.Data.Impl;

/// <summary>
/// Represents an end portal frame block
/// </summary>
public sealed class EndPortalFrame : AbstractBlockData, IDirectional
{
    /// <inheritdoc />
    public IDirectional Facing(BlockFace face)
    {
        Data["facing"] = face.Name;
        return this;
    }

    /// <summary>
    /// Sets whether this end portal frame has an eye
    /// </summary>
    /// <param name="has">Whether it has an eye</param>
    /// <returns>This end portal frame</returns>
    public EndPortalFrame WithEye(bool has = true)
    {
        Data["eye"] = has;
        return this;
    }
}