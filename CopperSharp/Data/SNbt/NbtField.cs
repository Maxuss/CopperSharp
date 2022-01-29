namespace CopperSharp.Data.SNbt;

/// <summary>
/// Represents a field which contains NBT data
/// </summary>
public interface INbtField<out T> where T : INbtValue
{
    /// <summary>
    /// Key to the value in this field
    /// </summary>
    public string Key { get; }

    /// <summary>
    /// Value of this field
    /// </summary>
    public T Value { get; }

    /// <summary>
    /// Serializes data of this field into string writer
    /// </summary>
    /// <param name="sw">String writer into which the data should be written</param>
    public void SerializeInto(StringNbtWriter sw)
    {
        sw.WritePropertyName(Key);
        Value.SerializeInto(sw);
    }
}

internal readonly struct NbtFieldImpl<T> : INbtField<T> where T : INbtValue
{
    public NbtFieldImpl(string key, T value)
    {
        Key = key;
        Value = value;
    }

    public string Key { get; }
    public T Value { get; }
}