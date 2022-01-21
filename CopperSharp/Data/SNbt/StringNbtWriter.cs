using System.Globalization;

namespace CopperSharp.Data.SNbt;

/// <summary>
/// A writer, that can write string NBT objects to string.
/// </summary>
public class StringNbtWriter : IDisposable
{
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
    /// Writes the array begin tag
    /// </summary>
    public void WriteBeginArray()
    {
        sw.Write('[');
        PushDepth(State.Array);
    }

    /// <summary>
    /// Writes the array end tag
    /// </summary>
    public void WriteEndArray()
    {
        sw.Write(']');
        PullDepth();
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
    /// Writes a boolean
    /// </summary>
    /// <param name="b">Boolean to be written</param>
    public void WriteBool(bool b)
    {
        WriteByte((byte) (b ? 1 : 0));
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
    /// <param name="d">Double to be written</param>
    public void WriteFloat(double d)
    {
        ValidateCanWriteValue();
        sw.Write($"{d.ToString(CultureInfo.InvariantCulture)}f");
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
    /// Writes a uuid
    /// </summary>
    /// <param name="id"></param>
    public void WriteUuid(Guid id)
    {
        WriteString(id.ToString());
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

    private void ValidateArray()
    {
        if (_state == State.Array)
        {
            sw.Write(",");
        }
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

    private void ValidateCanWriteValue()
    {
        if (_state != State.Array && _state != State.InProperty)
        {
            throw new Exception("Writing a value in current state would result in malformed SNBT!");
        }

        ValidateArray();
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