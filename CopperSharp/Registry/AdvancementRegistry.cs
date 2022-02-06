using CopperSharp.Advancements;

namespace CopperSharp.Registry;

/// <summary>
/// Represents an advancement registry
/// </summary>
public sealed class AdvancementRegistry : Registry<Advancement>
{
    internal AdvancementRegistry()
    {
        
    }
    
    /// <inheritdoc />
    protected override string Transform(Advancement element)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public override Advancement Register(Advancement element, Identifier id)
    {
        Stack.Push((element, id));
        return element;
    }
}