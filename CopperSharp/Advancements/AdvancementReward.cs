using CopperSharp.Functions;
using CopperSharp.Registry;

namespace CopperSharp.Advancements;

/// <summary>
/// Represents an advancement reward
/// </summary>
public struct AdvancementReward
{
    /// <summary>
    /// Recipes to be given. Empty by default.
    /// </summary>
    public List<Identifier> Recipe { get; private init; } = new();
    /// <summary>
    /// Loot tables to be given. Empty by default
    /// </summary>
    public List<Identifier> Items { get; private init; } = new();
    /// <summary>
    /// Experience to be given. 0 by default
    /// </summary>
    public int Exp { get; private init; }
    /// <summary>
    /// Function to be triggered. Null by default
    /// </summary>
    public Identifier? Trigger { get; private init; }
    
    /// <summary>
    /// Gives player recipes as a reward
    /// </summary>
    /// <param name="recipes">IDs of recipes to be given</param>
    /// <returns>New advancement reward</returns>
    public static AdvancementReward Recipes(params Identifier[] recipes)
        => new()
        {
            Recipe = recipes.ToList()
        };

    /// <summary>
    /// Gives player items from loot tables as a reward
    /// </summary>
    /// <param name="lootTables">IDs of loot tables to be used</param>
    /// <returns>New advancement reward</returns>
    public static AdvancementReward Loot(params Identifier[] lootTables)
        => new()
        {
            Items = lootTables.ToList()
        };

    /// <summary>
    /// Gives player experience as a reward
    /// </summary>
    /// <param name="exp">Amount of experience to be given</param>
    /// <returns>New advancement reward</returns>
    public static AdvancementReward Experience(int exp)
        => new()
        {
            Exp = exp
        };

    /// <summary>
    /// Runs a function instead of reward
    /// </summary>
    /// <param name="fn">Function to be ran</param>
    /// <returns>This advancement reward</returns>
    public static AdvancementReward RunFunction(Identifier fn)
        => new()
        {
            Trigger = fn
        };
    
    /// <summary>
    /// Runs a function instead of reward
    /// </summary>
    /// <param name="fn">Function to be ran</param>
    /// <returns>This advancement reward</returns>
    public static AdvancementReward RunFunction(IFunction fn)
        => new()
        {
            Trigger = Registries.Functions.Seek(fn)
        };
}