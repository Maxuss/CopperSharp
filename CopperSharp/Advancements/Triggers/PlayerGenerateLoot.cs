using CopperSharp.Registry;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
///     Triggers when the player generates the contents
///     of a container with a loot table set.
///     E.g. kills an entity or opens a dungeon chest.
/// </summary>
[CriterionName("player_generate_loot")]
public sealed class PlayerGenerateLoot : TriggerCondition
{
    /// <summary>
    ///     The ID of generated loot table
    /// </summary>
    /// <param name="table">Table to be set</param>
    /// <returns>This trigger</returns>
    public PlayerGenerateLoot LootTable(Identifier table)
    {
        Data["loot_table"] = table.ToString();
        return this;
    }
}