using CopperSharp.Data.SNbt;
using Newtonsoft.Json;

namespace CopperSharp.Advancements.Predicates;

/// <summary>
/// Represents a trigger condition that also includes a player
/// </summary>
public class EntityPredicate
{
    private Dictionary<string, (float?, float?)> Distances { get; set; } = new();
    private List<EffectPredicate> Effects { get; set; } = new();
    private Dictionary<string, ItemPredicate> Items { get; set; } = new();
    private Dictionary<string, bool> Flags { get; set; } = new();
    private (int?, EntityPredicate?)? LightningProperties { get; set; }
    private LocationPredicate? Location { get; set; }
    private string? Nbt { get; set; }
    private EntityPredicate? Passenger { get; set; }
    private PlayerPredicate? PlayerData { get; set; }
    
    /// <summary>
    /// Sets absolute distance of this entity predicate
    /// </summary>
    /// <param name="max">Max distance</param>
    /// <param name="min">Min distance</param>
    /// <returns>This entity predicate</returns>
    public EntityPredicate AbsoluteDistance(float? max = null, float? min = null)
    {
        Distances["absolute"] = (max, min);
        return this;
    }
    
    /// <summary>
    /// Sets horizontal distance of this entity predicate
    /// </summary>
    /// <param name="max">Max distance</param>
    /// <param name="min">Min distance</param>
    /// <returns>This entity predicate</returns>
    public EntityPredicate HorizontalDistance(float? max = null, float? min = null)
    {
        Distances["horizontal"] = (max, min);
        return this;
    }

    /// <summary>
    /// Sets X axis distance of this entity predicate
    /// </summary>
    /// <param name="max">Max distance</param>
    /// <param name="min">Min distance</param>
    /// <returns>This entity predicate</returns>
    public EntityPredicate DistanceX(float? max = null, float? min = null)
    {
        Distances["x"] = (max, min);
        return this;
    }
    
    /// <summary>
    /// Sets Y axis distance of this entity predicate
    /// </summary>
    /// <param name="max">Max distance</param>
    /// <param name="min">Min distance</param>
    /// <returns>This entity predicate</returns>
    public EntityPredicate DistanceY(float? max = null, float? min = null)
    {
        Distances["y"] = (max, min);
        return this;
    }
    
    /// <summary>
    /// Sets Z axis distance of this entity predicate
    /// </summary>
    /// <param name="max">Max distance</param>
    /// <param name="min">Min distance</param>
    /// <returns>This entity predicate</returns>
    public EntityPredicate DistanceZ(float? max = null, float? min = null)
    {
        Distances["z"] = (max, min);
        return this;
    }
    
    /// <summary>
    /// Requires this entity to have provided effects
    /// </summary>
    /// <param name="effects">Effects to be required</param>
    /// <returns>This entity predicate</returns>
    public EntityPredicate RequireEffects(params EffectPredicate[] effects)
    {
        Effects.AddRange(effects);
        return this;
    }

    /// <summary>
    /// Requires a specific item in main hand
    /// </summary>
    /// <param name="item">Item to be required</param>
    /// <returns>This entity predicate</returns>
    public EntityPredicate RequireMainHand(ItemPredicate item)
    {
        Items["mainhand"] = item;
        return this;
    }
    
    /// <summary>
    /// Requires a specific item in off hand
    /// </summary>
    /// <param name="item">Item to be required</param>
    /// <returns>This entity predicate</returns>
    public EntityPredicate RequireOffHand(ItemPredicate item)
    {
        Items["offhand"] = item;
        return this;
    }
    
    /// <summary>
    /// Requires a specific item in helmet slot
    /// </summary>
    /// <param name="item">Item to be required</param>
    /// <returns>This entity predicate</returns>
    public EntityPredicate RequireHelmet(ItemPredicate item)
    {
        Items["head"] = item;
        return this;
    }
    
    /// <summary>
    /// Requires a specific item in chestplate slot
    /// </summary>
    /// <param name="item">Item to be required</param>
    /// <returns>This entity predicate</returns>
    public EntityPredicate RequireChestplate(ItemPredicate item)
    {
        Items["chest"] = item;
        return this;
    }
    
    /// <summary>
    /// Requires a specific item in legs slot
    /// </summary>
    /// <param name="item">Item to be required</param>
    /// <returns>This entity predicate</returns>
    public EntityPredicate RequireLeggings(ItemPredicate item)
    {
        Items["legs"] = item;
        return this;
    }
    
    /// <summary>
    /// Requires a specific item in feet slot
    /// </summary>
    /// <param name="item">Item to be required</param>
    /// <returns>This entity predicate</returns>
    public EntityPredicate RequireBoots(ItemPredicate item)
    {
        Items["feet"] = item;
        return this;
    }
    
    /// <summary>
    /// Requires this entity to be on fire
    /// </summary>
    /// <param name="marker">Whether to require</param>
    /// <returns>This entity predicate</returns>
    public EntityPredicate RequireOnFire(bool marker = true)
    {
        Flags["is_on_fire"] = marker;
        return this;
    }
    
    /// <summary>
    /// Requires this entity to be sneaking
    /// </summary>
    /// <param name="marker">Whether to require</param>
    /// <returns>This entity predicate</returns>
    public EntityPredicate RequireSneaking(bool marker = true)
    {
        Flags["is_sneaking"] = marker;
        return this;
    }

    /// <summary>
    /// Requires this entity to be sprinting
    /// </summary>
    /// <param name="marker">Whether to require</param>
    /// <returns>This entity predicate</returns>
    public EntityPredicate RequireSprinting(bool marker = true)
    {
        Flags["is_sprinting"] = marker;
        return this;
    }

