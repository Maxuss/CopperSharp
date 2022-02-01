namespace CopperSharp.Block.Impl;

/// <summary>
/// Represents a sculk sensor block
/// </summary>
public sealed class SculkSensor :
    AbstractBlockData,
    ISignalEmitter,
    IWaterlogged
{
    /// <summary>
    /// Represents phase of sculk sensor
    /// </summary>
    public enum Phase
    {
        /// <summary>
        /// Sensor is active
        /// </summary>
        Active,

        /// <summary>
        /// Sensor is inactive
        /// </summary>
        Inactive,

        /// <summary>
        /// Sensor is on cooldown
        /// </summary>
        Cooldown
    }

    /// <inheritdoc />
    public ISignalEmitter Power(int power)
    {
        Data["power"] = Math.Clamp(power, 0, 15);
        return this;
    }

    /// <inheritdoc />
    public IWaterlogged Waterlogged(bool logged)
    {
        Data["waterlogged"] = logged;
        return this;
    }

    /// <summary>
    /// Sets this sensor's phase
    /// </summary>
    /// <param name="phase">Phase to be set</param>
    /// <returns>This sculk sensor</returns>
    public SculkSensor SetPhase(Phase phase)
    {
        Data["sculk_sensor_phase"] = Enum.GetName(phase)?.ToLower() ?? "cooldown";
        return this;
    }
}