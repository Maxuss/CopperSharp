using CopperSharp.Data.SNbt;
using CopperSharp.Item;

namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents a thrown trident projectile
/// </summary>
public sealed class ThrownTrident : AbstractArrow
{
    internal ThrownTrident() : base(EntityType.Trident)
    {
    }

    private ItemStack? TridentItem { get; set; }

    /// <summary>
    ///     Whether the trident has already damaged entity.
    /// </summary>
    /// <param name="damaged">Marker</param>
    /// <returns>This thrown trident</returns>
    public ThrownTrident AlreadyDamaged(bool damaged = true)
    {
        Bools["DealtDamage"] = damaged;
        return this;
    }

    /// <summary>
    ///     Sets item, that is given to player when they pick the trident up.
    /// </summary>
    /// <param name="pick">Item to be set</param>
    /// <returns>This thrown trident</returns>
    public ThrownTrident PickupItem(ItemStack pick)
    {
        TridentItem = pick;
        return this;
    }

    /// <inheritdoc />
    protected override async Task SerializeExtra(INbtWriter sw)
    {
        await base.SerializeExtra(sw);

        if (TridentItem == null)
            return;

        await sw.WritePropertyNameAsync("Trident");
        await sw.WriteItem(TridentItem);
    }
}