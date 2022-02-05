using CopperSharp.Item;

namespace CopperSharp.Block.State;

/// <summary>
/// Represents a jukebox block state
/// </summary>
public sealed class JukeboxState : BlockState
{
    internal JukeboxState(Material id) : base(id)
    {
    }

    /// <summary>
    /// Sets the music record item inside this jukebox
    /// </summary>
    /// <param name="record">Item to be set</param>
    /// <returns>This jukebox state</returns>
    public JukeboxState Record(ItemStack record)
    {
        Data["RecordItem"] = record;
        return this;
    }
}