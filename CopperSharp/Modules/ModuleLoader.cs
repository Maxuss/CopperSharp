using System.Collections.Concurrent;
using System.Diagnostics;
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
    /// <summary>
    ///     Name of the resourcepack directory from the build folder
    /// </summary>
    public static readonly string ResourcesDir = "resources";

    /// <summary>
    ///     Name of the datapack directory from the build folder
    /// </summary>
    public static readonly string DatapackDir = "pack";

    private bool _acceptingTasks = true;
    private int _currentPriority = -1;

    private ModuleLoader()
    {
    }

    /// <summary>
    ///     Whether to show the time it took to compile several modules after the end of the build
    /// </summary>
    public bool ShowCompilationTimes { get; set; } = false;

    private ConcurrentQueue<(string, (int, ModuleTask))> Tasks { get; } = new();
    private ConcurrentList<string> Warnings { get; } = new();
    private ConcurrentList<string> Errors { get; } = new();
    private string? OutputDirectory { get; set; }
    private string? BuildDirectory { get; set; }
    private string? ResourcesDirectory { get; set; }
    private bool InitRp { get; set; }
    private ConcurrentDictionary<string, string> ResourceCache { get; } = new();

    /// <summary>
    ///     A global hook handler
    /// </summary>
    public static HookHandler HookHandler { get; set; } = new();

    /// <summary>
    ///     Module that is currently processed. May be null
    /// </summary>
    public static Module? CurrentModule { get; set; }

    /// <summary>
    ///     A global module loader
    /// </summary>
    public static ModuleLoader GlobalLoader { get; } = new();

    /// <summary>
    ///     A global model manager
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
    ///     Sets the directory to which the resource pack will be outputted
    /// </summary>
    /// <param name="dir">Directory to be set</param>
    public void SetResourcepackDirectory(string dir)
    {
        ResourcesDirectory = dir;
    }

    /// <summary>
    ///     Toggles the generation of resourcepack's pack.mcmeta file
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
    ///     Registers a provided task if task registration is allowed
    /// </summary>
    /// <param name="name">Name of the task</param>
    /// <param name="priority">Priority of the task. By default next available priority.</param>
    /// <param name="task">Task to be registered</param>
    public void RegisterTask(string name, ModuleTask task, int? priority = null)
    {
        if (!_acceptingTasks)
            return;
        var actualPriority = priority ?? _currentPriority;
        _currentPriority = actualPriority + 1;
        Tasks.Enqueue((name, (actualPriority, task)));
    }

    /// <summary>
    ///     Emits a warning that is displayed for user
    /// </summary>
    /// <param name="message">Message to be displayed</param>
    public void EmitWarning(string message)
    {
        Warnings.Add(message);
    }

    /// <summary>
    ///     Emits an error that is displayed for user
    /// </summary>
    /// <param name="message">Message to be displayed</param>
    public void EmitError(string message)
    {
        Errors.Add(message);
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

    // ReSharper disable once UnusedMember.Local
    private void EnableRegistration()
    {
        _acceptingTasks = true;
        Tasks.Clear();
    }

    private void DisableRegistration()
    {
        _acceptingTasks = false;
    }

    private void DisplaySuccess(ConcurrentDictionary<string, Stopwatch?> results, Stopwatch total)
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("=========== BUILD FINISHED ===========");
        var warns = Warnings.Count;
        var errs = Errors.Count;
        Console.WriteLine($"Build completed with {warns} warnings and {errs} errors.");

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();

        DisplayErrors(warns, errs);

        DisplayTaskProgress(results, total);


        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();
        Console.WriteLine($"Built with CopperSharp v{CopperSharp.Version}");
        Console.ForegroundColor = ConsoleColor.White;
    }

    private void DisplayFailure(ConcurrentDictionary<string, Stopwatch?> results, Stopwatch total)
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Red;
        var warns = Warnings.Count;
        var errs = Errors.Count;

        Console.WriteLine("=========== BUILD FAILED ===========");
        Console.WriteLine($"Failed to build module {CurrentModule?.Name}!");
        Console.WriteLine($"{warns} warnings and {errs} errors emitted.");

        Console.WriteLine();
        DisplayErrors(warns, errs);

        DisplayTaskProgress(results, total);
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Built with CopperSharp v{CopperSharp.Version}");
        Console.ForegroundColor = ConsoleColor.White;
    }

    private void DisplayTaskProgress(ConcurrentDictionary<string, Stopwatch?> results, Stopwatch total)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Completed tasks:");

        foreach (var (name, time) in results)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"{name}: ");
            var isNull = time == null;
            Console.ForegroundColor = isNull ? ConsoleColor.Red : ConsoleColor.Green;
            Console.WriteLine(isNull ? "[✘]" : $"[✓️] in {time?.ElapsedMilliseconds}ms");
        }

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Total build time: ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"{total.ElapsedMilliseconds}ms");
    }

    private void DisplayErrors(int warns, int errs)
    {
        if (errs > 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[ERRORS]");
            for (var i = 0; i < errs; i++) Console.WriteLine($"[{i + 1}]: {Errors[i]}");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }

        if (warns > 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[WARNINGS]");
            for (var i = 0; i < warns; i++) Console.WriteLine($"[{i + 1}]: {Warnings[i]}");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }

        Warnings.Clear();
        Errors.Clear();
    }

    private void LoadNecessaryTasks()
    {
        var curdir = Directory.GetCurrentDirectory();
        var build = BuildDirectory ?? Path.Join(curdir, "Build");
        var dpPath = Path.Join(build, DatapackDir);
        var rpPath = Path.Join(build, ResourcesDir);

        RegisterTask("Set up magic functions", async mod =>
        {
            var time = Stopwatch.StartNew();
            await mod.InternalSetupMagicFns();
            time.Stop();
            return time;
        }, 0);
        RegisterTask("Build hooks", async _ =>
        {
            var time = Stopwatch.StartNew();
            await HookHandler.Dump();
            time.Stop();
            return time;
        }, 1);
        RegisterTask("Load+Tick functions", mod =>
        {
            var time = Stopwatch.StartNew();
            mod.InternalTick();
            mod.InternalWorldLoad();
            time.Stop();
            return Task.FromResult(time);
        }, 2);
        RegisterTask("Load advancements", async mod => await Registries.Advancements.Dump(mod), 3);
        RegisterTask("Load functions", async mod => await Registries.Functions.Dump(mod), 4);
        RegisterTask("Load tags", async mod => await Registries.Tags.Dump(mod), 5);
        RegisterTask("Load disguises", async mod => await Registries.Disguises.Dump(mod), 6);
        RegisterTask("Generate meta file", async mod =>
        {
            var time = Stopwatch.StartNew();
            var meta = new PackMcMeta((int) mod.Format, mod.FullDescription);
            var mcmeta = await meta.Serialize();

            await File.WriteAllTextAsync(Path.Join(dpPath, "pack.mcmeta"), mcmeta);
            if (InitRp)
                await File.WriteAllTextAsync(Path.Join(rpPath, "pack.mcmeta"), mcmeta);
            time.Stop();
            return time;
        }, 8);
    }

    /// <summary>
    ///     Asynchronously loads a provided module
    /// </summary>
    /// <param name="mod">Module to be loaded</param>
    public async Task LoadModule(Module mod)
    {
        // init necessary load tasks
        LoadNecessaryTasks();
        DisableRegistration();

        var total = Stopwatch.StartNew();

        CurrentModule = mod;
        if (mod.Locked)
            return;

        var curdir = Directory.GetCurrentDirectory();
        var build = BuildDirectory ?? Path.Join(curdir, "Build");
        var dpPath = Path.Join(build, DatapackDir);
        var rpPath = Path.Join(build, ResourcesDir);

        var dataPath = Path.Join(dpPath, "data");

        var results =
            new ConcurrentDictionary<string, Stopwatch?>(Tasks.Select(it =>
                new KeyValuePair<string, Stopwatch?>(it.Item1, null)));
        try
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Starting module {mod.Name} of namespace {mod.Namespace}...");

            mod.Startup();

            Console.WriteLine($"Loading tasks for module {mod.Name}...");

            // create important directories
            FileUtils.ForceCreateDir(Path.Join(dataPath, mod.Namespace));

            Console.ForegroundColor = ConsoleColor.White;
            var required = new List<Task>();

            while (Tasks.TryPeek(out _))
            {
                Tasks.TryDequeue(out var deq);
                required.Add(Task.Run(async () =>
                {
                    try
                    {
                        var time = await deq.Item2.Item2(mod);
                        results[deq.Item1] = time;
                    }
                    catch (Exception e)
                    {
                        EmitError($"During execution of '{deq.Item1}' task: {e.Message}");
                        results[deq.Item1] = null;
                    }
                }));
            }

            await Task.WhenAll(required);

            #region safe cache + file manipulations

            #region dumping cache

            var time = Stopwatch.StartNew();
            if (Directory.Exists(Path.Join(curdir, "Assets")) || ResourceCache.Count > 0 || InitRp)
            {
                InitRp = true;

                if (ResourceCache.Count > 0)
                    foreach (var (p, d) in ResourceCache)
                    {
                        var cds = p.Split(Path.DirectorySeparatorChar).SkipLast(1).ToList();
                        if (cds.Any())
                        {
                            var cd = cds.Aggregate(Path.Join);
                            if (!Directory.Exists(Path.Join(build, cd)))
                                Directory.CreateDirectory(Path.Join(build, cd));
                        }

                        await File.WriteAllTextAsync(Path.Join(build, p), d);
                    }

                if (Directory.Exists(Path.Join(curdir, "Assets")))
                {
                    if (File.Exists(Path.Join(curdir, "Assets", "icon.png")))
                    {
                        await FileUtils.CopyAsync(Path.Join(curdir, "Assets", "icon.png"),
                            Path.Join(dpPath, "pack.png"));
                        File.Delete(Path.Join(curdir, "Assets", "icon.png"));
                    }

                    await FileUtils.CopyFilesRecursively(Path.Join(curdir, "Assets"), rpPath);
                }
            }

            time.Stop();
            results["Generate resources"] = time;

            #endregion

            #region zip

            var zipTime = Stopwatch.StartNew();
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

            zipTime.Stop();
            results["Build zip artifacts"] = zipTime;

            #endregion

            #endregion

            total.Stop();
            if (Errors.Count > 0)
            {
                Console.Clear();
                total.Stop();
                DisplayFailure(results, total);
                mod.Locked = true;
                CurrentModule = null;
                return;
            }

            Console.WriteLine($"Finished building module {mod.Name}!");
            Console.Clear();

            DisplaySuccess(results, total);
        }
        catch (Exception e)
        {
            Console.Clear();
            EmitError($"During the execution of main task: {e.Message}!");

            total.Stop();
            DisplayFailure(results, total);
        }

        mod.Locked = true;

        CurrentModule = null;
    }
}