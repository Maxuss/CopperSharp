using CopperSharp.Block;
using CopperSharp.Data.SNbt;

namespace CopperSharp.Entity;

/// <summary>
/// An abstract superclass for minecart
/// </summary>
public abstract class AbstractMinecart : AbstractEntity
{
    internal AbstractMinecart(EntityType type) : base(type)
    {
    }

    private string? BlockState { get; set; } = null;

    /// <summary>
    /// Sets custom decoration block to be displayed in this minecart.
    /// </summary>
    /// <param name="state">Block state to be used</param>
    /// <returns>This abstract minecart</returns>
    public AbstractMinecart CustomBlock(BlockState state)
    {
        BlockState = state.Serialize();
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

    /// <inheritdoc />
    protected override void SerializeExtra(StringNbtWriter sw)
    {
        base.SerializeExtra(sw);

        if (BlockState == null)
            return;

        sw.WriteRawValue("DisplayState", BlockState);
    }
}