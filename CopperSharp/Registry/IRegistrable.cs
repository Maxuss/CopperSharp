namespace CopperSharp.Registry;

/// <summary>
///     Represents an element, that can be registered in registries
/// </summary>
public interface IRegistrable
{
    /// <summary>
    ///     Relative path to the registrable
    /// </summary>
    public string PathTo { get; set; }

    /// <summary>
    ///     Builds this registry element to string
    /// </summary>
    /// <returns>Build registry element</returns>
    public string Build();
}