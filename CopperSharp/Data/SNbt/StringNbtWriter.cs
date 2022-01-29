using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using CopperSharp.Data.Locations;
using CopperSharp.Item;

namespace CopperSharp.Data.SNbt;

/// <summary>
/// A writer, that can write string NBT objects to string.
/// </summary>
public class StringNbtWriter : IDisposable
{
    private int _arrayPosition = 0;
    private int _depthLevel;
    private State _previous = State.Error;
    private State _state = State.Open;
    private readonly StringWriter _sw;

    /// <summary>
    /// Generates a new string nbt writer, piped to provided writer
    /// </summary>
    /// <param name="sw">Writer to which current SNBT writer should be piped</param>
    public StringNbtWriter(StringWriter sw)
    {
        this._sw = sw;
    }

    /// <inheritdoc />
    public void Dispose()
    {
        GC.SuppressFinalize(this);
        _sw.Dispose();
    }

    /// <summary>
    /// Writes the component begin tag
    /// </summary>
    public void WriteBeginCompound()
    {
        if (_state == State.PostProperty)
        {
            _sw.Write(',');
        }

        _sw.Write('{');
        PushDepth(State.Compound);
    }

    /// <summary>
    /// Writes the component end tag
    /// </summary>
    public void WriteEndCompound()
    {
        _sw.Write('}');
        PullDepth();
    }

    /// <summary>
    /// Writes an identifier for array, e.g. I, or D
    /// </summary>
    /// <param name="id">Identifier to be written</param>
    public void WriteArrayIdentifier(string id)
    {
        _sw.Write($"{id};");
    }

    /// <summary>
    /// Writes the component begin tag
    /// </summary>
    public async Task WriteBeginCompoundAsync()
    {
        await _sw.WriteAsync('{');
        PushDepth(State.Compound);
    }

    /// <summary>
    /// Writes the component end tag
    /// </summary>
    public async Task WriteEndCompoundAsync()
    {
        await _sw.WriteAsync('}');
        PullDepth();
    }

    /// <summary>
    /// Writes the array begin tag
    /// </summary>
    public void WriteBeginArray()
    {
        ValidateArray();
        _sw.Write('[');
        PushDepth(State.Array);
    }

    /// <summary>
    /// Writes the array begin tag
    /// </summary>
    public async Task WriteBeginArrayAsync()
    {
        await ValidateArrayAsync();
        await _sw.WriteAsync('[');
        PushDepth(State.Array);
    }

    /// <summary>
    /// Writes the array end tag
    /// </summary>
    public void WriteEndArray()
    {
        _sw.Write(']');
        PullDepth();
        _arrayPosition = 0;
    }

    /// <summary>
    /// Writes the array end tag
    /// </summary>
    public async Task WriteEndArrayAsync()
    {
        await _sw.WriteAsync(']');
        PullDepth();
        _arrayPosition = 0;
    }

    /// <summary>
    /// Writes the property name and allows writing value
    /// </summary>
    /// <param name="name">Name of the property to be written</param>
    public void WritePropertyName(string name)
    {
        if (_state == State.PostProperty)
        {
            _sw.Write(',');
        }

        _sw.Write($"{name}:");
        _state = State.InProperty;
    }

    /// <summary>
    /// Writes the property name and allows writing value
    /// </summary>
    /// <param name="name">Name of the property to be written</param>
    public async Task WritePropertyNameAsync(string name)
    {
        if (_state == State.PostProperty)
        {
            await _sw.WriteAsync(',');
        }

        await _sw.WriteAsync($"{name}:");
        _state = State.InProperty;
    }

    /// <summary>
    /// Writes and escapes a string
    /// </summary>
    /// <param name="str">String to be written</param>
    public void WriteString(string str)
    {
        ValidateCanWriteValue();
        WriteEscapedString(str);
        FinalizeProperty();
    }

    /// <summary>
    /// Writes and escapes a string
    /// </summary>
    /// <param name="str">String to be written</param>
    public async Task WriteStringAsync(string str)
    {
        await ValidateCanWriteValueAsync();
        await WriteEscapedStringAsync(str);
        FinalizeProperty();
    }

