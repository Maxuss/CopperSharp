using CopperSharp.Item;

namespace CopperSharp.Blocks.State;

/// <summary>
///     Represents a lectern block state
/// </summary>
public sealed class LecternState : BlockState
{
    internal LecternState(Material id) : base(id)
    {
    }

    /// <summary>
    ///     Sets book on this lectern
    /// </summary>
    /// <param name="book">Item to be set</param>
    /// <returns>This lectern block state</returns>
    public LecternState Book(ItemStack book)
    {
        Data["Book"] = book;
        return this;
    }

    /// <summary>
    ///     Sets page of this lectern's book, starting from 0
    /// </summary>
    /// <param name="page">Page to be set</param>
    /// <returns>This lectern state</returns>
    public LecternState Page(int page)
    {
        Data["Page"] = page;
        return this;
    }
}