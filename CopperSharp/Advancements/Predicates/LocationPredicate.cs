using CopperSharp.Registry;
using CopperSharp.Utils;
using CopperSharp.World;
using Newtonsoft.Json;

namespace CopperSharp.Advancements.Predicates;

/// <summary>
///     Represents a condition for a location
/// </summary>
public struct LocationPredicate
{
    private Dictionary<string, string> Data { get; } = new();
    private StrictRange? LightRange { get; set; }
    private (StrictRange?, StrictRange?, StrictRange?)? LocPosition { get; set; }
    private bool? LocSmokey { get; set; }
    private BlockPredicate? LocBlock { get; set; }
    private Identifier? LocFluid { get; set; }

    /// <summary>
    ///     Sets biome for this location predicate
    /// </summary>
    /// <param name="biome">Biome to be set</param>
    /// <returns>This location predicate</returns>
    public LocationPredicate Biome(Identifier biome)
    {
        Data["biome"] = biome.Path;
        return this;
    }

    /// <summary>
    ///     Sets dimension for this location predicate
    /// </summary>
    /// <param name="dimension">Dimension to be set</param>
    /// <returns>This location predicate</returns>
    public LocationPredicate Dimension(Dimension dimension)
    {
        Data["dimension"] = dimension.GetName().ToSnakeCase();
        return this;
    }

    /// <summary>
    ///     Sets structure feature for this location predicate
    /// </summary>
    /// <param name="structure">Structure to be set</param>
    /// <returns>This location predicate</returns>
    public LocationPredicate Structure(Identifier structure)
    {
        Data["feature"] = structure.Path;
        return this;
    }

    /// <summary>
    ///     Sets light amount for this location predicate
    /// </summary>
    /// <param name="light">Light amount to be set</param>
    /// <returns>This location predicate</returns>
    public LocationPredicate Light(StrictRange light)
    {
        LightRange = light;
        return this;
    }

    /// <summary>
    ///     Sets specific block condition for this location predicate
    /// </summary>
    /// <param name="block">Block predicate to be set</param>
    /// <returns>This location predicate</returns>
    public LocationPredicate Block(BlockPredicate block)
    {
        LocBlock = block;
        return this;
    }

    /// <summary>
    ///     Sets whether this location should be over the campfire
    /// </summary>
    /// <param name="smokey">Marker</param>
    /// <returns>This location predicate</returns>
    public LocationPredicate Smokey(bool smokey = true)
    {
        LocSmokey = smokey;
        return this;
    }

    /// <summary>
    ///     Sets specific fluid at this location predicate
    /// </summary>
    /// <param name="fluid">Fluid to be set</param>
    /// <returns>This location predicate</returns>
    public LocationPredicate Fluid(Identifier fluid)
    {
        LocFluid = fluid;
        return this;
    }


    /// <summary>
    ///     Sets a specific position for this location predicate
    /// </summary>
    /// <param name="x">X to be set</param>
    /// <param name="y">Y to be set</param>
    /// <param name="z">Z to be set</param>
    /// <returns>This location predicate</returns>
    public LocationPredicate Position(
        StrictRange? x = null,
        StrictRange? y = null,
        StrictRange? z = null)
    {
        LocPosition = (x, y, z);
        return this;
    }

    /// <summary>
    ///     Serializes this entity predicate into provided
    /// </summary>
    /// <param name="jw">Writer to be used</param>
    public async Task SerializeInto(JsonTextWriter jw)
    {
        await jw.WriteStartObjectAsync();

        if (Data.Any())
            foreach (var (k, v) in Data)
            {
                await jw.WritePropertyNameAsync(k);
                await jw.WriteValueAsync(v);
            }

        if (LocBlock != null)
        {
            await jw.WritePropertyNameAsync("block");
            await (LocBlock?.SerializeInto(jw) ?? Task.CompletedTask);
        }

        if (LocFluid != null)
        {
            await jw.WritePropertyNameAsync("fluid");
            await jw.WriteStartObjectAsync();
            await jw.WritePropertyNameAsync("fluid");
            await jw.WriteValueAsync(LocFluid.ToString());
            await jw.WriteEndObjectAsync();
        }

        if (LightRange != null)
        {
            await jw.WritePropertyNameAsync("light");
            await jw.WriteStartObjectAsync();
            await (LightRange?.SerializeInto(jw, "light") ?? Task.CompletedTask);
            await jw.WriteEndObjectAsync();
        }

        if (LocPosition != null)
        {
            await (LocPosition?.Item1?.SerializeInto(jw, "x") ?? Task.CompletedTask);
            await (LocPosition?.Item2?.SerializeInto(jw, "y") ?? Task.CompletedTask);
            await (LocPosition?.Item3?.SerializeInto(jw, "z") ?? Task.CompletedTask);
        }

        if (LocSmokey != null)
        {
            await jw.WritePropertyNameAsync("smokey");
            await jw.WriteValueAsync(LocSmokey);
        }

        await jw.WriteEndObjectAsync();
    }
}