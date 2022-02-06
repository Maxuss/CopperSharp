namespace CopperSharp.Entity;

/// <summary>
///     Represents an entity that can become angry
/// </summary>
public interface IAngerableEntity
{
    /// <summary>
    ///     Marks target of anger of this entity
    /// </summary>
    /// <param name="on">The entity this one is angry on</param>
    /// <returns>This angerable entity</returns>
    public IAngerableEntity AngryOn(Guid on);

    /// <summary>
    ///     Marks amount of time this entity is angry
    /// </summary>
    /// <param name="time">Amount of time in ticks</param>
    /// <returns>This angerable entityw</returns>
    public IAngerableEntity AngerTime(int time);
}