using System.IO.Compression;
using CopperSharp.Hooks;
using CopperSharp.Models;
using CopperSharp.Registry;
using CopperSharp.Utils;

namespace CopperSharp.Modules;

/// <summary>
///     A global module loader
/// </summary>
public sealed class ModuleLoader
{
    private ModuleLoader()
    {
    }

    /// <summary>
    /// Name of the resourcepack directory from the build folder
    /// </summary>
    public static readonly string ResourcesDir = "resources";
    /// <summary>
    /// Name of the datapack directory from the build folder
    /// </summary>
    public static readonly string DatapackDir = "pack";
    private int WarningCount { get; set; }
    private int ErrorCount { get; set; }
    private string? OutputDirectory { get; set; }
    private string? BuildDirectory { get; set; }
    private string? ResourcesDirectory { get; set; }
    private bool InitRp { get; set; } = false;
    private Dictionary<string, string> ResourceCache { get; } = new();

    /// <summary>
    /// A global hook handler
    /// </summary>
    public static HookHandler HookHandler { get; set; } = new();
    
    /// <summary>
    /// Module that is currently processed. May be null
    /// </summary>
    public static Module? CurrentModule { get; set; }
    
    /// <summary>
    ///     A global module loader
    /// </summary>
    public static ModuleLoader GlobalLoader { get; } = new();

    /// <summary>
    /// A global model manager
    /// </summary>
    public static ModelManager ModelManager { get; } = new();

    /// <summary>
    ///     Sets the .zip archive output directory. Can be set to minecraft datapack folder for debugging.
    /// </summary>
    /// <param name="dir">Directory to be set</param>
    public void SetOutputDirectory(string dir)
    {
        OutputDirectory = dir;
    }

    /// <summary>
    /// Sets the directory to which the resource pack will be outputted
    /// </summary>
    /// <param name="dir">Directory to be set</param>
    public void SetResourcepackDirectory(string dir)
    {
        ResourcesDirectory = dir;
    }

    /// <summary>
    /// Toggles the generation of resourcepack's pack.mcmeta file
    /// </summary>
    /// <param name="enable">Whether to enable the resourcepack</param>
    public void ToggleResourcepack(bool enable = true)
    {
        InitRp = enable;
    }

    /// <summary>
    ///     Sets the build .mcfunction and .json directory. Can be set to minecraft datapack folder for debugging.
    /// </summary>
    /// <param name="dir">Directory to be set</param>
    public void SetBuildDirectory(string dir)
    {
        BuildDirectory = dir;
    }

