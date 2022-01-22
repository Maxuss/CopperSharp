using CopperSharp.Data.SNbt;

namespace CopperSharp.Entity;

/// <summary>
/// Represents an entity, that is a mob
/// </summary>
public abstract class AbstractLivingEntity : AbstractEntity
{
    protected AbstractLivingEntity(EntityType type) : base(type)
    {
    }

    protected override void SerializeExtra(StringNbtWriter sw)
    {
    }
}