using CopperSharp.Data.Locations;
using CopperSharp.Data.SNbt;

namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents an end crystal entity
/// </summary>
public sealed class EndCrystal : AbstractEntity
{
    internal EndCrystal() : base(EntityType.EndCrystal)
    {
    }

    private Location? BeamTarget { get; set; }

    /// <summary>
    ///     Sets beam target of this end crystal
    /// </summary>
    /// <param name="loc">Location to which the beam targets</param>
    /// <returns>This end crystal</returns>
    public EndCrystal Target(Location loc)
    {
        BeamTarget = loc;
        return this;
    }

    /// <summary>
    ///     Whether to show bedrock statue beneath the crystal
    /// </summary>
    /// <param name="show">Marker</param>
    /// <returns>This end crystal</returns>
    public EndCrystal ShowBottom(bool show = true)
    {
        Bools["ShowBottom"] = show;
        return this;
    }

    /// <inheritdoc />
    protected override void SerializeExtra(StringNbtWriter sw)
    {
        base.SerializeExtra(sw);

        if (BeamTarget == null)
            return;

        sw.WritePosition("BeamTarget", BeamTarget ?? default);
    }
}