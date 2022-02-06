namespace CopperSharp.Blocks.Data.Impl;

/// <summary>
///     Represents a layered snow block
/// </summary>
public sealed class Snow : AbstractBlockData
{
    /// <summary>
    ///     Sets amount of snow layers inside this block
    /// </summary>
    /// <param name="layers">Amount of layers in range of 1 to 8</param>
    /// <returns>This snow</returns>
    public Snow Layers(int layers)
    {
        Data["layers"] = Math.Clamp(layers, 1, 8);
        return this;
    }
}