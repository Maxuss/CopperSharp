using CopperSharp.Data.SNbt;
using CopperSharp.Item;
using CopperSharp.Item.Meta;

namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents a firework rocket projectile
/// </summary>
public sealed class FireworkRocket : Projectile
{
    internal FireworkRocket() : base(EntityType.FireworkRocket)
    {
    }

    private FireworkMeta? Meta { get; set; }

    /// <summary>
    ///     Gets data from provided item meta
    /// </summary>
    /// <param name="meta">Meta from which to get firework data</param>
    /// <returns>This firework rocket</returns>
    public FireworkRocket GetDataFrom(FireworkMeta meta)
    {
        Meta = meta;
        return this;
    }

    /// <summary>
    ///     Gets data from provided item stack
    /// </summary>
    /// <param name="stack">Stack from which to get firework data</param>
    /// <returns>This firework rocket</returns>
    /// <exception cref="Exception">If provided stack does not contain <see cref="FireworkMeta" /></exception>
    public FireworkRocket GetDataFrom(ItemStack stack)
    {
        var meta = stack.Meta;
        if (meta is not FireworkMeta fm)
            throw new Exception("Provided stack does not contain FireworkMeta!");
        Meta = fm;
        return this;
    }

    /// <summary>
    ///     Sets lifetime of this firework rocket.
    ///     By default it is
    ///     <c>((Flight + 1) * 10 + random(0 to 5) + random(0 to 6))</c>
    /// </summary>
    /// <param name="ticks">Amount of time in ticks</param>
    /// <returns>This firework rocket</returns>
    public FireworkRocket Lifetime(int ticks)
    {
        Ints["LifeTime"] = ticks;
        return this;
    }

    /// <summary>
    ///     Whether this rocket was shot from dispenser or crossbow.
    /// </summary>
    /// <param name="shot">Marker</param>
    /// <returns>This firework rocket</returns>
    public FireworkRocket ShotAtAngle(bool shot = true)
    {
        Bools["ShotAtAngle"] = shot;
        return this;
    }

    /// <inheritdoc />
    protected override async Task SerializeExtra(INbtWriter sw)
    {
        await sw.WritePropertyNameAsync("FireworksItem");
        await sw.WriteBeginCompoundAsync();
        await sw.WriteByteAsync("Count", 1);
        await sw.WriteStringAsync("id", "minecraft:firework_rocket");
        await sw.WritePropertyNameAsync("tag");
        if (Meta != null)
        {
            await Meta.WriteExternalMetaData(sw);
        }
        else
        {
            await sw.WriteBeginCompoundAsync();
            await sw.WriteEndCompoundAsync();
        }

        await sw.WriteEndCompoundAsync();
    }
}