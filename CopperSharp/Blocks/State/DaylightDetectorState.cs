using CopperSharp.Item;

namespace CopperSharp.Blocks.State;

/// <summary>
///     Represents a daylight detector block state
/// </summary>
public sealed class DaylightDetectorState : BlockState
{
    internal DaylightDetectorState(Material id) : base(id)
    {
    }
}