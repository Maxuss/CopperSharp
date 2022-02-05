namespace CopperSharp.Blocks.Data.Impl;

/// <summary>
/// Represents a bamboo block
/// </summary>
public sealed class Bamboo : Sapling, IAgeable
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

    /// <inheritdoc />
    public IAgeable Age(int age)
    {
        Data["age"] = age;
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