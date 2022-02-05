namespace CopperSharp.Blocks.Data.Impl;

/// <summary>
/// Represents a lever block
/// </summary>
public sealed class Lever :
    AbstractBlockData,
    IDirectional,
    IFaceAttachable,
    IPowerable
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

    /// <inheritdoc />
    public IPowerable Powered(bool power = true)
    {
        Data["powered"] = power;
        return this;
    }
}