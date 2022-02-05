namespace CopperSharp.Blocks.Data.Impl;

/// <summary>
/// Represents a small dripleaf block
/// </summary>
public sealed class SmallDripleaf : Dripleaf, IBisected
{
    /// <inheritdoc />
    public IBisected SetHalf(IBisected.Half half)
    {
        Data["half"] = Enum.GetName(half)?.ToLower() ?? "lower";
        return this;
    }
}