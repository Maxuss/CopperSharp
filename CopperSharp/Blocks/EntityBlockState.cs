using CopperSharp.Data.SNbt;
using CopperSharp.Entity;
using CopperSharp.Item;

namespace CopperSharp.Blocks;

/// <summary>
///     Represents a block state which can contain entities
/// </summary>
/// <typeparam name="TEntity">Type of entity</typeparam>
public abstract class EntityBlockState<TEntity> : BlockState where TEntity : AbstractEntity
{
    /// <inheritdoc />
    protected EntityBlockState(Material id) : base(id)
    {
    }

    /// <summary>
    ///     Name of the entity in this block state
    /// </summary>
    protected abstract string EntityName { get; set; }

    private List<TEntity> Entities { get; } = new();

    /// <summary>
    ///     Adds an entity to this entity container
    /// </summary>
    /// <param name="entity">Entity to be added</param>
    /// <returns>This entity block state</returns>
    public EntityBlockState<TEntity> AddEntity(TEntity entity)
    {
        Entities.Add(entity);
        return this;
    }

    /// <inheritdoc />
    internal override async Task SerializeExtra(INbtWriter sw)
    {
        await base.SerializeExtra(sw);

        if (!Entities.Any()) return;
        await sw.WritePropertyNameAsync(EntityName);
        await sw.WriteBeginArrayAsync();
        foreach (var entity in Entities)
        {
            await sw.WriteBeginCompoundAsync();
            await sw.WriteRawValueAsync("EntityData", await entity.Serialize(false));
            await sw.WriteEndCompoundAsync();
        }

        await sw.WriteEndArrayAsync();
    }
}