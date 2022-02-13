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
        
        Console.WriteLine($"Loading module {mod.Name} of namespace {mod.Namespace}");
        
        Console.WriteLine(Directory.GetCurrentDirectory());
        
        mod.Startup();
        var curdir = Directory.GetCurrentDirectory();

        var build = Path.Join(curdir, "Build");
        var dpPath = Path.Join(build, "datapack");
        var rpPath = Path.Join(build, "resourcepack");

        var scopePath = Path.Join(dpPath, mod.Name);
        var dataPath = Path.Join(scopePath, "data");
        var nsPath = Path.Join(dataPath, mod.Namespace);
        
        FileUtils.ForceCreateDir(nsPath);

        if (Directory.Exists(Path.Join(curdir, "Assets")))
        {
            Console.WriteLine("Assets directory exists, extracting it...");
            FileUtils.ForceCreateDir(rpPath);
            if (File.Exists(Path.Join(curdir, "Assets", "icon.png")))
            {
                await FileUtils.CopyAsync(Path.Join(curdir, "Assets", "icon.png"), Path.Join(scopePath, "pack.png"));
                File.Delete(Path.Join(curdir, "Assets", "icon.png"));
            }
            
            await FileUtils.CopyFilesRecursively(Path.Join(curdir, "Assets"), rpPath);
        }

        // Dumping registries
        await Registries.Advancements.Dump(mod);
        await Registries.Functions.Dump(mod);
        
        // mcmeta file
        var meta = new PackMcMeta((int) mod.Format, mod.FullDescription);
        var mcmeta = await meta.Serialize();

        await File.WriteAllTextAsync(Path.Join(scopePath, "pack.mcmeta"), mcmeta);

        mod._locked = true;
    }
}