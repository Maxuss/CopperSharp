using CopperSharp.Utils;
using CopperSharp.World;

namespace CopperSharp.Advancements.Triggers;

/// <summary>
/// Triggers after the player travels between two dimensions
/// </summary>
public sealed class ChangedDimension : TriggerCondition
{
    /// <summary>
    /// Sets the dimension travelled from
    /// </summary>
    /// <param name="from">Dimension to be set</param>
    /// <returns>This trigger</returns>
    public ChangedDimension From(Dimension from)
    {
        Data["from"] = from.GetName().ToSnakeCase();
        return this;
    }

    /// <summary>
    /// Sets the dimension travelled to
    /// </summary>
    /// <param name="to">Dimension to be set</param>
    /// <returns>This trigger</returns>
    public ChangedDimension To(Dimension to)
    {
        Data["to"] = to.GetName().ToSnakeCase();
        return this;
    }
}