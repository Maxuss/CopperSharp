using CopperSharp.Item;

namespace CopperSharp.Blocks.State;

/// <summary>
///     Represents a default block state
/// </summary>
public sealed class DefaultBlockState : BlockState
{
    internal DefaultBlockState(Material id) : base(id)
    {
    }
}