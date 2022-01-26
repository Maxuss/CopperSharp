namespace CopperSharp.Entity.Impl;

/// <summary>
/// Represents a panda entity
/// </summary>
public sealed class Panda : BreedableEntity
{
    /// <summary>
    /// Represents gene of panda
    /// </summary>
    public enum Gene
    {
        /// <summary>
        /// Normal
        /// </summary>
        Normal,

        /// <summary>
        /// Lazy
        /// </summary>
        Lazy,

        /// <summary>
        /// Worried
        /// </summary>
        Worried,

        /// <summary>
        /// Playful
        /// </summary>
        Playful,

        /// <summary>
        /// Brown
        /// </summary>
        Brown,

        /// <summary>
        /// Weak
        /// </summary>
        Weak,

        /// <summary>
        /// Aggressive
        /// </summary>
        Aggressive
    }

    internal Panda() : base(EntityType.Panda)
    {
    }

    /// <summary>
    /// Sets secondary gene for this panda, that can transfer to the child
    /// </summary>
    /// <param name="gene">Gene to be set</param>
    /// <returns>This panda</returns>
    public Panda HiddenGene(Gene gene)
    {
        Strings["HiddenGene"] = Enum.GetName(gene)?.ToLower() ?? "normal";
        return this;
    }

    /// <summary>
    /// Sets primary gene, that this panda has and that can transfer to it's child
    /// </summary>
    /// <param name="gene">Gene to be set</param>
    /// <returns>This panda</returns>
    public Panda MainGene(Gene gene)
    {
        Strings["MainGene"] = Enum.GetName(gene)?.ToLower() ?? "normal";
        return this;
    }
}