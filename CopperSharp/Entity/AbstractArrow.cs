namespace CopperSharp.Entity;

/// <summary>
///     An abstract super class for arrows
/// </summary>
public abstract class AbstractArrow : Projectile
{
    /// <inheritdoc />
    protected AbstractArrow(EntityType type) : base(type)
    {
    }

    /// <summary>
    ///     Whether this arrow will crit
    /// </summary>
    /// <param name="crits">Marker</param>
    /// <returns>This abstract arrow</returns>
    public AbstractArrow Crits(bool crits)
    {
        Bools["crit"] = crits;
        return this;
    }

    /// <summary>
    ///     Sets damage multiplier of this arrow. Default is 2.0
    /// </summary>
    /// <param name="mul">New damage multiplier</param>
    /// <returns>This abstract arrow</returns>
    public AbstractArrow DamageMultiplier(double mul)
    {
        Doubles["damage"] = mul;
        return this;
    }

    /// <summary>
    ///     Sets an extra pick up policy for this arrow
    /// </summary>
    /// <param name="ap">Pick up policy</param>
    /// <returns>This abstract arrow</returns>
    public AbstractArrow Pickup(ArrowPickup ap)
    {
        Bytes["pickup"] = (byte) ap;
        return this;
    }

    /// <summary>
    ///     Amount of targets this arrow can pierce
    /// </summary>
    /// <param name="left">Amount of targets left to pierce</param>
    /// <returns>This abstract arrow</returns>
    public AbstractArrow PiercesLeft(byte left)
    {
        Bytes["PierceLevel"] = left;
        return this;
    }

    /// <summary>
    ///     A hit sound to be played when this arrow hits something
    /// </summary>
    /// <param name="sound">Sound event to be played</param>
    /// <returns>This abstract arrow</returns>
    public AbstractArrow HitSound(string sound)
    {
        Strings["SoundEvent"] = sound;
        return this;
    }
}

/// <summary>
///     Represents an extra state for arrow pickups
/// </summary>
public enum ArrowPickup : byte
{
    /// <summary>
    ///     No one can pick up this arrow
    /// </summary>
    NoPickup = 0,

    /// <summary>
    ///     All players can pick up this arrow
    /// </summary>
    PlayerPickup = 1,

    /// <summary>
    ///     Only players in creative can pick up this arrow
    /// </summary>
    CreativePickup = 2
}