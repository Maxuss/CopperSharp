using CopperSharp.Utils;

namespace CopperSharp.Entity;

/// <summary>
/// Represents a player statistic
/// </summary>
public enum PlayerStatistic
{
    /// <summary>
    /// Custom statistic
    /// </summary>
    [EnumData("custom")] Custom,
    /// <summary>
    /// Amount of items crafted
    /// </summary>
    [EnumData("custom")] Crafted,
    /// <summary>
    /// Amount of times item used
    /// </summary>
    [EnumData("custom")] Used,
    /// <summary>
    /// Amount of times item broken
    /// </summary>
    [EnumData("custom")] Broken,
    /// <summary>
    /// Amount of blocks mined
    /// </summary>
    [EnumData("custom")] Mined,
    /// <summary>
    /// Amount of entities killed
    /// </summary>
    [EnumData("custom")] Killed,
    /// <summary>
    /// Amount of items picked up
    /// </summary>
    [EnumData("custom")] PickedUp,
    /// <summary>
    /// Amount of items dropped
    /// </summary>
    [EnumData("custom")] Dropped,
    /// <summary>
    /// Amount of times died
    /// </summary>
    [EnumData("custom")] KilledBy
}