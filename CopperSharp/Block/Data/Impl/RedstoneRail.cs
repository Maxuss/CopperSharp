namespace CopperSharp.Block.Data.Impl;

/// <summary>
/// Represents a redstone rail block
/// </summary>
public sealed class RedstoneRail : Rail, IPowerable
{
    /// <inheritdoc />
    public IPowerable Powered(bool power)
    {
        Data["powered"] = power;
        return this;
    }
}