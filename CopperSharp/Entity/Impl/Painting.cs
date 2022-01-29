using CopperSharp.Registry;

namespace CopperSharp.Entity.Impl;

/// <summary>
/// Represents a painting entity
/// </summary>
public sealed class Painting : AbstractEntity
{
    internal Painting() : base(EntityType.Painting)
    {
    }

    /// <summary>
    /// Sets style of this painting
    /// </summary>
    /// <param name="motive">Motive of painting</param>
    /// <returns>This painting</returns>
    public Painting Style(Identifier motive)
    {
        Strings["Motive"] = motive.ToString();
        return this;
    }
}