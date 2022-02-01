namespace CopperSharp.Block.Impl;

/// <summary>
/// Represents a slab block
/// </summary>
public sealed class Slab : AbstractBlockData, IWaterlogged
{
    /// <inheritdoc />
    public IWaterlogged Waterlogged(bool logged)
    {
        Data["waterlogged"] = logged;
        return this;
    }

    /// <summary>
    /// Sets this slab as double slab
    /// </summary>
    /// <param name="dbl">Whether to make this slab double</param>
    /// <returns>This slab</returns>
    public Slab Double(bool dbl = true)
    {
        Data["type"] = dbl ? "double" : "top";
        return this;
    }

    /// <summary>
    /// Sets this slab as bottom slab
    /// </summary>
    /// <param name="btm">True for bottom slab, false for top slab</param>
    /// <returns>This slab</returns>
    public Slab Bottom(bool btm = true)
    {
        Data["type"] = btm ? "bottom" : "top";
        return this;
    }
}