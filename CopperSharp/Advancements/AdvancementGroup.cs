using CopperSharp.Registry;

namespace CopperSharp.Advancements;

/// <summary>
/// Represents a group of advancements, sharing the same tab and background
/// </summary>
public readonly struct AdvancementGroup
{
    /// <summary>
    /// Background block of this advancement group
    /// </summary>
    public Identifier Background { get; }

    /// <summary>
    /// Creates a new advancement group
    /// </summary>
    /// <param name="background">Background block of this group</param>
    public AdvancementGroup(Identifier background)
    {
        Background = background;
    }
}