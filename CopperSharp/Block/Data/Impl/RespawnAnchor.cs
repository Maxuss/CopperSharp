namespace CopperSharp.Block.Data.Impl;

/// <summary>
/// Represents a respawn anchor
/// </summary>
public sealed class RespawnAnchor : AbstractBlockData
{
    /// <summary>
    /// Sets amount of charges are left in this respawn anchor
    /// </summary>
    /// <param name="charges">Amount of charges in range of 0 to 4</param>
    /// <returns>This respawn anchor</returns>
    public RespawnAnchor Charges(int charges)
    {
        Data["charges"] = Math.Clamp(charges, 0, 4);
        return this;
    }
}