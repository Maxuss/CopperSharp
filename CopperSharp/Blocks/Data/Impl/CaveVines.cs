namespace CopperSharp.Blocks.Data.Impl;

/// <summary>
///     Represents lush cave vines plant
/// </summary>
public sealed class CaveVines : AbstractBlockData, IAgeable
{
    /// <inheritdoc />
    public IAgeable Age(int age)
    {
        Data["age"] = age;
        return this;
    }

    /// <summary>
    ///     Sets whether these cave vines have berries
    /// </summary>
    /// <param name="has">Marker</param>
    /// <returns>These cave vines</returns>
    public CaveVines HasBerries(bool has = true)
    {
        Data["berries"] = has;
        return this;
    }
}