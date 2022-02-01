namespace CopperSharp.Block.Data.Impl;

/// <summary>
/// Represents a scaffolding block
/// </summary>
public sealed class Scaffolding : AbstractBlockData, IWaterlogged
{
    /// <inheritdoc />
    public IWaterlogged Waterlogged(bool logged)
    {
        Data["waterlogged"] = logged;
        return this;
    }

    /// <summary>
    /// Whether this scaffolding is the bottom one, and will never fall
    /// </summary>
    /// <param name="btm">Marker</param>
    /// <returns>This scaffolding</returns>
    public Scaffolding Bottom(bool btm = true)
    {
        Data["bottom"] = btm;
        return this;
    }

    /// <summary>
    /// Amount of distance to the bottom scaffolding from this one
    /// </summary>
    /// <param name="distance">Distance in range of 0 to 7</param>
    /// <returns>This scaffolding</returns>
    public Scaffolding BottomDistance(int distance)
    {
        Data["distance"] = Math.Clamp(distance, 0, 7);
        return this;
    }
}