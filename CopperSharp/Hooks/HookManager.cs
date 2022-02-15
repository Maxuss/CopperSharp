using System.Reflection;
using CopperSharp.Modules;

namespace CopperSharp.Hooks;

internal static class HookManager
{
    public static void ProcessHooks(object obj)
    {
        var type = obj.GetType();
        var hooks = type.GetMethods().Select(it => (it, it.GetCustomAttribute<HookAttribute>())).Where(it => it.Item2 != null);
        foreach (var hook in hooks)
        {
            var (mtd, attr) = hook;
            var actualHook = attr!.Hook;
            actualHook.Executor = ctx =>
            {
                mtd.Invoke(obj, new object?[] {ctx});
            };
            actualHook.Configure(ModuleLoader.ProcessingModule!);
        }
    }
}