using System.IO.Compression;
using CopperSharp.Registry;
using CopperSharp.Utils;

namespace CopperSharp.Modules;

/// <summary>
/// A global module loader
/// </summary>
public sealed class ModuleLoader
{
    private ModuleLoader()
    {
        
    }

    /// <summary>
    /// A global module loader
    /// </summary>
    public static ModuleLoader GlobalLoader { get; } = new();

    /// <summary>
    /// Asynchronously loads a provided module
    /// </summary>
    /// <param name="mod">Module to be loaded</param>
    public async Task LoadAsync(Module mod)
    {
        if (mod._locked)
            return;
        
        Console.WriteLine($"Starting module {mod.Name} of namespace {mod.Namespace}...");

        mod.Startup();
        
        Console.WriteLine($"Initializing build hooks for module {mod.Name}");
        var curdir = Directory.GetCurrentDirectory();

        Console.WriteLine("Creating build dir");
        var build = Path.Join(curdir, "Build");
        var dpPath = Path.Join(build, "datapack");
        var rpPath = Path.Join(build, "resourcepack");

        var dataPath = Path.Join(dpPath, "data");
        var nsPath = Path.Join(dataPath, mod.Namespace);
        
        FileUtils.ForceCreateDir(nsPath);
        
        if (Directory.Exists(Path.Join(curdir, "Assets")))
        {
            Console.WriteLine("Assets directory exists, extracting it...");
            FileUtils.ForceCreateDir(rpPath);
            if (File.Exists(Path.Join(curdir, "Assets", "icon.png")))
            {
                await FileUtils.CopyAsync(Path.Join(curdir, "Assets", "icon.png"), Path.Join(dpPath, "pack.png"));
                File.Delete(Path.Join(curdir, "Assets", "icon.png"));
            }
            
            await FileUtils.CopyFilesRecursively(Path.Join(curdir, "Assets"), rpPath);
        }

        // Dumping registries
        Console.WriteLine("Dumping registry contents");
        await Registries.Advancements.Dump(mod);
        await Registries.Functions.Dump(mod);
        
        // mcmeta file
        Console.WriteLine("Creating meta file");
        var meta = new PackMcMeta((int) mod.Format, mod.FullDescription);
        var mcmeta = await meta.Serialize();

        await File.WriteAllTextAsync(Path.Join(dpPath, "pack.mcmeta"), mcmeta);
        
        // building into zip files
        Console.WriteLine("Building zip file output.");
        FileUtils.ForceCreateDir(Path.Join(Directory.GetCurrentDirectory(), "Output"));
        var zipPath = Path.Join(Directory.GetCurrentDirectory(), "Output", $"{mod.Name}.zip");
        
        ZipFile.CreateFromDirectory(dpPath, zipPath, CompressionLevel.Fastest, false);
        if (Directory.Exists(rpPath))
        {
            var rpZip = Path.Join(Directory.GetCurrentDirectory(), "Output", $"{mod.Name}_resources.zip");
            ZipFile.CreateFromDirectory(rpPath, rpZip, CompressionLevel.Fastest, false);
        }
        Console.WriteLine($"Finished building module {mod.Name}!");

        mod._locked = true;
    }
}