using Newtonsoft.Json;

namespace CopperSharp.Utils;

/// <summary>
/// Represents a range of two values that can also a strict single value
/// </summary>
public readonly struct StrictRange
{
    /// <summary>
    /// Max value of this range
    /// </summary>
    public int? MaxValue { get; } = null;
    /// <summary>
    /// Min value of this range
    /// </summary>
    public int? MinValue { get; } = null;
    /// <summary>
    /// Whether it is a strict single value, or a range
    /// </summary>
    public bool Strict { get; } = false;
    /// <summary>
    /// Value if strict
    /// </summary>
    public int? StrictValue { get; } = null;
    
    /// <summary>
    /// Constructs a new range with one single value
    /// </summary>
    /// <param name="strict">Strict single value</param>
    public StrictRange(int strict)
    {
        Strict = true;
        StrictValue = strict;
    }

    /// <summary>
    /// Constructs a new range with two different values
    /// </summary>
    /// <param name="min">Min value</param>
    /// <param name="max">Max value</param>
    public StrictRange(int min, int max)
    {
        MinValue = min;
        MaxValue = max;
    }
    
    /// <summary>
    /// Serializes this range into provided text writer
    /// </summary>
    /// <param name="w">Writer to be used</param>
    /// <param name="name">Name of this value</param>
    public async Task SerializeInto(JsonTextWriter w, string name)
    {
        await w.WritePropertyNameAsync(name);
        if (Strict)
        {
            await w.WriteValueAsync(Strict);
            return;
        }

        await w.WriteStartObjectAsync();

        await w.WritePropertyNameAsync("max");
        await w.WriteValueAsync(MaxValue);
        await w.WritePropertyNameAsync("min");
        await w.WriteValueAsync(MinValue);
        await w.WriteEndObjectAsync();
    }
}