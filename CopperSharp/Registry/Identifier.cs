namespace CopperSharp.Registry;

/// <summary>
/// A namespace:path pair, used to represent a lot of things, such as item ids, functions and more
/// </summary>
public readonly struct Identifier
{
    /// <summary>
    /// Namespace of this identifier
    /// </summary>
    public readonly string Namespace;

    /// <summary>
    /// Path of this identifier
    /// </summary>
    public readonly string Path;

    private Identifier(string @namespace, string path)
    {
        Namespace = @namespace;
        Path = path;
    }

    /// <summary>
    /// Creates a new identifier with minecraft namespace
    /// </summary>
    /// <param name="path">Path of the identifier</param>
    public static Identifier Minecraft(string path)
        => new("minecraft", path);

    /// <summary>
    /// Creates a new identifier with provided namespace and path
    /// </summary>
    /// <param name="ns">Namespace of the identifier</param>
    /// <param name="path">Path of the identifier</param>
    public static Identifier Of(string ns, string path)
        => new(ns, path);

    /// <summary>
    /// Converts this identifier to minecraft-readable string
    /// </summary>
    public override string ToString()
    {
        return $"{Namespace}:{Path}";
    }
}