using CopperSharp.Data.Locations;
using CopperSharp.Item;
using CopperSharp.Utils;

namespace CopperSharp.Blocks.State;

/// <summary>
///     Represents a structure block state
/// </summary>
public sealed class StructureBlockState : BlockState
{
    /// <summary>
    ///     Represents mode of structure block
    /// </summary>
    public enum Mode
    {
        /// <summary>
        ///     SAVE
        /// </summary>
        Save,

        /// <summary>
        ///     LOAD
        /// </summary>
        Load,

        /// <summary>
        ///     CORNER
        /// </summary>
        Corner,

        /// <summary>
        ///     DATA
        /// </summary>
        Data
    }

    /// <summary>
    ///     Represents rotation of the structure
    /// </summary>
    public enum Rotation
    {
        /// <summary>
        ///     No rotation
        /// </summary>
        [EnumData("NONE")] None,

        /// <summary>
        ///     Clockwise 90 degree rotation
        /// </summary>
        [EnumData("CLOCKWISE_90")] Clockwise90,

        /// <summary>
        ///     Clockwise 180 degree rotation
        /// </summary>
        [EnumData("CLOCKWISE_180")] Clockwise180,

        /// <summary>
        ///     Counter clockwise 90 degree rotation
        /// </summary>
        [EnumData("COUNTER_CLOCKWISE_90")] CounterClockwise90
    }

    internal StructureBlockState(Material id) : base(id)
    {
    }

    /// <summary>
    ///     Sets author of this structure
    /// </summary>
    /// <param name="author">Author's name. Set to "?" for vanilla structures</param>
    /// <returns>This structure block state</returns>
    public StructureBlockState Author(string author)
    {
        Data["author"] = author;
        return this;
    }

    /// <summary>
    ///     Whether the entities in the structure should be ignored
    /// </summary>
    /// <param name="ignore">Marker</param>
    /// <returns>This structure block state</returns>
    public StructureBlockState IgnoresEntities(bool ignore = true)
    {
        Data["ignoreEntities"] = ignore;
        return this;
    }

    /// <summary>
    ///     Sets how complete this structure when comparing to original one
    /// </summary>
    /// <param name="integrity">Integrity in percents</param>
    /// <returns>This structure block state</returns>
    public StructureBlockState Integrity(float integrity)
    {
        Data["integrity"] = integrity;
        return this;
    }

    /// <summary>
    ///     Sets meta data for this structure block, if it is a data structure block
    /// </summary>
    /// <param name="metadata">Meta data to be set</param>
    /// <returns>This structure block state</returns>
    public StructureBlockState Meta(string metadata)
    {
        Data["metadata"] = metadata;
        return this;
    }

    /// <summary>
    ///     Sets type of mirroring for this structure block
    /// </summary>
    /// <param name="mirror">Type of mirroring</param>
    /// <returns>This structure block state</returns>
    public StructureBlockState Mirrored(StructureMirror mirror)
    {
        Data["mirror"] = mirror.GetData() ?? "NONE";
        return this;
    }

    /// <summary>
    ///     Sets mode of this structure block state
    /// </summary>
    /// <param name="mode">Mode to be set</param>
    /// <returns>This structure block state</returns>
    public StructureBlockState SetMode(Mode mode)
    {
        Data["mode"] = Enum.GetName(mode)?.ToUpper() ?? "SAVE";
        return this;
    }

    /// <summary>
    ///     Sets position at which to place the structure
    /// </summary>
    /// <param name="loc">Location to be set</param>
    /// <returns>This structure block state</returns>
    public StructureBlockState StructurePosition(Location loc)
    {
        Data["posX"] = (int) loc.X.Value;
        Data["posY"] = (int) loc.Y.Value;
        Data["posZ"] = (int) loc.Z.Value;
        return this;
    }

    /// <summary>
    ///     Sets whether this structure block is powered
    /// </summary>
    /// <param name="powered">Marker</param>
    /// <returns>This structure block</returns>
    public StructureBlockState Powered(bool powered = true)
    {
        Data["powered"] = powered;
        return this;
    }

    /// <summary>
    ///     Sets rotation of this structure
    /// </summary>
    /// <param name="rot">Rotation of the structure</param>
    /// <returns>This structure block state</returns>
    public StructureBlockState SetRotation(Rotation rot)
    {
        Data["rotation"] = rot.GetData() ?? "NONE";
        return this;
    }

    /// <summary>
    ///     Sets seed of this structure block
    /// </summary>
    /// <param name="seed">Seed to be set</param>
    /// <returns>This structure block state</returns>
    public StructureBlockState Seed(long seed)
    {
        Data["seed"] = seed;
        return this;
    }

    /// <summary>
    ///     Enables showing bounding box for structure in creative mod
    /// </summary>
    /// <param name="show">Marker</param>
    /// <returns>This structure block state</returns>
    public StructureBlockState ShowBoundingBox(bool show = true)
    {
        Data["showboundingbox"] = show;
        return this;
    }

    /// <summary>
    ///     Sets size of this structure
    /// </summary>
    /// <param name="x">X size</param>
    /// <param name="y">Y size</param>
    /// <param name="z">Z size</param>
    /// <returns>This structure block state</returns>
    public StructureBlockState Size(int x, int y, int z)
    {
        Data["sizeX"] = x;
        Data["sizeY"] = y;
        Data["sizeZ"] = z;
        return this;
    }
}

/// <summary>
///     Type of structure's mirroring
/// </summary>
public enum StructureMirror
{
    /// <summary>
    ///     No mirroring
    /// </summary>
    [EnumData("NONE")] None,

    /// <summary>
    ///     Left-right mirroring
    /// </summary>
    [EnumData("LEFT_RIGHT")] LeftRight,

    /// <summary>
    ///     Front-back mirroring
    /// </summary>
    [EnumData("FRONT_BACK")] FrontBack
}