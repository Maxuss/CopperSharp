namespace CopperSharp.Utils;

/// <summary>
/// Represents a rotation vector
/// </summary>
public readonly struct Vec2
{
    /// <summary>
    /// Constructs a new rotation vector
    /// </summary>
    /// <param name="pitch">Pitch of the vec</param>
    /// <param name="yaw">Yaw of the vec</param>
    public Vec2(float pitch, float yaw)
    {
        Pitch = pitch;
        Yaw = yaw;
    }

    /// <summary>
    /// Yaw (rotation clockwise) of the vector
    /// </summary>
    public float Yaw { get; }

    /// <summary>
    /// Pitch (declination from the horizon) of the vector
    /// </summary>
    public float Pitch { get; }
}