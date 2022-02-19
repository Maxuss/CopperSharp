using CopperSharp.Data.Locations;
using CopperSharp.Item;

namespace CopperSharp.Data.SNbt;

/// <summary>
///     A global interface for nbt writers
/// </summary>
public interface INbtWriter : IDisposable, IAsyncDisposable
{
    /// <summary>
    ///     Writes the component begin tag
    /// </summary>
    void WriteBeginCompound();

    /// <summary>
    ///     Writes the component begin tag asynchronously
    /// </summary>
    Task WriteBeginCompoundAsync();

    /// <summary>
    ///     Writes the component end tag
    /// </summary>
    void WriteEndCompound();

    /// <summary>
    ///     Writes the component end tag asynchronously
    /// </summary>
    Task WriteEndCompoundAsync();

    /// <summary>
    ///     Writes an identifier for array, e.g. I, or D
    /// </summary>
    /// <param name="id">Identifier to be written</param>
    void WriteArrayIdentifier(string id);

    /// <summary>
    ///     Writes an identifier for array, e.g. I, or D asynchronously
    /// </summary>
    /// <param name="id">Identifier to be written</param>
    Task WriteArrayIdentifierAsync(string id);

    /// <summary>
    ///     Writes the array begin tag
    /// </summary>
    void WriteBeginArray();

    /// <summary>
    ///     Writes the array begin tag asynchronously
    /// </summary>
    Task WriteBeginArrayAsync();

    /// <summary>
    ///     Writes the array end tag
    /// </summary>
    void WriteEndArray();

    /// <summary>
    ///     Writes the array end tag asynchronously
    /// </summary>
    Task WriteEndArrayAsync();

    /// <summary>
    ///     Writes the property name and allows writing value
    /// </summary>
    /// <param name="name">Name of the property to be written</param>
    void WritePropertyName(string name);

    /// <summary>
    ///     Writes the property name and allows writing value
    /// </summary>
    /// <param name="name">Name of the property to be written</param>
    Task WritePropertyNameAsync(string name);

    /// <summary>
    ///     Writes and escapes a string
    /// </summary>
    /// <param name="str">String to be written</param>
    void WriteString(string str);

    /// <summary>
    ///     Writes and escapes a string
    /// </summary>
    /// <param name="property">Property name</param>
    /// <param name="str">String to be written</param>
    void WriteString(string property, string str);

    /// <summary>
    ///     Writes and escapes a string
    /// </summary>
    /// <param name="str">String to be written</param>
    Task WriteStringAsync(string str);

    /// <summary>
    ///     Writes and escapes a string asynchronously
    /// </summary>
    /// <param name="property">Property name</param>
    /// <param name="str">String to be written</param>
    Task WriteStringAsync(string property, string str);

    /// <summary>
    ///     Writes a byte tag
    /// </summary>
    /// <param name="b">Byte to be written</param>
    void WriteByte(byte b);

    /// <summary>
    ///     Writes a byte tag
    /// </summary>
    /// <param name="property">Property name</param>
    /// <param name="b">Byte to be written</param>
    void WriteByte(string property, byte b);

    /// <summary>
    ///     Writes a signed byte tag
    /// </summary>
    /// <param name="b">Signed byte to be written</param>
    void WriteSByte(sbyte b);

    /// <summary>
    ///     Writes a signed byte tag asynchronously
    /// </summary>
    /// <param name="b">Signed byte to be written</param>
    Task WriteSByteAsync(sbyte b);

    /// <summary>
    ///     Writes a byte tag
    /// </summary>
    /// <param name="b">Byte to be written</param>
    Task WriteByteAsync(byte b);

    /// <summary>
    ///     Writes a byte tag asynchronously
    /// </summary>
    /// <param name="property">Property name</param>
    /// <param name="b">Byte to be written</param>
    Task WriteByteAsync(string property, byte b);

    /// <summary>
    ///     Writes a boolean
    /// </summary>
    /// <param name="b">Boolean to be written</param>
    void WriteBool(bool b);

    /// <summary>
    ///     Writes a boolean
    /// </summary>
    /// <param name="property">Property name</param>
    /// <param name="b">Boolean to be written</param>
    void WriteBool(string property, bool b);

    /// <summary>
    ///     Writes a boolean
    /// </summary>
    /// <param name="b">Boolean to be written</param>
    Task WriteBoolAsync(bool b);

    /// <summary>
    ///     Writes a boolean asynchronously
    /// </summary>
    /// <param name="property">Property name</param>
    /// <param name="b">Boolean to be written</param>
    Task WriteBoolAsync(string property, bool b);

    /// <summary>
    ///     Writes an int
    /// </summary>
    /// <param name="i">Integer to be written</param>
    void WriteInteger(int i);

    /// <summary>
    ///     Writes an int
    /// </summary>
    /// <param name="property">Property name</param>
    /// <param name="i">Integer to be written</param>
    void WriteInteger(string property, int i);

    /// <summary>
    ///     Writes a float
    /// </summary>
    /// <param name="f">Float to be written</param>
    void WriteFloat(float f);

    /// <summary>
    ///     Writes a double as float
    /// </summary>
    /// <param name="d">Double to be written</param>
    void WriteFloat(double d);

    /// <summary>
    ///     Writes a float
    /// </summary>
    /// <param name="property">Property name</param>
    /// <param name="f">Float to be written</param>
    void WriteFloat(string property, float f);

    /// <summary>
    ///     Writes a double as float
    /// </summary>
    /// <param name="property">Property name</param>
    /// <param name="d">Double to be written</param>
    void WriteFloat(string property, double d);

