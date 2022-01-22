using CopperSharp.Text;
using CopperSharp.Utils;

namespace CopperSharp.Entity;

/// <summary>
/// A global interface for entity
/// </summary>
public abstract class AbstractEntity
{
    private short? Air { get; set; }
    private bool? Glowing { get; set; }
    private bool? HasVisualFire { get; set; }
    private bool? Invulnerable { get; set; }
    private bool? Silent { get; set; }
    private IComponent? CustomName { get; set; }
    private bool? CustomNameVisible { get; set; }
    private Vec3? Motion { get; set; }
    private Vec2? Rotation { get; set; }
    private List<AbstractEntity> Passengers { get; set; } = new();

    /// <summary>
    /// Makes this entity silent, not making any noise at all
    /// </summary>
    /// <param name="silent">Whether to make this entity silent</param>
    /// <returns>This entity</returns>
    public AbstractEntity SetSilent(bool silent)
    {
        Silent = silent;
        return this;
    }

    /// <summary>
    /// Makes the entity immune to all attacks
    /// </summary>
    /// <param name="immune">Whether to make entity immune to all attacks</param>
    /// <returns>This entity</returns>
    public AbstractEntity Invulnerability(bool immune)
    {
        Invulnerable = immune;
        return this;
    }

    /// <summary>
    /// Configures the left amount of breathing air for this entity
    /// </summary>
    /// <returns>This entity</returns>
    public AbstractEntity BreathingAirLeft(short air)
    {
        Air = air;
        return this;
    }

    /// <summary>
    /// Adds a visual-only fire effect to this entity
    /// </summary>
    /// <returns>This entity</returns>
    public AbstractEntity VisualFire()
    {
        HasVisualFire = true;
        return this;
    }

    /// <summary>
    /// Applies a glowing effect to this entity
    /// </summary>
    /// <param name="glow">Whether the entity should glow</param>
    /// <returns>This entity</returns>
    public AbstractEntity Glow(bool glow = true)
    {
        Glowing = glow;
        return this;
    }

    /// <summary>
    /// Sets custom name of this entity
    /// </summary>
    /// <param name="name">New name of this entity</param>
    /// <param name="alwaysVisible">Whether the name should be always visible</param>
    /// <returns>This entity</returns>
    public AbstractEntity Name(IComponent name, bool alwaysVisible = false)
    {
        CustomName = name;
        CustomNameVisible = alwaysVisible;
        return this;
    }

    /// <summary>
    /// Applies a provided rotation to this entity
    /// </summary>
    /// <returns>This entity</returns>
    public AbstractEntity Rotate(Vec2 rotation)
    {
        Rotation = rotation;
        return this;
    }

    /// <summary>
    /// Applies a provided rotation to this entity
    /// </summary>
    /// <param name="pitch">Pitch rotation of this entity</param>
    /// <param name="yaw">Yaw rotation of this entity</param>
    /// <returns>This entity</returns>
    public AbstractEntity Rotate(float pitch, float yaw)
    {
        Rotation = new Vec2(pitch, yaw);
        return this;
    }

    /// <summary>
    /// Applies a provided velocity to this entity
    /// </summary>
    /// <param name="motion">Velocity to be applied</param>
    /// <returns>This entity</returns>
    public AbstractEntity Velocity(Vec3 motion)
    {
        Motion = motion;
        return this;
    }

    /// <summary>
    /// Gets velocity of this entity
    /// </summary>
    /// <returns>This entity's velocity</returns>
    public Vec3? Velocity() => Motion;

    /// <summary>
    /// Gets rotation of this entity
    /// </summary>
    /// <returns>This entity's rotation</returns>
    public Vec2? EntityRotation() => Rotation;

    /// <summary>
    /// Adds all provided entities as passengers to this entity
    /// </summary>
    /// <param name="passengers">Passengers to be added</param>
    /// <returns>This entity</returns>
    public AbstractEntity AddPassengers(params AbstractEntity[] passengers)
    {
        Passengers.AddRange(passengers);
        return this;
    }
}