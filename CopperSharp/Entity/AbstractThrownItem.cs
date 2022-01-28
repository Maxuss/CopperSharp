using CopperSharp.Data.SNbt;
using CopperSharp.Item;

namespace CopperSharp.Entity;

/// <summary>
/// Represents an abstract thrown item, such as thrown egg or ender pearl
/// </summary>
public abstract class AbstractThrownItem : Projectile
{
    /// <inheritdoc />
    protected AbstractThrownItem(EntityType type) : base(type)
    {
    }

    private ItemStack? Item { get; set; }

    /// <summary>
    /// Sets an item, this thrown item is rendered as
    /// </summary>
    /// <param name="item">Item to be set</param>
    /// <returns>This thrown item</returns>
    public AbstractThrownItem RenderAs(ItemStack item)
    {
        Item = item;
        return this;
    }

    /// <inheritdoc />
    protected override void SerializeExtra(StringNbtWriter sw)
    {
        base.SerializeExtra(sw);

        if (Item == null)
            return;
        sw.WritePropertyName("Item");
        sw.WriteItem(Item);
    }
}