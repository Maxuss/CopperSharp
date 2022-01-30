namespace CopperSharp.Block;

/// <summary>
/// Represents an orientable tile entity
/// </summary>
public interface IOrientable : ITileEntity
{
    /// <summary>
    /// Sets axis rotation of this orientable entity
    /// </summary>
    /// <param name="axis">Axis to be set</param>
    /// <returns>This orientable entity</returns>
    public IOrientable Axis(Axis axis);
}

/// <summary>
/// Represents axis in the world
/// </summary>
public enum Axis
{
    /// <summary>
    /// The X horizontal axis
    /// </summary>
    X,

    /// <summary>
    /// The Y vertical axis
    /// </summary>
    Y,

    /// <summary>
    /// The Z horizontal axis
    /// </summary>
    Z
}