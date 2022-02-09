using CopperSharp.Utils;
using Newtonsoft.Json;

namespace CopperSharp.Advancements.Predicates;

/// <summary>
/// Represents a damage done predicate
/// </summary>
public sealed class DamagePredicate
{
    private Dictionary<string, StrictRange> Ranges { get; set; } = new();
    private EntityPredicate? Source { get; set; }
    private EntityPredicate? Direct { get; set; }
    private Dictionary<string, bool> Flags { get; set; } = new();
    private bool? Blocked { get; set; }

    /// <summary>
    /// Requires this damage to be blocked
    /// </summary>
    /// <param name="block">Marker</param>
    /// <returns>This predicate</returns>
    public DamagePredicate RequireBlocked(bool block = true)
    {
        Blocked = block;
        return this;
    }

    /// <summary>
    /// Require certain amount of damage dealt before applying different calculations
    /// </summary>
    /// <param name="amount">Amount to be set</param>
    /// <returns>This predicate</returns>
    public DamagePredicate RequireDealt(StrictRange amount)
    {
        Ranges["dealt"] = amount;
        return this;
    }

    /// <summary>
    /// Require certain amount of damage dealt after applying different calculations
    /// </summary>
    /// <param name="taken">Amount to be set</param>
    /// <returns>This predicate</returns>
    public DamagePredicate RequireTaken(StrictRange taken)
    {
        Ranges["taken"] = taken;
        return this;
    }

    /// <summary>
    /// Sets the direct cause of damage, e.g. <b>arrow</b> that the skeleton shot
    /// </summary>
    /// <param name="direct">Entity to be set</param>
    /// <returns>This damage predicate</returns>
    public DamagePredicate DirectEntity(EntityPredicate direct)
    {
        Direct = direct;
        return this;
    }

    /// <summary>
    /// Sets the source cause of damage, e.g. <b>skeleton</b> that shot the arrow
    /// </summary>
    /// <param name="source">Entity to be set</param>
    /// <returns>This damage predicate</returns>
    public DamagePredicate SourceEntity(EntityPredicate source)
    {
        Source = source;
        return this;
    }

    /// <summary>
    /// Requires this damage to bypass armor
    /// </summary>
    /// <param name="req">Marker</param>
    /// <returns>This predicate</returns>
    public DamagePredicate BypassedArmor(bool req = true)
    {
        Flags["bypasses_armor"] = req;
        return this;
    }
    /// <summary>
    /// Requires this damage to bypass invulnerability </summary>
    /// <param name="req">Marker</param>
    /// <returns>This predicate</returns>
    public DamagePredicate BypassedInvulnerability(bool req = true)
    {
        Flags["bypasses_invulnerability"] = req;
        return this;
    }
    /// <summary>
    /// Requires this damage to bypass magic damage
    /// </summary>
    /// <param name="req">Marker</param>
    /// <returns>This predicate</returns>
    public DamagePredicate BypassedMagic(bool req = true)
    {
        Flags["bypasses_magic"] = req;
        return this;
    }
    /// <summary>
    /// Requires this damage to be explosion
    /// </summary>
    /// <param name="req">Marker</param>
    /// <returns>This predicate</returns>
    public DamagePredicate RequireExplosion(bool req = true)
    {
        Flags["is_explosion"] = req;
        return this;
    }
    /// <summary>
    /// Requires this damage to be fire
    /// </summary>
    /// <param name="req">Marker</param>
    /// <returns>This predicate</returns>
    public DamagePredicate RequireFire(bool req = true)
    {
        Flags["is_fire"] = req;
        return this;
    }
    /// <summary>
    /// Requires this damage to be magic
    /// </summary>
    /// <param name="req">Marker</param>
    /// <returns>This predicate</returns>
    public DamagePredicate RequireMagic(bool req = true)
    {
        Flags["is_magic"] = req;
        return this;
    }
    /// <summary>
    /// Requires this damage to be projectile damage
    /// </summary>
    /// <param name="req">Marker</param>
    /// <returns>This predicate</returns>
    public DamagePredicate RequireProjectile(bool req = true)
    {
        Flags["is_projectile"] = req;
        return this;
    }
    /// <summary>
    /// Requires this damage to be lightning
    /// </summary>
    /// <param name="req">Marker</param>
    /// <returns>This predicate</returns>
    public DamagePredicate RequireLightning(bool req = true)
    {
        Flags["is_lightning"] = req;
        return this;
    }

    /// <summary>
    /// Serializes this predicate into provided writer
    /// </summary>
    /// <param name="w">Writer to be used</param>
    public async Task SerializeInto(JsonTextWriter w)
    {
        await w.WriteStartObjectAsync();
        foreach (var (k, v) in Ranges)
        {
            await v.SerializeInto(w, k);
        }

        if (Blocked != null)
        {
            await w.WritePropertyNameAsync("blocked");
            await w.WriteValueAsync(Blocked);
        }

        if (Source != null)
        {
            await w.WritePropertyNameAsync("source_entity");
            await Source!.SerializeInto(w);
        }

        if (Flags.Any() || Direct != null)
        {
            await w.WritePropertyNameAsync("type");
            await w.WriteStartObjectAsync();
            if (Direct != null)
            {
                await w.WritePropertyNameAsync("direct_entity");
                await Direct!.SerializeInto(w);
            }

            foreach (var (k, v) in Flags)
            {
                await w.WritePropertyNameAsync(k);
                await w.WriteValueAsync(v);
            }

            await w.WriteEndObjectAsync();
        }

        await w.WriteEndObjectAsync();
    }
}