namespace CopperSharp.Blocks.Data.Impl;

/// <summary>
///     Represents a trap door block
/// </summary>
public sealed class TrapDoor :
    AbstractBlockData,
    IBisected,
    IDirectional,
    IOpenable,
    IPowerable,
    IWaterlogged
{
    /// <inheritdoc />
    public IBisected SetHalf(IBisected.Half half)
    {
        Data["half"] = Enum.GetName(half)?.ToLower() ?? "lower";
        return this;
    }

    /// <inheritdoc />
    public IDirectional Facing(BlockFace face)
    {
        if (!face.Cartesian)
            return this;

        Data["facing"] = face.Name;
        return this;
    }

    /// <inheritdoc />
    public IOpenable Open(bool open = true)
    {
        Data["open"] = open;
        return this;
    }

    /// <inheritdoc />
    public IPowerable Powered(bool power = true)
    {
        Data["powered"] = power;
        return this;
    }

    /// <inheritdoc />
    public IWaterlogged Waterlogged(bool logged = true)
    {
        Data["waterlogged"] = logged;
        return this;
    }
}