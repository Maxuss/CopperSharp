using CopperSharp.Data.SNbt;
using CopperSharp.Item;

namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents a piglin entity
/// </summary>
public class Piglin : LivingEntity
{
    internal Piglin() : base(EntityType.Piglin)
    {
    }

    private List<ItemStack?> Items { get; } = new();

    /// <summary>
    ///     Whether this piglin can hunt hoglins
    /// </summary>
    /// <param name="can">Marker</param>
    /// <returns>This piglin</returns>
    public Piglin CanHunt(bool can = false)
    {
        Bools["CannotHunt"] = !can;
        return this;
    }

    /// <summary>
    ///     Whether this piglin is a baby
    /// </summary>
    /// <param name="baby">Marker</param>
    /// <returns>This piglin</returns>
    public Piglin Baby(bool baby)
    {
        Bools["IsBaby"] = baby;
        return this;
    }

    /// <summary>
    ///     Whether this piglin is immune to zombification
    /// </summary>
    /// <param name="immune">Marker</param>
    /// <returns>This piglin</returns>
    public Piglin ImmuneToZombification(bool immune = true)
    {
        Bools["IsImmuneToZombification"] = immune;
        return this;
    }

    /// <summary>
    ///     Time this piglin has spent in the overworld
    /// </summary>
    /// <param name="time">Amount of time in ticks</param>
    /// <returns>This piglin</returns>
    public Piglin TimeInOverworld(int time)
    {
        Ints["TimeInOverworld"] = time;
        return this;
    }

    /// <summary>
    ///     Adds items to this piglin's inventory
    /// </summary>
    /// <param name="items"></param>
    /// <returns></returns>
    public Piglin AddItems(params ItemStack?[] items)
    {
        Items.AddRange(items);
        return this;
    }

    /// <inheritdoc />
    protected override async Task SerializeExtra(INbtWriter sw)
    {
        await base.SerializeExtra(sw);

        if (Items.Any(it => it != null))
        {
            await sw.WritePropertyNameAsync("Inventory");
            await sw.WriteBeginArrayAsync();
            var slot = 0;
            foreach (var item in Items)
            {
                await sw.WriteItem(item, slot);
                slot++;
            }

            await sw.WriteEndArrayAsync();
        }
    }
}