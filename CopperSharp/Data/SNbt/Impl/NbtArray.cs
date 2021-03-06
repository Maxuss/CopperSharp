using System.Collections;
using Newtonsoft.Json;

namespace CopperSharp.Data.SNbt.Impl;

/// <summary>
///     Represents an array of nbt elements
/// </summary>
public sealed class NbtArray : INbtValue, IEnumerable<INbtValue>
{
    /// <summary>
    ///     Initializes this array with provided values
    /// </summary>
    /// <param name="values">Values to be added</param>
    public NbtArray(List<INbtValue> values)
    {
        Values = values;
    }

    /// <summary>
    ///     Default constructor
    /// </summary>
    public NbtArray()
    {
    }

    private List<INbtValue> Values { get; } = new();

    /// <inheritdoc />
    public IEnumerator<INbtValue> GetEnumerator()
    {
        return Values.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    /// <inheritdoc />
    public async Task SerializeInto(INbtWriter sw)
    {
        await sw.WriteBeginArrayAsync();
        foreach (var item in Values) await item.SerializeInto(sw);

        await sw.WriteEndArrayAsync();
    }

    /// <inheritdoc />
    public async Task SerializeInto(JsonTextWriter sw)
    {
        await sw.WriteStartArrayAsync();
        foreach (var item in Values) await item.SerializeInto(sw);

        await sw.WriteEndArrayAsync();
    }

    /// <summary>
    ///     Adds range of values into this NB array
    /// </summary>
    /// <param name="elements">Elements to be added</param>
    public void AddRange(params object[] elements)
    {
        foreach (var element in elements) Values.Add(INbtValue.Wrap(element));
    }

    /// <summary>
    ///     Adds an element to this NBT array
    /// </summary>
    /// <param name="element">Element to be added</param>
    public void Add(object element)
    {
        Values.Add(INbtValue.Wrap(element));
    }
}