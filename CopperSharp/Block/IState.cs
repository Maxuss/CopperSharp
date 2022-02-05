using CopperSharp.Block.Data;
using CopperSharp.Data.SNbt;

namespace CopperSharp.Block;

/// <summary>
/// An interface for block states
/// </summary>
public interface IState
{
    /// <summary>
    /// Extra data on this block
    /// </summary>
    public IBlockData? BlockData { get; set; }

    /// <summary>
    /// Serializes this block state into stringified NBT
    /// </summary>
    /// <returns>Stringified NBT of this block state</returns>
    public string Serialize();
}