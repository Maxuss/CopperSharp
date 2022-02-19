using System.Collections.Concurrent;
using System.Reflection;

namespace CopperSharp.Functions;

/// <summary>
///     A global function manager
/// </summary>
public static class FunctionManager
{
    private static ConcurrentDictionary<Type, List<(AsyncMinecraftDelegate, FunctionHandlerAttribute)>> AsyncMethods { get; } =
        new();

    private static ConcurrentDictionary<int, List<(AsyncMinecraftDelegate, FunctionHandlerAttribute)>>
        AsyncMethodsByHash { get; } = new();

    private static ConcurrentDictionary<Type, List<(MinecraftDelegate, FunctionHandlerAttribute)>> Methods { get; } = new();
    private static ConcurrentDictionary<int, List<(MinecraftDelegate, FunctionHandlerAttribute)>> MethodsByHash { get; } = new();

    /// <summary>
    ///     Looks up provided function and gets all methods
    /// </summary>
    /// <param name="fn">Function to be looked up</param>
    /// <returns>Null if function not registered, otherwise list of methods that can be called</returns>
    public static List<(MinecraftDelegate, FunctionHandlerAttribute)>? Lookup(IFunction fn)
    {
        if (fn is EmptyFunction hash)
            return MethodsByHash.ContainsKey(hash._hashNum) ? MethodsByHash[hash._hashNum] : null;

        var type = fn.GetType();
        return Methods.ContainsKey(type) ? Methods[type] : null;
    }

    /// <summary>
    ///     Looks up provided function and gets all async methods
    /// </summary>
    /// <param name="fn">Function to be looked up</param>
    /// <returns>Null if function not registered, otherwise list of methods that can be called</returns>
    public static List<(AsyncMinecraftDelegate, FunctionHandlerAttribute)>? LookupAsyncs(IFunction fn)
    {
        if (fn is EmptyFunction hash)
            return AsyncMethodsByHash.ContainsKey(hash._hashNum) ? AsyncMethodsByHash[hash._hashNum] : null;

        var type = fn.GetType();
        return AsyncMethods.ContainsKey(type) ? AsyncMethods[type] : null;
    }

    /// <summary>
    ///     Registers provided function as well as all it's handlers
    /// </summary>
    /// <param name="fn">Function to be registered</param>
    public static void Register(IFunction fn)
    {
        var type = fn.GetType();
        var mapped = type.GetMethods()
            .Where(it => it.GetCustomAttribute<FunctionHandlerAttribute>() != null).ToList();
        var async = mapped.Where(it => it.ReturnType == typeof(Task)).ToList();
        var sync = mapped.Where(it => it.ReturnType != typeof(Task)).ToList();

        if (async.Any())
            AsyncMethods[type] = async.Select(it => (
                (AsyncMinecraftDelegate) Delegate.CreateDelegate(typeof(AsyncMinecraftDelegate), fn, it),
                it.GetCustomAttribute<FunctionHandlerAttribute>()!)).ToList();

        if (sync.Any())
            Methods[type] = mapped.Select(it => (
                (MinecraftDelegate) Delegate.CreateDelegate(typeof(MinecraftDelegate), fn, it),
                it.GetCustomAttribute<FunctionHandlerAttribute>()!)).ToList();
    }

    internal static void RegisterHashed(MinecraftDelegate del, EmptyFunction hash, string name)
    {
        MethodsByHash[hash._hashNum] = new List<(MinecraftDelegate, FunctionHandlerAttribute)>
        {
            (del, new FunctionHandlerAttribute(name))
        };
    }

    internal static void RegisterAsyncHashed(AsyncMinecraftDelegate del, EmptyFunction hash, string name)
    {
        AsyncMethodsByHash[hash._hashNum] = new List<(AsyncMinecraftDelegate, FunctionHandlerAttribute)>
        {
            (del, new FunctionHandlerAttribute(name))
        };
    }
}