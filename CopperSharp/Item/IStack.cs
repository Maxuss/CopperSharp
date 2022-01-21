namespace CopperSharp.Item;

/// <summary>
/// A global interface to item stacks
/// </summary>
public interface IStack
{
    /// <summary>
    /// Amount of item in this stack
    /// </summary>
    public int Amount { get; set; }

    /// <summary>
    /// Material of this stack
    /// </summary>
    public Material Material { get; }

    /// <summary>
    /// Item metadata, stored in tag
    /// </summary>
    public ItemTag? Meta { get; set; }
}