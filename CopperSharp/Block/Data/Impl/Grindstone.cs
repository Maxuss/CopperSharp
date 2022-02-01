namespace CopperSharp.Block.Data.Impl;

/// <summary>
/// Represents a grindstone block
/// </summary>
public sealed class Grindstone : AbstractBlockData, IDirectional, IFaceAttachable
{
    /// <inheritdoc />
    public IDirectional Facing(BlockFace face)
    {
        if (!face.Cartesian)
            return this;

        Data["facing"] = face.Name;
        return this;
    }

    /// <inheritdoc />
    public IFaceAttachable AttachedFace(IFaceAttachable.Face face)
    {
        Data["face"] = Enum.GetName(face)?.ToLower() ?? "wall";
        return this;
    }
}