    /// <summary>
    /// Writes a byte tag
    /// </summary>
    /// <param name="b">Byte to be written</param>
    public void WriteByte(byte b)
    {
        ValidateCanWriteValue();
        _sw.Write($"{b}b");
        FinalizeProperty();
    }
    
    /// <summary>
    /// Writes a signed byte tag
    /// </summary>
    /// <param name="b">Signed byte to be written</param>
    public void WriteSByte(sbyte b)
    {
        ValidateCanWriteValue();
        _sw.Write($"{b}b");
        FinalizeProperty();
    }

    /// <summary>
    /// Writes a byte tag
    /// </summary>
    /// <param name="b">Byte to be written</param>
    public async Task WriteByteAsync(byte b)
    {
        await ValidateCanWriteValueAsync();
        await _sw.WriteAsync($"{b}b");
        FinalizeProperty();
    }

    /// <summary>
    /// Writes a boolean
    /// </summary>
    /// <param name="b">Boolean to be written</param>
    public void WriteBool(bool b)
    {
        WriteByte((byte) (b ? 1 : 0));
    }

    /// <summary>
    /// Writes a boolean
    /// </summary>
    /// <param name="b">Boolean to be written</param>
    public async Task WriteBoolAsync(bool b)
    {
        await WriteByteAsync((byte) (b ? 1 : 0));
    }

    /// <summary>
    /// Writes an int
    /// </summary>
    /// <param name="i">Integer to be written</param>
    public void WriteInteger(int i)
    {
        ValidateCanWriteValue();
        _sw.Write(i.ToString());
        FinalizeProperty();
    }

    /// <summary>
    /// Writes a float
    /// </summary>
    /// <param name="f">Float to be written</param>
    public void WriteFloat(float f)
    {
        ValidateCanWriteValue();
        _sw.Write($"{f.ToString(CultureInfo.InvariantCulture)}f");
        FinalizeProperty();
    }

    /// <summary>
    /// Writes a double
    /// </summary>
    /// <param name="d">Double to be written</param>
    public void WriteDouble(double d)
    {
        ValidateCanWriteValue();
        _sw.Write($"{d.ToString(CultureInfo.InvariantCulture)}");
        FinalizeProperty();
    }

    /// <summary>
    /// Writes a position
    /// </summary>
    /// <param name="loc">Location to be written</param>
    public void WritePosition(Location loc)
    {
        WriteBeginCompound();
        WriteInteger("X", (int) loc.X.Value);
        WriteInteger("Y", (int) loc.Y.Value);
        WriteInteger("Z", (int) loc.Z.Value);
        WriteEndCompound();
    }

    /// <summary>
    /// Writes a position
    /// </summary>
    /// <param name="property">Property name</param>
    /// <param name="loc">Location to be written</param>
    public void WritePosition(string property, Location loc)
    {
        WritePropertyName(property);
        WritePosition(loc);
    }

    /// <summary>
    /// Writes a double as float
    /// </summary>
    /// <param name="f">Float to be written</param>
    public async Task WriteFloatAsync(float f)
    {
        await ValidateCanWriteValueAsync();
        await _sw.WriteAsync($"{f.ToString(CultureInfo.InvariantCulture)}f");
        FinalizeProperty();
    }

    /// <summary>
    /// Writes a double as float
    /// </summary>
    /// <param name="d">Double to be written</param>
    public void WriteFloat(double d)
    {
        ValidateCanWriteValue();
        _sw.Write($"{d.ToString(CultureInfo.InvariantCulture)}f");
        FinalizeProperty();
    }

    /// <summary>
    /// Writes a double as float
    /// </summary>
    /// <param name="d">Double to be written</param>
    public async Task WriteFloatAsync(double d)
    {
        await ValidateCanWriteValueAsync();
        await _sw.WriteAsync($"{d.ToString(CultureInfo.InvariantCulture)}f");
        FinalizeProperty();
    }

    /// <summary>
    /// Writes a short
    /// </summary>
    /// <param name="s">Short to be written</param>
    public void WriteShort(short s)
    {
        ValidateCanWriteValue();
        _sw.Write($"{s}s");
        FinalizeProperty();
    }

