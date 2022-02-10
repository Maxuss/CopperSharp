using CopperSharp.Registry;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
/// Triggers after the player unlocks a recipe
/// (e.g. using a knowledge book).
/// </summary>
[CriterionName("recipe_unlocked")]
public sealed class RecipeUnlocked : TriggerCondition
{
    /// <summary>
    /// Sets the recipe that was unlocked
    /// </summary>
    /// <param name="id">Recipe to be set</param>
    /// <returns>This trigger</returns>
    public RecipeUnlocked Recipe(Identifier id)
    {
        Data["recipe"] = id.ToString();
        return this;
    }
}