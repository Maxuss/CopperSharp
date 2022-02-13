using System.Reflection;
using CopperSharp.Contexts;

namespace CopperSharp.Functions;

/// <summary>
/// A global function manager
/// </summary>
public static class FunctionManager
{
    private static Dictionary<Type, List<(MethodInfo, FunctionHandlerAttribute)>> Methods { get; } = new();

    /// <summary>
    /// Looks up provided function and gets all methods
    /// </summary>
    /// <param name="fn">Function to be looked up</param>
    /// <returns>Null if function not registered, otherwise list of methods that can be called</returns>
    public static List<(MethodInfo, FunctionHandlerAttribute)>? Lookup(IFunction fn)
    {
        var type = fn.GetType();
        return Methods.ContainsKey(type) ? Methods[type] : null;
    }

    /// <summary>
    /// Registers provided function as well as all it's handlers
    /// </summary>
    /// <param name="fn">Function to be registered</param>
    public static void Register(IFunction fn)
    {
        var type = fn.GetType();
        var mtds = type.GetMethods()
            .Where(it => it.GetCustomAttribute<FunctionHandlerAttribute>() != null)
            .Select(it => (it, it.GetCustomAttribute<FunctionHandlerAttribute>()!)).ToList();
        Methods[type] = mtds;
    }
}