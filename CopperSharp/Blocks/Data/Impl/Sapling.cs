namespace CopperSharp.Blocks.Data.Impl;

/// <summary>
///     Represents a growable tile entity
/// </summary>
public class Sapling : AbstractBlockData
{
    /// <summary>
    ///     Whether this sapling is trying to grow
    /// </summary>
    /// <param name="growing">Whether it is possible for sapling to grow</param>
    /// <returns>This sapling entity</returns>
    public Sapling Growing(bool growing)
    {
        Data["stage"] = growing ? 1 : 0;
        return this;
    }
}