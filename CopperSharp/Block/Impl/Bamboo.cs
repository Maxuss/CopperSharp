using CopperSharp.Item;

namespace CopperSharp.Block.Impl;

/// <summary>
/// Represents a bamboo block
/// </summary>
public sealed class Bamboo : AbstractTileEntity, IAgeable, ISapling
{
    /// <summary>
    /// Represents type of bamboo leaves
    /// </summary>
    public enum Leaves
    {
        /// <summary>
        /// Bamboo has no leaves
        /// </summary>
        None,

        /// <summary>
        /// Bamboo has small leaves
        /// </summary>
        Small,

        /// <summary>
        /// Bamboo has big leaves
        /// </summary>
        Large
    }

    internal Bamboo() : base(Material.Bamboo)
    {
    }

    /// <inheritdoc />
    public IAgeable Age(int age)
    {
        Data["age"] = age;
        return this;
    }

    /// <inheritdoc />
    public ISapling Growing(bool growing)
    {
        Data["stage"] = growing ? 1 : 0;
        return this;
    }

    /// <summary>
    /// Sets leaves of this bamboo
    /// </summary>
    /// <param name="leaves">Leaves to be set</param>
    /// <returns>This bamboo</returns>
    public Bamboo SetLeaves(Leaves leaves)
    {
        Data["leaves"] = Enum.GetName(leaves)?.ToLower() ?? "none";
        return this;
    }
}