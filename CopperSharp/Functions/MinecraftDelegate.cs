using CopperSharp.Contexts;

namespace CopperSharp.Functions;

/// <summary>
///     Represents a minecraft function delegate that can be executed
/// </summary>
public delegate void MinecraftDelegate(WorldContext ctx);

/// <summary>
///     Represents an asynchronous minecraft function delegate that can be executed
/// </summary>
public delegate Task AsyncMinecraftDelegate(WorldContext ctx);