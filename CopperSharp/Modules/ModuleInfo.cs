using CopperSharp.Datapack;

namespace CopperSharp.Modules;

/// <summary>
/// An attribute that contains necessary info for module
/// </summary>
[AttributeUsage(AttributeTargets.Class, Inherited = true)]
public sealed class ModuleInfoAttribute : Attribute
{
    /// <summary>
    /// Name of this module
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Description of this module
    /// </summary>
    public string Description { get; set; } = "A cool module.";

    /// <summary>
    /// Minecraft version this module was made for
    /// </summary>
    public PackFormat Version { get; set; } = PackFormat.v1_18;

    /// <summary>
    /// Constructs a new module info attribute
    /// </summary>
    /// <param name="name">Name of this module</param>
    public ModuleInfoAttribute(string name)
    {
        Name = name;
    }
}