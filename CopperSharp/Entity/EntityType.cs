// THIS FILE IS AUTO-GENERATED!

using CopperSharp.Entity.Impl;
using CopperSharp.Registry;

namespace CopperSharp.Entity;

/// <summary>
///     Represents a specific type of entity
/// </summary>
public readonly struct EntityType
{
    /// <summary>
    ///     ID of this entity
    /// </summary>
    public Identifier Id { get; }

    /// <summary>
    ///     Class of this entity. Should have a no-args constructor
    /// </summary>
    public Type Class { get; }

    private EntityType(Identifier id, Type @class)
    {
        Id = id;
        Class = @class;
    }

    /// <summary>
    ///     Injects an entity type. Not recommended to do
    /// </summary>
    /// <param name="id">ID of the new entity</param>
    /// <param name="class">Class of the entity</param>
    /// <returns>New generated entity type</returns>
    public static EntityType Inject(Identifier id, Type @class)
    {
        return new EntityType(id, @class);
    }

    /// <summary>Represents entity of type minecraft:area_effect_cloud</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType AreaEffectCloud { get; } =
        new(Identifier.Minecraft("area_effect_cloud"), typeof(AreaEffectCloud));

    /// <summary>Represents entity of type minecraft:armor_stand</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType ArmorStand { get; } = new(Identifier.Minecraft("armor_stand"), typeof(ArmorStand));

    /// <summary>Represents entity of type minecraft:arrow</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Arrow { get; } = new(Identifier.Minecraft("arrow"), typeof(Arrow));

    /// <summary>Represents entity of type minecraft:axolotl</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Axolotl { get; } = new(Identifier.Minecraft("axolotl"), typeof(Axolotl));

    /// <summary>Represents entity of type minecraft:bat</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Bat { get; } = new(Identifier.Minecraft("bat"), typeof(Bat));

    /// <summary>Represents entity of type minecraft:bee</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Bee { get; } = new(Identifier.Minecraft("bee"), typeof(Bee));

    /// <summary>Represents entity of type minecraft:blaze</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Blaze { get; } = new(Identifier.Minecraft("blaze"), typeof(Blaze));

    /// <summary>Represents entity of type minecraft:boat</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Boat { get; } = new(Identifier.Minecraft("boat"), typeof(Boat));

    /// <summary>Represents entity of type minecraft:cat</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Cat { get; } = new(Identifier.Minecraft("cat"), typeof(Cat));

    /// <summary>Represents entity of type minecraft:cave_spider</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType CaveSpider { get; } = new(Identifier.Minecraft("cave_spider"), typeof(CaveSpider));

    /// <summary>Represents entity of type minecraft:chicken</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Chicken { get; } = new(Identifier.Minecraft("chicken"), typeof(Chicken));

    /// <summary>Represents entity of type minecraft:cod</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Cod { get; } = new(Identifier.Minecraft("cod"), typeof(Cod));

    /// <summary>Represents entity of type minecraft:cow</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Cow { get; } = new(Identifier.Minecraft("cow"), typeof(Cow));

    /// <summary>Represents entity of type minecraft:creeper</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Creeper { get; } = new(Identifier.Minecraft("creeper"), typeof(Creeper));

    /// <summary>Represents entity of type minecraft:dolphin</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Dolphin { get; } = new(Identifier.Minecraft("dolphin"), typeof(Dolphin));

    /// <summary>Represents entity of type minecraft:donkey</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Donkey { get; } = new(Identifier.Minecraft("donkey"), typeof(Donkey));

    /// <summary>Represents entity of type minecraft:dragon_fireball</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType DragonFireball { get; } =
        new(Identifier.Minecraft("dragon_fireball"), typeof(DragonFireball));

    /// <summary>Represents entity of type minecraft:drowned</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Drowned { get; } = new(Identifier.Minecraft("drowned"), typeof(Drowned));

    /// <summary>Represents entity of type minecraft:elder_guardian</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType ElderGuardian { get; } =
        new(Identifier.Minecraft("elder_guardian"), typeof(ElderGuardian));

    /// <summary>Represents entity of type minecraft:end_crystal</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType EndCrystal { get; } = new(Identifier.Minecraft("end_crystal"), typeof(EndCrystal));

    /// <summary>Represents entity of type minecraft:ender_dragon</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType EnderDragon { get; } = new(Identifier.Minecraft("ender_dragon"), typeof(EnderDragon));

    /// <summary>Represents entity of type minecraft:enderman</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Enderman { get; } = new(Identifier.Minecraft("enderman"), typeof(Enderman));

    /// <summary>Represents entity of type minecraft:endermite</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Endermite { get; } = new(Identifier.Minecraft("endermite"), typeof(Endermite));

    /// <summary>Represents entity of type minecraft:evoker</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Evoker { get; } = new(Identifier.Minecraft("evoker"), typeof(Evoker));

    /// <summary>Represents entity of type minecraft:evoker_fangs</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType EvokerFangs { get; } = new(Identifier.Minecraft("evoker_fangs"), typeof(EvokerFangs));

    /// <summary>Represents entity of type minecraft:experience_orb</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType ExperienceOrb { get; } =
        new(Identifier.Minecraft("experience_orb"), typeof(ExperienceOrb));

    /// <summary>Represents entity of type minecraft:eye_of_ender</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType EyeOfEnder { get; } = new(Identifier.Minecraft("eye_of_ender"), typeof(EyeOfEnder));

    /// <summary>Represents entity of type minecraft:falling_block</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType FallingBlock { get; } = new(Identifier.Minecraft("falling_block"), typeof(FallingBlock));

    /// <summary>Represents entity of type minecraft:firework_rocket</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType FireworkRocket { get; } =
        new(Identifier.Minecraft("firework_rocket"), typeof(FireworkRocket));

    /// <summary>Represents entity of type minecraft:fox</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Fox { get; } = new(Identifier.Minecraft("fox"), typeof(Fox));

    /// <summary>Represents entity of type minecraft:ghast</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Ghast { get; } = new(Identifier.Minecraft("ghast"), typeof(Ghast));

    /// <summary>Represents entity of type minecraft:giant</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Giant { get; } = new(Identifier.Minecraft("giant"), typeof(Giant));

    /// <summary>Represents entity of type minecraft:glow_item_frame</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType GlowItemFrame { get; } = new(Identifier.Minecraft("glow_item_frame"), typeof(ItemFrame));

    /// <summary>Represents entity of type minecraft:glow_squid</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType GlowSquid { get; } = new(Identifier.Minecraft("glow_squid"), typeof(GlowSquid));

    /// <summary>Represents entity of type minecraft:goat</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Goat { get; } = new(Identifier.Minecraft("goat"), typeof(Goat));

    /// <summary>Represents entity of type minecraft:guardian</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Guardian { get; } = new(Identifier.Minecraft("guardian"), typeof(Guardian));

    /// <summary>Represents entity of type minecraft:hoglin</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Hoglin { get; } = new(Identifier.Minecraft("hoglin"), typeof(Hoglin));

    /// <summary>Represents entity of type minecraft:horse</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Horse { get; } = new(Identifier.Minecraft("horse"), typeof(Horse));

    /// <summary>Represents entity of type minecraft:husk</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Husk { get; } = new(Identifier.Minecraft("husk"), typeof(Husk));

    /// <summary>Represents entity of type minecraft:illusioner</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Illusioner { get; } = new(Identifier.Minecraft("illusioner"), typeof(Illusioner));

    /// <summary>Represents entity of type minecraft:iron_golem</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType IronGolem { get; } = new(Identifier.Minecraft("iron_golem"), typeof(IronGolem));

    /// <summary>Represents entity of type minecraft:item</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Item { get; } = new(Identifier.Minecraft("item"), typeof(DroppedItem));

    /// <summary>Represents entity of type minecraft:item_frame</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType ItemFrame { get; } = new(Identifier.Minecraft("item_frame"), typeof(ItemFrame));

    /// <summary>Represents entity of type minecraft:fireball</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Fireball { get; } = new(Identifier.Minecraft("fireball"), typeof(Fireball));

    /// <summary>Represents entity of type minecraft:leash_knot</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType LeashKnot { get; } = new(Identifier.Minecraft("leash_knot"), typeof(LeashKnot));

    /// <summary>Represents entity of type minecraft:lightning_bolt</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType LightningBolt { get; } =
        new(Identifier.Minecraft("lightning_bolt"), typeof(LightningBolt));

    /// <summary>Represents entity of type minecraft:llama</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Llama { get; } = new(Identifier.Minecraft("llama"), typeof(Llama));

    /// <summary>Represents entity of type minecraft:llama_spit</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType LlamaSpit { get; } = new(Identifier.Minecraft("llama_spit"), typeof(LlamaSpit));

    /// <summary>Represents entity of type minecraft:magma_cube</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType MagmaCube { get; } = new(Identifier.Minecraft("magma_cube"), typeof(MagmaCube));

    /// <summary>Represents entity of type minecraft:marker</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Marker { get; } = new(Identifier.Minecraft("marker"), typeof(Marker));

    /// <summary>Represents entity of type minecraft:minecart</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Minecart { get; } = new(Identifier.Minecraft("minecart"), typeof(Minecart));

    /// <summary>Represents entity of type minecraft:chest_minecart</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType ChestMinecart { get; } =
        new(Identifier.Minecraft("chest_minecart"), typeof(ChestMinecart));

    /// <summary>Represents entity of type minecraft:command_block_minecart</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType CommandBlockMinecart { get; } =
        new(Identifier.Minecraft("command_block_minecart"), typeof(CommandBlockMinecart));

    /// <summary>Represents entity of type minecraft:furnace_minecart</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType FurnaceMinecart { get; } =
        new(Identifier.Minecraft("furnace_minecart"), typeof(FurnaceMinecart));

    /// <summary>Represents entity of type minecraft:hopper_minecart</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType HopperMinecart { get; } =
        new(Identifier.Minecraft("hopper_minecart"), typeof(HopperMinecart));

    /// <summary>Represents entity of type minecraft:spawner_minecart</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType SpawnerMinecart { get; } =
        new(Identifier.Minecraft("spawner_minecart"), typeof(SpawnerMinecart));

    /// <summary>Represents entity of type minecraft:tnt_minecart</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType TntMinecart { get; } = new(Identifier.Minecraft("tnt_minecart"), typeof(TntMinecart));

    /// <summary>Represents entity of type minecraft:mule</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Mule { get; } = new(Identifier.Minecraft("mule"), typeof(Mule));

    /// <summary>Represents entity of type minecraft:mooshroom</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Mooshroom { get; } = new(Identifier.Minecraft("mooshroom"), typeof(Mooshroom));

    /// <summary>Represents entity of type minecraft:ocelot</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Ocelot { get; } = new(Identifier.Minecraft("ocelot"), typeof(Ocelot));

    /// <summary>Represents entity of type minecraft:painting</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Painting { get; } = new(Identifier.Minecraft("painting"), typeof(Painting));

    /// <summary>Represents entity of type minecraft:panda</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Panda { get; } = new(Identifier.Minecraft("panda"), typeof(Panda));

    /// <summary>Represents entity of type minecraft:parrot</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Parrot { get; } = new(Identifier.Minecraft("parrot"), typeof(Parrot));

    /// <summary>Represents entity of type minecraft:phantom</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Phantom { get; } = new(Identifier.Minecraft("phantom"), typeof(Phantom));

    /// <summary>Represents entity of type minecraft:pig</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Pig { get; } = new(Identifier.Minecraft("pig"), typeof(Pig));

    /// <summary>Represents entity of type minecraft:piglin</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Piglin { get; } = new(Identifier.Minecraft("piglin"), typeof(Piglin));

    /// <summary>Represents entity of type minecraft:piglin_brute</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType PiglinBrute { get; } = new(Identifier.Minecraft("piglin_brute"), typeof(PiglinBrute));

    /// <summary>Represents entity of type minecraft:pillager</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Pillager { get; } = new(Identifier.Minecraft("pillager"), typeof(Pillager));

    /// <summary>Represents entity of type minecraft:polar_bear</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType PolarBear { get; } = new(Identifier.Minecraft("polar_bear"), typeof(PolarBear));

    /// <summary>Represents entity of type minecraft:tnt</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Tnt { get; } = new(Identifier.Minecraft("tnt"), typeof(Tnt));

    /// <summary>Represents entity of type minecraft:pufferfish</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Pufferfish { get; } = new(Identifier.Minecraft("pufferfish"), typeof(Pufferfish));

    /// <summary>Represents entity of type minecraft:rabbit</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Rabbit { get; } = new(Identifier.Minecraft("rabbit"), typeof(Rabbit));

    /// <summary>Represents entity of type minecraft:ravager</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Ravager { get; } = new(Identifier.Minecraft("ravager"), typeof(Ravager));

    /// <summary>Represents entity of type minecraft:salmon</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Salmon { get; } = new(Identifier.Minecraft("salmon"), typeof(Salmon));

    /// <summary>Represents entity of type minecraft:sheep</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Sheep { get; } = new(Identifier.Minecraft("sheep"), typeof(Sheep));

    /// <summary>Represents entity of type minecraft:shulker</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Shulker { get; } = new(Identifier.Minecraft("shulker"), typeof(Shulker));

    /// <summary>Represents entity of type minecraft:shulker_bullet</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType ShulkerBullet { get; } =
        new(Identifier.Minecraft("shulker_bullet"), typeof(ShulkerBullet));

    /// <summary>Represents entity of type minecraft:silverfish</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Silverfish { get; } = new(Identifier.Minecraft("silverfish"), typeof(Silverfish));

    /// <summary>Represents entity of type minecraft:skeleton</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Skeleton { get; } = new(Identifier.Minecraft("skeleton"), typeof(Skeleton));

    /// <summary>Represents entity of type minecraft:skeleton_horse</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType SkeletonHorse { get; } =
        new(Identifier.Minecraft("skeleton_horse"), typeof(SkeletonHorse));

    /// <summary>Represents entity of type minecraft:slime</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Slime { get; } = new(Identifier.Minecraft("slime"), typeof(Slime));

    /// <summary>Represents entity of type minecraft:small_fireball</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType SmallFireball { get; } =
        new(Identifier.Minecraft("small_fireball"), typeof(SmallFireball));

    /// <summary>Represents entity of type minecraft:snow_golem</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType SnowGolem { get; } = new(Identifier.Minecraft("snow_golem"), typeof(SnowGolem));

    /// <summary>Represents entity of type minecraft:snowball</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Snowball { get; } = new(Identifier.Minecraft("snowball"), typeof(Snowball));

    /// <summary>Represents entity of type minecraft:spectral_arrow</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType SpectralArrow { get; } =
        new(Identifier.Minecraft("spectral_arrow"), typeof(SpectralArrow));

    /// <summary>Represents entity of type minecraft:spider</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Spider { get; } = new(Identifier.Minecraft("spider"), typeof(Spider));

    /// <summary>Represents entity of type minecraft:squid</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Squid { get; } = new(Identifier.Minecraft("squid"), typeof(Squid));

    /// <summary>Represents entity of type minecraft:stray</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Stray { get; } = new(Identifier.Minecraft("stray"), typeof(Stray));

    /// <summary>Represents entity of type minecraft:strider</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Strider { get; } = new(Identifier.Minecraft("strider"), typeof(Strider));

    /// <summary>Represents entity of type minecraft:egg</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Egg { get; } = new(Identifier.Minecraft("egg"), typeof(ThrownEgg));

    /// <summary>Represents entity of type minecraft:ender_pearl</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType EnderPearl { get; } = new(Identifier.Minecraft("ender_pearl"), typeof(EnderPearl));

    /// <summary>Represents entity of type minecraft:experience_bottle</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType ExperienceBottle { get; } =
        new(Identifier.Minecraft("experience_bottle"), typeof(ExperienceOrb));

    /// <summary>Represents entity of type minecraft:potion</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Potion { get; } = new(Identifier.Minecraft("potion"), typeof(ThrownPotion));

    /// <summary>Represents entity of type minecraft:trident</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Trident { get; } = new(Identifier.Minecraft("trident"), typeof(ThrownTrident));

    /// <summary>Represents entity of type minecraft:trader_llama</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType TraderLlama { get; } = new(Identifier.Minecraft("trader_llama"), typeof(Llama));

    /// <summary>Represents entity of type minecraft:tropical_fish</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType TropicalFish { get; } = new(Identifier.Minecraft("tropical_fish"), typeof(TropicalFish));

    /// <summary>Represents entity of type minecraft:turtle</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Turtle { get; } = new(Identifier.Minecraft("turtle"), typeof(Turtle));

    /// <summary>Represents entity of type minecraft:vex</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Vex { get; } = new(Identifier.Minecraft("vex"), typeof(Vex));

    /// <summary>Represents entity of type minecraft:villager</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Villager { get; } = new(Identifier.Minecraft("villager"), typeof(Villager));

    /// <summary>Represents entity of type minecraft:vindicator</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Vindicator { get; } = new(Identifier.Minecraft("vindicator"), typeof(Vindicator));

    /// <summary>Represents entity of type minecraft:wandering_trader</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType WanderingTrader { get; } =
        new(Identifier.Minecraft("wandering_trader"), typeof(WanderingTrader));

    /// <summary>Represents entity of type minecraft:witch</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Witch { get; } = new(Identifier.Minecraft("witch"), typeof(Witch));

    /// <summary>Represents entity of type minecraft:wither</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Wither { get; } = new(Identifier.Minecraft("wither"), typeof(Wither));

    /// <summary>Represents entity of type minecraft:wither_skeleton</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType WitherSkeleton { get; } =
        new(Identifier.Minecraft("wither_skeleton"), typeof(WitherSkeleton));

    /// <summary>Represents entity of type minecraft:wither_skull</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType WitherSkull { get; } = new(Identifier.Minecraft("wither_skull"), typeof(WitherSkeleton));

    /// <summary>Represents entity of type minecraft:wolf</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Wolf { get; } = new(Identifier.Minecraft("wolf"), typeof(Wolf));

    /// <summary>Represents entity of type minecraft:zoglin</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Zoglin { get; } = new(Identifier.Minecraft("zoglin"), typeof(Zoglin));

    /// <summary>Represents entity of type minecraft:zombie</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Zombie { get; } = new(Identifier.Minecraft("zombie"), typeof(Zombie));

    /// <summary>Represents entity of type minecraft:zombie_horse</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType ZombieHorse { get; } = new(Identifier.Minecraft("zombie_horse"), typeof(ZombieHorse));

    /// <summary>Represents entity of type minecraft:zombie_villager</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType ZombieVillager { get; } =
        new(Identifier.Minecraft("zombie_villager"), typeof(ZombieVillager));

    /// <summary>Represents entity of type minecraft:zombified_piglin</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType ZombifiedPiglin { get; } =
        new(Identifier.Minecraft("zombified_piglin"), typeof(ZombifiedPiglin));

    /// <summary>Represents entity of type minecraft:player</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType Player { get; } = new(Identifier.Minecraft("player"), typeof(ArmorStand));

    /// <summary>Represents entity of type minecraft:fishing_bobber</summary>
    /// <remarks>This field is <b>auto-generated</b>!</remarks>
    public static EntityType FishingBobber { get; } =
        new(Identifier.Minecraft("fishing_bobber"), typeof(FishingBobber));
}