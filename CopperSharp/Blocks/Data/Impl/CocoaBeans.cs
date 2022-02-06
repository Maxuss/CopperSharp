namespace CopperSharp.Blocks.Data.Impl;

/// <summary>
///     Represents a cocoa beans block
/// </summary>
public sealed class CocoaBeans : AbstractBlockData, IDirectional, IAgeable
{
    /// <inheritdoc />
    public IAgeable Age(int age)
    {
        Data["age"] = age;
        return this;
    }

    /// <inheritdoc />
    public IDirectional Facing(BlockFace face)
    {
        if (!face.Cartesian)
            return this;

        Data["facing"] = face.Name;
        return this;
    }
}