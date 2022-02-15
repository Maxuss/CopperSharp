namespace CopperSharp.Modules;

/// <summary>
///     Contains a single author of this module
/// </summary>
[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
public sealed class ModuleAuthorAttribute : Attribute
{
    /// <summary>
    ///     Constructs a new module author attribute
    /// </summary>
    /// <param name="author">Name of the author</param>
    public ModuleAuthorAttribute(string author)
    {
        Author = author;
    }

    /// <summary>
    ///     Author's name
    /// </summary>
    public string Author { get; set; }
}