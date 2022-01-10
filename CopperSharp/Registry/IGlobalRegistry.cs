namespace CopperSharp.Registry;

/// <summary>
/// A global registry super-interface. It is inherited by each registry interface
/// </summary>
public interface IGlobalRegistry
{
    /// <summary>
    /// Writes the contents of registry to output stream
    /// </summary>
    /// <param name="stream">Stream, registry's contents to be written into</param>
    public void WriteTo(RegistryOutputStream stream);
}