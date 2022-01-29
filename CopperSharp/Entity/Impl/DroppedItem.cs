using CopperSharp.Data.SNbt;
using CopperSharp.Item;

namespace CopperSharp.Entity.Impl;

/// <summary>
/// Represents a dropped item entity
/// </summary>
public sealed class DroppedItem : AbstractEntity
{
    internal DroppedItem() : base(EntityType.Item)
    {
    }

    private ItemStack? Container { get; set; } = null;

    /// <summary>
    /// Sets age of this item.
    /// When age reaches 6000 ticks, the orb disappears.
    ///
    /// Can be set to <see cref="short.MinValue"/>, for item to never
    /// disappear.
    /// </summary>
    /// <param name="age">Age to be set</param>
    /// <returns>This dropped item</returns>
    public DroppedItem Age(short age)
    {
        Ints["Age"] = age;
        return this;
    }

    /// <summary>
    /// Sets owner of this item, to prevent other players
    /// picking up this item.
    /// </summary>
    /// <param name="playerOwner">UUID of owner player</param>
    /// <returns>This dropped item</returns>
    public DroppedItem Owner(Guid playerOwner)
    {
        Ids["Owner"] = playerOwner;
        return this;
    }

    /// <summary>
    /// Sets delay until this item can be picked up.
    ///
    /// Can be set to <see cref="short.MaxValue"/> to never
    /// be able to pick up this item.
    /// </summary>
    /// <param name="delay">Amount of time in ticks</param>
    /// <returns>This dropped item</returns>
    public DroppedItem PickupDelay(short delay)
    {
        Ints["PickupDelay"] = delay;
        return this;
    }

    /// <summary>
    /// Sets the item stored inside this dropped item
    /// </summary>
    /// <param name="item">Item to be set</param>
    /// <returns>This dropped item</returns>
    public DroppedItem Item(ItemStack item)
    {
        Container = item;
        return this;
    }

    /// <summary>
    /// Sets health of this item.
    /// Items get destroyed when health reaches 0.
    /// </summary>
    /// <param name="health">Health to be set</param>
    /// <returns>This dropped item</returns>
    public DroppedItem Health(short health)
    {
        Ints["Health"] = health;
        return this;
    }

    /// <inheritdoc />
    protected override void SerializeExtra(StringNbtWriter sw)
    {
        base.SerializeExtra(sw);

        if (Container == null)
            return;

        sw.WritePropertyName("Item");
        sw.WriteItem(Container);
    }
}