namespace CopperSharp.Block;

/// <summary>
/// Represents a tile entity that can be attached to a block
/// </summary>
public interface IAttachable : ITileEntity
{
    /// <summary>
    /// Makes this tripwire form a complete circuit, ready to output signal
    /// </summary>
    /// <param name="attached">Whether to make this entity attached</param>
    /// <returns>This attachable entity</returns>
    public IAttachable Attach(bool attached);
}