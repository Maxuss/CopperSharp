using CopperSharp.Item;

namespace CopperSharp.Blocks.State;

/// <summary>
///     Represents a command block state
/// </summary>
public sealed class CommandBlockState : BlockState
{
    internal CommandBlockState(Material id) : base(id)
    {
    }

    /// <summary>
    ///     Whether this command block state is always powered
    /// </summary>
    /// <param name="auto">Marker</param>
    /// <returns>This command block state</returns>
    public CommandBlockState AlwaysPowered(bool auto = true)
    {
        Data["auto"] = auto;
        return this;
    }

    /// <summary>
    ///     Whether the condition for this conditional command block was met
    /// </summary>
    /// <param name="met">Marker</param>
    /// <returns>This command block state</returns>
    public CommandBlockState ConditionMet(bool met = true)
    {
        Data["conditionMet"] = met;
        return this;
    }

    /// <summary>
    ///     Sets the command inside this command block state
    /// </summary>
    /// <param name="cmd">Command to be set</param>
    /// <returns>This command block state</returns>
    public CommandBlockState Command(string cmd)
    {
        Data["Command"] = cmd;
        return this;
    }

    /// <summary>
    ///     Sets the last command block output contents
    /// </summary>
    /// <param name="output">String output</param>
    /// <param name="at">Tick at which the output was produced</param>
    /// <returns></returns>
    public CommandBlockState LastOutput(string output, long at = -1)
    {
        Data["LastOutput"] = output;
        Data["LastExecution"] = at;
        return this;
    }

    /// <summary>
    ///     Whether this command block is powered by redstone
    /// </summary>
    /// <param name="powered">Marker</param>
    /// <returns>This command block state</returns>
    public CommandBlockState Powered(bool powered = true)
    {
        Data["powered"] = powered;
        return this;
    }
}