// ReSharper disable MemberCanBePrivate.Global

using CopperSharp.Datapack;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

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
public abstract class Module
{
    /// <summary>
    ///     Creates a new module, and initializes fields in it
    /// </summary>
    protected Module()
    {
        var des = new DeserializerBuilder()
            .WithNamingConvention(CamelCaseNamingConvention.Instance)
            .Build();
        Config = des.Deserialize<ModuleConfig>(File.ReadAllText(Path.Join(Directory.GetCurrentDirectory(), "Pack",
            "module.yml")));

        Format = Config.MinecraftVersion switch
        {
            "1.13" or "1.14" => PackFormat.v1_13,
            "1.15" or "1.16" or "1.16.1" => PackFormat.v1_15,
            "1.16.2" or "1.16.4" or "1.16.5" => PackFormat.v1_16_2,
            "1.17" or "1.17.1" => PackFormat.v1_17,
            "1.18" or "1.18.1" => PackFormat.v1_18,
            _ => PackFormat.v1_18
        };
    }

    /// <summary>
    ///     Config of the module
    /// </summary>
    public ModuleConfig Config { get; }

    /// <summary>
    ///     Format of the pack, depends on minecraft version
    /// </summary>
    public PackFormat Format { get; }
}