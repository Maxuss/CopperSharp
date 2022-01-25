using CopperSharp.Data.Attributes;
using CopperSharp.Data.Effects;
using CopperSharp.Data.SNbt;
using CopperSharp.Item;

namespace CopperSharp.Entity;

/// <summary>
/// Represents an entity, that is a mob
/// </summary>
public abstract class LivingEntity : AbstractEntity
{
    /// <inheritdoc />
    protected LivingEntity(EntityType type) : base(type)
    {
    }

    private List<PotionEffect> Effects { get; set; } = new();
    private float? AbsorptionAmount { get; set; }
    private float[] ArmorDropChance { get; set; } = {0f, 0f, 0f, 0f};
    private float[] HandDropChance { get; set; } = {0f, 0f};
    private ItemStack?[] ArmorItems { get; set; } = {null, null, null, null};
    private ItemStack?[] HandItems { get; set; } = {null, null};
    private List<(IAttributeType, double)> Modifiers { get; set; } = new();

    /// <summary>
    /// Extra bool values to store inside this entity
    /// </summary>
    protected Dictionary<string, bool> Bools { get; set; } = new();

    /// <summary>
    /// Extra integers in this entity
    /// </summary>
    protected Dictionary<string, int> Ints { get; set; } = new();

    private float? HealthAmount { get; set; } = null;

    /// <summary>
    /// Adds provided potion effects to this entity
    /// </summary>
    /// <param name="effects">Effects to be added</param>
    /// <returns>This living entity</returns>
    public LivingEntity AddEffect(params PotionEffect[] effects)
    {
        Effects.AddRange(effects);
        return this;
    }

    /// <summary>
    /// Adds an effect to this entity
    /// </summary>
    /// <param name="type">Type of effect</param>
    /// <param name="duration">Duration of the effect</param>
    /// <param name="level">Zero-based level of the effect</param>
    /// <param name="showIcon">Whether to show icon of the effect</param>
    /// <param name="showParticles">Whether to show particles of this effect</param>
    /// <param name="ambient">Whether the effect is ambient</param>
    /// <returns>This living entity</returns>
    public LivingEntity AddEffect(StatusEffect type, int duration, byte level = 0, bool showIcon = true,
        bool showParticles = true, bool ambient = false) =>
        AddEffect(new PotionEffect(type, duration, level, showParticles, showIcon, ambient));

    /// <summary>
    /// Sets absorption amount to this entity
    /// </summary>
    /// <param name="absorption">Amount of absorption</param>
    /// <returns>This living entity</returns>
    public LivingEntity SetAbsorption(float absorption)
    {
        AbsorptionAmount = absorption;
        return this;
    }

    /// <summary>
    /// Sets chance to drop helmet
    /// </summary>
    /// <param name="newChance">New drop chance</param>
    /// <returns>This living entity</returns>
    public LivingEntity HelmetDropChance(float newChance)
    {
        ArmorDropChance[3] = newChance;
        return this;
    }

    /// <summary>
    /// Sets chance to drop chestplate
    /// </summary>
    /// <param name="newChance">New drop chance</param>
    /// <returns>This living entity</returns>
    public LivingEntity ChestplateDropChance(float newChance)
    {
        ArmorDropChance[2] = newChance;
        return this;
    }

    /// <summary>
    /// Sets chance to drop leggings
    /// </summary>
    /// <param name="newChance">New drop chance</param>
    /// <returns>This living entity</returns>
    public LivingEntity LeggingsDropChance(float newChance)
    {
        ArmorDropChance[1] = newChance;
        return this;
    }

    /// <summary>
    /// Sets chance to drop boots
    /// </summary>
    /// <param name="newChance">New drop chance</param>
    /// <returns>This living entity</returns>
    public LivingEntity BootsDropChance(float newChance)
    {
        ArmorDropChance[0] = newChance;
        return this;
    }

    /// <summary>
    /// Sets helmet of this entity
    /// </summary>
    /// <param name="item">New helmet</param>
    /// <returns>This living entity</returns>
    public LivingEntity Helmet(ItemStack item)
    {
        ArmorItems[3] = item;
        return this;
    }

    /// <summary>
    /// Sets chestplate of this entity
    /// </summary>
    /// <param name="item">New chestplate</param>
    /// <returns>This living entity</returns>
    public LivingEntity Chestplate(ItemStack item)
    {
        ArmorItems[2] = item;
        return this;
    }

    /// <summary>
    /// Sets leggings of this entity
    /// </summary>
    /// <param name="item">New leggings</param>
    /// <returns>This living entity</returns>
    public LivingEntity Leggings(ItemStack item)
    {
        ArmorItems[1] = item;
        return this;
    }

    /// <summary>
    /// Sets boots of this entity
    /// </summary>
    /// <param name="item">New boots</param>
    /// <returns>This living entity</returns>
    public LivingEntity Boots(ItemStack item)
    {
        ArmorItems[0] = item;
        return this;
    }

    /// <summary>
    /// Sets item in main hand of this entity
    /// </summary>
    /// <param name="item">New item</param>
    /// <returns>This living entity</returns>
    public LivingEntity MainHand(ItemStack item)
    {
        HandItems[0] = item;
        return this;
    }

    /// <summary>
    /// Sets item in off hand of this entity
    /// </summary>
    /// <param name="item">New item</param>
    /// <returns>This living entity</returns>
    public LivingEntity OffHand(ItemStack item)
    {
        HandItems[1] = item;
        return this;
    }

