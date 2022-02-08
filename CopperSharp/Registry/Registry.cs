using CopperSharp.Advancements;
using CopperSharp.Functions;

namespace CopperSharp.Registry;

/// <summary>
/// An abstract super class for registries
/// </summary>
public abstract class Registry<TElement>
{
    /// <summary>
    /// Stack of elements inside this registry
    /// </summary>
    protected Stack<(TElement, Identifier)> Stack { get; set; } = new();

    /// <summary>
    /// Transforms provided element into it's string representation
    /// </summary>
    /// <param name="element">Element to be transformed</param>
    /// <returns>String representation</returns>
    protected abstract string Transform(TElement element);

    /// <summary>
    /// Registers provided element in current registry
    /// </summary>
    /// <param name="element">Element to be registered</param>
    /// <param name="id">ID of element to be registered</param>
    /// <returns>The provided element</returns>
    public abstract TElement Register(TElement element, Identifier id);

    /// <summary>
    /// Looks up provided element in this registry
    /// </summary>
    /// <param name="element">Element to be looked up</param>
    /// <returns>Found identifier of element, or null</returns>
    public Identifier? Seek(TElement element)
    {
        var filtered = Stack.Where(it => it.Item1?.Equals(element) == true);
        var valueTuples = filtered.ToList();
        if (!valueTuples.Any())
            return null;
        return valueTuples[0].Item2;
    }
}

/// <summary>
/// Class, containing all global registries
/// </summary>
public static class Registries
{
    /// <summary>
    /// Global function registry
    /// </summary>
    public static Registry<IFunction> Functions { get; } = new FunctionRegistry();

    /// <summary>
    /// Global advancement registry
    /// </summary>
    public static Registry<Advancement> Advancements { get; } = new AdvancementRegistry();
    
    /// <summary>
    /// Registers provided element in provided registry
    /// </summary>
    /// <param name="registry">Registry in which to register the element</param>
    /// <param name="element">Element to be registered</param>
    /// <param name="id">ID of element. Not recommended to have minecraft's namespace.</param>
    /// <typeparam name="TRegistrable">Type of registrable element</typeparam>
    /// <returns>The provided element</returns>
    public static TRegistrable Register<TRegistrable>(Registry<TRegistrable> registry, TRegistrable element, Identifier id)
        => registry.Register(element, id);
}