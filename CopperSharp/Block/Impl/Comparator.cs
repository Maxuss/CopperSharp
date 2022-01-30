namespace CopperSharp.Block.Impl;

public sealed class Comparator : AbstractBlockData, IDirectional, IPowerable
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
    public IPowerable Powered(bool power)
    {
        Data["powered"] = power;
        return this;
    }

    /// <summary>
    /// Whether this comparator subtracts values or compares them
    /// </summary>
    /// <param name="sub">Subtracts if true, otherwise compares</param>
    /// <returns>This comparator</returns>
    public Comparator Subtracting(bool sub = true)
    {
        Data["mode"] = sub ? "subtract" : "compare";
        return this;
    }
}