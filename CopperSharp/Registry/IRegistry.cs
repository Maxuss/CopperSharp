using System.Runtime.CompilerServices;
using CopperSharp.Registry.Impl;

namespace CopperSharp.Registry;

/// <summary>
/// A super-interface for all registries to implement. It also contains all registries as static fields.
/// </summary>
/// <typeparam name="TElement">Type of element stored in registry</typeparam>
public interface IRegistry<TElement> where TElement : IRegistrable
{
    /// <summary>
    /// Registers element, allowing to later write it to stream
    /// </summary>
    /// <param name="element">Element to be registered</param>
    public void Register(TElement element);

    /// <summary>
    /// Writes data inside this registry to provided output stream
    /// </summary>
    /// <param name="stream">Stream the contents to be written into</param>
    public void WriteTo(RegistryOutputStream<TElement> stream);

    /// <summary>
    /// Clears the contents of this registry
    /// </summary>
    public void Flush();

    /// <summary>
    /// Static instance of functions registry
    /// </summary>
    public static IFunctionRegistry Functions = new FunctionRegistryImpl();

    /// <summary>
    /// Registers an element to provided registry and returns it
    /// </summary>
    /// <param name="registry">Registry for element to be registered into</param>
    /// <param name="element">Element to be registered</param>
    /// <typeparam name="TWhat">Type of registrant</typeparam>
    /// <returns>Provided <paramref name="element"/></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TWhat Register<TWhat>(IRegistry<TWhat> registry, TWhat element)
        where TWhat : IRegistrable
    {
        registry.Register(element);
        return element;
    }

    /// <summary>
    /// Flushes the contents of provided registry into stream
    /// </summary>
    /// <param name="registry">Registry, contents of which to be flushed</param>
    /// <param name="stream">Stream to which the contents of registry should be flushed</param>
    /// <typeparam name="TWhat">Type of element in registry</typeparam>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Flush<TWhat>(IRegistry<TWhat> registry, RegistryOutputStream<TWhat> stream)
        where TWhat : IRegistrable
    {
        registry.WriteTo(stream);
        registry.Flush();
    }
}