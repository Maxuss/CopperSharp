using CopperSharp.Data.SNbt;

namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents a fox entity
/// </summary>
public sealed class Fox : BreedableEntity
{
    internal Fox() : base(EntityType.Fox)
    {
    }

    private List<Guid> Trusted { get; } = new();

    /// <summary>
    ///     Makes the fox crouch
    /// </summary>
    /// <param name="crouch">Whether the fox crouches</param>
    /// <returns>This fox</returns>
    public Fox Crouching(bool crouch = true)
    {
        Bools["Crouching"] = crouch;
        return this;
    }

    /// <summary>
    ///     Makes the fox sit
    /// </summary>
    /// <param name="sit">Whether the fox sits</param>
    /// <returns>This fox</returns>
    public Fox Sitting(bool sit = true)
    {
        Bools["Sitting"] = sit;
        return this;
    }

    /// <summary>
    ///     Makes the fox sleep
    /// </summary>
    /// <param name="sleep">Whether the fox sleeps</param>
    /// <returns>This fox</returns>
    public Fox Sleeping(bool sleep = true)
    {
        Bools["Sleeping"] = sleep;
        return this;
    }

    /// <summary>
    ///     Makes the fox trust players with provided ids
    /// </summary>
    /// <param name="players">Players to be trusted</param>
    /// <returns>This fox</returns>
    public Fox Trust(params Guid[] players)
    {
        Trusted.AddRange(players);
        return this;
    }

    /// <summary>
    ///     Makes the fox a snow variant
    /// </summary>
    /// <param name="snow">Whether the fox should be snow</param>
    /// <returns>This fox</returns>
    public Fox IsSnow(bool snow = true)
    {
        Strings["Type"] = snow ? "snow" : "red";
        return this;
    }

    /// <inheritdoc />
    protected override void SerializeExtra(StringNbtWriter sw)
    {
        base.SerializeExtra(sw);

        if (Trusted.Any())
        {
            sw.WritePropertyName("Trusted");
            sw.WriteBeginArray();
            foreach (var id in Trusted) sw.WriteUuidArray(id);

            sw.WriteEndArray();
        }
    }
}