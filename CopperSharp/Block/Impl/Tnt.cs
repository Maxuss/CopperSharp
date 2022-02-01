namespace CopperSharp.Block.Impl;

/// <summary>
/// Represents a TNT block
/// </summary>
public sealed class Tnt : AbstractBlockData
{
    /// <summary>
    /// Makes this TNT unstable.
    /// </summary>
    /// <param name="unstable">Makes the TNT explode on hit if true, works normally if false</param>
    /// <returns>This TNT</returns>
    public Tnt Unstable(bool unstable = true)
    {
        Data["unstable"] = unstable;
        return this;
    }
}