using CopperSharp.Data.SNbt;
using CopperSharp.Item;
using CopperSharp.Item.Meta;
using CopperSharp.Utils;
using Newtonsoft.Json;

namespace CopperSharp.Advancements.Predicates;

/// <summary>
/// Represents an item for use in conditions
/// </summary>
public struct ItemPredicate
{
    private StrictRange? CountRange { get; set; }
    private StrictRange? DurabilityRange { get; set; }
    private string? Nbt { get; set; }
    private List<EnchantmentPredicate> Enchantments { get; } = new();
    private List<EnchantmentPredicate> StoredEnchantments { get; } = new();
    private List<Material> Types { get; } = new();

    /// <summary>
    /// Constructs a new simple item predicate
    /// </summary>
    /// <param name="type">Types of this predicate</param>
    /// <returns>New constructed predicate</returns>
    public static ItemPredicate Simple(params Material[] type) => new ItemPredicate().OfTypes(type);

    /// <summary>
    /// Sets possible counts of item
    /// </summary>
    /// <param name="count">Count to be set</param>
    /// <returns>This item condition</returns>
    public ItemPredicate Count(StrictRange count)
    {
        CountRange = count;
        return this;
    }

    /// <summary>
    /// Sets possible durabilities of item
    /// </summary>
    /// <param name="durability">Durability to be set</param>
    /// <returns>This item condition</returns>
    public ItemPredicate Durability(StrictRange durability)
    {
        DurabilityRange = durability;
        return this;
    }

    /// <summary>
    /// Adds an NBT string to this item
    /// </summary>
    /// <param name="comp">NBT to be added</param>
    /// <returns>This item condition</returns>
    public ItemPredicate WithNbt(NbtCompound comp)
    {
        Nbt = comp.Serialize();
        return this;
    }
    
    /// <summary>
    /// Adds a required item meta to this item condition
    /// </summary>
    /// <param name="meta">Meta to be added</param>
    /// <returns>This item condition</returns>
    public ItemPredicate WithMeta(ItemMeta meta)
    {
        Nbt = meta.Serialize();
        return this;
    }

    /// <summary>
    /// Adds required enchantments to this item condition
    /// </summary>
    /// <param name="enchants">Enchantments to be added</param>
    /// <returns>This item condition</returns>
    public ItemPredicate WithEnchantments(params EnchantmentPredicate[] enchants)
    {
        Enchantments.AddRange(enchants);
        return this;
    }
    
    /// <summary>
    /// Adds stored required enchantments to this item condition
    /// </summary>
    /// <param name="enchants">Enchantments to be added</param>
    /// <returns>This item condition</returns>
    public ItemPredicate WithStoredEnchantments(params EnchantmentPredicate[] enchants)
    {
        StoredEnchantments.AddRange(enchants);
        return this;
    }

    /// <summary>
    /// Requires the item to be of provided types
    /// </summary>
    /// <param name="types">Types of item</param>
    /// <returns>This item condition</returns>
    public ItemPredicate OfTypes(params Material[] types)
    {
        Types.AddRange(types);
        return this;
    }

    /// <summary>
    /// Serializes this item condition
    /// </summary>
    /// <param name="jw">Writer to be used</param>
    public async Task SerializeInto(JsonTextWriter jw)
    {
        await jw.WriteStartObjectAsync();
        if (Types.Any())
        {
            await jw.WritePropertyNameAsync("items");
            await jw.WriteStartArrayAsync();
            foreach (var type in Types)
            {
                await jw.WriteValueAsync(type.Id.ToString());
            }
            await jw.WriteEndArrayAsync();
        }

        if (Nbt != null)
        {
            await jw.WritePropertyNameAsync("nbt");
            await jw.WriteValueAsync(Nbt);
        }

        if (Enchantments.Any())
        {
            await jw.WritePropertyNameAsync("enchantments");
            await jw.WriteStartArrayAsync();
            foreach (var enchant in Enchantments)
            {
                await enchant.SerializeInto(jw);
            }
            await jw.WriteEndArrayAsync();
        }
        
        if (StoredEnchantments.Any())
        {
            await jw.WritePropertyNameAsync("stored_enchantments");
            await jw.WriteStartArrayAsync();
            foreach (var enchant in StoredEnchantments)
            {
                await enchant.SerializeInto(jw);
            }
            await jw.WriteEndArrayAsync();
        }

        await (CountRange?.SerializeInto(jw, "count") ?? Task.CompletedTask);
        await (DurabilityRange?.SerializeInto(jw, "count") ?? Task.CompletedTask);

        await jw.WriteEndObjectAsync();
    }
}