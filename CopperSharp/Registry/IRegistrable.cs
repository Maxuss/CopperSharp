namespace CopperSharp.Registry;

/// <summary>
/// Represents an element, that can be registered in <see cref="IGlobalRegistry"/>s
/// </summary>
public interface IRegistrable
{
    /// <summary>
    /// Builds this registry element to string
    /// </summary>
    /// <returns>Build registry element</returns>
    public string Build();
}