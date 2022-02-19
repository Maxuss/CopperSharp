using CopperSharp.Entity;
using Newtonsoft.Json;

namespace CopperSharp.Text;

/// <summary>
/// Represents a component for entities
/// </summary>
public sealed class EntityComponent : Component
{
    /// <inheritdoc />
    public override ComponentType ComponentType => ComponentType.Entity;

    private Selector EntityS { get; }
    private Component? SeparatorComponent { get; set; }
    
    /// <summary>
    /// Constructs a new entity component
    /// </summary>
    /// <param name="entity">Selector for entities to be displayed</param>
    public EntityComponent(Selector entity)
    {
        EntityS = entity;
    }

    /// <summary>
    /// Sets a new separator for this component.
    /// Used to separate entity names when there are
    /// more than 1 entity affected.
    /// </summary>
    /// <param name="separator"></param>
    /// <returns></returns>
    public EntityComponent Separator(Component separator)
    {
        SeparatorComponent = separator;
        return this;
    }

    /// <inheritdoc />
    protected override async Task SerializeExtra(JsonTextWriter jw)
    {
        await jw.WritePropertyNameAsync("selector");
        await jw.WriteValueAsync(EntityS.ToString());
        if (SeparatorComponent != null)
        {
            await jw.WritePropertyNameAsync("separator");
            await SeparatorComponent.SerializeInto(jw);
        }
    }
}