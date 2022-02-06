namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents an ender dragon entity
/// </summary>
public sealed class EnderDragon : LivingEntity
{
    internal EnderDragon() : base(EntityType.EnderDragon)
    {
    }

    /// <summary>
    ///     Sets phase of dragon fight
    /// </summary>
    /// <param name="phase">Phase to be set</param>
    /// <returns>This ender dragon</returns>
    public EnderDragon FightPhase(DragonFightPhase phase)
    {
        Ints["DragonPhase"] = (int) phase;
        return this;
    }
}

/// <summary>
///     Marks stage of dragon fight phase
/// </summary>
public enum DragonFightPhase
{
    /// <summary>
    ///     Circling around
    /// </summary>
    Circling = 0,

    /// <summary>
    ///     Preparing to shoot a fireball
    /// </summary>
    Strafing = 1,

    /// <summary>
    ///     Preparing to land
    /// </summary>
    PreparingToLand = 2,

    /// <summary>
    ///     Landing to the portal
    /// </summary>
    Landing = 3,

    /// <summary>
    ///     Taking off from the portal
    /// </summary>
    TakingOff = 4,

    /// <summary>
    ///     Landed, performing breath attacks
    /// </summary>
    Landed = 5,

    /// <summary>
    ///     Landed, looking for player
    /// </summary>
    SearchingForPlayer = 6,

    /// <summary>
    ///     Roar before breath attack
    /// </summary>
    Roaring = 7,

    /// <summary>
    ///     Charging player
    /// </summary>
    Charging = 8,

    /// <summary>
    ///     Flying to portal to die
    /// </summary>
    PreparingToDie = 9,

    /// <summary>
    ///     Hovering around with no default AI
    /// </summary>
    // ReSharper disable once InconsistentNaming
    NoDefaultAI = 10
}