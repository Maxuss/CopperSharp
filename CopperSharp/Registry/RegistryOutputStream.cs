using System.Text;

namespace CopperSharp.Registry;

public abstract class RegistryOutputStream : StreamWriter
{
    private StreamWriter _base;

    /// <inheritdoc />
    protected RegistryOutputStream(Stream stream) : base(stream)
    {
        _base = new StreamWriter(stream);
    }

    /// <inheritdoc />
    protected RegistryOutputStream(Stream stream, Encoding encoding) : base(stream, encoding)
    {
        _base = new StreamWriter(stream, encoding);
    }

    /// <inheritdoc />
    protected RegistryOutputStream(Stream stream, Encoding encoding, int bufferSize) : base(stream, encoding,
        bufferSize)
    {
        _base = new StreamWriter(stream, encoding, bufferSize);
    }

    /// <inheritdoc />
    protected RegistryOutputStream(Stream stream, Encoding? encoding = null, int bufferSize = -1,
        bool leaveOpen = false) : base(stream, encoding, bufferSize, leaveOpen)
    {
        _base = new StreamWriter(stream, encoding, bufferSize, leaveOpen);
    }

    /// <inheritdoc />
    protected RegistryOutputStream(string path) : base(path)
    {
        _base = new StreamWriter(path);
    }

    /// <inheritdoc />
    protected RegistryOutputStream(string path, FileStreamOptions options) : base(path, options)
    {
        _base = new StreamWriter(path, options);
    }

    /// <inheritdoc />
    protected RegistryOutputStream(string path, bool append) : base(path, append)
    {
        _base = new StreamWriter(path, append);
    }

    /// <inheritdoc />
    protected RegistryOutputStream(string path, bool append, Encoding encoding) : base(path, append, encoding)
    {
        _base = new StreamWriter(path, append, encoding);
    }

    /// <inheritdoc />
    protected RegistryOutputStream(string path, bool append, Encoding encoding, int bufferSize) : base(path, append,
        encoding, bufferSize)
    {
        _base = new StreamWriter(path, append, encoding, bufferSize);
    }

    /// <inheritdoc />
    protected RegistryOutputStream(string path, Encoding encoding, FileStreamOptions options) : base(path, encoding,
        options)
    {
        _base = new StreamWriter(path, encoding, options);
    }
}