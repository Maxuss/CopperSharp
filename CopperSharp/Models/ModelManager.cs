namespace CopperSharp.Models;

/// <summary>
/// A model manager, which can allocate values for model data
/// </summary>
public sealed class ModelManager
{
    private const int SECTION_BEGIN  =    0x124F80;
    private const int SECTION_END    =    0x7704C0;
    private const int JUMP_SIZE      =    0x000001;

    private Dictionary<IModel, int> LookupTable { get; } = new();

    private int PTR = SECTION_BEGIN - JUMP_SIZE;

    /// <summary>
    /// Gets a provided model from this model manager's registered models
    /// </summary>
    /// <param name="model">Model to be fetched</param>
    /// <returns>Model ID or null, if not registered</returns>
    public int? Lookup(IModel model)
    {
        return LookupTable.ContainsKey(model) ? LookupTable[model] : null;
    }
    
    /// <summary>
    /// Safely allocates a model value
    /// </summary>
    /// <returns>Allocated position for model</returns>
    [Obsolete("Use Allocate(IModel) instead, it has more functionality")]
    public int Allocate()
    {
        if (PTR > SECTION_END)
            throw new Exception("Failed to allocate space for model! CS Section size ended!");
        PTR += JUMP_SIZE;
        return PTR;
    }

    /// <summary>
    /// Safely allocates a model value and binds it to the provided model, for further lookups.
    /// </summary>
    /// <param name="model">Model to which to bind the model id</param>
    /// <returns>Allocated position for model</returns>
    public int Allocate(IModel model)
    {
        if (PTR > SECTION_END)
            throw new Exception("Failed to allocate space for model! CS Section size ended!");
        PTR += JUMP_SIZE;
        LookupTable[model] = PTR;
        return PTR;
    }
}