// ReSharper disable InconsistentNaming

namespace CopperSharp.Datapack;

/// <summary>
///     Represents a format for pack
/// </summary>
public enum PackFormat : byte
{
    /// <summary>
    ///     For MC versions 1.13 to 1.14.4
    /// </summary>
    v1_13 = 4,

    /// <summary>
    ///     For MC versions 1.15 to 1.16.1
    /// </summary>
    v1_15 = 5,

    /// <summary>
    ///     For MC versions 1.16.2 to 1.16.5
    /// </summary>
    v1_16_2 = 6,

    /// <summary>
    ///     For MC versions 1.17-1.17.1
    /// </summary>
    v1_17 = 7,

    /// <summary>
    ///     For MC versions 1.18-1.18.1+
    /// </summary>
    v1_18 = 8
}