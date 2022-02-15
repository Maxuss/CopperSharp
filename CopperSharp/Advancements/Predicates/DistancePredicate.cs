using Newtonsoft.Json;

namespace CopperSharp.Advancements.Predicates;

/// <summary>
///     Represents a distance predicate
/// </summary>
public struct DistancePredicate
{
    private Dictionary<string, (float?, float?)> Distances { get; } = new();

    /// <summary>
    ///     Sets absolute distance
    /// </summary>
    /// <param name="max">Max distance</param>
    /// <param name="min">Min distance</param>
    /// <returns>This distance predicate</returns>
    public DistancePredicate Absolute(float? max = null, float? min = null)
    {
        Distances["absolute"] = (max, min);
        return this;
    }

    /// <summary>
    ///     Sets horizontal distance
    /// </summary>
    /// <param name="max">Max distance</param>
    /// <param name="min">Min distance</param>
    /// <returns>This distance predicate</returns>
    public DistancePredicate HorizontalDistance(float? max = null, float? min = null)
    {
        Distances["horizontal"] = (max, min);
        return this;
    }

    /// <summary>
    ///     Sets X axis distance
    /// </summary>
    /// <param name="max">Max distance</param>
    /// <param name="min">Min distance</param>
    /// <returns>This distance predicate</returns>
    public DistancePredicate DistanceX(float? max = null, float? min = null)
    {
        Distances["x"] = (max, min);
        return this;
    }

    /// <summary>
    ///     Sets Y axis distance
    /// </summary>
    /// <param name="max">Max distance</param>
    /// <param name="min">Min distance</param>
    /// <returns>This distance predicate</returns>
    public DistancePredicate DistanceY(float? max = null, float? min = null)
    {
        Distances["y"] = (max, min);
        return this;
    }

    /// <summary>
    ///     Sets Z axis distance
    /// </summary>
    /// <param name="max">Max distance</param>
    /// <param name="min">Min distance</param>
    /// <returns>This distance</returns>
    public DistancePredicate DistanceZ(float? max = null, float? min = null)
    {
        Distances["z"] = (max, min);
        return this;
    }

    /// <summary>
    ///     Serializes this distance predicate into provided writer
    /// </summary>
    /// <param name="jw">Writer to be used</param>
    public async Task SerializeInto(JsonTextWriter jw)
    {
        await jw.WriteStartObjectAsync();
        foreach (var (key, (max, min)) in Distances)
        {
            await jw.WritePropertyNameAsync(key);
            await jw.WriteStartObjectAsync();
            if (max != null)
            {
                await jw.WritePropertyNameAsync("max");
                await jw.WriteValueAsync(max);
            }

            if (min != null)
            {
                await jw.WritePropertyNameAsync("min");
                await jw.WriteValueAsync(min);
            }

            await jw.WriteEndObjectAsync();
        }

        await jw.WriteEndObjectAsync();
    }
}