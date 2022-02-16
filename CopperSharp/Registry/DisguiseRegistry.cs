using CopperSharp.Item;
using CopperSharp.Models;
using CopperSharp.Modules;
using CopperSharp.Utils;
using Newtonsoft.Json;

namespace CopperSharp.Registry;

public sealed class DisguiseRegistry : Registry<Disguise>
{
    /// <inheritdoc />
    protected override string Name => "disguises";

    private Dictionary<Identifier, List<DisguisePredicate>> Predicates { get; set; }= new();

    /// <summary>
    /// Registers a provided disguise
    /// </summary>
    /// <param name="element">Disguise to be registered</param>
    /// <returns>Provided disguise</returns>
    public Disguise Register(Disguise element) => Register(element, Identifier.Of("null", "null"));

    /// <inheritdoc />
    public override Disguise Register(Disguise element, Identifier id)
    {
        // we ignore the id
        if (Predicates.ContainsKey(element.Base))
            Predicates[element.Base].Add(new DisguisePredicate(element.Cloak, element.ModelData));
        else
            Predicates[element.Base] = new List<DisguisePredicate>
                {new(element.Cloak, element.ModelData)};
        return element;
    }

    /// <inheritdoc />
    public override Task Write((Disguise, Identifier) element, ModuleOutputStream stream)
    {
        // not doing anything here, everything is already implemented internally in Dump method
        return Task.CompletedTask;
    }

    /// <inheritdoc />
    public override async Task Dump(Module mod)
    {
        Console.Write("Dumping disguises... ");
        using var bar = new ProgressBar();

        var loader = ModuleLoader.GlobalLoader;
        var l = Predicates.Count;
        var cnt = 0;
        foreach (var (id, disguises) in Predicates)
        {
            await using (var sw = new StringWriter())
            {
                using var w = new JsonTextWriter(sw);
                w.Formatting = Formatting.Indented;

                await w.WriteStartObjectAsync();

                await w.WritePropertyNameAsync("parent");
                await w.WriteValueAsync("item/generated");

                await w.WritePropertyNameAsync("textures");
                await w.WriteStartObjectAsync();
                await w.WritePropertyNameAsync("layer0");
                await w.WriteValueAsync($"item/{id.Path}");
                await w.WriteEndObjectAsync();
                
                await w.WritePropertyNameAsync("overrides");
                await w.WriteStartArrayAsync();

                await Parallel.ForEachAsync(disguises, async (dis, cancel) =>
                {
                    await dis.Serialize(w);
                });
                
                await w.WriteEndArrayAsync();
                
                await w.WriteEndObjectAsync();

                loader.CacheResource(Path.Join(ModuleLoader.ResourcesDir, "assets", "minecraft", "models", "item",
                    $"{id.Path}.json"), sw.ToString());
            }

            bar.Report((double) cnt / l);
            cnt++;
        }
        
        bar.Dispose();
        
        Console.WriteLine("Done.");
    }
}

internal readonly struct DisguisePredicate
{
    private readonly Identifier _from;
    private readonly int _data;

    public DisguisePredicate(Identifier from, int data)
    {
        _from = @from;
        _data = data;
    }
    
    public async Task Serialize(JsonTextWriter w)
    {
        await w.WriteStartObjectAsync();

        await w.WritePropertyNameAsync("predicate");
        await w.WriteStartObjectAsync();
        await w.WritePropertyNameAsync("custom_model_data");
        await w.WriteValueAsync(_data);
        await w.WriteEndObjectAsync();

        await w.WritePropertyNameAsync("model");
        await w.WriteValueAsync(_from.Path);
        
        await w.WriteEndObjectAsync();
    }
}