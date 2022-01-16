using CopperSharp.Utils;

namespace CopperSharp.Entity;

/// <summary>
/// Type of entity selector
/// </summary>
public enum SelectorType
{
    /// <summary>
    /// Calls for nearest player near executor
    /// </summary>
    [EnumData("@p")] NearestPlayer,

    /// <summary>
    /// Calls for all players
    /// </summary>
    [EnumData("@a")] AllPlayers,

    /// <summary>
    /// Calls for all entities
    /// </summary>
    [EnumData("@e")] AllEntities,

    /// <summary>
    /// Calls for random entity
    /// </summary>
    [EnumData("@r")] RandomEntity,
}