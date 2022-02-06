using CopperSharp.Functions;

namespace CopperSharp.Registry;

/// <summary>
///     Output stream to write functions inside datapack
/// </summary>
public class FunctionOutputStream : RegistryOutputStream<IFunction>
{
    /// <summary>
    ///     Initializes a new function output stream
    /// </summary>
    /// <param name="path">Path to datapack's data/&lt;namespace&gt; directory</param>
    public FunctionOutputStream(string path)
    {
        FunctionsPath = Path.Join(path, "functions");
    }

    /// <summary>
    ///     Path to the current functions path
    /// </summary>
    public string FunctionsPath { get; set; }

    /// <inheritdoc />
    public override void Write(IFunction fn)
    {
        var path = Path.Join(FunctionsPath, $"{fn.PathTo}.mcfunction");
        if (File.Exists(path))
            File.Delete(path);
        fn.Dump(File.Create(path));
    }
}