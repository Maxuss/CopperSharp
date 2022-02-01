namespace CopperSharp.Block.Data;

/// <summary>
/// Represents a tile entity that can emit analogue signal
/// </summary>
public interface ISignalEmitter : IBlockData
{
    /// <summary>
    /// Sets analogue redstone output level of this entity
    /// </summary>
    /// <param name="power">Power to be set. Should not exceed 9000. Usually it's equal to 15</param>
    /// <returns>This analogue powerable entity</returns>
    public ISignalEmitter Power(int power);
}