    /// <summary>
    /// Writes a short
    /// </summary>
    /// <param name="s">Short to be written</param>
    public async Task WriteShortAsync(short s)
    {
        await ValidateCanWriteValueAsync();
        await _sw.WriteAsync($"{s}s");
        FinalizeProperty();
    }

    /// <summary>
    /// Writes a long
    /// </summary>
    /// <param name="l">Long to be written</param>
    public void WriteLong(long l)
    {
        ValidateCanWriteValue();
        _sw.Write($"{l}L");
        FinalizeProperty();
    }

    /// <summary>
    /// Writes a provided UUID
    /// </summary>
    /// <param name="id"></param>
    public void WriteUuid(Guid id)
    {
        WriteString(id.ToString());
    }

    /// <summary>
    /// Writes a provided UUID as an array of integers
    /// </summary>
    /// <param name="id">Id to be written</param>
    public void WriteUuidArray(Guid id)
    {
        var bytes = id.ToByteArray();
        var ints = new int[4];
        for (var i = 0; i < 4; i++)
        {
            ints[i] = BitConverter.ToInt32(bytes, i * 4);
        }

        WriteRawValue($"[I; {ints[0]}, {ints[1]}, {ints[2]}, {ints[3]}]");
    }

    /// <summary>
    /// Writes a raw value, represented by string
    /// </summary>
    /// <param name="raw">Value to be written</param>
    public void WriteRawValue(string raw)
    {
        ValidateCanWriteValue();
        _sw.Write(raw);
        FinalizeProperty();
    }

    /// <summary>
    /// Writes a raw value, represented by string
    /// </summary>
    /// <param name="raw">Value to be written</param>
    public async Task WriteRawValueAsync(string raw)
    {
        await ValidateCanWriteValueAsync();
        await _sw.WriteAsync(raw);
        FinalizeProperty();
    }


    /// <summary>
    /// Writes an item to the stream
    /// </summary>
    /// <param name="item">Item to be written</param>
    /// <param name="slot">Slot data of this item. Optional</param>
    [SuppressMessage("ReSharper", "ConstantConditionalAccessQualifier")]
    public void WriteItem(ItemStack? item, int? slot = null)
    {
        if (item == null)
        {
            WriteBeginCompound();
            WriteEndCompound();
            return;
        }

        WriteBeginCompound();
        if (slot != null)
            WriteInteger("Slot", slot ?? 0);
        WriteInteger("Count", item?.Amount ?? 0);
        WriteString("id", item?.Material.Id.ToString() ?? "minecraft:null");
        if (item?.Meta != null)
        {
            WritePropertyName("tag");
            WriteRawValue(item?.Meta?.Serialize() ?? "{}");
        }

        WriteEndCompound();
    }


    /// <summary>
    /// Writes and escapes a string
    /// </summary>
    /// <param name="property">Property name</param>
    /// <param name="str">String to be written</param>
    public void WriteString(string property, string str)
    {
        WritePropertyName(property);
        WriteString(str);
    }

    /// <summary>
    /// Writes a byte tag
    /// </summary>
    /// <param name="property">Property name</param>
    /// <param name="b">Byte to be written</param>
    public void WriteByte(string property, byte b)
    {
        WritePropertyName(property);
        WriteByte(b);
    }

    /// <summary>
    /// Writes a boolean
    /// </summary>
    /// <param name="property">Property name</param>
    /// <param name="b">Boolean to be written</param>
    public void WriteBool(string property, bool b)
    {
        WritePropertyName(property);
        WriteBool(b);
    }

    /// <summary>
    /// Writes an int
    /// </summary>
    /// <param name="property">Property name</param>
    /// <param name="i">Integer to be written</param>
    public void WriteInteger(string property, int i)
    {
        WritePropertyName(property);
        WriteInteger(i);
    }

    /// <summary>
    /// Writes a float
    /// </summary>
    /// <param name="property">Property name</param>
    /// <param name="f">Float to be written</param>
    public void WriteFloat(string property, float f)
    {
        WritePropertyName(property);
        WriteFloat(f);
    }