    /// <summary>
    ///     Writes a double
    /// </summary>
    /// <param name="d">Double to be written</param>
    void WriteDouble(double d);

    /// <summary>
    ///     Writes a double
    /// </summary>
    /// <param name="property">Property name</param>
    /// <param name="d">Double to be written</param>
    void WriteDouble(string property, double d);

    /// <summary>
    ///     Writes an int asynchronously
    /// </summary>
    /// <param name="i">Integer to be written</param>
    Task WriteIntegerAsync(int i);

    /// <summary>
    ///     Writes an int asynchronously
    /// </summary>
    /// <param name="property">Property name</param>
    /// <param name="i">Integer to be written</param>
    Task WriteIntegerAsync(string property, int i);

    /// <summary>
    ///     Writes a double asynchronously
    /// </summary>
    /// <param name="d">Double to be written</param>
    Task WriteDoubleAsync(double d);

    /// <summary>
    ///     Writes a double asynchronously
    /// </summary>
    /// <param name="property">Property name</param>
    /// <param name="d">Double to be written</param>
    Task WriteDoubleAsync(string property, double d);

    /// <summary>
    ///     Writes a position
    /// </summary>
    /// <param name="loc">Location to be written</param>
    void WritePosition(Location loc);

    /// <summary>
    ///     Writes a position
    /// </summary>
    /// <param name="property">Property name</param>
    /// <param name="loc">Location to be written</param>
    void WritePosition(string property, Location loc);

    /// <summary>
    ///     Writes a position asynchronously
    /// </summary>
    /// <param name="loc">Location to be written</param>
    Task WritePositionAsync(Location loc);

    /// <summary>
    ///     Writes a position asynchronously
    /// </summary>
    /// <param name="property">Property name</param>
    /// <param name="loc">Location to be written</param>
    Task WritePositionAsync(string property, Location loc);

    /// <summary>
    ///     Writes a double as float
    /// </summary>
    /// <param name="f">Float to be written</param>
    Task WriteFloatAsync(float f);

    /// <summary>
    ///     Writes a double as float
    /// </summary>
    /// <param name="d">Double to be written</param>
    Task WriteFloatAsync(double d);

    /// <summary>
    ///     Writes a short
    /// </summary>
    /// <param name="s">Short to be written</param>
    void WriteShort(short s);

    /// <summary>
    ///     Writes a short
    /// </summary>
    /// <param name="property">Property name</param>
    /// <param name="s">Short to be written</param>
    void WriteShort(string property, short s);

    /// <summary>
    ///     Writes a short
    /// </summary>
    /// <param name="s">Short to be written</param>
    Task WriteShortAsync(short s);

    /// <summary>
    ///     Writes a short asynchronously
    /// </summary>
    /// <param name="property">Property name</param>
    /// <param name="s">Short to be written</param>
    Task WriteShortAsync(string property, short s);

    /// <summary>
    ///     Writes a long
    /// </summary>
    /// <param name="l">Long to be written</param>
    void WriteLong(long l);

    /// <summary>
    ///     Writes a long
    /// </summary>
    /// <param name="property">Property name</param>
    /// <param name="l">Long to be written</param>
    void WriteLong(string property, long l);

    /// <summary>
    ///     Writes a long asynchronously
    /// </summary>
    /// <param name="l">Long to be written</param>
    Task WriteLongAsync(long l);

    /// <summary>
    ///     Writes a long asynchronously
    /// </summary>
    /// <param name="property">Property name</param>
    /// <param name="l">Long to be written</param>
    Task WriteLongAsync(string property, long l);

    /// <summary>
    ///     Writes a provided UUID
    /// </summary>
    /// <param name="id"></param>
    void WriteUuid(Guid id);

    /// <summary>
    ///     Writes a provided UUID as an array of integers
    /// </summary>
    /// <param name="id">Id to be written</param>
    void WriteUuidArray(Guid id);

    /// <summary>
    ///     Writes a provided UUID as an array of integers
    /// </summary>
    /// <param name="property">Property name</param>
    /// <param name="id">Id to be written</param>
    void WriteUuidArray(string property, Guid id);

    /// <summary>
    ///     Writes a provided UUID as an array of integers asynchronously
    /// </summary>
    /// <param name="id">Id to be written</param>
    Task WriteUuidArrayAsync(Guid id);

    /// <summary>
    ///     Writes a provided UUID as an array of integers asynchronously
    /// </summary>
    /// <param name="property">Property name</param>
    /// <param name="id">Id to be written</param>
    Task WriteUuidArrayAsync(string property, Guid id);

    /// <summary>
    ///     Writes a raw value, represented by string
    /// </summary>
    /// <param name="raw">Value to be written</param>
    void WriteRawValue(string raw);

    /// <summary>
    ///     Writes a raw value, represented by string
    /// </summary>
    /// <param name="property">Property name</param>
    /// <param name="raw">Value to be written</param>
    void WriteRawValue(string property, string raw);

    /// <summary>
    ///     Writes a raw value, represented by string
    /// </summary>
    /// <param name="raw">Value to be written</param>
    Task WriteRawValueAsync(string raw);

    /// <summary>
    ///     Writes a raw value, represented by string asynchronously
    /// </summary>
    /// <param name="property">Property name</param>
    /// <param name="raw">Value to be written</param>
    Task WriteRawValueAsync(string property, string raw);

    /// <summary>
    ///     Writes an item to the stream
    /// </summary>
    /// <param name="item">Item to be written</param>
    /// <param name="slot">Slot data of this item. Optional</param>
    Task WriteItem(ItemStack? item, int? slot = null);
}