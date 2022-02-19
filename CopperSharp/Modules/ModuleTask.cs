using System.Diagnostics;

namespace CopperSharp.Modules;

/// <summary>
/// Represents a module execution task
/// </summary>
public delegate Task<Stopwatch> ModuleTask(Module mod);