    /// <summary>
    /// Writes a double as float
    /// </summary>
    /// <param name="property">Property name</param>
    /// <param name="d">Double to be written</param>
    public void WriteFloat(string property, double d)
    {
        WritePropertyName(property);
        WriteFloat(d);
    }

    /// <summary>
    /// Writes a double
    /// </summary>
    /// <param name="property">Property name</param>
    /// <param name="d">Double to be written</param>
    public void WriteDouble(string property, double d)
    {
        WritePropertyName(property);
        WriteDouble(d);
    }


    /// <summary>
    /// Writes a short
    /// </summary>
    /// <param name="property">Property name</param>
    /// <param name="s">Short to be written</param>
    public void WriteShort(string property, short s)
    {
        WritePropertyName(property);
        WriteShort(s);
    }

    /// <summary>
    /// Writes a long
    /// </summary>
    /// <param name="property">Property name</param>
    /// <param name="l">Long to be written</param>
    public void WriteLong(string property, long l)
    {
        WritePropertyName(property);
        WriteLong(l);
    }

    /// <summary>
    /// Writes a provided UUID
    /// </summary>
    /// <param name="property">Property name</param>
    /// <param name="id"></param>
    public void WriteUuid(string property, Guid id)
    {
        WritePropertyName(property);
        WriteUuid(id);
    }

    /// <summary>
    /// Writes a provided UUID as an array of integers
    /// </summary>
    /// <param name="property">Property name</param>
    /// <param name="id">Id to be written</param>
    public void WriteUuidArray(string property, Guid id)
    {
        WritePropertyName(property);
        WriteUuidArray(id);
    }

    /// <summary>
    /// Writes a raw value, represented by string
    /// </summary>
    /// <param name="property">Property name</param>
    /// <param name="raw">Value to be written</param>
    public void WriteRawValue(string property, string raw)
    {
        WritePropertyName(property);
        WriteRawValue(raw);
    }

    /// <summary>
    /// Explicitly writes a comma to the writer
    /// </summary>
    public void WriteComma()
    {
        _sw.Write(',');
    }

    /// <summary>
    /// Explicitly writes a comma to the writer
    /// </summary>
    public async Task WriteCommaAsync()
    {
        await _sw.WriteAsync(',');
    }


    private void ValidateArray()
    {
        if (_state != State.Array) return;
        if (_arrayPosition > 0)
            _sw.Write(",");
        _arrayPosition++;
    }

    private async Task ValidateArrayAsync()
    {
        if (_state != State.Array) return;
        if (_arrayPosition > 0)
            await _sw.WriteAsync(",");
        _arrayPosition++;
    }

    private void FinalizeProperty()
    {
        if (_state != State.Array)
        {
            _state = State.PostProperty;
        }
    }

    private void WriteEscapedString(string val)
    {
        var escaped = val.Replace("\"", "\\\"");
        _sw.Write($"\"{escaped}\"");
    }

    private async Task WriteEscapedStringAsync(string val)
    {
        var escaped = val.Replace("\"", "\\\"");
        await _sw.WriteAsync($"\"{escaped}\"");
    }

    private void ValidateCanWriteValue()
    {
        if (_state != State.Array && _state != State.InProperty)
        {
            throw new Exception("Writing a value in current state would result in malformed SNBT!");
        }

        ValidateArray();
    }

    private async Task ValidateCanWriteValueAsync()
    {
        if (_state != State.Array && _state != State.InProperty)
        {
            throw new Exception("Writing a value in current state would result in malformed SNBT!");
        }

        await ValidateArrayAsync();
    }

    private void PullDepth()
    {
        if (_depthLevel <= 0) return;
        _depthLevel--;
        _state = _previous;
    }

    private void PushDepth(State newState)
    {
        _depthLevel++;
        _previous = _state;
        _state = newState;
    }

    private enum State
    {
        Error = 0,
        Open = 1,
        Compound = 3,
        Array = 4,
        PostProperty = 5,
        InProperty = 6
    }
}