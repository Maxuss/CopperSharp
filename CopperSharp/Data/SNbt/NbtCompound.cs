using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace CopperSharp.Data.SNbt;

/// <summary>
/// A container to store any kind of NBT data
/// </summary>
[SuppressMessage("ReSharper", "RedundantCast")]
public sealed class NbtCompound : IEnumerable<INbtField<INbtValue>>
{
    private List<INbtField<INbtValue>> Fields { get; } = new();

    /// <summary>
    /// Adds a value by provided key into this compound
    /// </summary>
    /// <param name="key">Key to be used</param>
    public object this[string key]
    {
        set => Add(key, value);
    }

    /// <inheritdoc />
    public IEnumerator<INbtField<INbtValue>> GetEnumerator()
    {
        return Fields.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    /// <summary>
    /// Adds a value inside this compound
    /// </summary>
    /// <param name="key">Key of this pair</param>
    /// <param name="value">Value of this pair</param>
    public void Add(string key, object value)
    {
        Fields.Add(new NbtFieldImpl<INbtValue>(key, INbtValue.Wrap(value)) as INbtField<INbtValue>);
    }

    /// <summary>
    /// Serializes this NBT compound into provided SNBT writer
    /// </summary>
    /// <param name="w">Writer, into which to serialize</param>
    /// <param name="enclosed">Whether to enclose this compound with parenthesis</param>
    public void SerializeInto(StringNbtWriter w, bool enclosed = true)
    {
        if (enclosed) w.WriteBeginCompound();
        foreach (var field in Fields)
        {
            field.SerializeInto(w);
        }

        if (enclosed) w.WriteEndCompound();
    }

    /// <summary>
    /// Serializes this NBT compound into SNBT string
    /// </summary>
    /// <returns>Serialized string</returns>
    public string Serialize()
    {
        using var sw = new StringWriter();
        using var w = new StringNbtWriter(sw);
        SerializeInto(w);

        return sw.ToString();
    }
}