using CopperSharp.Functions;

namespace CopperSharp.Registry;

/// <summary>
///     This registry is used to register functions for datapacks.
///     <br /> <br />
///     You <b>should not</b> implement this interface, as it is already
///     implemented internally
/// </summary>
public interface IFunctionRegistry : IRegistry<IFunction>
{
}