using CopperSharp.Utils;

namespace CopperSharp.Hooks;

/// <summary>
///     Represents a global hook handler
/// </summary>
public sealed class HookHandler
{
    private List<IHookHandler> HookManagers { get; } = new();

    /// <summary>
    ///     Registers a provided hook handler
    /// </summary>
    /// <param name="obj">Class that contains hooks to be registered</param>
    public void Register(IHookHandler obj)
    {
        HookManagers.Add(obj);
    }

    /// <summary>
    ///     Dumps this hook handler
    /// </summary>
    public async Task Dump()
    {
        using (var bar = new ProgressBar())
        {
            var cnt = 0;
            var l = HookManagers.Count;
            foreach (var manager in HookManagers)
                await Task.Run(() =>
                {
                    HookManager.ProcessHooks(manager);
                    bar.Report((double) cnt / l);
                    cnt++;
                });
        }

        Console.WriteLine("Done");

        HookManagers.Clear();
    }
}