namespace CopperSharp.Block.Data.Impl;

/// <summary>
/// Represents a fire block
/// </summary>
public sealed class Fire : AbstractBlockData, IAgeable, IMultipleFacing
{
    /// <inheritdoc />
    public IAgeable Age(int age)
    {
        Data["age"] = age;
        return this;
    }

    /// <inheritdoc />
    public IMultipleFacing SetFace(BlockFace face, bool has = true)
    {
        if (!face.Cartesian)
            return this;

        Data[face.Name] = has;
        return this;
    }
}