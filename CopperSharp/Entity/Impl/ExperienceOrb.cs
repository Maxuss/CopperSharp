namespace CopperSharp.Entity.Impl;

/// <summary>
/// Represents an experience orb entity
/// </summary>
public sealed class ExperienceOrb : AbstractEntity
{
    internal ExperienceOrb() : base(EntityType.ExperienceOrb)
    {
    }

    /// <summary>
    /// Count of orbs inside this orb.
    /// </summary>
    /// <param name="size">Count to be set</param>
    /// <returns>This experience orb</returns>
    public ExperienceOrb Size(int size)
    {
        Ints["Count"] = size;
        return this;
    }

    /// <summary>
    /// Sets age of this experience org. When age reaches 6000 ticks, the orb disappears
    /// </summary>
    /// <param name="age">Age to be set</param>
    /// <returns>This experience orb</returns>
    public ExperienceOrb Age(short age)
    {
        Ints["Age"] = age;
        return this;
    }

    /// <summary>
    /// Sets health of this experience orb.
    /// Orbs get destroyed when health reaches 0.
    /// </summary>
    /// <param name="health">Health to be set</param>
    /// <returns>This experience orb</returns>
    public ExperienceOrb Health(short health)
    {
        Ints["Health"] = health;
        return this;
    }

    /// <summary>
    /// Sets experience value of this orb
    /// </summary>
    /// <param name="amount">Amount of experience to be set</param>
    /// <returns>This experience orb</returns>
    public ExperienceOrb Experience(short amount)
    {
        Ints["Value"] = amount;
        return this;
    }
}