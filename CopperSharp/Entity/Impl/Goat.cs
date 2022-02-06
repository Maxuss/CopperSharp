namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents a goat entity
/// </summary>
public sealed class Goat : BreedableEntity
{
    internal Goat() : base(EntityType.Goat)
    {
    }

    /// <summary>
    ///     Whether this goat is screaming
    /// </summary>
    /// <param name="screaming">Marker</param>
    /// <returns>This goat</returns>
    public Goat Screaming(bool screaming = true)
    {
        Bools["IsScreamingGoat"] = screaming;
        return this;
    }
}