using CopperSharp.Data.Locations;

namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents a dolphin entity
/// </summary>
public sealed class Dolphin : LivingEntity
{
    internal Dolphin(EntityType type) : base(type)
    {
    }

    /// <summary>
    ///     If true, this dolphin can lead a player to treasure.
    /// </summary>
    /// <param name="can">Marker to set</param>
    /// <returns>This dolphin</returns>
    public Dolphin CanFindTreasure(bool can = true)
    {
        Bools["CanFindTreasure"] = can;
        return this;
    }

    /// <summary>
    ///     If true, this dolphin got fish from a player.
    /// </summary>
    /// <param name="got">Marker to set</param>
    /// <returns>This dolphin</returns>
    public Dolphin GotFish(bool got = true)
    {
        Bools["GotFish"] = got;
        return this;
    }

    /// <summary>
    ///     The coordinates to which the dolphin can lead the player
    /// </summary>
    /// <param name="treasure">Treasure location</param>
    /// <returns>This dolphin</returns>
    public Dolphin TreasureLocation(Location treasure)
    {
        Ints["TreasurePosX"] = (int) treasure.X.Value;
        Ints["TreasurePosY"] = (int) treasure.Y.Value;
        Ints["TreasurePosZ"] = (int) treasure.Z.Value;
        return this;
    }
}