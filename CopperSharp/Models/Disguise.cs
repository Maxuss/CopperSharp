using CopperSharp.Item;
using CopperSharp.Modules;
using CopperSharp.Registry;

namespace CopperSharp.Models;

/// <summary>
///     Represents an item, visually disguised as another item
/// </summary>
public readonly struct Disguise : IModel
{
    /// <summary>
    ///     The base item to be hidden
    /// </summary>
    public Identifier Base { get; }

    /// <summary>
    ///     A model data value to hide
    /// </summary>
    public int ModelData { get; }

    /// <summary>
    ///     The disguise of this item
    /// </summary>
    public Identifier Cloak { get; }

    /// <summary>
    ///     Constructs a new disguise
    /// </summary>
    /// <param name="item">Item to be disguised</param>
    /// <param name="hide">The new visual of the item</param>
    /// <param name="cmd">Model data of the item</param>
    public Disguise(Identifier item, Identifier hide, int cmd)
    {
        Base = item;
        Cloak = hide;
        ModelData = cmd;
    }

    /// <summary>
    ///     Constructs a new disguise
    /// </summary>
    /// <param name="item">Item to be disguised</param>
    /// <param name="hide">The new visual of the item</param>
    public Disguise(Material item, Material hide)
    {
        Base = item.Id;
        Cloak = Identifier.Minecraft($"item/{hide.Id.Path}");
#pragma warning disable CS0618
        ModelData = ModuleLoader.ModelManager.Allocate();
#pragma warning restore CS0618
    }
}