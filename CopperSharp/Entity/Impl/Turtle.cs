using CopperSharp.Data.Locations;

namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents a turtle entity
/// </summary>
public sealed class Turtle : BreedableEntity
{
    internal Turtle() : base(EntityType.Turtle)
    {
    }

    /// <summary>
    ///     Sets whether this turtle has an egg
    /// </summary>
    /// <param name="has">Marker</param>
    /// <returns>This turtle</returns>
    public Turtle HasEgg(bool has = true)
    {
        Bools["HasEgg"] = has;
        return this;
    }

    /// <summary>
    ///     Sets home location, where this turtle will lay eggs after breeding
    /// </summary>
    /// <param name="home">Location to be set</param>
    /// <returns>This turtle</returns>
    public Turtle HomeLocation(Location home)
    {
        Ints["HomePosX"] = (int) home.X.Value;
        Ints["HomePosY"] = (int) home.Y.Value;
        Ints["HomePosZ"] = (int) home.Z.Value;
        return this;
    }

    /// <summary>
    ///     Location for swimming in random points in water
    /// </summary>
    /// <param name="travel">Location to which this turtle will travel</param>
    /// <returns>This turtle</returns>
    public Turtle TravelLocation(Location travel)
    {
        Ints["TravelPosX"] = (int) travel.X.Value;
        Ints["TravelPosX"] = (int) travel.X.Value;
        Ints["TravelPosX"] = (int) travel.X.Value;
        return this;
    }
}