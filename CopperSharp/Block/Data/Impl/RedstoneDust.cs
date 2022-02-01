namespace CopperSharp.Block.Data.Impl;

/// <summary>
/// Represents a redstone dust block
/// </summary>
public sealed class RedstoneDust : AbstractBlockData, ISignalEmitter
{
    /// <summary>
    /// Type of redstone dust connection
    /// </summary>
    public enum Connection
    {
        /// <summary>
        /// Not connected
        /// </summary>
        None,

        /// <summary>
        /// Connected to the side
        /// </summary>
        Side,

        /// <summary>
        /// Connected ascending
        /// </summary>
        Up
    }

    /// <inheritdoc />
    public ISignalEmitter Power(int power)
    {
        Data["power"] = Math.Clamp(power, 0, 15);
        return this;
    }

    /// <summary>
    /// Sets connection of this redstone dust
    /// </summary>
    /// <param name="face">Face to be connected to</param>
    /// <param name="connection">Type of connection</param>
    /// <returns>This redstone dust</returns>
    public RedstoneDust Connect(BlockFace face, Connection connection)
    {
        if (!face.Cartesian)
            return this;

        Data[face.Name] = Enum.GetName(connection)?.ToLower() ?? "none";
        return this;
    }
}