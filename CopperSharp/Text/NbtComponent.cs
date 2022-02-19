using CopperSharp.Data.Locations;
using CopperSharp.Entity;
using CopperSharp.Registry;

namespace CopperSharp.Text;

/// <summary>
///     Represents a component which can display nbt values
/// </summary>
public sealed class NbtComponent : Component
{
    /// <summary>
    ///     Constructs a new block-based nbt component
    /// </summary>
    /// <param name="path">Path to the nbt values</param>
    /// <param name="pos">Position of the block</param>
    public NbtComponent(string path, Location pos)
    {
        Path = path;
        Block = pos;
    }

    /// <summary>
    ///     Constructs a new entity-based nbt component
    /// </summary>
    /// <param name="path">Path to the nbt values</param>
    /// <param name="sel">Selector for entity to be affected</param>
    public NbtComponent(string path, Selector sel)
    {
        Path = path;
        Entity = sel;
    }

    /// <summary>
    ///     Constructs a new storage-based nbt component
    /// </summary>
    /// <param name="path">Path to the nbt values</param>
    /// <param name="storage">ID of command data storage</param>
    public NbtComponent(string path, Identifier storage)
    {
        Path = path;
        Storage = storage;
    }

    /// <inheritdoc />
    public override ComponentType ComponentType => ComponentType.Nbt;

    private string Path { get; }
    private Location? Block { get; }
    private new Selector? Entity { get; }
    private Identifier? Storage { get; }
    private bool? Interprets { get; set; }
    private Component? SeparatorComponent { get; set; }

    /// <summary>
    ///     Whether to make the component resolution interpret
    ///     each nbt value as JSON component
    /// </summary>
    /// <param name="interpret">Marker</param>
    /// <returns>This component</returns>
    public NbtComponent Interpret(bool interpret = true)
    {
        Interprets = interpret;
        return this;
    }

    /// <summary>
    ///     Sets the separator between parsed tags
    /// </summary>
    /// <param name="separator">Separator component to be set.</param>
    /// <returns>This component</returns>
    public NbtComponent Separator(Component separator)
    {
        SeparatorComponent = separator;
        return this;
    }
}