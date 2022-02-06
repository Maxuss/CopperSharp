using CopperSharp.Utils;

namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents a boat vehicle
/// </summary>
public sealed class Boat : AbstractEntity
{
    internal Boat() : base(EntityType.Boat)
    {
    }

    /// <summary>
    ///     Sets style of boat
    /// </summary>
    /// <param name="type">Type of boat to be set</param>
    /// <returns>This boat</returns>
    public Boat Style(WoodType type)
    {
        Strings["Type"] = type.GetData() ?? "oak";
        return this;
    }
}