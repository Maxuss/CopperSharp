using System.Diagnostics;
using CopperSharp.Modules;
using CopperSharp.Utils;

namespace CopperSharp.Registry;

/// <summary>
///     An abstract super class for registries
/// </summary>
public abstract class Registry<TElement>
{
    /// <summary>
    ///     Name of this registry port
    /// </summary>
    protected abstract string Name { get; }

    /// <summary>
    ///     Stack of elements inside this registry
    /// </summary>
    protected Stack<(TElement, Identifier)> Stack { get; set; } = new();

    /// <summary>
    ///     Registers provided element in current registry
    /// </summary>
    /// <param name="element">Element to be registered</param>
    /// <param name="id">ID of element to be registered</param>
    /// <returns>The provided element</returns>
    public abstract TElement Register(TElement element, Identifier id);

    /// <summary>
    ///     Looks up provided element in this registry
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
    ///     Writes data to provided stream
    /// </summary>
    /// <param name="element">Element to be written</param>
    /// <param name="stream">Stream to be used</param>
    public abstract Task Write((TElement, Identifier) element, ModuleOutputStream stream);


    /// <summary>
    ///     Asynchronously dumps this registry's contents
    /// </summary>
    /// <param name="mod">Module to be used</param>
    public virtual async Task Dump(Module mod)
    {
        Console.Write($"Dumping {Name}... ");
        using var bar = new ProgressBar();
        var stream = mod.InitStream(Name);
        var l = Stack.Count;
        var cur = 0;
        foreach (var data in Stack)
        {
            var id = data.Item2;
            if (id.Path.Contains('/'))
            {
                var dirs = id.Path.Split('/');
                var cd = dirs.SkipLast(1).Aggregate(stream.Directory, Path.Join);
                Directory.CreateDirectory(cd);
            }

            await Write(data, stream);
            bar.Report((double) cur / l);
            cur++;
        }

        Console.WriteLine("Done.");
    }
}

/// <summary>
///     Class, containing all global registries
/// </summary>
public static class Registries
{
    /// <summary>
    ///     Global function registry
    /// </summary>
    public static FunctionRegistry Functions { get; } = new();

    /// <summary>
    ///     Global advancement registry
    /// </summary>
    public static AdvancementRegistry Advancements { get; } = new();

    /// <summary>
    ///     Global tag registry
    /// </summary>
    public static TagRegistry Tags { get; } = new();

    /// <summary>
    /// Global disguise registry
    /// </summary>
    public static DisguiseRegistry Disguises { get; } = new();

    /// <summary>
    ///     Registers provided element in provided registry
    /// </summary>
    /// <param name="registry">Registry in which to register the element</param>
    /// <param name="element">Element to be registered</param>
    /// <param name="id">ID of element. Not recommended to have minecraft's namespace.</param>
    /// <typeparam name="TRegistrable">Type of registrable element</typeparam>
    /// <returns>The provided element</returns>
    public static TRegistrable Register<TRegistrable>(Registry<TRegistrable> registry, TRegistrable element,
        Identifier id)
    {
        return registry.Register(element, id);
    }
}