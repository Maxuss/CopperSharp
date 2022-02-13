using System.Text;

namespace CopperSharp.Modules;
using Dirs = Directory;
/// <summary>
/// Represents a stream, piped to a certain directory, allowing to write module files
/// </summary>
public sealed class ModuleOutputStream
{
    private string Directory { get; }

    /// <summary>
    /// Constructs a new module output stream
    /// </summary>
    /// <param name="mod">Owning module</param>
    /// <param name="port">Type of output. e.g. "functions"</param>
    public ModuleOutputStream(Module mod, string port)
    {
        Directory = Path.Join(Dirs.GetCurrentDirectory(), "Build", "datapack", "data", mod.Namespace, port);
        if(Dirs.Exists(Directory))
            Dirs.Delete(Directory, true);

        Dirs.CreateDirectory(Directory);
    }

    /// <summary>
    /// Writes provided string into relative file
    /// </summary>
    /// <param name="file">File to be used</param>
    /// <param name="data">Data to be written</param>
    public void Write(string file, string data) 
        => Write(file, Encoding.UTF8.GetBytes(data));
    
    /// <summary>
    /// Writes provided bytes into relative file
    /// </summary>
    /// <param name="file">File to be used</param>
    /// <param name="data">Data to be written</param>
    public void Write(string file, byte[] data)
    {
        var f = Path.Join(Directory, file);
        if(File.Exists(f))
            File.Delete(f);

        using var stream = File.Create(f);
        stream.Write(data);
    }
    
    /// <summary>
    /// Writes provided string into relative file asynchronously
    /// </summary>
    /// <param name="file">File to be used</param>
    /// <param name="data">Data to be written</param>
    public async Task WriteAsync(string file, string data)
        => await WriteAsync(file, Encoding.UTF8.GetBytes(data));
    
    /// <summary>
    /// Writes provided bytes into relative file asynchronously
    /// </summary>
    /// <param name="file">File to be used</param>
    /// <param name="data">Data to be written</param>
    public async Task WriteAsync(string file, byte[] data)
    {
        var f = Path.Join(Directory, file);
        if(File.Exists(f))
            File.Delete(f);

        await using var stream = File.Create(f);
        await stream.WriteAsync(data);
    }

    /// <summary>
    /// Opens a new stream for provided relative file name
    /// </summary>
    /// <param name="file">Relative file name</param>
    /// <returns>Opened stream</returns>
    public Stream Open(string file)
    {
        var f = Path.Join(Directory, file);
        if(File.Exists(f))
            File.Delete(f);
        
        return File.Create(f);
    }
}