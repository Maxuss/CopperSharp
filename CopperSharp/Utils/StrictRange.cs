using Newtonsoft.Json;

namespace CopperSharp.Utils;

/// <summary>
///     Represents a range of two values that can also a strict single value
/// </summary>
public readonly struct StrictRange
{
    /// <summary>
    ///     Max value of this range
    /// </summary>
    public int? MaxValue { get; }

    /// <summary>
    ///     Min value of this range
    /// </summary>
    public int? MinValue { get; }

    /// <summary>
    ///     Whether it is a strict single value, or a range
    /// </summary>
    public bool IsStrict { get; }

    /// <summary>
    ///     Value if strict
    /// </summary>
    public int? StrictValue { get; }

    /// <summary>
    ///     Constructs a new range with one single value
    /// </summary>
    /// <param name="strict">Strict single value</param>
    public StrictRange(int strict)
    {
        IsStrict = true;
        StrictValue = strict;
        MaxValue = null;
        MinValue = null;
    }

    /// <summary>
    ///     Constructs a new range with two different values
    /// </summary>
    /// <param name="min">Min value</param>
    /// <param name="max">Max value</param>
    public StrictRange(int? min = null, int? max = null)
    {
        MinValue = min;
        MaxValue = max;
        IsStrict = false;
        StrictValue = null;
    }

    /// <summary>
    ///     Creates a new strict range only with min value
    /// </summary>
    /// <param name="min">Minimum value</param>
    /// <returns>New range</returns>
    public static StrictRange Min(int min)
    {
        return new StrictRange(min, null);
    }

    /// <summary>
    ///     Creates a new strict range only with max value
    /// </summary>
    /// <param name="max">Maximum value</param>
    /// <returns>New range</returns>
    public static StrictRange Max(int max)
    {
        return new StrictRange(null, max);
    }

    /// <summary>
    ///     Creates a new strict range only with a single value
    /// </summary>
    /// <param name="val">The value</param>
    /// <returns>New range</returns>
    public static StrictRange Strict(int val)
    {
        return new StrictRange(val);
    }

    /// <summary>
    ///     Serializes this range into provided text writer
    /// </summary>
    /// <param name="w">Writer to be used</param>
    /// <param name="name">Name of this value</param>
    public async Task SerializeInto(JsonTextWriter w, string name)
    {
        await w.WritePropertyNameAsync(name);
        if (IsStrict)
        {
            await w.WriteValueAsync(IsStrict);
            return;
        }

        await w.WriteStartObjectAsync();

        if (MaxValue != null)
        {
            await w.WritePropertyNameAsync("max");
            await w.WriteValueAsync(MaxValue);
        }

        if (MinValue != null)
        {
            await w.WritePropertyNameAsync("min");
            await w.WriteValueAsync(MinValue);
        }

        await w.WriteEndObjectAsync();
    }
}