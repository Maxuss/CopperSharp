namespace CopperSharp.Registry;

/// <summary>
/// An output stream for registries to write into, usually piped into file
/// </summary>
/// <typeparam name="TWrite">Type of element stored in registry that will be written into stream</typeparam>
public abstract class RegistryOutputStream<TWrite> : IDisposable, IAsyncDisposable
{
    /// <summary>
    /// Base stream writer of this stream
    /// </summary>
    protected StreamWriter? Base { get; }

    /// <summary>
    /// Creates a new registry output stream piped to provided path
    /// </summary>
    /// <param name="path">Path to which the registry data should be written</param>
    protected RegistryOutputStream(string path)
    {
        Base = new StreamWriter(File.Open(path, FileMode.Create));
    }

    /// <summary>
    /// A no-args constructor for inheritors
    /// </summary>
    protected RegistryOutputStream()
    {
    }

    /// <summary>
    /// Writes an element to the stream
    /// </summary>
    /// <param name="write">Element to be written</param>
    public abstract void Write(TWrite write);


    /// <inheritdoc />
    public void Dispose()
    {
        GC.SuppressFinalize(this);
        Base?.Dispose();
    }

    /// <inheritdoc />
    public ValueTask DisposeAsync()
    {
        GC.SuppressFinalize(this);
        return Base?.DisposeAsync() ?? ValueTask.CompletedTask;
    }
}