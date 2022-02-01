namespace CopperSharp.Block.Data.Impl;

/// <summary>
/// Represents a leaves block
/// </summary>
public sealed class Leaves : AbstractBlockData
{
    /// <summary>
    /// Distance to nearest wood log block
    /// </summary>
    /// <param name="distance">Distance to be set</param>
    /// <returns>These leaves</returns>
    public Leaves LogDistance(int distance)
    {
        Data["distance"] = Math.Clamp(distance, 1, 7);
        return this;
    }

    /// <summary>
    /// Whether these leaves are persistent, and wont disappear
    /// even when there is no wood nearby
    /// </summary>
    /// <param name="persist">Marker</param>
    /// <returns>These leaves</returns>
    public Leaves Persistent(bool persist)
    {
        Data["persistent"] = persist;
        return this;
    }
}