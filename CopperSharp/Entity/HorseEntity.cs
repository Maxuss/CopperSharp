using CopperSharp.Data.SNbt;
using CopperSharp.Item;

namespace CopperSharp.Entity;

/// <summary>
///     Represents a horse-like entity
/// </summary>
public abstract class HorseEntity : BreedableEntity
{
    /// <inheritdoc />
    protected HorseEntity(EntityType type) : base(type)
    {
    }

    private ItemStack? ArmorItem { get; set; }
    private ItemStack? SaddleItem { get; set; }
    private Guid? Owner { get; set; }

    /// <summary>
    ///     Sets armor contents of this horse
    /// </summary>
    /// <param name="armor">New armor of this horse</param>
    /// <returns>This horse entity</returns>
    public HorseEntity Armor(ItemStack? armor)
    {
        ArmorItem = armor;
        return this;
    }

    /// <summary>
    ///     Marks whether the horse was bred
    /// </summary>
    /// <param name="bred">Whether the horse bred</param>
    /// <returns>This horse entity</returns>
    public HorseEntity Bred(bool bred = true)
    {
        Bools["Bred"] = bred;
        return this;
    }

    /// <summary>
    ///     Whether the horse is grazing
    /// </summary>
    /// <param name="eating">Whether the horse is eating</param>
    /// <returns>This horse entity</returns>
    public HorseEntity EatingHaystack(bool eating = true)
    {
        Bools["EatingHaystack"] = eating;
        return this;
    }

    /// <summary>
    ///     Sets the owner who tamed the horse
    /// </summary>
    /// <param name="entity">UUID of entity who tamed the horse</param>
    /// <returns>This horse</returns>
    public HorseEntity SetOwner(Guid? entity)
    {
        Owner = entity;
        return this;
    }

    /// <summary>
    ///     Sets saddle of this horse
    /// </summary>
    /// <param name="saddle">Saddle item of this horse</param>
    /// <returns>This horse entity</returns>
    public HorseEntity Saddle(ItemStack? saddle)
    {
        SaddleItem = saddle;
        return this;
    }

    /// <summary>
    ///     Marks whether the horse was already tamed
    /// </summary>
    /// <param name="tamed">Whether the horse is tamed</param>
    /// <returns>This horse entity</returns>
    public HorseEntity Tamed(bool tamed = true)
    {
        Bools["Tame"] = true;
        return this;
    }

    /// <summary>
    ///     Sets temper of this horse entity. <br />
    ///     Higher temper increases chance to tame the horse
    /// </summary>
    /// <param name="temper"></param>
    /// <returns></returns>
    public HorseEntity Temper(int temper)
    {
        Ints["Temper"] = temper;
        return this;
    }

    /// <inheritdoc />
    protected override async Task SerializeExtra(INbtWriter sw)
    {
        await base.SerializeExtra(sw);

        if (ArmorItem != null)
        {
            await sw.WritePropertyNameAsync("ArmorItem");
            await sw.WriteItem(ArmorItem);
        }

        if (SaddleItem != null)
        {
            await sw.WritePropertyNameAsync("SaddleItem");
            await sw.WriteItem(SaddleItem);
        }

        if (Owner != null)
            await sw.WriteUuidArrayAsync(Owner ?? Guid.Empty);
    }
}