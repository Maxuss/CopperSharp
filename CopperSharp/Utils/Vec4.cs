namespace CopperSharp.Utils;

/// <summary>
/// Represents a vector of 4 elements
/// </summary>
/// <typeparam name="TValue">Type of value stored inside the vec</typeparam>
public struct Vec4<TValue>
{
    /// <summary>
    /// First element
    /// </summary>
    public TValue? Item1 { get; set; } = default;

    /// <summary>
    /// Second element
    /// </summary>
    public TValue? Item2 { get; set; } = default;

    /// <summary>
    /// Third element
    /// </summary>
    public TValue? Item3 { get; set; } = default;

    /// <summary>
    /// Fourth element
    /// </summary>
    public TValue? Item4 { get; set; } = default;
}

/// <summary>
/// Represents a typed vector of 2 elements
/// </summary>
/// <typeparam name="TValue">Type of value stored inside the vec</typeparam>
public struct TypedVec2<TValue>
{
    /// <summary>
    /// First element
    /// </summary>
    public TValue? Item1 { get; set; } = default;

    /// <summary>
    /// Second element
    /// </summary>
    public TValue? Item2 { get; set; } = default;
}