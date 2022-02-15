// ReSharper disable MemberCanBePrivate.Global

using System.Reflection;
using CopperSharp.Contexts;
using CopperSharp.Datapack;
using CopperSharp.Functions;
using CopperSharp.Registry;
using CopperSharp.Tags;

namespace CopperSharp.Modules;

/// <summary>
///     <b>Module</b> <br /><br />
///     Module represents a Datapack, that can be combined with other packs into a single Datapack.
///     <br />
///     <br />
///     A Module can <i>internally</i> contain different items and entities, that will be converted to functions on
///     runtime.
///     It can also normally contain different functions, advancements, recipes, etc.
/// </summary>
[ModuleInfo("cs_stdlib", Description = "Standard library for CopperSharp", Version = PackFormat.v1_18)]
public abstract class Module
{
    internal bool _locked = false;

    /// <summary>
    ///     Creates a new module, and initializes fields in it
    /// </summary>
    protected Module()
    {
        var info = GetType().GetCustomAttribute<ModuleInfoAttribute>();
        if (info == null)
            throw new Exception($"Failed to init module {GetType().FullName}. Does not have a ModuleInfoAttribute!");

        Name = info.Name;
        Description = info.Description;
        Format = info.Version;
        Namespace = Name.ToLower().Replace(" ", "_");

        var authors = GetType().GetCustomAttributes<ModuleAuthorAttribute>();
        Authors = authors.Select(it => it.Author).ToList();
    }

    internal Dictionary<string, ModuleOutputStream> Streams { get; set; } = new();

    /// <summary>
    ///     Gets the full description of this module
    /// </summary>
    public string FullDescription =>
        $"{Description}{(Authors.Count != 0 ? $". Authors: {string.Join(", ", Authors)}" : "")}";

    /// <summary>
    ///     Namespace of this module. Created from name
    /// </summary>
    public string Namespace { get; }

    /// <summary>
    ///     Name of this module
    /// </summary>
    public string Name { get; }

    /// <summary>
    ///     Authors of this module
    /// </summary>
    public List<string> Authors { get; } = new();

    /// <summary>
    ///     Description of this module
    /// </summary>
    public string Description { get; }

    /// <summary>
    ///     Format of the pack, depends on minecraft version
    /// </summary>
    public PackFormat Format { get; }

    /// <summary>
    ///     Ran when module is loaded
    /// </summary>
    public virtual void Startup()
    {
    }

    /// <summary>
    ///     Called each time a server is (re)loaded
    /// </summary>
    /// <param name="ctx">Current world</param>
    public virtual void WorldLoad(WorldContext ctx)
    {
    }

    /// <summary>
    ///     Called each tick
    /// </summary>
    /// <param name="ctx">Current world</param>
    public virtual void OnTick(WorldContext ctx)
    {
    }

    internal async Task InternalSetupMagicFns()
    {
        var tick = new Tag(Identifier.Of(Namespace, "tick")).ReplaceSimilar(false);
        var load = new Tag(Identifier.Of(Namespace, "load")).ReplaceSimilar(false);
        ModuleLoader.GlobalLoader.InjectMinecraftResource(Path.Join("tags", "functions", "tick.json"),
            await tick.Serialize());
        ModuleLoader.GlobalLoader.InjectMinecraftResource(Path.Join("tags", "functions", "load.json"),
            await load.Serialize());
    }

    internal void InternalWorldLoad()
    {
        Registries.Functions.Register(new LoadFunction(WorldLoad), Identifier.Of(Namespace, "load"));
    }

    internal void InternalTick()
    {
        Registries.Functions.Register(new TickFunction(OnTick), Identifier.Of(Namespace, "tick"));
    }

    /// <summary>
    ///     Creates a new identifier for this module
    /// </summary>
    /// <param name="path">The path part of the identifier</param>
    /// <returns>Built identifier</returns>
    public Identifier GetId(string path)
    {
        return Identifier.Of(Namespace, path);
    }

    internal ModuleOutputStream InitStream(string stream)
    {
        if (Streams.ContainsKey(stream))
            return Streams[stream];

        Streams[stream] = new ModuleOutputStream(this, stream);
        return Streams[stream];
    }
}