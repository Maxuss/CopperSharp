namespace CopperSharp.Block.Data.Impl;

/// <summary>
/// Represents a big drip leaf
/// </summary>
public sealed class BigDripleaf : Dripleaf
{
    /// <summary>
    /// Tilt of dripleaf
    /// </summary>
    public enum Tilt
    {
        /// <summary>
        /// Fully tilted
        /// </summary>
        Full,

        /// <summary>
        /// Partially tilted
        /// </summary>
        Partial,

        /// <summary>
        /// Unstable
        /// </summary>
        Unstable,

        /// <summary>
        /// No tilt
        /// </summary>
        None
    }

    /// <summary>
    /// Sets tilting of this dripleaf
    /// </summary>
    /// <param name="tilt">Type of tilt</param>
    /// <returns>This big dripleaf</returns>
    public BigDripleaf Tilted(Tilt tilt)
    {
        Data["tilt"] = Enum.GetName(tilt)?.ToLower() ?? "none";
        return this;
    }
}