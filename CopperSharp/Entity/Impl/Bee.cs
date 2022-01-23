using CopperSharp.Data.Locations;
using CopperSharp.Data.SNbt;

namespace CopperSharp.Entity.Impl;

/// <summary>
/// Represents a bee entity
/// </summary>
public sealed class Bee : BreedableEntity, IAngerableEntity
{
    internal Bee() : base(EntityType.Bee)
    {
    }

    private Guid? AngryAt { get; set; }
    private Location? FlowerPos { get; set; }
    private Location? HivePos { get; set; }

    /// <inheritdoc />
    public IAngerableEntity AngryOn(Guid id)
    {
        AngryAt = id;
        return this;
    }

    /// <inheritdoc />
    public IAngerableEntity AngerTime(int duration)
    {
        Ints["AngerTime"] = duration;
        return this;
    }

    /// <summary>
    /// Sets the amount of time the bee can not enter the hive
    /// </summary>
    /// <param name="ticks">Amount of time in ticks</param>
    /// <returns>This bee</returns>
    public Bee CantEnterHiveTicks(int ticks)
    {
        Ints["CannotEnterHiveTicks"] = ticks;
        return this;
    }

    /// <summary>
    /// How many crops the bee has grown since its last pollination
    /// </summary>
    /// <param name="crops">The amount of crops</param>
    /// <returns>This bee</returns>
    public Bee CropsGrownSincePollination(int crops)
    {
        Ints["CropsGrownSincePollination"] = crops;
        return this;
    }

    /// <summary>
    /// Coordinates of the flower the bee is circling. 
    /// </summary>
    /// <param name="loc">The location</param>
    /// <returns>This bee</returns>
    public Bee FlowerLocation(Location loc)
    {
        FlowerPos = loc;
        return this;
    }

    /// <summary>
    /// Marks whether the bee has nectar
    /// </summary>
    /// <param name="has">Whether the bee has nectar</param>
    /// <returns>This bee</returns>
    public Bee HasNectar(bool has)
    {
        Bools["HasNectar"] = has;
        return this;
    }

    /// <summary>
    /// Marks whether the bee has already stung
    /// </summary>
    /// <param name="has">Whether the bee has stung</param>
    /// <returns>This bee</returns>
    public Bee HasStung(bool has)
    {
        Bools["HasStung"] = has;
        return this;
    }

    /// <summary>
    /// Sets coordinates of the bee's hive.
    /// </summary>
    /// <param name="loc">The location</param>
    /// <returns>This bee</returns>
    public Bee HiveLocation(Location loc)
    {
        HivePos = loc;
        return this;
    }

    /// <summary>
    /// Sets the number of ticks passed since the bee's last pollination.
    /// </summary>
    /// <param name="ticks">Amount of time in ticks</param>
    /// <returns>This bee</returns>
    public Bee TicksSincePollination(int ticks)
    {
        Ints["TicksSincePollination"] = ticks;
        return this;
    }

    /// <inheritdoc />
    protected override void SerializeExtra(StringNbtWriter sw)
    {
        base.SerializeExtra(sw);

        if (AngryAt != null)
            sw.WriteUuidArray("AngryAt", AngryAt ?? default);

        if (FlowerPos != null)
            sw.WritePosition("FlowerPos", FlowerPos ?? default);

        if (HivePos != null)
            sw.WritePosition("HivePos", HivePos ?? default);
    }
}