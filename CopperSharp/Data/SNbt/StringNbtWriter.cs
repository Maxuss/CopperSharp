using System.Globalization;

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
    private StringWriter sw;

    /// <summary>
    /// Generates a new string nbt writer, piped to provided writer
    /// </summary>
    /// <param name="sw">Writer to which current SNBT writer should be piped</param>
    public StringNbtWriter(StringWriter sw)
    {
        this.sw = sw;
    }

    /// <inheritdoc />
    public void Dispose()
    {
        GC.SuppressFinalize(this);
        sw.Dispose();
    }

    /// <summary>
    /// Writes the component begin tag
    /// </summary>
    public void WriteBeginCompound()
    {
        sw.Write('{');
        PushDepth(State.Compound);
    }

    /// <summary>
    /// Writes the component end tag
    /// </summary>
    public void WriteEndCompound()
    {
        sw.Write('}');
        PullDepth();
    }

    /// <summary>
    /// Writes the component begin tag
    /// </summary>
    public async Task WriteBeginCompoundAsync()
    {
        await sw.WriteAsync('{');
        PushDepth(State.Compound);
    }

    /// <summary>
    /// Writes the component end tag
    /// </summary>
    public async Task WriteEndCompoundAsync()
    {
        await sw.WriteAsync('}');
        PullDepth();
    }

    /// <summary>
    /// Writes the array begin tag
    /// </summary>
    public void WriteBeginArray()
    {
        ValidateArray();
        sw.Write('[');
        PushDepth(State.Array);
    }

    /// <summary>
    /// Writes the array begin tag
    /// </summary>
    public async Task WriteBeginArrayAsync()
    {
        await ValidateArrayAsync();
        await sw.WriteAsync('[');
        PushDepth(State.Array);
    }

    /// <summary>
    /// Writes the array end tag
    /// </summary>
    public void WriteEndArray()
    {
        sw.Write(']');
        PullDepth();
        _arrayPosition = 0;
    }

    /// <summary>
    /// Writes the array end tag
    /// </summary>
    public async Task WriteEndArrayAsync()
    {
        await sw.WriteAsync(']');
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
            sw.Write(',');
        }

        sw.Write($"{name}:");
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
            await sw.WriteAsync(',');
        }

        await sw.WriteAsync($"{name}:");
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
        sw.Write($"{b}b");
        FinalizeProperty();
    }

    /// <summary>
    /// Writes a byte tag
    /// </summary>
    /// <param name="b">Byte to be written</param>
    public async Task WriteByteAsync(byte b)
    {
        await ValidateCanWriteValueAsync();
        await sw.WriteAsync($"{b}b");
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
        sw.Write(i.ToString());
        FinalizeProperty();
    }

    /// <summary>
    /// Writes a float
    /// </summary>
    /// <param name="f">Float to be written</param>
    public void WriteFloat(float f)
    {
        ValidateCanWriteValue();
        sw.Write($"{f.ToString(CultureInfo.InvariantCulture)}f");
        FinalizeProperty();
    }

    /// <summary>
    /// Writes a double as float
    /// </summary>
    /// <param name="f">Float to be written</param>
    public async Task WriteFloatAsync(float f)
    {
        await ValidateCanWriteValueAsync();
        await sw.WriteAsync($"{f.ToString(CultureInfo.InvariantCulture)}f");
        FinalizeProperty();
    }

    /// <summary>
    /// Writes a double as float
    /// </summary>
    /// <param name="d">Double to be written</param>
    public void WriteFloat(double d)
    {
        ValidateCanWriteValue();
        sw.Write($"{d.ToString(CultureInfo.InvariantCulture)}f");
        FinalizeProperty();
    }

    /// <summary>
    /// Writes a double as float
    /// </summary>
    /// <param name="d">Double to be written</param>
    public async Task WriteFloatAsync(double d)
    {
        await ValidateCanWriteValueAsync();
        await sw.WriteAsync($"{d.ToString(CultureInfo.InvariantCulture)}f");
        FinalizeProperty();
    }

    /// <summary>
    /// Writes a short
    /// </summary>
    /// <param name="s">Short to be written</param>
    public void WriteShort(short s)
    {
        ValidateCanWriteValue();
        sw.Write($"{s}s");
        FinalizeProperty();
    }

    /// <summary>
    /// Writes a short
    /// </summary>
    /// <param name="s">Short to be written</param>
    public async Task WriteShortAsync(short s)
    {
        await ValidateCanWriteValueAsync();
        await sw.WriteAsync($"{s}s");
        FinalizeProperty();
    }

    /// <summary>
    /// Writes a long
    /// </summary>
    /// <param name="l">Long to be written</param>
    public void WriteLong(long l)
    {
        ValidateCanWriteValue();
        sw.Write($"{l}L");
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
        sw.Write(raw);
        FinalizeProperty();
    }

    /// <summary>
    /// Writes a raw value, represented by string
    /// </summary>
    /// <param name="raw">Value to be written</param>
    public async Task WriteRawValueAsync(string raw)
    {
        await ValidateCanWriteValueAsync();
        await sw.WriteAsync(raw);
        FinalizeProperty();
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
        sw.Write(',');
    }

    /// <summary>
    /// Explicitly writes a comma to the writer
    /// </summary>
    public async Task WriteCommaAsync()
    {
        await sw.WriteAsync(',');
    }


    private void ValidateArray()
    {
        if (_state != State.Array) return;
        if (_arrayPosition > 0)
            sw.Write(",");
        _arrayPosition++;
    }

    private async Task ValidateArrayAsync()
    {
        if (_state != State.Array) return;
        if (_arrayPosition > 0)
            await sw.WriteAsync(",");
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
        sw.Write($"\"{escaped}\"");
    }

    private async Task WriteEscapedStringAsync(string val)
    {
        var escaped = val.Replace("\"", "\\\"");
        await sw.WriteAsync($"\"{escaped}\"");
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