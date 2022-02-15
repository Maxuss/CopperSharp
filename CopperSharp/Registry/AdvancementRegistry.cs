using CopperSharp.Advancements;
using CopperSharp.Modules;

namespace CopperSharp.Registry;

/// <summary>
///     Represents an advancement registry
/// </summary>
public sealed class AdvancementRegistry : Registry<Advancement>
{
    internal AdvancementRegistry()
    {
    }

    /// <inheritdoc />
    protected override string Name => "advancements";

    /// <inheritdoc />
    public override Advancement Register(Advancement element, Identifier id)
    {
        Stack.Push((element, id));
        return element;
    }

    /// <inheritdoc />
    public override async Task Write((Advancement, Identifier) element, ModuleOutputStream stream)
    {
        var (adv, id) = element;
        await stream.WriteAsync($"{id.Path}.json", await adv.Serialize());
    }
}