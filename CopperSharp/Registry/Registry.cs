using CopperSharp.Advancements;
using CopperSharp.Functions;
using CopperSharp.Modules;

namespace CopperSharp.Registry;

/// <summary>
/// An abstract super class for registries
/// </summary>
public abstract class Registry<TElement>
{
    /// <summary>
    /// Name of this registry port
    /// </summary>
    protected abstract string Name { get; } 
    
    /// <summary>
    /// Stack of elements inside this registry
    /// </summary>
    protected Stack<(TElement, Identifier)> Stack { get; set; } = new();

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

    /// <summary>
    /// Writes data to provided stream
    /// </summary>
    /// <param name="element">Element to be written</param>
    /// <param name="stream">Stream to be used</param>
    public abstract Task Write((TElement, Identifier) element, ModuleOutputStream stream); 

    
    /// <summary>
    /// Asynchronously dumps this registry's contents
    /// </summary>
    /// <param name="mod">Module to be used</param>
    public async Task Dump(Module mod)
    {
        var stream = mod.InitStream(Name);
        foreach (var data in Stack)
        {
            await Write(data, stream);
        }
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
    public static FunctionRegistry Functions { get; } = new();

    /// <summary>
    /// Global advancement registry
    /// </summary>
    public static AdvancementRegistry Advancements { get; } = new();
    
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