    /// <summary>
    /// Sets chance to drop item from main hand by this entity
    /// </summary>
    /// <param name="chance">Chance to drop item</param>
    /// <returns>This living entity</returns>
    public LivingEntity MainHandDropChance(float chance)
    {
        HandDropChance[0] = chance;
        return this;
    }

    /// <summary>
    /// Sets chance to drop item from off hand by this entity
    /// </summary>
    /// <param name="chance">Chance to drop item</param>
    /// <returns>This living entity</returns>
    public LivingEntity OffHandDropChance(float chance)
    {
        HandDropChance[1] = chance;
        return this;
    }

    /// <summary>
    /// Disables AI for this entity
    /// </summary>
    /// <returns>This living entity</returns>
    // ReSharper disable once InconsistentNaming
    public LivingEntity NoAI()
    {
        Bools["NoAI"] = true;
        return this;
    }

    /// <summary>
    /// Makes this entity left-handed
    /// </summary>
    /// <returns>This living entity</returns>
    public LivingEntity LeftHanded()
    {
        Bools["LeftHanded"] = true;
        return this;
    }

    /// <summary>
    /// Disables default despawning for this entity
    /// </summary>
    /// <returns>This living entity</returns>
    public LivingEntity DontDespawn()
    {
        Bools["PersistenceRequired"] = true;
        return this;
    }

    /// <summary>
    /// Makes this entity able to pick up loot
    /// </summary>
    /// <param name="can">Whether the entity can pick up loot</param>
    /// <returns>This living entity</returns>
    public LivingEntity CanPickupLoot(bool can)
    {
        Bools["CanPickUpLoot"] = can;
        return this;
    }

    /// <summary>
    /// Whether to allow this entity to use elytra
    /// </summary>
    /// <param name="can">Whether this entity can use elytra</param>
    /// <returns>This living entity</returns>
    public LivingEntity CanUseElytra(bool can)
    {
        Bools["FallFlying"] = can;
        return this;
    }

    /// <summary>
    /// Sets default health for this entity
    /// </summary>
    /// <param name="health">Health amount</param>
    /// <returns>This living entity</returns>
    public LivingEntity Health(float health)
    {
        HealthAmount = health;
        return this;
    }

    /// <summary>
    /// Adds an extra attribute to this entity
    /// </summary>
    /// <param name="attribute">Type of attribute</param>
    /// <param name="value">Value of the attribute</param>
    /// <returns>This living entity</returns>
    public LivingEntity AddAttribute(IAttributeType attribute, double value)
    {
        Modifiers.Add((attribute, value));
        return this;
    }

    /// <inheritdoc />
    protected override void SerializeExtra(StringNbtWriter sw)
    {
        if (AbsorptionAmount != null)
            sw.WriteFloat("AbsorptionAmount", AbsorptionAmount ?? 0);

        if (Effects.Any())
        {
            sw.WritePropertyName("ActiveEffects");
            sw.WriteBeginArray();
            foreach (var eff in Effects)
            {
                if (Effects.IndexOf(eff) != 0)
                    sw.WriteComma();
                sw.WriteBeginCompound();
                sw.WriteBool("Ambient", eff.Ambient);
                sw.WriteByte("Amplifier", eff.Level);
                sw.WriteInteger("Duration", eff.Duration);
                sw.WriteByte("Id", eff.Id);
                sw.WriteBool("ShowIcon", eff.ShowIcon);
                sw.WriteBool("ShowParticles", eff.ShowParticles);
                sw.WriteEndCompound();
            }

            sw.WriteEndArray();
            sw.WriteComma();
        }

        if (HandItems.Any(it => it != null))
        {
            sw.WritePropertyName("HandItems");
            sw.WriteBeginArray();
            foreach (var item in HandItems)
            {
                sw.WriteItem(item);
                sw.WriteComma();
            }

            sw.WriteEndArray();
            sw.WriteComma();
        }

        if (ArmorItems.Any(it => it != null))
        {
            sw.WritePropertyName("ArmorItems");
            sw.WriteBeginArray();
            foreach (var item in ArmorItems)
            {
                sw.WriteItem(item);
                sw.WriteComma();
            }

            sw.WriteEndArray();
            sw.WriteComma();
        }

        if (Modifiers.Any())
        {
            sw.WritePropertyName("Attributes");
            sw.WriteBeginArray();
            foreach (var (mod, val) in Modifiers)
            {
                sw.WriteBeginCompound();
                sw.WriteDouble("Base", val);
                sw.WriteRawValue("Name", mod.Name);
                sw.WriteEndCompound();
                sw.WriteComma();
            }

            sw.WriteEndArray();
            sw.WriteComma();
        }

        if (HealthAmount != null)
            sw.WriteFloat("Health", HealthAmount ?? 0);

        foreach (var (key, val) in Bools)
        {
            sw.WriteBool(key, val);
        }

        foreach (var (key, val) in Ints)
        {
            sw.WriteInteger(key, val);
        }

        sw.WritePropertyName("ArmorDropChances");
        sw.WriteBeginArray();
        foreach (var chance in ArmorDropChance)
        {
            sw.WriteFloat(chance);
        }

        sw.WriteEndArray();
        sw.WriteComma();

        sw.WritePropertyName("HandDropChances");
        sw.WriteBeginArray();
        foreach (var chance in HandDropChance)
        {
            sw.WriteFloat(chance);
        }

        sw.WriteEndArray();
    }
}