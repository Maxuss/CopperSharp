namespace CopperSharp.Modules;

/// <summary>
/// <b>Module</b> <br/><br/>
/// Module represents a Datapack, that can be combined with other packs into a single Datapack.
/// <br/>
/// <br/>
/// A Module can <i>internally</i> contain different items and entities, that will be converted to functions on runtime.
/// It can also normally contain different functions, advancements, recipes, etc.
/// </summary>
public abstract class Module
{
    /**
     * 
     */
    public ModuleRegistry Registry { get; }

    public Module()
    {
        Registry = new ModuleRegistry(this);
    }
}