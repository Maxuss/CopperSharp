namespace CopperSharp.Block;

/// <summary>
/// Represents a lightable tile entity
/// </summary>
public interface ILightable : IBlockData
{
    /// <summary>
    /// Whether this lightable entity is lit
    /// </summary>
    /// <param name="lit">Marker</param>
    /// <returns>This lightable entity</returns>
    public ILightable Lit(bool lit);
}