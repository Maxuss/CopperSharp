using CopperSharp.Blocks.Data;

namespace CopperSharp.Blocks;

/// <summary>
///     An interface for block states
/// </summary>
public interface IState
{
    /// <summary>
    ///     Extra data on this block
    /// </summary>
    public IBlockData? BlockData { get; set; }

    /// <summary>
    ///     Serializes this block state into stringified NBT
    /// </summary>
    /// <returns>Stringified NBT of this block state</returns>
    public Task<string> Serialize();
}