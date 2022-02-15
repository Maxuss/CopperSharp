using CopperSharp.Modules;
using CopperSharp.Tags;

namespace CopperSharp.Registry;

/// <summary>
///     Represents a registry for tags
/// </summary>
public sealed class TagRegistry : Registry<Tag>
{
    /// <inheritdoc />
    protected override string Name => "tags";

    /// <inheritdoc />
    public override Tag Register(Tag element, Identifier id)
    {
        Stack.Push((element, id));
        return element;
    }

    /// <inheritdoc />
    public override async Task Write((Tag, Identifier) element, ModuleOutputStream stream)
    {
        var (tag, id) = element;
        await stream.WriteAsync($"{id.Path}.json", await tag.Serialize());
    }
}