namespace CopperSharp.Blocks.Data.Impl;

/// <summary>
/// Represents a cake tile entity
/// </summary>
public sealed class Cake : AbstractBlockData
{
    /// <summary>
    /// Sets bites left in this cake
    /// </summary>
    /// <param name="bites">Amount of bites left</param>
    /// <returns>This cake</returns>
    public Cake Bites(int bites)
    {
        Data["bites"] = bites;
        return this;
    }
}