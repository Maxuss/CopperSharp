namespace CopperSharp.Block.Data.Impl;

/// <summary>
/// Represents a farmland block
/// </summary>
public sealed class Farmland : AbstractBlockData
{
    /// <summary>
    /// Sets moisture of this farmland
    /// </summary>
    /// <param name="moisture">Value in range of 0 to 7, representing moisture of this farmland</param>
    /// <returns>This farmland</returns>
    public Farmland Moisture(int moisture)
    {
        Data["moisture"] = Math.Clamp(moisture, 0, 7);
        return this;
    }
}