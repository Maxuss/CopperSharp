using YamlDotNet.Serialization;

namespace CopperSharp.Modules;

/// <summary>
///     Main configuration file schema for module
/// </summary>
public class ModuleConfig
{
    /// <summary>
    ///     Id of the module
    /// </summary>
    [YamlMember(Alias = "id")]
    public string? Id { get; set; }

    /// <summary>
    ///     Authors of the pack
    /// </summary>
    [YamlMember(Alias = "authors")]
    public List<string>? Authors { get; set; }

    /// <summary>
    ///     Description of the pack
    /// </summary>
    [YamlMember(Alias = "description")]
    public string? Description { get; set; }

    /// <summary>
    ///     Which minecraft version was the pack made for?
    /// </summary>
    [YamlMember(Alias = "minecraftVersion")]
    public string? MinecraftVersion { get; set; }

    /// <summary>
    ///     Name of the datapack module
    /// </summary>
    [YamlMember(Alias = "name")]
    public string? Name { get; set; }
}