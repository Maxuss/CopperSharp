using CopperSharp.Item;

namespace CopperSharp.Entity;

/// <summary>
/// An abstract superclass for minecart
/// </summary>
public abstract class AbstractMinecart : AbstractEntity
{
    internal AbstractMinecart(EntityType type) : base(type)
    {
    }

    private string? BlockId { get; set; } = null;

    /// <summary>
    /// Sets custom decoration block to be displayed in this minecart.
    /// </summary>
    /// <param name="block">Type of block to be set</param>
    /// <returns>This abstract minecart</returns>
    public AbstractMinecart CustomBlock(Material block)
    {
        BlockId = block.Id.ToString();
        Bools["CustomDisplayTile"] = true;
        return this;
    }

    /// <summary>
    /// Sets display block offset of this minecart.
    /// 16 pixels equals to one block size
    /// </summary>
    /// <param name="pixels">Amount of offset in pixels.</param>
    /// <returns>This abstract minecart</returns>
    public AbstractMinecart DisplayOffset(int pixels)
    {
        Ints["DisplayOffset"] = pixels;
        return this;
    }
}