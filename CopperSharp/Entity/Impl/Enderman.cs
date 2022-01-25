using CopperSharp.Data.SNbt;

namespace CopperSharp.Entity.Impl;

// Need to add blockstate later
/// <summary>
/// Represents an enderman
/// </summary>
public sealed class Enderman : LivingEntity, IAngerableEntity
{
    internal Enderman() : base(EntityType.Enderman)
    {
    }

    private Guid? Anger { get; set; } = null;

    /// <inheritdoc />
    public IAngerableEntity AngryOn(Guid on)
    {
        Anger = on;
        return this;
    }

    /// <inheritdoc />
    public IAngerableEntity AngerTime(int time)
    {
        Ints["AngerTime"] = time;
        return this;
    }

    protected override void SerializeExtra(StringNbtWriter sw)
    {
        base.SerializeExtra(sw);

        if (Anger != null)
            sw.WriteUuidArray("AngryAt", Anger ?? Guid.Empty);
    }
}