namespace CopperSharp.Entity.Impl;

/// <summary>
/// Represents an ocelot entity
/// </summary>
public sealed class Ocelot : BreedableEntity
{
    internal Ocelot() : base(EntityType.Ocelot)
    {
    }

    /// <summary>
    /// True if this ocelot trusts players
    /// </summary>
    /// <param name="trusts">Marker</param>
    /// <returns>This ocelot</returns>
    public Ocelot Trusts(bool trusts = true)
    {
        Bools["Trusting"] = trusts;
        return this;
    }
}