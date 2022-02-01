namespace CopperSharp.Block.Impl;

/// <summary>
/// Represents a structure block
/// </summary>
public sealed class StructureBlock : AbstractBlockData
{
    /// <summary>
    /// Represents mode of the structure block
    /// </summary>
    public enum Mode
    {
        /// <summary>
        /// Structure block indicates a corner of the structure
        /// </summary>
        Corner,

        /// <summary>
        /// Structure block is a data block
        /// </summary>
        Data,

        /// <summary>
        /// Structure block loads structure
        /// </summary>
        Load,

        /// <summary>
        /// Structure block save structure
        /// </summary>
        Save
    }

    /// <summary>
    /// Sets mode of this structure block
    /// </summary>
    /// <param name="mode">Mode to be set</param>
    /// <returns>This structure block</returns>
    public StructureBlock SetMode(Mode mode)
    {
        Data["mode"] = Enum.GetName(mode)?.ToLower() ?? "data";
        return this;
    }
}