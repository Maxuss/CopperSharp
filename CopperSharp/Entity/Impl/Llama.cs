using CopperSharp.Data.SNbt;
using CopperSharp.Item;

namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents a llama entity
/// </summary>
public sealed class Llama : BreedableEntity
{
    /// <summary>
    ///     Represents a color variant of llama
    /// </summary>
    public enum Variant
    {
        /// <summary>
        ///     Creamy
        /// </summary>
        Creamy = 0,

        /// <summary>
        ///     White
        /// </summary>
        White = 1,

        /// <summary>
        ///     Brown
        /// </summary>
        Brown = 2,

        /// <summary>
        ///     Gray
        /// </summary>
        Gray = 3
    }

    internal Llama() : base(EntityType.Llama)
    {
    }

    private List<ItemStack?> Items { get; } = new();
    private ItemStack? DecorItem { get; set; }

    /// <summary>
    ///     Causes llama to stay near other llamas
    /// </summary>
    /// <param name="bred">Marker</param>
    /// <returns>This llama</returns>
    public Llama Bred(bool bred = true)
    {
        Bools["Bred"] = bred;
        return this;
    }

    /// <summary>
    ///     Whether this llama has chests
    /// </summary>
    /// <param name="has">Marker</param>
    /// <returns>This llama</returns>
    public Llama HasChest(bool has = true)
    {
        Bools["ChestedHorse"] = has;
        return this;
    }

    /// <summary>
    ///     Sets decoration item this llama wears, usually a carpet
    /// </summary>
    /// <param name="decor">Item decoration for llama</param>
    /// <returns>This llama</returns>
    public Llama Decoration(ItemStack? decor)
    {
        DecorItem = decor;
        return this;
    }

    /// <summary>
    ///     Timer for trader llamas to despawn
    /// </summary>
    /// <param name="delay">Amount of time in ticks</param>
    /// <returns>This llama</returns>
    public Llama DespawnDelay(int delay)
    {
        Ints["DespawnDelay"] = delay;
        return this;
    }

    /// <summary>
    ///     Whether this llama is grazing
    /// </summary>
    /// <param name="eating">Whether the llama is eating grass</param>
    /// <returns>This llama</returns>
    public Llama EatingHaystack(bool eating)
    {
        Bools["EatingHaystack"] = eating;
        return this;
    }

    /// <summary>
    ///     Adds extra items to this llama
    /// </summary>
    /// <param name="items">Items to be added</param>
    /// <returns>This llama</returns>
    public Llama AddStorageItems(params ItemStack?[] items)
    {
        Items.AddRange(items);
        return this;
    }

    /// <summary>
    ///     Sets llama's owner
    /// </summary>
    /// <param name="owner">UUID of owner</param>
    /// <returns>This llama</returns>
    public Llama Owner(Guid owner)
    {
        Ids["Owner"] = owner;
        return this;
    }

    /// <summary>
    ///     Sets color of the llama
    /// </summary>
    /// <param name="color">Color to be set</param>
    /// <returns>This llama</returns>
    public Llama Color(Variant color)
    {
        Ints["Variant"] = (int) color;
        return this;
    }

    /// <summary>
    ///     Sets strength of the llama. Maximum amount<br />
    ///     of items carried depends on strength (items = 3x strength).<br />
    ///     Strengths over 4 causes wolf to flee
    /// </summary>
    /// <param name="strength">Int in range from 1 to 5</param>
    /// <returns>This llama</returns>
    public Llama Strength(int strength = 1)
    {
        Ints["Strength"] = Math.Clamp(strength, 0, 5);
        return this;
    }

    /// <summary>
    ///     Sets this llama as tamed
    /// </summary>
    /// <param name="tamed">Whether this llama is tamed</param>
    /// <returns>This llama</returns>
    public Llama Tamed(bool tamed = true)
    {
        Bools["Tame"] = tamed;
        return this;
    }

    /// <summary>
    ///     Increases chances to tame the llama.<br />
    ///     Ranges from 0 to 100
    /// </summary>
    /// <param name="temper">Temper of this llama</param>
    /// <returns>This llama</returns>
    public Llama Temper(int temper)
    {
        Ints["Temper"] = temper;
        return this;
    }

    /// <inheritdoc />
    protected override async Task SerializeExtra(INbtWriter sw)
    {
        await base.SerializeExtra(sw);

        if (DecorItem != null)
            await sw.WriteRawValueAsync("DecorItem", await DecorItem?.Meta.Serialize()!);

        if (Bools.ContainsKey("ChestedHorse") && Bools["ChestedHorse"] && Items.Any(it => it != null))
        {
            await sw.WritePropertyNameAsync("Items");
            await sw.WriteBeginArrayAsync();
            var slot = 0;
            foreach (var item in Items)
            {
                if (item?.Meta == null)
                    await sw.WriteRawValueAsync("{}");
                else 
                    await sw.WriteRawValueAsync(await item?.Meta.Serialize(slot)!);
                slot++;
            }

            await sw.WriteEndArrayAsync();
        }
    }
}