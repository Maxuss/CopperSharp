namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents a command block minecart
/// </summary>
public sealed class CommandBlockMinecart : AbstractMinecart
{
    internal CommandBlockMinecart() : base(EntityType.CommandBlockMinecart)
    {
    }

    /// <summary>
    ///     Sets command in this minecart
    /// </summary>
    /// <param name="cmd">Command to be set</param>
    /// <returns>This command block minecart</returns>
    public CommandBlockMinecart Command(string cmd)
    {
        Strings["Command"] = cmd;
        return this;
    }
}