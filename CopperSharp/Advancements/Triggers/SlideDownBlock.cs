using CopperSharp.Item;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
///     Triggers when the player slides down a block.
/// </summary>
[CriterionName("slid_down_block")]
public sealed class SlideDownBlock : TriggerCondition
{
    /// <summary>
    ///     Sets the block that the player slid on
    /// </summary>
    /// <param name="id">Block to be set</param>
    /// <returns>This trigger</returns>
    public SlideDownBlock Block(Material id)
    {
        Data["block"] = id.Id.ToString();
        return this;
    }
}