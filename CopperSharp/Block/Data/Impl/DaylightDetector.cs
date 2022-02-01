namespace CopperSharp.Block.Data.Impl;

/// <summary>
/// Represents a daylight detector block
/// </summary>
public class DaylightSensor : AbstractBlockData, ISignalEmitter
{
    /// <inheritdoc />
    public ISignalEmitter Power(int power)
    {
        Data["power"] = Math.Clamp(power, 0, 15);
        return this;
    }

    /// <summary>
    /// Whether this daylight detector is inverted
    /// </summary>
    /// <param name="inverted">Marker</param>
    /// <returns>This daylight sensor</returns>
    public DaylightSensor Inverted(bool inverted = true)
    {
        Data["inverted"] = inverted;
        return this;
    }
}