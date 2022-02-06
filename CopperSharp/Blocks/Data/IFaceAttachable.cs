namespace CopperSharp.Blocks.Data;

/// <summary>
///     Represents a tile entity that can be attached to a block's face
/// </summary>
public interface IFaceAttachable : IBlockData
{
    /// <summary>
    ///     Type of attached face
    /// </summary>
    public enum Face
    {
        /// <summary>
        ///     Attached to floor, pointing vertically
        /// </summary>
        Floor,

        /// <summary>
        ///     Attached to a wall, pointing horizontally
        /// </summary>
        Wall,

        /// <summary>
        ///     Attached to a ceiling, pointing vertically
        /// </summary>
        Ceiling
    }

    /// <summary>
    ///     Sets attached face of this entity
    /// </summary>
    /// <param name="face">Face to be set</param>
    /// <returns>This face attachable entity</returns>
    public IFaceAttachable AttachedFace(Face face);
}