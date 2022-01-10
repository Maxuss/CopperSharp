using CopperSharp.Functions;
using CopperSharp.Modules;

namespace CopperSharp.Registry;

/// <summary>
/// This registry is used to register functions for datapacks.
/// <br/> <br/>
/// You <b>should not</b> implement this interface, as <see cref="Module"/>
/// already has <see cref="ModuleRegistry"/>, which implements this interface
/// </summary>
public interface IFunctionRegistry : IGlobalRegistry
{
    /// <summary>
    /// Functions inside this registry
    /// </summary>
    public List<IFunction> Elements { get; set; }


    /// <summary>
    /// Registers the function into registry
    /// </summary>
    /// <param name="registrable">Function to be registered</param>
    public void Register(IFunction registrable);

    void IGlobalRegistry.WriteTo(RegistryOutputStream stream)
    {
        if (RegistryOutputStream)
    }
}