using CopperSharp.Functions;

namespace CopperSharp.Modules;

/// <summary>
/// This registry is used to register functions for datapacks.
/// <br/> <br/>
/// You <b>should not</b> implement this interface, as <see cref="Module"/>
/// already has <see cref="ModuleRegistry"/>, which implements this interface
/// </summary>
public interface IFunctionRegistry
{
    /// <summary>
    /// Actions to be used
    /// </summary>
    public List<IAction> Actions { get; set; }
}