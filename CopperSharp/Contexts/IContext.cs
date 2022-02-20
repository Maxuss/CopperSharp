namespace CopperSharp.Contexts;

/// <summary>
/// The global interface for all contexts
/// </summary>
public interface IContext
{
    
}

/// <summary>
/// A context that contains a reference to current world
/// </summary>
public interface IWorldReference : IContext
{
    /// <summary>
    /// Represents the current world context
    /// </summary>
    public WorldContext World { get; }
}