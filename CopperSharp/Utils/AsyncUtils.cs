namespace CopperSharp.Utils;

/// <summary>
///     Contains several utilities for async methods
/// </summary>
public static class AsyncUtils
{
    /// <summary>
    ///     An empty compound task
    /// </summary>
    public static Task<string> EmptyCompoundTask => new(() => "{}");
}