    /// <summary>
    ///     Emits a warning that is displayed for user
    /// </summary>
    /// <param name="message">Message to be displayed</param>
    public void EmitWarning(string message)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine();
        Console.WriteLine($"[WARN]: {message}");
        Console.ForegroundColor = ConsoleColor.White;
        WarningCount++;
    }

    /// <summary>
    ///     Emits an error that is displayed for user
    /// </summary>
    /// <param name="message">Message to be displayed</param>
    public void EmitError(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine();
        Console.WriteLine($"[ERROR]: {message}");
        Console.ForegroundColor = ConsoleColor.White;
        ErrorCount++;
    }

    /// <summary>
    ///     Caches provided resource by relative file name
    /// </summary>
    /// <param name="relativePath">Relative path from the build directory</param>
    /// <param name="data">Data to be cached</param>
    public void CacheResource(string relativePath, string data)
    {
        ResourceCache[relativePath] = data;
    }

    /// <summary>
    ///     Caches provided resource by relative file name
    /// </summary>
    /// <param name="relativePath">Relative path from the data/minecraft directory</param>
    /// <param name="data">Data to be cached</param>
    public void InjectMinecraftResource(string relativePath, string data)
    {
        CacheResource(Path.Join("pack", "data", "minecraft", relativePath), data);
    }


    /// <summary>
    ///     Asynchronously loads a provided module
    /// </summary>
    /// <param name="mod">Module to be loaded</param>
    public async Task LoadAsync(Module mod)
    {
        CurrentModule = mod;
        
        if (mod._locked)
            return;
        try
        {
            Console.WriteLine($"Starting module {mod.Name} of namespace {mod.Namespace}...");

            mod.Startup();

            Console.WriteLine($"Initializing build hooks for module {mod.Name}");
            var curdir = Directory.GetCurrentDirectory();

            Console.WriteLine("Creating build dir");
            var build = BuildDirectory ?? Path.Join(curdir, "Build");
            var dpPath = Path.Join(build, DatapackDir);
            var rpPath = Path.Join(build, ResourcesDir);

            var dataPath = Path.Join(dpPath, "data");
            var nsPath = Path.Join(dataPath, mod.Namespace);

            FileUtils.ForceCreateDir(nsPath);

            Console.WriteLine("Setting up magic functions.");
            await mod.InternalSetupMagicFns();
            
            Console.Write("Building hooks...");
            await HookHandler.Dump();
            
            Console.WriteLine("Dumping load + tick functions.");
            mod.InternalTick();
            mod.InternalWorldLoad();

            // Dumping registries
            Console.WriteLine("Dumping registry contents");
            await Registries.Advancements.Dump(mod);
            await Registries.Functions.Dump(mod);
            await Registries.Tags.Dump(mod);
            await Registries.Disguises.Dump(mod);
            
            if (Directory.Exists(Path.Join(curdir, "Assets")) || ResourceCache.Count > 0 || InitRp)
            {
                InitRp = true;
                Console.WriteLine("Generating resourcepack...");
                
                if (ResourceCache.Count > 0)
                {
                    Console.WriteLine("Resource cache available, processing it...");

                    Console.Write("Processing cache... ");

                    // ReSharper disable once ConvertToUsingDeclaration
                    using (var bar = new ProgressBar())
                    {
                        var l = ResourceCache.Count;
                        var cur = 0;
                        foreach (var (p, d) in ResourceCache)
                        {
                            var cds = p.Split(Path.DirectorySeparatorChar).SkipLast(1).ToList();
                            if (cds.Any())
                            {
                                var cd = cds.Aggregate(Path.Join);
                                Directory.CreateDirectory(Path.Join(build, cd));
                            }

                            await File.WriteAllTextAsync(Path.Join(build, p), d);
                            bar.Report((double) cur / l);
                            cur++;
                        }
                    }

                    Console.WriteLine("Done.");
                }

                if (Directory.Exists(Path.Join(curdir, "Assets")))
                {
                    Console.WriteLine("Assets directory exists, extracting it...");

                    if (File.Exists(Path.Join(curdir, "Assets", "icon.png")))
                    {
                        await FileUtils.CopyAsync(Path.Join(curdir, "Assets", "icon.png"),
                            Path.Join(dpPath, "pack.png"));
                        File.Delete(Path.Join(curdir, "Assets", "icon.png"));
                    }

                    await FileUtils.CopyFilesRecursively(Path.Join(curdir, "Assets"), rpPath);
                }
            }

            // mcmeta file
            Console.WriteLine("Creating meta file");
            var meta = new PackMcMeta((int) mod.Format, mod.FullDescription);
            var mcmeta = await meta.Serialize();

            await File.WriteAllTextAsync(Path.Join(dpPath, "pack.mcmeta"), mcmeta);
            if (InitRp)
                File.WriteAllTextAsync(Path.Join(rpPath, "pack.mcmeta"), mcmeta);
            
            // building into zip files
            Console.WriteLine("Building zip file output.");
            var outDir = OutputDirectory ?? Path.Join(Directory.GetCurrentDirectory(), "Output");
            if (OutputDirectory == null)
            {
                FileUtils.ForceCreateDir(outDir);
            }
            else
            {
                // Safely creating directory to make sure we dont delete some valuable dir
                if (!Directory.Exists(outDir))
                    Directory.CreateDirectory(outDir);
            }

            var zipPath = Path.Join(outDir, $"{mod.Name}.zip");

            if (File.Exists(zipPath))
                File.Delete(zipPath);
            ZipFile.CreateFromDirectory(dpPath, zipPath, CompressionLevel.Fastest, false);
            if (Directory.Exists(rpPath))
            {
                var rpZip = Path.Join(ResourcesDirectory ?? outDir, $"{mod.Name}_resources.zip");
                if (File.Exists(rpZip))
                    File.Delete(rpZip);
                ZipFile.CreateFromDirectory(rpPath, rpZip, CompressionLevel.Fastest, false);
            }

            Console.WriteLine($"Finished building module {mod.Name}!");
            Console.WriteLine($"{WarningCount} warnings emitted and {ErrorCount} errors emitted.");

            mod._locked = true;
        }
        catch (Exception
               e) // it is recommended not to throw exceptions and instead to emit an error, but im too lazy to refactor whole codebase :P
        {
            EmitError($"Error building module: {e.Message}!");

            Console.WriteLine(
                $"Failed building module {mod.Name} with {WarningCount} warnings and {ErrorCount} errors!");
        }

        CurrentModule = null;
    }
}