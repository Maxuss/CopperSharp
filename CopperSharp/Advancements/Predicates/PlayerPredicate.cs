using CopperSharp.Entity;
using CopperSharp.Utils;
using Newtonsoft.Json;

namespace CopperSharp.Advancements.Predicates;

/// <summary>
/// Represents specific conditions to be checked for player
/// </summary>
public sealed class PlayerPredicate
{
    private Dictionary<string, string> Strings { get; set; } = new();
    private Dictionary<string, EntityPredicate> Entities { get; set; } = new();
    private EntityPredicate? LookingAt { get; set; }
    private List<string> Advancements { get; set; } = new();
    private StrictRange? ExpLevel { get; set; }
    private List<string> Recipes { get; set; } = new();
    private Dictionary<string, StrictRange> Statistics { get; set; } = new();
    private LocationPredicate? SteppingOn { get; set; }
    private bool? HookInWater { get; set; }
    
    /// <summary>
    /// Sets the entity this player is looking at
    /// </summary>
    /// <param name="at">Entity to be set</param>
    /// <returns>This player predicate</returns>
    public PlayerPredicate LooksAt(EntityPredicate at)
    {
        LookingAt = at;
        return this;
    }

    /// <summary>
    /// Sets required advancements for this player
    /// </summary>
    /// <param name="advancements">Advancements to be required</param>
    /// <returns>This player predicate</returns>
    public PlayerPredicate RequireAdvancements(params string[] advancements)
    {
        Advancements.AddRange(advancements);
        return this;
    }

    /// <summary>
    /// Requires provided game mode for this player
    /// </summary>
    /// <param name="gm">Required game mode</param>
    /// <returns>This player predicate</returns>
    public PlayerPredicate RequireGameMode(string gm)
    {
        Strings["gamemode"] = gm;
        return this;
    }

    /// <summary>
    /// Requires certain experience level from this player
    /// </summary>
    /// <param name="level">Required level</param>
    /// <returns>This player predicate</returns>
    public PlayerPredicate RequireExperience(StrictRange level)
    {
        ExpLevel = level;
        return this;
    }

    /// <summary>
    /// Requires certain recipes from this player
    /// </summary>
    /// <param name="recipes">Required recipes</param>
    /// <returns>This player predicate</returns>
    public PlayerPredicate RequireRecipes(params string[] recipes)
    {
        Recipes.AddRange(recipes);
        return this;
    }

    /// <summary>
    /// Requires certain statistic to be of a certain amount for this player
    /// </summary>
    /// <param name="statistic">Required statistic</param>
    /// <param name="value">Required value for the statistic</param>
    /// <returns>This player predicate</returns>
    public PlayerPredicate RequireStatistic(PlayerStatistic statistic, StrictRange value)
    {
        Statistics[statistic.GetData() ?? "custom"] = value;
        return this;
    }

    /// <summary>
    /// Requires a location for player to stand on
    /// </summary>
    /// <param name="block">Required location</param>
    /// <returns>This player predicate</returns>
    public PlayerPredicate StandingOn(LocationPredicate block)
    {
        SteppingOn = block;
        return this;
    }

    /// <summary>
    /// Requires a certain team from this player
    /// </summary>
    /// <param name="team">Required team</param>
    /// <returns>This player predicate</returns>
    public PlayerPredicate RequireTeam(string team)
    {
        Strings["team"] = team;
        return this;
    }

    /// <summary>
    /// Requires this player to target a certain entity in combat
    /// </summary>
    /// <param name="target">Required entity</param>
    /// <returns>This player predicate</returns>
    public PlayerPredicate TargetsAt(EntityPredicate target)
    {
        Entities["targeted_entity"] = target;
        return this;
    }

    /// <summary>
    /// Requires this player to ride a specific vehicle
    /// </summary>
    /// <param name="entity">Required vehicle</param>
    /// <returns>This player predicate</returns>
    public PlayerPredicate RidesOn(EntityPredicate entity)
    {
        Entities["vehicle"] = entity;
        return this;
    }

    /// <summary>
    /// Requires this player to have a fishing hook in open water
    /// </summary>
    /// <param name="open">Marker</param>
    /// <returns>This player predicate</returns>
    public PlayerPredicate HookInOpenWater(bool open = true)
    {
        HookInWater = open;
        return this;
    }

    /// <summary>
    /// Serializes this player to provided json writer
    /// </summary>
    /// <param name="jw">Writer to be used</param>
    public async Task SerializeInto(JsonTextWriter jw)
    {
        await jw.WriteStartObjectAsync();
        if (LookingAt != null)
        {
            await jw.WritePropertyNameAsync("looking_at");
            await (LookingAt?.SerializeInto(jw) ?? Task.CompletedTask);
        }

        if (Advancements.Any())
        {
            await jw.WritePropertyNameAsync("advancements");
            await jw.WriteStartObjectAsync();
            foreach (var adv in Advancements)
            {
                await jw.WritePropertyNameAsync(adv);
                await jw.WriteValueAsync(true);
            }
            await jw.WriteEndObjectAsync();
        }

        if (Strings.Any())
        {
            foreach (var (k, v) in Strings)
            {
                await jw.WritePropertyNameAsync(k);
                await jw.WriteValueAsync(v);
            }
        }

        if (Entities.Any())
        {
            foreach (var (k, v) in Entities)
            {
                await jw.WritePropertyNameAsync(k);
                await v.SerializeInto(jw);
            }
        }

        if (ExpLevel != null)
        {
            await (ExpLevel?.SerializeInto(jw, "level") ?? Task.CompletedTask);
        }

        if (Recipes.Any())
        {
            await jw.WritePropertyNameAsync("recipes");
            await jw.WriteStartObjectAsync();
            foreach (var recipe in Recipes)
            {
                await jw.WritePropertyNameAsync(recipe);
                await jw.WriteValueAsync(true);
            }
            await jw.WriteEndObjectAsync();
        }

        if (Statistics.Any())
        {
            await jw.WritePropertyNameAsync("stats");
            await jw.WriteStartArrayAsync();
            foreach (var (stat, value) in Statistics)
            {
                await jw.WriteStartObjectAsync();
                await jw.WritePropertyNameAsync("type");
                await jw.WriteValueAsync($"minecraft:{stat}");
                await value.SerializeInto(jw, "value");
                await jw.WriteEndObjectAsync();
            }
            await jw.WriteEndArrayAsync();
        }

        if (SteppingOn != null)
        {
            await jw.WritePropertyNameAsync("stepping_on");
            await (SteppingOn?.SerializeInto(jw) ?? Task.CompletedTask);
        }

        if (HookInWater != null)
        {
            await jw.WritePropertyNameAsync("fishing_hook");
            await jw.WriteStartObjectAsync();
            await jw.WritePropertyNameAsync("in_open_water");
            await jw.WriteValueAsync(HookInWater);
            await jw.WriteEndObjectAsync();
        }
        
        await jw.WriteEndObjectAsync();
    }
}