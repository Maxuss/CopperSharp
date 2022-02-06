namespace CopperSharp.Blocks.Data.Impl;

/// <summary>
///     Represents a bubble column tile entity
/// </summary>
public sealed class BubbleColumn : AbstractBlockData
{
    /// <summary>
    ///     Whether this column drags or pushes upwards
    /// </summary>
    /// <param name="drags">Marker</param>
    /// <returns>This bubble column</returns>
    public BubbleColumn Drags(bool drags = true)
    {
        Data["drag"] = drags;
        return this;
    }
}