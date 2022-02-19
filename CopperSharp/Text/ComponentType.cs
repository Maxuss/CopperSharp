namespace CopperSharp.Text;

/// <summary>
///     Type of component
/// </summary>
public enum ComponentType
{
    /// <summary>
    ///     Default raw text component
    /// </summary>
    Text,

    /// <summary>
    ///     Translatable key component
    /// </summary>
    Translatable,

    /// <summary>
    ///     Scoreboard score component
    /// </summary>
    Scoreboard,

    /// <summary>
    ///     Entity selector component
    /// </summary>
    Entity,

    /// <summary>
    ///     A keybind component
    /// </summary>
    Keybind,

    /// <summary>
    ///     NBT data component
    /// </summary>
    Nbt
}