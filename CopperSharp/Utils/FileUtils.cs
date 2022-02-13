using System.IO.Pipelines;

namespace CopperSharp.Utils;

/// <summary>
/// Some file-related utilities
/// </summary>
public static class FileUtils
{
    /// <summary>
    /// Walks through a directory, listing all files in it
    /// </summary>
    /// <param name="sDir">Directory to be scanned</param>
    /// <returns>Found files</returns>
    public static IEnumerable<string> WalkDir(string sDir)
    {

        foreach (var f in Directory.GetFiles(sDir))
        {
            yield return Path.Join(sDir, f);
        }

        foreach (var d in Directory.GetDirectories(sDir))
        { 
            var searched = WalkDir(d);
            
            foreach (var s in searched)
            {
                yield return s;
            }
        }
        
    }

    /// <summary>
    /// Copies all files recursively from one directory to another
    /// </summary>
    /// <param name="sourcePath">Source directory</param>
    /// <param name="targetPath">Output directory</param>
    public static async Task CopyFilesRecursively(string sourcePath, string targetPath)
    {
        var dirs = Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories);
        var files = Directory.GetFiles(sourcePath, "*", SearchOption.AllDirectories);
        var dL = dirs.Length;
        var fL = files.Length;
        
        Console.Write("Copying directories... ");
        using (var bar = new ProgressBar())
        {
            var cur = 0;
            foreach (var dirPath in dirs)
            {
                Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
                bar.Report((double) cur / dL);
                cur++;
            }
        }
        Console.WriteLine("Done.");

        Console.Write("Copying files... ");
        using (var bar = new ProgressBar())
        {
            var cur = 0;
            foreach (var newPath in files)
            {
                await CopyAsync(newPath, newPath.Replace(sourcePath, targetPath));
                bar.Report((double) cur / fL);
                cur++;
            }
        }
        Console.WriteLine("Done.");
    }

    /// <summary>
    /// Copies file asynchronously
    /// </summary>
    /// <param name="source">Source file path</param>
    /// <param name="dest">Destination file path</param>
    public static async Task CopyAsync(string source, string dest)
    {
        await using var f = File.Create(dest);
        await f.WriteAsync(await File.ReadAllBytesAsync(source));
    }

    /// <summary>
    /// Force creates a directory, and deletes all files in it, if there were any
    /// </summary>
    /// <param name="path">Path to the directory</param>
    public static void ForceCreateDir(string path)
    {
        if(Directory.Exists(path))
            Directory.Delete(path, true);
        Directory.CreateDirectory(path);
    }
}