    /// <summary>
    /// Requires this entity to be swimming
    /// </summary>
    /// <param name="marker">Whether to require</param>
    /// <returns>This entity predicate</returns>
    public EntityPredicate RequireSwimming(bool marker = true)
    {
        Flags["is_swimming"] = marker;
        return this;
    }

    /// <summary>
    /// Requires this entity to be a baby
    /// </summary>
    /// <param name="marker">Whether to require</param>
    /// <returns>This entity predicate</returns>
    public EntityPredicate RequireBaby(bool marker = true)
    {
        Flags["is_baby"] = marker;
        return this;
    }

    /// <summary>
    /// Marks this entity as lightning.
    /// <b>WILL FAIL FOR ANY ENTITY THAT IS NOT A LIGHTNING!</b>
    /// </summary>
    /// <param name="blocksOnFire">Amount of blocks set on fire</param>
    /// <param name="struck">Entity struck</param>
    /// <returns>This entity predicate</returns>
    public EntityPredicate RequireLightning(int? blocksOnFire, EntityPredicate? struck)
    {
        LightningProperties = (blocksOnFire, struck);
        return this;
    }

    /// <summary>
    /// Requires this entity to be at specific location
    /// </summary>
    /// <param name="loc">Location required</param>
    /// <returns>This entity predicate</returns>
    public EntityPredicate RequireLocation(LocationPredicate loc)
    {
        Location = loc;
        return this;
    }

    /// <summary>
    /// Requires this entity to have specific nbt
    /// </summary>
    /// <param name="nbt">NBT required</param>
    /// <returns>This entity predicate</returns>
    public EntityPredicate RequireNbt(NbtCompound nbt)
    {
        Nbt = nbt.Serialize();
        return this;
    }

    /// <summary>
    /// Requires this entity to have a specific passenger
    /// </summary>
    /// <param name="passenger">Passenger required</param>
    /// <returns>This entity predicate</returns>
    public EntityPredicate RequirePassenger(EntityPredicate passenger)
    {
        Passenger = passenger;
        return this;
    }

    /// <summary>
    /// Requires this entity to have specific player data.
    /// <b>WILL FAIL FOR ANY ENTITY THAT IS NOT A PLAYER!</b>
    /// </summary>
    /// <param name="player">Required player data</param>
    /// <returns>This entity predicaet</returns>
    public EntityPredicate PlayerProperties(PlayerPredicate player)
    {
        PlayerData = player;
        return this;
    }

    /// <summary>
    /// Serializes this entity predicate into provided json writer
    /// </summary>
    /// <param name="jw">Writer to be used</param>
    public async Task SerializeInto(JsonTextWriter jw)
    {
        await jw.WriteStartObjectAsync();
        
        if(Distances.Any(it => it.Value.Item1 != null || it.Value.Item2 != null))
        {
            await jw.WritePropertyNameAsync("distance");
            await jw.WriteStartObjectAsync();
            foreach (var (key, (max, min)) in Distances)
            {
                await jw.WritePropertyNameAsync(key);
                await jw.WriteStartObjectAsync();
                if (max != null)
                {
                    await jw.WritePropertyNameAsync("max");
                    await jw.WriteValueAsync(max);
                }
                if (min != null)
                {
                    await jw.WritePropertyNameAsync("min");
                    await jw.WriteValueAsync(min);
                }
                await jw.WriteEndObjectAsync();
            }

            await jw.WriteEndObjectAsync();
        }

        if (Effects.Any())
        {
            await jw.WritePropertyNameAsync("effects");
            await jw.WriteStartObjectAsync();
            foreach (var effect in Effects)
            {
                await effect.SerializeInto(jw);
            }
            await jw.WriteEndObjectAsync();
        }

        if (Items.Any())
        {
            await jw.WritePropertyNameAsync("equipment");
            await jw.WriteStartObjectAsync();
            foreach (var (k, v) in Items)
            {
                await jw.WritePropertyNameAsync(k);
                await v.SerializeInto(jw);
            }

            await jw.WriteEndObjectAsync();
        }

        if (Flags.Any())
        {
            await jw.WritePropertyNameAsync("flags");
            await jw.WriteStartObjectAsync();
            foreach (var (flag, ind) in Flags)
            {
                await jw.WritePropertyNameAsync(flag);
                await jw.WriteValueAsync(ind);
            }
            await jw.WriteEndObjectAsync();
        }

        if (LightningProperties != null)
        {
            await jw.WritePropertyNameAsync("lightning_bolt");
            await jw.WriteStartObjectAsync();
            if (LightningProperties?.Item1 != null)
            {
                await jw.WritePropertyNameAsync("blocks_set_on_fire");
                await jw.WriteValueAsync(LightningProperties?.Item1);
            }

            if (LightningProperties?.Item2 != null)
            {
                await jw.WritePropertyNameAsync("entity_struck");
                await jw.WriteValueAsync(LightningProperties?.Item2);
            }
            
            await jw.WriteEndObjectAsync();
        }

        if (Location != null)
        {
            await jw.WritePropertyNameAsync("location");
            await jw.WriteValueAsync(Location);
        }

        if (Nbt != null)
        {
            await jw.WritePropertyNameAsync("nbt");
            await jw.WriteValueAsync(Nbt);
        }

        if (Passenger != null)
        {
            await jw.WritePropertyNameAsync("passenger");
            await (Passenger?.SerializeInto(jw) ?? Task.CompletedTask);
        }

        if (PlayerData != null)
        {
            await jw.WritePropertyNameAsync("player");
            await (PlayerData?.SerializeInto(jw) ?? Task.CompletedTask);
        }
        
        await jw.WriteEndObjectAsync();
    }
}