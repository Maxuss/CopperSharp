// THIS FILE IS AUTO GENERATED!

using CopperSharp.Blocks.Data.Impl;
using CopperSharp.Registry;

namespace CopperSharp.Item;

/// <summary>
///     Represents a minecraft material.
/// </summary>
public readonly struct Material
{
    /// <summary>
    ///     ID of material item
    /// </summary>
    public Identifier Id { get; }

    /// <summary>
    ///     Extra type of block data
    /// </summary>
    public Type? BlockType { get; }

    internal Material(Identifier id, Type? dataType = null)
    {
        Id = id;
        BlockType = dataType;
    }

    /// <summary>
    ///     Constructs a new custom material. This is not recommended to use
    /// </summary>
    /// <param name="custom">Custom material to use</param>
    /// <returns>A material with provided identifier</returns>
    public static Material Inject(Identifier custom)
    {
        return new Material(custom);
    }

    /// <summary>Represents item by ID of minecraft:air.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Air = new(Identifier.Minecraft("air"));


    /// <summary>Represents item by ID of minecraft:stone.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Stone = new(Identifier.Minecraft("stone"));


    /// <summary>Represents item by ID of minecraft:granite.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Granite = new(Identifier.Minecraft("granite"));


    /// <summary>Represents item by ID of minecraft:polished_granite.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PolishedGranite = new(Identifier.Minecraft("polished_granite"));


    /// <summary>Represents item by ID of minecraft:diorite.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Diorite = new(Identifier.Minecraft("diorite"));


    /// <summary>Represents item by ID of minecraft:polished_diorite.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PolishedDiorite = new(Identifier.Minecraft("polished_diorite"));


    /// <summary>Represents item by ID of minecraft:andesite.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Andesite = new(Identifier.Minecraft("andesite"));


    /// <summary>Represents item by ID of minecraft:polished_andesite.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PolishedAndesite = new(Identifier.Minecraft("polished_andesite"));


    /// <summary>Represents item by ID of minecraft:grass_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GrassBlock = new(Identifier.Minecraft("grass_block"));


    /// <summary>Represents item by ID of minecraft:dirt.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Dirt = new(Identifier.Minecraft("dirt"));


    /// <summary>Represents item by ID of minecraft:coarse_dirt.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CoarseDirt = new(Identifier.Minecraft("coarse_dirt"));


    /// <summary>Represents item by ID of minecraft:podzol.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Podzol = new(Identifier.Minecraft("podzol"));


    /// <summary>Represents item by ID of minecraft:cobblestone.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Cobblestone = new(Identifier.Minecraft("cobblestone"));


    /// <summary>Represents item by ID of minecraft:oak_planks.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material OakPlanks = new(Identifier.Minecraft("oak_planks"));


    /// <summary>Represents item by ID of minecraft:spruce_planks.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SprucePlanks = new(Identifier.Minecraft("spruce_planks"));


    /// <summary>Represents item by ID of minecraft:birch_planks.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BirchPlanks = new(Identifier.Minecraft("birch_planks"));


    /// <summary>Represents item by ID of minecraft:jungle_planks.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material JunglePlanks = new(Identifier.Minecraft("jungle_planks"));


    /// <summary>Represents item by ID of minecraft:acacia_planks.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material AcaciaPlanks = new(Identifier.Minecraft("acacia_planks"));


    /// <summary>Represents item by ID of minecraft:dark_oak_planks.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DarkOakPlanks = new(Identifier.Minecraft("dark_oak_planks"));


    /// <summary>Represents item by ID of minecraft:oak_sapling.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material OakSapling = new(Identifier.Minecraft("oak_sapling"), typeof(Sapling));


    /// <summary>Represents item by ID of minecraft:spruce_sapling.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SpruceSapling = new(Identifier.Minecraft("spruce_sapling"), typeof(Sapling));


    /// <summary>Represents item by ID of minecraft:birch_sapling.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BirchSapling = new(Identifier.Minecraft("birch_sapling"), typeof(Sapling));


    /// <summary>Represents item by ID of minecraft:jungle_sapling.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material JungleSapling = new(Identifier.Minecraft("jungle_sapling"), typeof(Sapling));

    /// <summary>Represents item by ID of minecraft:acacia_sapling.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material AcaciaSapling = new(Identifier.Minecraft("acacia_sapling"), typeof(Sapling));

    /// <summary>Represents item by ID of minecraft:dark_oak_sapling.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DarkOakSapling = new(Identifier.Minecraft("dark_oak_sapling"), typeof(Sapling));

    /// <summary>Represents item by ID of minecraft:bedrock.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Bedrock = new(Identifier.Minecraft("bedrock"));

    /// <summary>Represents item by ID of minecraft:water.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Water = new(Identifier.Minecraft("water"));

    /// <summary>Represents item by ID of minecraft:lava.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Lava = new(Identifier.Minecraft("lava"));

    /// <summary>Represents item by ID of minecraft:sand.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Sand = new(Identifier.Minecraft("sand"));

    /// <summary>Represents item by ID of minecraft:red_sand.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RedSand = new(Identifier.Minecraft("red_sand"));

    /// <summary>Represents item by ID of minecraft:gravel.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Gravel = new(Identifier.Minecraft("gravel"));

    /// <summary>Represents item by ID of minecraft:gold_ore.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GoldOre = new(Identifier.Minecraft("gold_ore"));

    /// <summary>Represents item by ID of minecraft:deepslate_gold_ore.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DeepslateGoldOre = new(Identifier.Minecraft("deepslate_gold_ore"));

    /// <summary>Represents item by ID of minecraft:iron_ore.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material IronOre = new(Identifier.Minecraft("iron_ore"));

    /// <summary>Represents item by ID of minecraft:deepslate_iron_ore.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DeepslateIronOre = new(Identifier.Minecraft("deepslate_iron_ore"));

    /// <summary>Represents item by ID of minecraft:coal_ore.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CoalOre = new(Identifier.Minecraft("coal_ore"));

    /// <summary>Represents item by ID of minecraft:deepslate_coal_ore.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DeepslateCoalOre = new(Identifier.Minecraft("deepslate_coal_ore"));


    /// <summary>Represents item by ID of minecraft:nether_gold_ore.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material NetherGoldOre = new(Identifier.Minecraft("nether_gold_ore"));


    /// <summary>Represents item by ID of minecraft:oak_log.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material OakLog = new(Identifier.Minecraft("oak_log"));


    /// <summary>Represents item by ID of minecraft:spruce_log.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SpruceLog = new(Identifier.Minecraft("spruce_log"));


    /// <summary>Represents item by ID of minecraft:birch_log.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BirchLog = new(Identifier.Minecraft("birch_log"));


    /// <summary>Represents item by ID of minecraft:jungle_log.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material JungleLog = new(Identifier.Minecraft("jungle_log"));


    /// <summary>Represents item by ID of minecraft:acacia_log.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material AcaciaLog = new(Identifier.Minecraft("acacia_log"));


    /// <summary>Represents item by ID of minecraft:dark_oak_log.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DarkOakLog = new(Identifier.Minecraft("dark_oak_log"));


    /// <summary>Represents item by ID of minecraft:stripped_spruce_log.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material StrippedSpruceLog = new(Identifier.Minecraft("stripped_spruce_log"));


    /// <summary>Represents item by ID of minecraft:stripped_birch_log.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material StrippedBirchLog = new(Identifier.Minecraft("stripped_birch_log"));


    /// <summary>Represents item by ID of minecraft:stripped_jungle_log.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material StrippedJungleLog = new(Identifier.Minecraft("stripped_jungle_log"));


    /// <summary>Represents item by ID of minecraft:stripped_acacia_log.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material StrippedAcaciaLog = new(Identifier.Minecraft("stripped_acacia_log"));


    /// <summary>Represents item by ID of minecraft:stripped_dark_oak_log.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material StrippedDarkOakLog = new(Identifier.Minecraft("stripped_dark_oak_log"));


    /// <summary>Represents item by ID of minecraft:stripped_oak_log.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material StrippedOakLog = new(Identifier.Minecraft("stripped_oak_log"));


    /// <summary>Represents item by ID of minecraft:oak_wood.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material OakWood = new(Identifier.Minecraft("oak_wood"));


    /// <summary>Represents item by ID of minecraft:spruce_wood.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SpruceWood = new(Identifier.Minecraft("spruce_wood"));


    /// <summary>Represents item by ID of minecraft:birch_wood.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BirchWood = new(Identifier.Minecraft("birch_wood"));


    /// <summary>Represents item by ID of minecraft:jungle_wood.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material JungleWood = new(Identifier.Minecraft("jungle_wood"));


    /// <summary>Represents item by ID of minecraft:acacia_wood.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material AcaciaWood = new(Identifier.Minecraft("acacia_wood"));


    /// <summary>Represents item by ID of minecraft:dark_oak_wood.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DarkOakWood = new(Identifier.Minecraft("dark_oak_wood"));


    /// <summary>Represents item by ID of minecraft:stripped_oak_wood.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material StrippedOakWood = new(Identifier.Minecraft("stripped_oak_wood"));


    /// <summary>Represents item by ID of minecraft:stripped_spruce_wood.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material StrippedSpruceWood = new(Identifier.Minecraft("stripped_spruce_wood"));


    /// <summary>Represents item by ID of minecraft:stripped_birch_wood.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material StrippedBirchWood = new(Identifier.Minecraft("stripped_birch_wood"));


    /// <summary>Represents item by ID of minecraft:stripped_jungle_wood.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material StrippedJungleWood = new(Identifier.Minecraft("stripped_jungle_wood"));


    /// <summary>Represents item by ID of minecraft:stripped_acacia_wood.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material StrippedAcaciaWood = new(Identifier.Minecraft("stripped_acacia_wood"));


    /// <summary>Represents item by ID of minecraft:stripped_dark_oak_wood.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material StrippedDarkOakWood = new(Identifier.Minecraft("stripped_dark_oak_wood"));


    /// <summary>Represents item by ID of minecraft:oak_leaves.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material OakLeaves = new(Identifier.Minecraft("oak_leaves"), typeof(Leaves));


    /// <summary>Represents item by ID of minecraft:spruce_leaves.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SpruceLeaves = new(Identifier.Minecraft("spruce_leaves"), typeof(Leaves));


    /// <summary>Represents item by ID of minecraft:birch_leaves.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BirchLeaves = new(Identifier.Minecraft("birch_leaves"), typeof(Leaves));


    /// <summary>Represents item by ID of minecraft:jungle_leaves.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material JungleLeaves = new(Identifier.Minecraft("jungle_leaves"), typeof(Leaves));


    /// <summary>Represents item by ID of minecraft:acacia_leaves.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material AcaciaLeaves = new(Identifier.Minecraft("acacia_leaves"), typeof(Leaves));


    /// <summary>Represents item by ID of minecraft:dark_oak_leaves.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DarkOakLeaves = new(Identifier.Minecraft("dark_oak_leaves"), typeof(Leaves));


    /// <summary>Represents item by ID of minecraft:azalea_leaves.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material AzaleaLeaves = new(Identifier.Minecraft("azalea_leaves"), typeof(Leaves));


    /// <summary>Represents item by ID of minecraft:flowering_azalea_leaves.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material FloweringAzaleaLeaves =
        new(Identifier.Minecraft("flowering_azalea_leaves"), typeof(Leaves));


    /// <summary>Represents item by ID of minecraft:sponge.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Sponge = new(Identifier.Minecraft("sponge"));


    /// <summary>Represents item by ID of minecraft:wet_sponge.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WetSponge = new(Identifier.Minecraft("wet_sponge"));


    /// <summary>Represents item by ID of minecraft:glass.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Glass = new(Identifier.Minecraft("glass"));


    /// <summary>Represents item by ID of minecraft:lapis_ore.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LapisOre = new(Identifier.Minecraft("lapis_ore"));


    /// <summary>Represents item by ID of minecraft:deepslate_lapis_ore.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DeepslateLapisOre = new(Identifier.Minecraft("deepslate_lapis_ore"));


    /// <summary>Represents item by ID of minecraft:lapis_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LapisBlock = new(Identifier.Minecraft("lapis_block"));


    /// <summary>Represents item by ID of minecraft:dispenser.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Dispenser = new(Identifier.Minecraft("dispenser"), typeof(Dispenser));


    /// <summary>Represents item by ID of minecraft:sandstone.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Sandstone = new(Identifier.Minecraft("sandstone"));


    /// <summary>Represents item by ID of minecraft:chiseled_sandstone.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material ChiseledSandstone = new(Identifier.Minecraft("chiseled_sandstone"));


    /// <summary>Represents item by ID of minecraft:cut_sandstone.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CutSandstone = new(Identifier.Minecraft("cut_sandstone"));


    /// <summary>Represents item by ID of minecraft:note_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material NoteBlock = new(Identifier.Minecraft("note_block"), typeof(NoteBlock));


    /// <summary>Represents item by ID of minecraft:white_bed.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WhiteBed = new(Identifier.Minecraft("white_bed"), typeof(Bed));


    /// <summary>Represents item by ID of minecraft:orange_bed.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material OrangeBed = new(Identifier.Minecraft("orange_bed"), typeof(Bed));


    /// <summary>Represents item by ID of minecraft:magenta_bed.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MagentaBed = new(Identifier.Minecraft("magenta_bed"), typeof(Bed));


    /// <summary>Represents item by ID of minecraft:light_blue_bed.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LightBlueBed = new(Identifier.Minecraft("light_blue_bed"), typeof(Bed));


    /// <summary>Represents item by ID of minecraft:yellow_bed.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material YellowBed = new(Identifier.Minecraft("yellow_bed"), typeof(Bed));


    /// <summary>Represents item by ID of minecraft:lime_bed.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LimeBed = new(Identifier.Minecraft("lime_bed"), typeof(Bed));


    /// <summary>Represents item by ID of minecraft:pink_bed.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PinkBed = new(Identifier.Minecraft("pink_bed"), typeof(Bed));


    /// <summary>Represents item by ID of minecraft:gray_bed.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GrayBed = new(Identifier.Minecraft("gray_bed"), typeof(Bed));


    /// <summary>Represents item by ID of minecraft:light_gray_bed.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LightGrayBed = new(Identifier.Minecraft("light_gray_bed"), typeof(Bed));


    /// <summary>Represents item by ID of minecraft:cyan_bed.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CyanBed = new(Identifier.Minecraft("cyan_bed"), typeof(Bed));


    /// <summary>Represents item by ID of minecraft:purple_bed.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PurpleBed = new(Identifier.Minecraft("purple_bed"), typeof(Bed));


    /// <summary>Represents item by ID of minecraft:blue_bed.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BlueBed = new(Identifier.Minecraft("blue_bed"), typeof(Bed));


    /// <summary>Represents item by ID of minecraft:brown_bed.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BrownBed = new(Identifier.Minecraft("brown_bed"), typeof(Bed));


    /// <summary>Represents item by ID of minecraft:green_bed.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GreenBed = new(Identifier.Minecraft("green_bed"), typeof(Bed));


    /// <summary>Represents item by ID of minecraft:red_bed.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RedBed = new(Identifier.Minecraft("red_bed"), typeof(Bed));


    /// <summary>Represents item by ID of minecraft:black_bed.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BlackBed = new(Identifier.Minecraft("black_bed"), typeof(Bed));


    /// <summary>Represents item by ID of minecraft:powered_rail.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PoweredRail = new(Identifier.Minecraft("powered_rail"), typeof(RedstoneRail));


    /// <summary>Represents item by ID of minecraft:detector_rail.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DetectorRail = new(Identifier.Minecraft("detector_rail"), typeof(RedstoneRail));


    /// <summary>Represents item by ID of minecraft:sticky_piston.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material StickyPiston = new(Identifier.Minecraft("sticky_piston"), typeof(Piston));


    /// <summary>Represents item by ID of minecraft:cobweb.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Cobweb = new(Identifier.Minecraft("cobweb"));


    /// <summary>Represents item by ID of minecraft:grass.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Grass = new(Identifier.Minecraft("grass"));


    /// <summary>Represents item by ID of minecraft:fern.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Fern = new(Identifier.Minecraft("fern"));


    /// <summary>Represents item by ID of minecraft:dead_bush.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DeadBush = new(Identifier.Minecraft("dead_bush"));


    /// <summary>Represents item by ID of minecraft:seagrass.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Seagrass = new(Identifier.Minecraft("seagrass"));


    /// <summary>Represents item by ID of minecraft:tall_seagrass.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material TallSeagrass = new(Identifier.Minecraft("tall_seagrass"));


    /// <summary>Represents item by ID of minecraft:piston.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Piston = new(Identifier.Minecraft("piston"), typeof(Piston));


    /// <summary>Represents item by ID of minecraft:piston_head.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PistonHead = new(Identifier.Minecraft("piston_head"));


    /// <summary>Represents item by ID of minecraft:white_wool.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WhiteWool = new(Identifier.Minecraft("white_wool"));


    /// <summary>Represents item by ID of minecraft:orange_wool.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material OrangeWool = new(Identifier.Minecraft("orange_wool"));


    /// <summary>Represents item by ID of minecraft:magenta_wool.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MagentaWool = new(Identifier.Minecraft("magenta_wool"));


    /// <summary>Represents item by ID of minecraft:light_blue_wool.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LightBlueWool = new(Identifier.Minecraft("light_blue_wool"));


    /// <summary>Represents item by ID of minecraft:yellow_wool.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material YellowWool = new(Identifier.Minecraft("yellow_wool"));


    /// <summary>Represents item by ID of minecraft:lime_wool.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LimeWool = new(Identifier.Minecraft("lime_wool"));


    /// <summary>Represents item by ID of minecraft:pink_wool.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PinkWool = new(Identifier.Minecraft("pink_wool"));


    /// <summary>Represents item by ID of minecraft:gray_wool.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GrayWool = new(Identifier.Minecraft("gray_wool"));


    /// <summary>Represents item by ID of minecraft:light_gray_wool.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LightGrayWool = new(Identifier.Minecraft("light_gray_wool"));


    /// <summary>Represents item by ID of minecraft:cyan_wool.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CyanWool = new(Identifier.Minecraft("cyan_wool"));


    /// <summary>Represents item by ID of minecraft:purple_wool.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PurpleWool = new(Identifier.Minecraft("purple_wool"));


    /// <summary>Represents item by ID of minecraft:blue_wool.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BlueWool = new(Identifier.Minecraft("blue_wool"));


    /// <summary>Represents item by ID of minecraft:brown_wool.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BrownWool = new(Identifier.Minecraft("brown_wool"));


    /// <summary>Represents item by ID of minecraft:green_wool.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GreenWool = new(Identifier.Minecraft("green_wool"));


    /// <summary>Represents item by ID of minecraft:red_wool.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RedWool = new(Identifier.Minecraft("red_wool"));


    /// <summary>Represents item by ID of minecraft:black_wool.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BlackWool = new(Identifier.Minecraft("black_wool"));


    /// <summary>Represents item by ID of minecraft:moving_piston.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MovingPiston = new(Identifier.Minecraft("moving_piston"));


    /// <summary>Represents item by ID of minecraft:dandelion.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Dandelion = new(Identifier.Minecraft("dandelion"));


    /// <summary>Represents item by ID of minecraft:poppy.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Poppy = new(Identifier.Minecraft("poppy"));


    /// <summary>Represents item by ID of minecraft:blue_orchid.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BlueOrchid = new(Identifier.Minecraft("blue_orchid"));


    /// <summary>Represents item by ID of minecraft:allium.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Allium = new(Identifier.Minecraft("allium"));


    /// <summary>Represents item by ID of minecraft:azure_bluet.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material AzureBluet = new(Identifier.Minecraft("azure_bluet"));


    /// <summary>Represents item by ID of minecraft:red_tulip.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RedTulip = new(Identifier.Minecraft("red_tulip"));


    /// <summary>Represents item by ID of minecraft:orange_tulip.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material OrangeTulip = new(Identifier.Minecraft("orange_tulip"));


    /// <summary>Represents item by ID of minecraft:white_tulip.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WhiteTulip = new(Identifier.Minecraft("white_tulip"));


    /// <summary>Represents item by ID of minecraft:pink_tulip.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PinkTulip = new(Identifier.Minecraft("pink_tulip"));


    /// <summary>Represents item by ID of minecraft:oxeye_daisy.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material OxeyeDaisy = new(Identifier.Minecraft("oxeye_daisy"));


    /// <summary>Represents item by ID of minecraft:cornflower.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Cornflower = new(Identifier.Minecraft("cornflower"));


    /// <summary>Represents item by ID of minecraft:wither_rose.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WitherRose = new(Identifier.Minecraft("wither_rose"));


    /// <summary>Represents item by ID of minecraft:lily_of_the_valley.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LilyOfTheValley = new(Identifier.Minecraft("lily_of_the_valley"));


    /// <summary>Represents item by ID of minecraft:brown_mushroom.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BrownMushroom = new(Identifier.Minecraft("brown_mushroom"));


    /// <summary>Represents item by ID of minecraft:red_mushroom.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RedMushroom = new(Identifier.Minecraft("red_mushroom"));


    /// <summary>Represents item by ID of minecraft:gold_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GoldBlock = new(Identifier.Minecraft("gold_block"));


    /// <summary>Represents item by ID of minecraft:iron_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material IronBlock = new(Identifier.Minecraft("iron_block"));


    /// <summary>Represents item by ID of minecraft:bricks.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Bricks = new(Identifier.Minecraft("bricks"));


    /// <summary>Represents item by ID of minecraft:tnt.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Tnt = new(Identifier.Minecraft("tnt"), typeof(Tnt));


    /// <summary>Represents item by ID of minecraft:bookshelf.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Bookshelf = new(Identifier.Minecraft("bookshelf"));


    /// <summary>Represents item by ID of minecraft:mossy_cobblestone.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MossyCobblestone = new(Identifier.Minecraft("mossy_cobblestone"));


    /// <summary>Represents item by ID of minecraft:obsidian.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Obsidian = new(Identifier.Minecraft("obsidian"));


    /// <summary>Represents item by ID of minecraft:torch.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Torch = new(Identifier.Minecraft("torch"));


    /// <summary>Represents item by ID of minecraft:wall_torch.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WallTorch = new(Identifier.Minecraft("wall_torch"), typeof(RedstoneWallTorch));


    /// <summary>Represents item by ID of minecraft:fire.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Fire = new(Identifier.Minecraft("fire"), typeof(Fire));


    /// <summary>Represents item by ID of minecraft:soul_fire.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SoulFire = new(Identifier.Minecraft("soul_fire"), typeof(Fire));


    /// <summary>Represents item by ID of minecraft:spawner.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Spawner = new(Identifier.Minecraft("spawner"), typeof(MobSpawner));


    /// <summary>Represents item by ID of minecraft:oak_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material OakStairs = new(Identifier.Minecraft("oak_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:chest.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Chest = new(Identifier.Minecraft("chest"), typeof(Chest));


    /// <summary>Represents item by ID of minecraft:redstone_wire.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RedstoneWire = new(Identifier.Minecraft("redstone_wire"), typeof(RedstoneDust));


    /// <summary>Represents item by ID of minecraft:diamond_ore.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DiamondOre = new(Identifier.Minecraft("diamond_ore"));


    /// <summary>Represents item by ID of minecraft:deepslate_diamond_ore.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DeepslateDiamondOre = new(Identifier.Minecraft("deepslate_diamond_ore"));


    /// <summary>Represents item by ID of minecraft:diamond_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DiamondBlock = new(Identifier.Minecraft("diamond_block"));


    /// <summary>Represents item by ID of minecraft:crafting_table.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CraftingTable = new(Identifier.Minecraft("crafting_table"));


    /// <summary>Represents item by ID of minecraft:wheat.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Wheat = new(Identifier.Minecraft("wheat"));


    /// <summary>Represents item by ID of minecraft:farmland.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Farmland = new(Identifier.Minecraft("farmland"), typeof(Farmland));


    /// <summary>Represents item by ID of minecraft:furnace.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Furnace = new(Identifier.Minecraft("furnace"), typeof(Furnace));


    /// <summary>Represents item by ID of minecraft:oak_sign.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material OakSign = new(Identifier.Minecraft("oak_sign"), typeof(Sign));


    /// <summary>Represents item by ID of minecraft:spruce_sign.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SpruceSign = new(Identifier.Minecraft("spruce_sign"), typeof(Sign));


    /// <summary>Represents item by ID of minecraft:birch_sign.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BirchSign = new(Identifier.Minecraft("birch_sign"), typeof(Sign));


    /// <summary>Represents item by ID of minecraft:acacia_sign.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material AcaciaSign = new(Identifier.Minecraft("acacia_sign"), typeof(Sign));


    /// <summary>Represents item by ID of minecraft:jungle_sign.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material JungleSign = new(Identifier.Minecraft("jungle_sign"), typeof(Sign));


    /// <summary>Represents item by ID of minecraft:dark_oak_sign.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DarkOakSign = new(Identifier.Minecraft("dark_oak_sign"), typeof(Sign));


    /// <summary>Represents item by ID of minecraft:oak_door.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material OakDoor = new(Identifier.Minecraft("oak_door"), typeof(Door));


    /// <summary>Represents item by ID of minecraft:ladder.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Ladder = new(Identifier.Minecraft("ladder"), typeof(Ladder));


    /// <summary>Represents item by ID of minecraft:rail.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Rail = new(Identifier.Minecraft("rail"), typeof(Rail));


    /// <summary>Represents item by ID of minecraft:cobblestone_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CobblestoneStairs = new(Identifier.Minecraft("cobblestone_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:oak_wall_sign.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material OakWallSign = new(Identifier.Minecraft("oak_wall_sign"), typeof(WallSign));


    /// <summary>Represents item by ID of minecraft:spruce_wall_sign.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SpruceWallSign = new(Identifier.Minecraft("spruce_wall_sign"), typeof(WallSign));


    /// <summary>Represents item by ID of minecraft:birch_wall_sign.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BirchWallSign = new(Identifier.Minecraft("birch_wall_sign"), typeof(WallSign));


    /// <summary>Represents item by ID of minecraft:acacia_wall_sign.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material AcaciaWallSign = new(Identifier.Minecraft("acacia_wall_sign"), typeof(WallSign));


    /// <summary>Represents item by ID of minecraft:jungle_wall_sign.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material JungleWallSign = new(Identifier.Minecraft("jungle_wall_sign"), typeof(WallSign));


    /// <summary>Represents item by ID of minecraft:dark_oak_wall_sign.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DarkOakWallSign = new(Identifier.Minecraft("dark_oak_wall_sign"), typeof(WallSign));


    /// <summary>Represents item by ID of minecraft:lever.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Lever = new(Identifier.Minecraft("lever"), typeof(Lever));


    /// <summary>Represents item by ID of minecraft:stone_pressure_plate.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material StonePressurePlate = new(Identifier.Minecraft("stone_pressure_plate"));


    /// <summary>Represents item by ID of minecraft:iron_door.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material IronDoor = new(Identifier.Minecraft("iron_door"), typeof(Door));


    /// <summary>Represents item by ID of minecraft:oak_pressure_plate.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material OakPressurePlate = new(Identifier.Minecraft("oak_pressure_plate"));


    /// <summary>Represents item by ID of minecraft:spruce_pressure_plate.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SprucePressurePlate = new(Identifier.Minecraft("spruce_pressure_plate"));


    /// <summary>Represents item by ID of minecraft:birch_pressure_plate.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BirchPressurePlate = new(Identifier.Minecraft("birch_pressure_plate"));


    /// <summary>Represents item by ID of minecraft:jungle_pressure_plate.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material JunglePressurePlate = new(Identifier.Minecraft("jungle_pressure_plate"));


    /// <summary>Represents item by ID of minecraft:acacia_pressure_plate.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material AcaciaPressurePlate = new(Identifier.Minecraft("acacia_pressure_plate"));


    /// <summary>Represents item by ID of minecraft:dark_oak_pressure_plate.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DarkOakPressurePlate = new(Identifier.Minecraft("dark_oak_pressure_plate"));


    /// <summary>Represents item by ID of minecraft:redstone_ore.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RedstoneOre = new(Identifier.Minecraft("redstone_ore"));


    /// <summary>Represents item by ID of minecraft:deepslate_redstone_ore.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DeepslateRedstoneOre = new(Identifier.Minecraft("deepslate_redstone_ore"));


    /// <summary>Represents item by ID of minecraft:redstone_torch.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RedstoneTorch = new(Identifier.Minecraft("redstone_torch"));


    /// <summary>Represents item by ID of minecraft:redstone_wall_torch.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RedstoneWallTorch =
        new(Identifier.Minecraft("redstone_wall_torch"), typeof(RedstoneWallTorch));


    /// <summary>Represents item by ID of minecraft:stone_button.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material StoneButton = new(Identifier.Minecraft("stone_button"));


    /// <summary>Represents item by ID of minecraft:snow.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Snow = new(Identifier.Minecraft("snow"), typeof(Snow));


    /// <summary>Represents item by ID of minecraft:ice.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Ice = new(Identifier.Minecraft("ice"));


    /// <summary>Represents item by ID of minecraft:snow_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SnowBlock = new(Identifier.Minecraft("snow_block"));


    /// <summary>Represents item by ID of minecraft:cactus.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Cactus = new(Identifier.Minecraft("cactus"));


    /// <summary>Represents item by ID of minecraft:clay.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Clay = new(Identifier.Minecraft("clay"));


    /// <summary>Represents item by ID of minecraft:sugar_cane.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SugarCane = new(Identifier.Minecraft("sugar_cane"));


    /// <summary>Represents item by ID of minecraft:jukebox.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Jukebox = new(Identifier.Minecraft("jukebox"), typeof(Jukebox));


    /// <summary>Represents item by ID of minecraft:oak_fence.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material OakFence = new(Identifier.Minecraft("oak_fence"), typeof(Fence));


    /// <summary>Represents item by ID of minecraft:pumpkin.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Pumpkin = new(Identifier.Minecraft("pumpkin"));


    /// <summary>Represents item by ID of minecraft:netherrack.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Netherrack = new(Identifier.Minecraft("netherrack"));


    /// <summary>Represents item by ID of minecraft:soul_sand.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SoulSand = new(Identifier.Minecraft("soul_sand"));


    /// <summary>Represents item by ID of minecraft:soul_soil.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SoulSoil = new(Identifier.Minecraft("soul_soil"));


    /// <summary>Represents item by ID of minecraft:basalt.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Basalt = new(Identifier.Minecraft("basalt"));


    /// <summary>Represents item by ID of minecraft:polished_basalt.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PolishedBasalt = new(Identifier.Minecraft("polished_basalt"));


    /// <summary>Represents item by ID of minecraft:soul_torch.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SoulTorch = new(Identifier.Minecraft("soul_torch"));


    /// <summary>Represents item by ID of minecraft:soul_wall_torch.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SoulWallTorch =
        new(Identifier.Minecraft("soul_wall_torch"), typeof(RedstoneWallTorch));


    /// <summary>Represents item by ID of minecraft:glowstone.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Glowstone = new(Identifier.Minecraft("glowstone"));


    /// <summary>Represents item by ID of minecraft:nether_portal.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material NetherPortal = new(Identifier.Minecraft("nether_portal"));


    /// <summary>Represents item by ID of minecraft:carved_pumpkin.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CarvedPumpkin = new(Identifier.Minecraft("carved_pumpkin"));


    /// <summary>Represents item by ID of minecraft:jack_o_lantern.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material JackOLantern = new(Identifier.Minecraft("jack_o_lantern"));


    /// <summary>Represents item by ID of minecraft:cake.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Cake = new(Identifier.Minecraft("cake"));


    /// <summary>Represents item by ID of minecraft:repeater.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Repeater = new(Identifier.Minecraft("repeater"), typeof(Repeater));


    /// <summary>Represents item by ID of minecraft:white_stained_glass.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WhiteStainedGlass = new(Identifier.Minecraft("white_stained_glass"));


    /// <summary>Represents item by ID of minecraft:orange_stained_glass.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material OrangeStainedGlass = new(Identifier.Minecraft("orange_stained_glass"));


    /// <summary>Represents item by ID of minecraft:magenta_stained_glass.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MagentaStainedGlass = new(Identifier.Minecraft("magenta_stained_glass"));


    /// <summary>Represents item by ID of minecraft:light_blue_stained_glass.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LightBlueStainedGlass = new(Identifier.Minecraft("light_blue_stained_glass"));


    /// <summary>Represents item by ID of minecraft:yellow_stained_glass.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material YellowStainedGlass = new(Identifier.Minecraft("yellow_stained_glass"));


    /// <summary>Represents item by ID of minecraft:lime_stained_glass.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LimeStainedGlass = new(Identifier.Minecraft("lime_stained_glass"));


    /// <summary>Represents item by ID of minecraft:pink_stained_glass.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PinkStainedGlass = new(Identifier.Minecraft("pink_stained_glass"));


    /// <summary>Represents item by ID of minecraft:gray_stained_glass.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GrayStainedGlass = new(Identifier.Minecraft("gray_stained_glass"));


    /// <summary>Represents item by ID of minecraft:light_gray_stained_glass.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LightGrayStainedGlass = new(Identifier.Minecraft("light_gray_stained_glass"));


    /// <summary>Represents item by ID of minecraft:cyan_stained_glass.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CyanStainedGlass = new(Identifier.Minecraft("cyan_stained_glass"));


    /// <summary>Represents item by ID of minecraft:purple_stained_glass.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PurpleStainedGlass = new(Identifier.Minecraft("purple_stained_glass"));


    /// <summary>Represents item by ID of minecraft:blue_stained_glass.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BlueStainedGlass = new(Identifier.Minecraft("blue_stained_glass"));


    /// <summary>Represents item by ID of minecraft:brown_stained_glass.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BrownStainedGlass = new(Identifier.Minecraft("brown_stained_glass"));


    /// <summary>Represents item by ID of minecraft:green_stained_glass.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GreenStainedGlass = new(Identifier.Minecraft("green_stained_glass"));


    /// <summary>Represents item by ID of minecraft:red_stained_glass.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RedStainedGlass = new(Identifier.Minecraft("red_stained_glass"));


    /// <summary>Represents item by ID of minecraft:black_stained_glass.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BlackStainedGlass = new(Identifier.Minecraft("black_stained_glass"));


    /// <summary>Represents item by ID of minecraft:oak_trapdoor.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material OakTrapdoor = new(Identifier.Minecraft("oak_trapdoor"), typeof(TrapDoor));


    /// <summary>Represents item by ID of minecraft:spruce_trapdoor.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SpruceTrapdoor = new(Identifier.Minecraft("spruce_trapdoor"), typeof(TrapDoor));


    /// <summary>Represents item by ID of minecraft:birch_trapdoor.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BirchTrapdoor = new(Identifier.Minecraft("birch_trapdoor"), typeof(TrapDoor));


    /// <summary>Represents item by ID of minecraft:jungle_trapdoor.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material JungleTrapdoor = new(Identifier.Minecraft("jungle_trapdoor"), typeof(TrapDoor));


    /// <summary>Represents item by ID of minecraft:acacia_trapdoor.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material AcaciaTrapdoor = new(Identifier.Minecraft("acacia_trapdoor"), typeof(TrapDoor));


    /// <summary>Represents item by ID of minecraft:dark_oak_trapdoor.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DarkOakTrapdoor = new(Identifier.Minecraft("dark_oak_trapdoor"), typeof(TrapDoor));


    /// <summary>Represents item by ID of minecraft:stone_bricks.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material StoneBricks = new(Identifier.Minecraft("stone_bricks"));


    /// <summary>Represents item by ID of minecraft:mossy_stone_bricks.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MossyStoneBricks = new(Identifier.Minecraft("mossy_stone_bricks"));


    /// <summary>Represents item by ID of minecraft:cracked_stone_bricks.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CrackedStoneBricks = new(Identifier.Minecraft("cracked_stone_bricks"));


    /// <summary>Represents item by ID of minecraft:chiseled_stone_bricks.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material ChiseledStoneBricks = new(Identifier.Minecraft("chiseled_stone_bricks"));


    /// <summary>Represents item by ID of minecraft:infested_stone.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material InfestedStone = new(Identifier.Minecraft("infested_stone"));


    /// <summary>Represents item by ID of minecraft:infested_cobblestone.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material InfestedCobblestone = new(Identifier.Minecraft("infested_cobblestone"));


    /// <summary>Represents item by ID of minecraft:infested_stone_bricks.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material InfestedStoneBricks = new(Identifier.Minecraft("infested_stone_bricks"));


    /// <summary>Represents item by ID of minecraft:infested_mossy_stone_bricks.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material InfestedMossyStoneBricks = new(Identifier.Minecraft("infested_mossy_stone_bricks"));


    /// <summary>Represents item by ID of minecraft:infested_cracked_stone_bricks.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material InfestedCrackedStoneBricks =
        new(Identifier.Minecraft("infested_cracked_stone_bricks"));


    /// <summary>Represents item by ID of minecraft:infested_chiseled_stone_bricks.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material InfestedChiseledStoneBricks =
        new(Identifier.Minecraft("infested_chiseled_stone_bricks"));


    /// <summary>Represents item by ID of minecraft:brown_mushroom_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BrownMushroomBlock = new(Identifier.Minecraft("brown_mushroom_block"));


    /// <summary>Represents item by ID of minecraft:red_mushroom_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RedMushroomBlock = new(Identifier.Minecraft("red_mushroom_block"));


    /// <summary>Represents item by ID of minecraft:mushroom_stem.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MushroomStem = new(Identifier.Minecraft("mushroom_stem"));


    /// <summary>Represents item by ID of minecraft:iron_bars.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material IronBars = new(Identifier.Minecraft("iron_bars"));


    /// <summary>Represents item by ID of minecraft:chain.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Chain = new(Identifier.Minecraft("chain"));


    /// <summary>Represents item by ID of minecraft:glass_pane.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GlassPane = new(Identifier.Minecraft("glass_pane"), typeof(GlassPane));


    /// <summary>Represents item by ID of minecraft:melon.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Melon = new(Identifier.Minecraft("melon"));


    /// <summary>Represents item by ID of minecraft:attached_pumpkin_stem.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material AttachedPumpkinStem = new(Identifier.Minecraft("attached_pumpkin_stem"));


    /// <summary>Represents item by ID of minecraft:attached_melon_stem.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material AttachedMelonStem = new(Identifier.Minecraft("attached_melon_stem"));


    /// <summary>Represents item by ID of minecraft:pumpkin_stem.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PumpkinStem = new(Identifier.Minecraft("pumpkin_stem"));


    /// <summary>Represents item by ID of minecraft:melon_stem.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MelonStem = new(Identifier.Minecraft("melon_stem"));


    /// <summary>Represents item by ID of minecraft:vine.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Vine = new(Identifier.Minecraft("vine"));


    /// <summary>Represents item by ID of minecraft:glow_lichen.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GlowLichen = new(Identifier.Minecraft("glow_lichen"), typeof(GlowLichen));


    /// <summary>Represents item by ID of minecraft:oak_fence_gate.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material OakFenceGate = new(Identifier.Minecraft("oak_fence_gate"), typeof(Gate));


    /// <summary>Represents item by ID of minecraft:brick_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BrickStairs = new(Identifier.Minecraft("brick_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:stone_brick_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material StoneBrickStairs = new(Identifier.Minecraft("stone_brick_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:mycelium.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Mycelium = new(Identifier.Minecraft("mycelium"));


    /// <summary>Represents item by ID of minecraft:lily_pad.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LilyPad = new(Identifier.Minecraft("lily_pad"));


    /// <summary>Represents item by ID of minecraft:nether_bricks.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material NetherBricks = new(Identifier.Minecraft("nether_bricks"));


    /// <summary>Represents item by ID of minecraft:nether_brick_fence.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material NetherBrickFence = new(Identifier.Minecraft("nether_brick_fence"), typeof(Fence));


    /// <summary>Represents item by ID of minecraft:nether_brick_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material
        NetherBrickStairs = new(Identifier.Minecraft("nether_brick_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:nether_wart.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material NetherWart = new(Identifier.Minecraft("nether_wart"));


    /// <summary>Represents item by ID of minecraft:enchanting_table.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material EnchantingTable = new(Identifier.Minecraft("enchanting_table"));


    /// <summary>Represents item by ID of minecraft:brewing_stand.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BrewingStand = new(Identifier.Minecraft("brewing_stand"), typeof(BrewingStand));


    /// <summary>Represents item by ID of minecraft:cauldron.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Cauldron = new(Identifier.Minecraft("cauldron"));


    /// <summary>Represents item by ID of minecraft:water_cauldron.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WaterCauldron = new(Identifier.Minecraft("water_cauldron"));


    /// <summary>Represents item by ID of minecraft:lava_cauldron.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LavaCauldron = new(Identifier.Minecraft("lava_cauldron"));


    /// <summary>Represents item by ID of minecraft:powder_snow_cauldron.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PowderSnowCauldron = new(Identifier.Minecraft("powder_snow_cauldron"));


    /// <summary>Represents item by ID of minecraft:end_portal.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material EndPortal = new(Identifier.Minecraft("end_portal"));


    /// <summary>Represents item by ID of minecraft:end_portal_frame.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material EndPortalFrame =
        new(Identifier.Minecraft("end_portal_frame"), typeof(EndPortalFrame));


    /// <summary>Represents item by ID of minecraft:end_stone.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material EndStone = new(Identifier.Minecraft("end_stone"));


    /// <summary>Represents item by ID of minecraft:dragon_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DragonEgg = new(Identifier.Minecraft("dragon_egg"));


    /// <summary>Represents item by ID of minecraft:redstone_lamp.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RedstoneLamp = new(Identifier.Minecraft("redstone_lamp"));


    /// <summary>Represents item by ID of minecraft:cocoa.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Cocoa = new(Identifier.Minecraft("cocoa"));


    /// <summary>Represents item by ID of minecraft:sandstone_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SandstoneStairs = new(Identifier.Minecraft("sandstone_stairs"));


    /// <summary>Represents item by ID of minecraft:emerald_ore.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material EmeraldOre = new(Identifier.Minecraft("emerald_ore"));


    /// <summary>Represents item by ID of minecraft:deepslate_emerald_ore.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DeepslateEmeraldOre = new(Identifier.Minecraft("deepslate_emerald_ore"));


    /// <summary>Represents item by ID of minecraft:ender_chest.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material EnderChest = new(Identifier.Minecraft("ender_chest"), typeof(EnderChest));


    /// <summary>Represents item by ID of minecraft:tripwire_hook.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material TripwireHook = new(Identifier.Minecraft("tripwire_hook"), typeof(Tripwire));


    /// <summary>Represents item by ID of minecraft:tripwire.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Tripwire = new(Identifier.Minecraft("tripwire"), typeof(Tripwire));


    /// <summary>Represents item by ID of minecraft:emerald_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material EmeraldBlock = new(Identifier.Minecraft("emerald_block"));


    /// <summary>Represents item by ID of minecraft:spruce_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SpruceStairs = new(Identifier.Minecraft("spruce_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:birch_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BirchStairs = new(Identifier.Minecraft("birch_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:jungle_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material JungleStairs = new(Identifier.Minecraft("jungle_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:command_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CommandBlock = new(Identifier.Minecraft("command_block"), typeof(CommandBlock));


    /// <summary>Represents item by ID of minecraft:beacon.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Beacon = new(Identifier.Minecraft("beacon"));


    /// <summary>Represents item by ID of minecraft:cobblestone_wall.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CobblestoneWall = new(Identifier.Minecraft("cobblestone_wall"), typeof(Wall));

    /// <summary>Represents item by ID of minecraft:mossy_cobblestone_wall.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MossyCobblestoneWall =
        new(Identifier.Minecraft("mossy_cobblestone_wall"), typeof(Wall));


    /// <summary>Represents item by ID of minecraft:flower_pot.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material FlowerPot = new(Identifier.Minecraft("flower_pot"));


    /// <summary>Represents item by ID of minecraft:potted_oak_sapling.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PottedOakSapling = new(Identifier.Minecraft("potted_oak_sapling"));


    /// <summary>Represents item by ID of minecraft:potted_spruce_sapling.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PottedSpruceSapling = new(Identifier.Minecraft("potted_spruce_sapling"));


    /// <summary>Represents item by ID of minecraft:potted_birch_sapling.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PottedBirchSapling = new(Identifier.Minecraft("potted_birch_sapling"));


    /// <summary>Represents item by ID of minecraft:potted_jungle_sapling.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PottedJungleSapling = new(Identifier.Minecraft("potted_jungle_sapling"));


    /// <summary>Represents item by ID of minecraft:potted_acacia_sapling.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PottedAcaciaSapling = new(Identifier.Minecraft("potted_acacia_sapling"));


    /// <summary>Represents item by ID of minecraft:potted_dark_oak_sapling.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PottedDarkOakSapling = new(Identifier.Minecraft("potted_dark_oak_sapling"));


    /// <summary>Represents item by ID of minecraft:potted_fern.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PottedFern = new(Identifier.Minecraft("potted_fern"));


    /// <summary>Represents item by ID of minecraft:potted_dandelion.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PottedDandelion = new(Identifier.Minecraft("potted_dandelion"));


    /// <summary>Represents item by ID of minecraft:potted_poppy.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PottedPoppy = new(Identifier.Minecraft("potted_poppy"));


    /// <summary>Represents item by ID of minecraft:potted_blue_orchid.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PottedBlueOrchid = new(Identifier.Minecraft("potted_blue_orchid"));


    /// <summary>Represents item by ID of minecraft:potted_allium.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PottedAllium = new(Identifier.Minecraft("potted_allium"));


    /// <summary>Represents item by ID of minecraft:potted_azure_bluet.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PottedAzureBluet = new(Identifier.Minecraft("potted_azure_bluet"));


    /// <summary>Represents item by ID of minecraft:potted_red_tulip.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PottedRedTulip = new(Identifier.Minecraft("potted_red_tulip"));


    /// <summary>Represents item by ID of minecraft:potted_orange_tulip.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PottedOrangeTulip = new(Identifier.Minecraft("potted_orange_tulip"));


    /// <summary>Represents item by ID of minecraft:potted_white_tulip.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PottedWhiteTulip = new(Identifier.Minecraft("potted_white_tulip"));


    /// <summary>Represents item by ID of minecraft:potted_pink_tulip.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PottedPinkTulip = new(Identifier.Minecraft("potted_pink_tulip"));


    /// <summary>Represents item by ID of minecraft:potted_oxeye_daisy.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PottedOxeyeDaisy = new(Identifier.Minecraft("potted_oxeye_daisy"));


    /// <summary>Represents item by ID of minecraft:potted_cornflower.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PottedCornflower = new(Identifier.Minecraft("potted_cornflower"));


    /// <summary>Represents item by ID of minecraft:potted_lily_of_the_valley.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PottedLilyOfTheValley = new(Identifier.Minecraft("potted_lily_of_the_valley"));


    /// <summary>Represents item by ID of minecraft:potted_wither_rose.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PottedWitherRose = new(Identifier.Minecraft("potted_wither_rose"));


    /// <summary>Represents item by ID of minecraft:potted_red_mushroom.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PottedRedMushroom = new(Identifier.Minecraft("potted_red_mushroom"));


    /// <summary>Represents item by ID of minecraft:potted_brown_mushroom.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PottedBrownMushroom = new(Identifier.Minecraft("potted_brown_mushroom"));


    /// <summary>Represents item by ID of minecraft:potted_dead_bush.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PottedDeadBush = new(Identifier.Minecraft("potted_dead_bush"));


    /// <summary>Represents item by ID of minecraft:potted_cactus.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PottedCactus = new(Identifier.Minecraft("potted_cactus"));


    /// <summary>Represents item by ID of minecraft:carrots.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Carrots = new(Identifier.Minecraft("carrots"));


    /// <summary>Represents item by ID of minecraft:potatoes.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Potatoes = new(Identifier.Minecraft("potatoes"));


    /// <summary>Represents item by ID of minecraft:oak_button.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material OakButton = new(Identifier.Minecraft("oak_button"));


    /// <summary>Represents item by ID of minecraft:spruce_button.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SpruceButton = new(Identifier.Minecraft("spruce_button"));


    /// <summary>Represents item by ID of minecraft:birch_button.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BirchButton = new(Identifier.Minecraft("birch_button"));


    /// <summary>Represents item by ID of minecraft:jungle_button.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material JungleButton = new(Identifier.Minecraft("jungle_button"));


    /// <summary>Represents item by ID of minecraft:acacia_button.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material AcaciaButton = new(Identifier.Minecraft("acacia_button"));


    /// <summary>Represents item by ID of minecraft:dark_oak_button.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DarkOakButton = new(Identifier.Minecraft("dark_oak_button"));


    /// <summary>Represents item by ID of minecraft:skeleton_skull.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SkeletonSkull = new(Identifier.Minecraft("skeleton_skull"));


    /// <summary>Represents item by ID of minecraft:skeleton_wall_skull.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SkeletonWallSkull = new(Identifier.Minecraft("skeleton_wall_skull"));


    /// <summary>Represents item by ID of minecraft:wither_skeleton_skull.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WitherSkeletonSkull = new(Identifier.Minecraft("wither_skeleton_skull"));


    /// <summary>Represents item by ID of minecraft:wither_skeleton_wall_skull.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WitherSkeletonWallSkull = new(Identifier.Minecraft("wither_skeleton_wall_skull"));


    /// <summary>Represents item by ID of minecraft:zombie_head.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material ZombieHead = new(Identifier.Minecraft("zombie_head"));


    /// <summary>Represents item by ID of minecraft:zombie_wall_head.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material ZombieWallHead = new(Identifier.Minecraft("zombie_wall_head"));


    /// <summary>Represents item by ID of minecraft:player_head.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PlayerHead = new(Identifier.Minecraft("player_head"));


    /// <summary>Represents item by ID of minecraft:player_wall_head.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PlayerWallHead = new(Identifier.Minecraft("player_wall_head"));


    /// <summary>Represents item by ID of minecraft:creeper_head.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CreeperHead = new(Identifier.Minecraft("creeper_head"));


    /// <summary>Represents item by ID of minecraft:creeper_wall_head.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CreeperWallHead = new(Identifier.Minecraft("creeper_wall_head"));


    /// <summary>Represents item by ID of minecraft:dragon_head.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DragonHead = new(Identifier.Minecraft("dragon_head"));


    /// <summary>Represents item by ID of minecraft:dragon_wall_head.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DragonWallHead = new(Identifier.Minecraft("dragon_wall_head"));


    /// <summary>Represents item by ID of minecraft:anvil.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Anvil = new(Identifier.Minecraft("anvil"));


    /// <summary>Represents item by ID of minecraft:chipped_anvil.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material ChippedAnvil = new(Identifier.Minecraft("chipped_anvil"));


    /// <summary>Represents item by ID of minecraft:damaged_anvil.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DamagedAnvil = new(Identifier.Minecraft("damaged_anvil"));


    /// <summary>Represents item by ID of minecraft:trapped_chest.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material TrappedChest = new(Identifier.Minecraft("trapped_chest"));


    /// <summary>Represents item by ID of minecraft:light_weighted_pressure_plate.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LightWeightedPressurePlate =
        new(Identifier.Minecraft("light_weighted_pressure_plate"));


    /// <summary>Represents item by ID of minecraft:heavy_weighted_pressure_plate.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material HeavyWeightedPressurePlate =
        new(Identifier.Minecraft("heavy_weighted_pressure_plate"));

    /// <summary>Represents item by ID of minecraft:comparator.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Comparator = new(Identifier.Minecraft("comparator"), typeof(Comparator));


    /// <summary>Represents item by ID of minecraft:daylight_detector.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DaylightDetector =
        new(Identifier.Minecraft("daylight_detector"), typeof(DaylightSensor));


    /// <summary>Represents item by ID of minecraft:redstone_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RedstoneBlock = new(Identifier.Minecraft("redstone_block"));


    /// <summary>Represents item by ID of minecraft:nether_quartz_ore.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material NetherQuartzOre = new(Identifier.Minecraft("nether_quartz_ore"));


    /// <summary>Represents item by ID of minecraft:hopper.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Hopper = new(Identifier.Minecraft("hopper"), typeof(Hopper));


    /// <summary>Represents item by ID of minecraft:quartz_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material QuartzBlock = new(Identifier.Minecraft("quartz_block"));


    /// <summary>Represents item by ID of minecraft:chiseled_quartz_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material ChiseledQuartzBlock = new(Identifier.Minecraft("chiseled_quartz_block"));


    /// <summary>Represents item by ID of minecraft:quartz_pillar.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material QuartzPillar = new(Identifier.Minecraft("quartz_pillar"));


    /// <summary>Represents item by ID of minecraft:quartz_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material QuartzStairs = new(Identifier.Minecraft("quartz_stairs"));


    /// <summary>Represents item by ID of minecraft:activator_rail.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material ActivatorRail = new(Identifier.Minecraft("activator_rail"), typeof(Rail));


    /// <summary>Represents item by ID of minecraft:dropper.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Dropper = new(Identifier.Minecraft("dropper"), typeof(Dispenser));


    /// <summary>Represents item by ID of minecraft:white_terracotta.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WhiteTerracotta = new(Identifier.Minecraft("white_terracotta"));


    /// <summary>Represents item by ID of minecraft:orange_terracotta.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material OrangeTerracotta = new(Identifier.Minecraft("orange_terracotta"));


    /// <summary>Represents item by ID of minecraft:magenta_terracotta.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MagentaTerracotta = new(Identifier.Minecraft("magenta_terracotta"));


    /// <summary>Represents item by ID of minecraft:light_blue_terracotta.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LightBlueTerracotta = new(Identifier.Minecraft("light_blue_terracotta"));


    /// <summary>Represents item by ID of minecraft:yellow_terracotta.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material YellowTerracotta = new(Identifier.Minecraft("yellow_terracotta"));


    /// <summary>Represents item by ID of minecraft:lime_terracotta.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LimeTerracotta = new(Identifier.Minecraft("lime_terracotta"));


    /// <summary>Represents item by ID of minecraft:pink_terracotta.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PinkTerracotta = new(Identifier.Minecraft("pink_terracotta"));


    /// <summary>Represents item by ID of minecraft:gray_terracotta.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GrayTerracotta = new(Identifier.Minecraft("gray_terracotta"));


    /// <summary>Represents item by ID of minecraft:light_gray_terracotta.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LightGrayTerracotta = new(Identifier.Minecraft("light_gray_terracotta"));


    /// <summary>Represents item by ID of minecraft:cyan_terracotta.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CyanTerracotta = new(Identifier.Minecraft("cyan_terracotta"));


    /// <summary>Represents item by ID of minecraft:purple_terracotta.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PurpleTerracotta = new(Identifier.Minecraft("purple_terracotta"));


    /// <summary>Represents item by ID of minecraft:blue_terracotta.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BlueTerracotta = new(Identifier.Minecraft("blue_terracotta"));


    /// <summary>Represents item by ID of minecraft:brown_terracotta.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BrownTerracotta = new(Identifier.Minecraft("brown_terracotta"));


    /// <summary>Represents item by ID of minecraft:green_terracotta.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GreenTerracotta = new(Identifier.Minecraft("green_terracotta"));


    /// <summary>Represents item by ID of minecraft:red_terracotta.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RedTerracotta = new(Identifier.Minecraft("red_terracotta"));


    /// <summary>Represents item by ID of minecraft:black_terracotta.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BlackTerracotta = new(Identifier.Minecraft("black_terracotta"));


    /// <summary>Represents item by ID of minecraft:white_stained_glass_pane.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WhiteStainedGlassPane =
        new(Identifier.Minecraft("white_stained_glass_pane"), typeof(GlassPane));


    /// <summary>Represents item by ID of minecraft:orange_stained_glass_pane.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material OrangeStainedGlassPane =
        new(Identifier.Minecraft("orange_stained_glass_pane"), typeof(GlassPane));


    /// <summary>Represents item by ID of minecraft:magenta_stained_glass_pane.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MagentaStainedGlassPane =
        new(Identifier.Minecraft("magenta_stained_glass_pane"), typeof(GlassPane));


    /// <summary>Represents item by ID of minecraft:light_blue_stained_glass_pane.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LightBlueStainedGlassPane =
        new(Identifier.Minecraft("light_blue_stained_glass_pane"), typeof(GlassPane));


    /// <summary>Represents item by ID of minecraft:yellow_stained_glass_pane.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material YellowStainedGlassPane =
        new(Identifier.Minecraft("yellow_stained_glass_pane"), typeof(GlassPane));


    /// <summary>Represents item by ID of minecraft:lime_stained_glass_pane.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LimeStainedGlassPane =
        new(Identifier.Minecraft("lime_stained_glass_pane"), typeof(GlassPane));


    /// <summary>Represents item by ID of minecraft:pink_stained_glass_pane.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PinkStainedGlassPane =
        new(Identifier.Minecraft("pink_stained_glass_pane"), typeof(GlassPane));


    /// <summary>Represents item by ID of minecraft:gray_stained_glass_pane.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GrayStainedGlassPane =
        new(Identifier.Minecraft("gray_stained_glass_pane"), typeof(GlassPane));


    /// <summary>Represents item by ID of minecraft:light_gray_stained_glass_pane.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LightGrayStainedGlassPane =
        new(Identifier.Minecraft("light_gray_stained_glass_pane"), typeof(GlassPane));


    /// <summary>Represents item by ID of minecraft:cyan_stained_glass_pane.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CyanStainedGlassPane =
        new(Identifier.Minecraft("cyan_stained_glass_pane"), typeof(GlassPane));


    /// <summary>Represents item by ID of minecraft:purple_stained_glass_pane.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PurpleStainedGlassPane =
        new(Identifier.Minecraft("purple_stained_glass_pane"), typeof(GlassPane));


    /// <summary>Represents item by ID of minecraft:blue_stained_glass_pane.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BlueStainedGlassPane =
        new(Identifier.Minecraft("blue_stained_glass_pane"), typeof(GlassPane));


    /// <summary>Represents item by ID of minecraft:brown_stained_glass_pane.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BrownStainedGlassPane =
        new(Identifier.Minecraft("brown_stained_glass_pane"), typeof(GlassPane));


    /// <summary>Represents item by ID of minecraft:green_stained_glass_pane.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GreenStainedGlassPane =
        new(Identifier.Minecraft("green_stained_glass_pane"), typeof(GlassPane));


    /// <summary>Represents item by ID of minecraft:red_stained_glass_pane.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RedStainedGlassPane =
        new(Identifier.Minecraft("red_stained_glass_pane"), typeof(GlassPane));


    /// <summary>Represents item by ID of minecraft:black_stained_glass_pane.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BlackStainedGlassPane =
        new(Identifier.Minecraft("black_stained_glass_pane"), typeof(GlassPane));


    /// <summary>Represents item by ID of minecraft:acacia_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material AcaciaStairs = new(Identifier.Minecraft("acacia_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:dark_oak_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DarkOakStairs = new(Identifier.Minecraft("dark_oak_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:slime_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SlimeBlock = new(Identifier.Minecraft("slime_block"));


    /// <summary>Represents item by ID of minecraft:barrier.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Barrier = new(Identifier.Minecraft("barrier"));


    /// <summary>Represents item by ID of minecraft:light.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Light = new(Identifier.Minecraft("light"), typeof(Light));


    /// <summary>Represents item by ID of minecraft:iron_trapdoor.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material IronTrapdoor = new(Identifier.Minecraft("iron_trapdoor"), typeof(TrapDoor));


    /// <summary>Represents item by ID of minecraft:prismarine.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Prismarine = new(Identifier.Minecraft("prismarine"));


    /// <summary>Represents item by ID of minecraft:prismarine_bricks.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PrismarineBricks = new(Identifier.Minecraft("prismarine_bricks"));


    /// <summary>Represents item by ID of minecraft:dark_prismarine.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DarkPrismarine = new(Identifier.Minecraft("dark_prismarine"));


    /// <summary>Represents item by ID of minecraft:prismarine_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PrismarineStairs = new(Identifier.Minecraft("prismarine_stairs"));


    /// <summary>Represents item by ID of minecraft:prismarine_brick_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PrismarineBrickStairs = new(Identifier.Minecraft("prismarine_brick_stairs"));


    /// <summary>Represents item by ID of minecraft:dark_prismarine_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DarkPrismarineStairs =
        new(Identifier.Minecraft("dark_prismarine_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:prismarine_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PrismarineSlab = new(Identifier.Minecraft("prismarine_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:prismarine_brick_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PrismarineBrickSlab =
        new(Identifier.Minecraft("prismarine_brick_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:dark_prismarine_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material
        DarkPrismarineSlab = new(Identifier.Minecraft("dark_prismarine_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:sea_lantern.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SeaLantern = new(Identifier.Minecraft("sea_lantern"));


    /// <summary>Represents item by ID of minecraft:hay_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material HayBlock = new(Identifier.Minecraft("hay_block"));


    /// <summary>Represents item by ID of minecraft:white_carpet.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WhiteCarpet = new(Identifier.Minecraft("white_carpet"));


    /// <summary>Represents item by ID of minecraft:orange_carpet.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material OrangeCarpet = new(Identifier.Minecraft("orange_carpet"));


    /// <summary>Represents item by ID of minecraft:magenta_carpet.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MagentaCarpet = new(Identifier.Minecraft("magenta_carpet"));


    /// <summary>Represents item by ID of minecraft:light_blue_carpet.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LightBlueCarpet = new(Identifier.Minecraft("light_blue_carpet"));


    /// <summary>Represents item by ID of minecraft:yellow_carpet.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material YellowCarpet = new(Identifier.Minecraft("yellow_carpet"));


    /// <summary>Represents item by ID of minecraft:lime_carpet.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LimeCarpet = new(Identifier.Minecraft("lime_carpet"));


    /// <summary>Represents item by ID of minecraft:pink_carpet.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PinkCarpet = new(Identifier.Minecraft("pink_carpet"));


    /// <summary>Represents item by ID of minecraft:gray_carpet.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GrayCarpet = new(Identifier.Minecraft("gray_carpet"));


    /// <summary>Represents item by ID of minecraft:light_gray_carpet.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LightGrayCarpet = new(Identifier.Minecraft("light_gray_carpet"));


    /// <summary>Represents item by ID of minecraft:cyan_carpet.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CyanCarpet = new(Identifier.Minecraft("cyan_carpet"));


    /// <summary>Represents item by ID of minecraft:purple_carpet.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PurpleCarpet = new(Identifier.Minecraft("purple_carpet"));


    /// <summary>Represents item by ID of minecraft:blue_carpet.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BlueCarpet = new(Identifier.Minecraft("blue_carpet"));


    /// <summary>Represents item by ID of minecraft:brown_carpet.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BrownCarpet = new(Identifier.Minecraft("brown_carpet"));


    /// <summary>Represents item by ID of minecraft:green_carpet.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GreenCarpet = new(Identifier.Minecraft("green_carpet"));


    /// <summary>Represents item by ID of minecraft:red_carpet.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RedCarpet = new(Identifier.Minecraft("red_carpet"));


    /// <summary>Represents item by ID of minecraft:black_carpet.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BlackCarpet = new(Identifier.Minecraft("black_carpet"));


    /// <summary>Represents item by ID of minecraft:terracotta.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Terracotta = new(Identifier.Minecraft("terracotta"));


    /// <summary>Represents item by ID of minecraft:coal_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CoalBlock = new(Identifier.Minecraft("coal_block"));


    /// <summary>Represents item by ID of minecraft:packed_ice.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PackedIce = new(Identifier.Minecraft("packed_ice"));


    /// <summary>Represents item by ID of minecraft:sunflower.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Sunflower = new(Identifier.Minecraft("sunflower"));


    /// <summary>Represents item by ID of minecraft:lilac.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Lilac = new(Identifier.Minecraft("lilac"));


    /// <summary>Represents item by ID of minecraft:rose_bush.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RoseBush = new(Identifier.Minecraft("rose_bush"));


    /// <summary>Represents item by ID of minecraft:peony.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Peony = new(Identifier.Minecraft("peony"));


    /// <summary>Represents item by ID of minecraft:tall_grass.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material TallGrass = new(Identifier.Minecraft("tall_grass"));


    /// <summary>Represents item by ID of minecraft:large_fern.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LargeFern = new(Identifier.Minecraft("large_fern"));


    /// <summary>Represents item by ID of minecraft:white_banner.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WhiteBanner = new(Identifier.Minecraft("white_banner"));


    /// <summary>Represents item by ID of minecraft:orange_banner.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material OrangeBanner = new(Identifier.Minecraft("orange_banner"));


    /// <summary>Represents item by ID of minecraft:magenta_banner.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MagentaBanner = new(Identifier.Minecraft("magenta_banner"));


    /// <summary>Represents item by ID of minecraft:light_blue_banner.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LightBlueBanner = new(Identifier.Minecraft("light_blue_banner"));


    /// <summary>Represents item by ID of minecraft:yellow_banner.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material YellowBanner = new(Identifier.Minecraft("yellow_banner"));


    /// <summary>Represents item by ID of minecraft:lime_banner.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LimeBanner = new(Identifier.Minecraft("lime_banner"));


    /// <summary>Represents item by ID of minecraft:pink_banner.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PinkBanner = new(Identifier.Minecraft("pink_banner"));


    /// <summary>Represents item by ID of minecraft:gray_banner.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GrayBanner = new(Identifier.Minecraft("gray_banner"));


    /// <summary>Represents item by ID of minecraft:light_gray_banner.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LightGrayBanner = new(Identifier.Minecraft("light_gray_banner"));


    /// <summary>Represents item by ID of minecraft:cyan_banner.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CyanBanner = new(Identifier.Minecraft("cyan_banner"));


    /// <summary>Represents item by ID of minecraft:purple_banner.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PurpleBanner = new(Identifier.Minecraft("purple_banner"));


    /// <summary>Represents item by ID of minecraft:blue_banner.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BlueBanner = new(Identifier.Minecraft("blue_banner"));


    /// <summary>Represents item by ID of minecraft:brown_banner.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BrownBanner = new(Identifier.Minecraft("brown_banner"));


    /// <summary>Represents item by ID of minecraft:green_banner.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GreenBanner = new(Identifier.Minecraft("green_banner"));


    /// <summary>Represents item by ID of minecraft:red_banner.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RedBanner = new(Identifier.Minecraft("red_banner"));


    /// <summary>Represents item by ID of minecraft:black_banner.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BlackBanner = new(Identifier.Minecraft("black_banner"));


    /// <summary>Represents item by ID of minecraft:white_wall_banner.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WhiteWallBanner = new(Identifier.Minecraft("white_wall_banner"));


    /// <summary>Represents item by ID of minecraft:orange_wall_banner.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material OrangeWallBanner = new(Identifier.Minecraft("orange_wall_banner"));


    /// <summary>Represents item by ID of minecraft:magenta_wall_banner.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MagentaWallBanner = new(Identifier.Minecraft("magenta_wall_banner"));


    /// <summary>Represents item by ID of minecraft:light_blue_wall_banner.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LightBlueWallBanner = new(Identifier.Minecraft("light_blue_wall_banner"));


    /// <summary>Represents item by ID of minecraft:yellow_wall_banner.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material YellowWallBanner = new(Identifier.Minecraft("yellow_wall_banner"));


    /// <summary>Represents item by ID of minecraft:lime_wall_banner.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LimeWallBanner = new(Identifier.Minecraft("lime_wall_banner"));


    /// <summary>Represents item by ID of minecraft:pink_wall_banner.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PinkWallBanner = new(Identifier.Minecraft("pink_wall_banner"));


    /// <summary>Represents item by ID of minecraft:gray_wall_banner.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GrayWallBanner = new(Identifier.Minecraft("gray_wall_banner"));


    /// <summary>Represents item by ID of minecraft:light_gray_wall_banner.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LightGrayWallBanner = new(Identifier.Minecraft("light_gray_wall_banner"));


    /// <summary>Represents item by ID of minecraft:cyan_wall_banner.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CyanWallBanner = new(Identifier.Minecraft("cyan_wall_banner"));


    /// <summary>Represents item by ID of minecraft:purple_wall_banner.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PurpleWallBanner = new(Identifier.Minecraft("purple_wall_banner"));


    /// <summary>Represents item by ID of minecraft:blue_wall_banner.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BlueWallBanner = new(Identifier.Minecraft("blue_wall_banner"));


    /// <summary>Represents item by ID of minecraft:brown_wall_banner.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BrownWallBanner = new(Identifier.Minecraft("brown_wall_banner"));


    /// <summary>Represents item by ID of minecraft:green_wall_banner.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GreenWallBanner = new(Identifier.Minecraft("green_wall_banner"));


    /// <summary>Represents item by ID of minecraft:red_wall_banner.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RedWallBanner = new(Identifier.Minecraft("red_wall_banner"));


    /// <summary>Represents item by ID of minecraft:black_wall_banner.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BlackWallBanner = new(Identifier.Minecraft("black_wall_banner"));


    /// <summary>Represents item by ID of minecraft:red_sandstone.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RedSandstone = new(Identifier.Minecraft("red_sandstone"));


    /// <summary>Represents item by ID of minecraft:chiseled_red_sandstone.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material ChiseledRedSandstone = new(Identifier.Minecraft("chiseled_red_sandstone"));


    /// <summary>Represents item by ID of minecraft:cut_red_sandstone.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CutRedSandstone = new(Identifier.Minecraft("cut_red_sandstone"));


    /// <summary>Represents item by ID of minecraft:red_sandstone_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RedSandstoneStairs = new(Identifier.Minecraft("red_sandstone_stairs"));


    /// <summary>Represents item by ID of minecraft:oak_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material OakSlab = new(Identifier.Minecraft("oak_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:spruce_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SpruceSlab = new(Identifier.Minecraft("spruce_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:birch_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BirchSlab = new(Identifier.Minecraft("birch_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:jungle_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material JungleSlab = new(Identifier.Minecraft("jungle_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:acacia_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material AcaciaSlab = new(Identifier.Minecraft("acacia_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:dark_oak_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DarkOakSlab = new(Identifier.Minecraft("dark_oak_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:stone_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material StoneSlab = new(Identifier.Minecraft("stone_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:smooth_stone_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SmoothStoneSlab = new(Identifier.Minecraft("smooth_stone_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:sandstone_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SandstoneSlab = new(Identifier.Minecraft("sandstone_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:cut_sandstone_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CutSandstoneSlab = new(Identifier.Minecraft("cut_sandstone_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:petrified_oak_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PetrifiedOakSlab = new(Identifier.Minecraft("petrified_oak_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:cobblestone_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CobblestoneSlab = new(Identifier.Minecraft("cobblestone_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:brick_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BrickSlab = new(Identifier.Minecraft("brick_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:stone_brick_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material StoneBrickSlab = new(Identifier.Minecraft("stone_brick_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:nether_brick_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material NetherBrickSlab = new(Identifier.Minecraft("nether_brick_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:quartz_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material QuartzSlab = new(Identifier.Minecraft("quartz_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:red_sandstone_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RedSandstoneSlab = new(Identifier.Minecraft("red_sandstone_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:cut_red_sandstone_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CutRedSandstoneSlab =
        new(Identifier.Minecraft("cut_red_sandstone_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:purpur_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PurpurSlab = new(Identifier.Minecraft("purpur_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:smooth_stone.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SmoothStone = new(Identifier.Minecraft("smooth_stone"));


    /// <summary>Represents item by ID of minecraft:smooth_sandstone.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SmoothSandstone = new(Identifier.Minecraft("smooth_sandstone"));


    /// <summary>Represents item by ID of minecraft:smooth_quartz.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SmoothQuartz = new(Identifier.Minecraft("smooth_quartz"));


    /// <summary>Represents item by ID of minecraft:smooth_red_sandstone.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SmoothRedSandstone = new(Identifier.Minecraft("smooth_red_sandstone"));


    /// <summary>Represents item by ID of minecraft:spruce_fence_gate.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SpruceFenceGate = new(Identifier.Minecraft("spruce_fence_gate"), typeof(Gate));


    /// <summary>Represents item by ID of minecraft:birch_fence_gate.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BirchFenceGate = new(Identifier.Minecraft("birch_fence_gate"), typeof(Gate));


    /// <summary>Represents item by ID of minecraft:jungle_fence_gate.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material JungleFenceGate = new(Identifier.Minecraft("jungle_fence_gate"), typeof(Gate));


    /// <summary>Represents item by ID of minecraft:acacia_fence_gate.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material AcaciaFenceGate = new(Identifier.Minecraft("acacia_fence_gate"), typeof(Gate));


    /// <summary>Represents item by ID of minecraft:dark_oak_fence_gate.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DarkOakFenceGate = new(Identifier.Minecraft("dark_oak_fence_gate"), typeof(Gate));


    /// <summary>Represents item by ID of minecraft:spruce_fence.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SpruceFence = new(Identifier.Minecraft("spruce_fence"), typeof(Fence));


    /// <summary>Represents item by ID of minecraft:birch_fence.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BirchFence = new(Identifier.Minecraft("birch_fence"), typeof(Fence));


    /// <summary>Represents item by ID of minecraft:jungle_fence.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material JungleFence = new(Identifier.Minecraft("jungle_fence"), typeof(Fence));


    /// <summary>Represents item by ID of minecraft:acacia_fence.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material AcaciaFence = new(Identifier.Minecraft("acacia_fence"), typeof(Fence));


    /// <summary>Represents item by ID of minecraft:dark_oak_fence.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DarkOakFence = new(Identifier.Minecraft("dark_oak_fence"), typeof(Fence));


    /// <summary>Represents item by ID of minecraft:spruce_door.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SpruceDoor = new(Identifier.Minecraft("spruce_door"), typeof(Door));


    /// <summary>Represents item by ID of minecraft:birch_door.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BirchDoor = new(Identifier.Minecraft("birch_door"), typeof(Door));


    /// <summary>Represents item by ID of minecraft:jungle_door.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material JungleDoor = new(Identifier.Minecraft("jungle_door"), typeof(Door));


    /// <summary>Represents item by ID of minecraft:acacia_door.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material AcaciaDoor = new(Identifier.Minecraft("acacia_door"), typeof(Door));


    /// <summary>Represents item by ID of minecraft:dark_oak_door.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DarkOakDoor = new(Identifier.Minecraft("dark_oak_door"), typeof(Door));


    /// <summary>Represents item by ID of minecraft:end_rod.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material EndRod = new(Identifier.Minecraft("end_rod"));


    /// <summary>Represents item by ID of minecraft:chorus_plant.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material ChorusPlant = new(Identifier.Minecraft("chorus_plant"));


    /// <summary>Represents item by ID of minecraft:chorus_flower.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material ChorusFlower = new(Identifier.Minecraft("chorus_flower"));


    /// <summary>Represents item by ID of minecraft:purpur_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PurpurBlock = new(Identifier.Minecraft("purpur_block"));


    /// <summary>Represents item by ID of minecraft:purpur_pillar.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PurpurPillar = new(Identifier.Minecraft("purpur_pillar"));


    /// <summary>Represents item by ID of minecraft:purpur_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PurpurStairs = new(Identifier.Minecraft("purpur_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:end_stone_bricks.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material EndStoneBricks = new(Identifier.Minecraft("end_stone_bricks"));


    /// <summary>Represents item by ID of minecraft:beetroots.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Beetroots = new(Identifier.Minecraft("beetroots"));


    /// <summary>Represents item by ID of minecraft:dirt_path.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DirtPath = new(Identifier.Minecraft("dirt_path"));


    /// <summary>Represents item by ID of minecraft:end_gateway.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material EndGateway = new(Identifier.Minecraft("end_gateway"));


    /// <summary>Represents item by ID of minecraft:repeating_command_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RepeatingCommandBlock =
        new(Identifier.Minecraft("repeating_command_block"), typeof(CommandBlock));


    /// <summary>Represents item by ID of minecraft:chain_command_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material ChainCommandBlock =
        new(Identifier.Minecraft("chain_command_block"), typeof(CommandBlock));


    /// <summary>Represents item by ID of minecraft:frosted_ice.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material FrostedIce = new(Identifier.Minecraft("frosted_ice"));


    /// <summary>Represents item by ID of minecraft:magma_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MagmaBlock = new(Identifier.Minecraft("magma_block"));


    /// <summary>Represents item by ID of minecraft:nether_wart_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material NetherWartBlock = new(Identifier.Minecraft("nether_wart_block"));


    /// <summary>Represents item by ID of minecraft:red_nether_bricks.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RedNetherBricks = new(Identifier.Minecraft("red_nether_bricks"));


    /// <summary>Represents item by ID of minecraft:bone_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BoneBlock = new(Identifier.Minecraft("bone_block"));


    /// <summary>Represents item by ID of minecraft:structure_void.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material StructureVoid = new(Identifier.Minecraft("structure_void"));


    /// <summary>Represents item by ID of minecraft:observer.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Observer = new(Identifier.Minecraft("observer"));


    /// <summary>Represents item by ID of minecraft:shulker_box.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material ShulkerBox = new(Identifier.Minecraft("shulker_box"));


    /// <summary>Represents item by ID of minecraft:white_shulker_box.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WhiteShulkerBox = new(Identifier.Minecraft("white_shulker_box"));


    /// <summary>Represents item by ID of minecraft:orange_shulker_box.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material OrangeShulkerBox = new(Identifier.Minecraft("orange_shulker_box"));


    /// <summary>Represents item by ID of minecraft:magenta_shulker_box.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MagentaShulkerBox = new(Identifier.Minecraft("magenta_shulker_box"));


    /// <summary>Represents item by ID of minecraft:light_blue_shulker_box.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LightBlueShulkerBox = new(Identifier.Minecraft("light_blue_shulker_box"));


    /// <summary>Represents item by ID of minecraft:yellow_shulker_box.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material YellowShulkerBox = new(Identifier.Minecraft("yellow_shulker_box"));


    /// <summary>Represents item by ID of minecraft:lime_shulker_box.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LimeShulkerBox = new(Identifier.Minecraft("lime_shulker_box"));


    /// <summary>Represents item by ID of minecraft:pink_shulker_box.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PinkShulkerBox = new(Identifier.Minecraft("pink_shulker_box"));


    /// <summary>Represents item by ID of minecraft:gray_shulker_box.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GrayShulkerBox = new(Identifier.Minecraft("gray_shulker_box"));


    /// <summary>Represents item by ID of minecraft:light_gray_shulker_box.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LightGrayShulkerBox = new(Identifier.Minecraft("light_gray_shulker_box"));


    /// <summary>Represents item by ID of minecraft:cyan_shulker_box.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CyanShulkerBox = new(Identifier.Minecraft("cyan_shulker_box"));


    /// <summary>Represents item by ID of minecraft:purple_shulker_box.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PurpleShulkerBox = new(Identifier.Minecraft("purple_shulker_box"));


    /// <summary>Represents item by ID of minecraft:blue_shulker_box.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BlueShulkerBox = new(Identifier.Minecraft("blue_shulker_box"));


    /// <summary>Represents item by ID of minecraft:brown_shulker_box.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BrownShulkerBox = new(Identifier.Minecraft("brown_shulker_box"));


    /// <summary>Represents item by ID of minecraft:green_shulker_box.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GreenShulkerBox = new(Identifier.Minecraft("green_shulker_box"));


    /// <summary>Represents item by ID of minecraft:red_shulker_box.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RedShulkerBox = new(Identifier.Minecraft("red_shulker_box"));


    /// <summary>Represents item by ID of minecraft:black_shulker_box.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BlackShulkerBox = new(Identifier.Minecraft("black_shulker_box"));


    /// <summary>Represents item by ID of minecraft:white_glazed_terracotta.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WhiteGlazedTerracotta = new(Identifier.Minecraft("white_glazed_terracotta"));


    /// <summary>Represents item by ID of minecraft:orange_glazed_terracotta.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material OrangeGlazedTerracotta = new(Identifier.Minecraft("orange_glazed_terracotta"));


    /// <summary>Represents item by ID of minecraft:magenta_glazed_terracotta.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MagentaGlazedTerracotta = new(Identifier.Minecraft("magenta_glazed_terracotta"));


    /// <summary>Represents item by ID of minecraft:light_blue_glazed_terracotta.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LightBlueGlazedTerracotta =
        new(Identifier.Minecraft("light_blue_glazed_terracotta"));


    /// <summary>Represents item by ID of minecraft:yellow_glazed_terracotta.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material YellowGlazedTerracotta = new(Identifier.Minecraft("yellow_glazed_terracotta"));


    /// <summary>Represents item by ID of minecraft:lime_glazed_terracotta.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LimeGlazedTerracotta = new(Identifier.Minecraft("lime_glazed_terracotta"));


    /// <summary>Represents item by ID of minecraft:pink_glazed_terracotta.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PinkGlazedTerracotta = new(Identifier.Minecraft("pink_glazed_terracotta"));


    /// <summary>Represents item by ID of minecraft:gray_glazed_terracotta.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GrayGlazedTerracotta = new(Identifier.Minecraft("gray_glazed_terracotta"));


    /// <summary>Represents item by ID of minecraft:light_gray_glazed_terracotta.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LightGrayGlazedTerracotta =
        new(Identifier.Minecraft("light_gray_glazed_terracotta"));


    /// <summary>Represents item by ID of minecraft:cyan_glazed_terracotta.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CyanGlazedTerracotta = new(Identifier.Minecraft("cyan_glazed_terracotta"));


    /// <summary>Represents item by ID of minecraft:purple_glazed_terracotta.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PurpleGlazedTerracotta = new(Identifier.Minecraft("purple_glazed_terracotta"));


    /// <summary>Represents item by ID of minecraft:blue_glazed_terracotta.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BlueGlazedTerracotta = new(Identifier.Minecraft("blue_glazed_terracotta"));


    /// <summary>Represents item by ID of minecraft:brown_glazed_terracotta.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BrownGlazedTerracotta = new(Identifier.Minecraft("brown_glazed_terracotta"));


    /// <summary>Represents item by ID of minecraft:green_glazed_terracotta.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GreenGlazedTerracotta = new(Identifier.Minecraft("green_glazed_terracotta"));


    /// <summary>Represents item by ID of minecraft:red_glazed_terracotta.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RedGlazedTerracotta = new(Identifier.Minecraft("red_glazed_terracotta"));


    /// <summary>Represents item by ID of minecraft:black_glazed_terracotta.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BlackGlazedTerracotta = new(Identifier.Minecraft("black_glazed_terracotta"));


    /// <summary>Represents item by ID of minecraft:white_concrete.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WhiteConcrete = new(Identifier.Minecraft("white_concrete"));


    /// <summary>Represents item by ID of minecraft:orange_concrete.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material OrangeConcrete = new(Identifier.Minecraft("orange_concrete"));


    /// <summary>Represents item by ID of minecraft:magenta_concrete.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MagentaConcrete = new(Identifier.Minecraft("magenta_concrete"));


    /// <summary>Represents item by ID of minecraft:light_blue_concrete.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LightBlueConcrete = new(Identifier.Minecraft("light_blue_concrete"));


    /// <summary>Represents item by ID of minecraft:yellow_concrete.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material YellowConcrete = new(Identifier.Minecraft("yellow_concrete"));


    /// <summary>Represents item by ID of minecraft:lime_concrete.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LimeConcrete = new(Identifier.Minecraft("lime_concrete"));


    /// <summary>Represents item by ID of minecraft:pink_concrete.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PinkConcrete = new(Identifier.Minecraft("pink_concrete"));


    /// <summary>Represents item by ID of minecraft:gray_concrete.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GrayConcrete = new(Identifier.Minecraft("gray_concrete"));


    /// <summary>Represents item by ID of minecraft:light_gray_concrete.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LightGrayConcrete = new(Identifier.Minecraft("light_gray_concrete"));


    /// <summary>Represents item by ID of minecraft:cyan_concrete.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CyanConcrete = new(Identifier.Minecraft("cyan_concrete"));


    /// <summary>Represents item by ID of minecraft:purple_concrete.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PurpleConcrete = new(Identifier.Minecraft("purple_concrete"));


    /// <summary>Represents item by ID of minecraft:blue_concrete.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BlueConcrete = new(Identifier.Minecraft("blue_concrete"));


    /// <summary>Represents item by ID of minecraft:brown_concrete.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BrownConcrete = new(Identifier.Minecraft("brown_concrete"));


    /// <summary>Represents item by ID of minecraft:green_concrete.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GreenConcrete = new(Identifier.Minecraft("green_concrete"));


    /// <summary>Represents item by ID of minecraft:red_concrete.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RedConcrete = new(Identifier.Minecraft("red_concrete"));


    /// <summary>Represents item by ID of minecraft:black_concrete.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BlackConcrete = new(Identifier.Minecraft("black_concrete"));


    /// <summary>Represents item by ID of minecraft:white_concrete_powder.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WhiteConcretePowder = new(Identifier.Minecraft("white_concrete_powder"));


    /// <summary>Represents item by ID of minecraft:orange_concrete_powder.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material OrangeConcretePowder = new(Identifier.Minecraft("orange_concrete_powder"));


    /// <summary>Represents item by ID of minecraft:magenta_concrete_powder.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MagentaConcretePowder = new(Identifier.Minecraft("magenta_concrete_powder"));


    /// <summary>Represents item by ID of minecraft:light_blue_concrete_powder.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LightBlueConcretePowder = new(Identifier.Minecraft("light_blue_concrete_powder"));


    /// <summary>Represents item by ID of minecraft:yellow_concrete_powder.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material YellowConcretePowder = new(Identifier.Minecraft("yellow_concrete_powder"));


    /// <summary>Represents item by ID of minecraft:lime_concrete_powder.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LimeConcretePowder = new(Identifier.Minecraft("lime_concrete_powder"));


    /// <summary>Represents item by ID of minecraft:pink_concrete_powder.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PinkConcretePowder = new(Identifier.Minecraft("pink_concrete_powder"));


    /// <summary>Represents item by ID of minecraft:gray_concrete_powder.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GrayConcretePowder = new(Identifier.Minecraft("gray_concrete_powder"));


    /// <summary>Represents item by ID of minecraft:light_gray_concrete_powder.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LightGrayConcretePowder = new(Identifier.Minecraft("light_gray_concrete_powder"));


    /// <summary>Represents item by ID of minecraft:cyan_concrete_powder.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CyanConcretePowder = new(Identifier.Minecraft("cyan_concrete_powder"));


    /// <summary>Represents item by ID of minecraft:purple_concrete_powder.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PurpleConcretePowder = new(Identifier.Minecraft("purple_concrete_powder"));


    /// <summary>Represents item by ID of minecraft:blue_concrete_powder.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BlueConcretePowder = new(Identifier.Minecraft("blue_concrete_powder"));


    /// <summary>Represents item by ID of minecraft:brown_concrete_powder.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BrownConcretePowder = new(Identifier.Minecraft("brown_concrete_powder"));


    /// <summary>Represents item by ID of minecraft:green_concrete_powder.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GreenConcretePowder = new(Identifier.Minecraft("green_concrete_powder"));


    /// <summary>Represents item by ID of minecraft:red_concrete_powder.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RedConcretePowder = new(Identifier.Minecraft("red_concrete_powder"));


    /// <summary>Represents item by ID of minecraft:black_concrete_powder.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BlackConcretePowder = new(Identifier.Minecraft("black_concrete_powder"));


    /// <summary>Represents item by ID of minecraft:kelp.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Kelp = new(Identifier.Minecraft("kelp"));


    /// <summary>Represents item by ID of minecraft:kelp_plant.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material KelpPlant = new(Identifier.Minecraft("kelp_plant"));


    /// <summary>Represents item by ID of minecraft:dried_kelp_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DriedKelpBlock = new(Identifier.Minecraft("dried_kelp_block"));


    /// <summary>Represents item by ID of minecraft:turtle_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material TurtleEgg = new(Identifier.Minecraft("turtle_egg"), typeof(TurtleEgg));


    /// <summary>Represents item by ID of minecraft:dead_tube_coral_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DeadTubeCoralBlock = new(Identifier.Minecraft("dead_tube_coral_block"));


    /// <summary>Represents item by ID of minecraft:dead_brain_coral_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DeadBrainCoralBlock = new(Identifier.Minecraft("dead_brain_coral_block"));


    /// <summary>Represents item by ID of minecraft:dead_bubble_coral_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DeadBubbleCoralBlock = new(Identifier.Minecraft("dead_bubble_coral_block"));


    /// <summary>Represents item by ID of minecraft:dead_fire_coral_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DeadFireCoralBlock = new(Identifier.Minecraft("dead_fire_coral_block"));


    /// <summary>Represents item by ID of minecraft:dead_horn_coral_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DeadHornCoralBlock = new(Identifier.Minecraft("dead_horn_coral_block"));


    /// <summary>Represents item by ID of minecraft:tube_coral_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material TubeCoralBlock = new(Identifier.Minecraft("tube_coral_block"));


    /// <summary>Represents item by ID of minecraft:brain_coral_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BrainCoralBlock = new(Identifier.Minecraft("brain_coral_block"));


    /// <summary>Represents item by ID of minecraft:bubble_coral_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BubbleCoralBlock = new(Identifier.Minecraft("bubble_coral_block"));


    /// <summary>Represents item by ID of minecraft:fire_coral_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material FireCoralBlock = new(Identifier.Minecraft("fire_coral_block"));


    /// <summary>Represents item by ID of minecraft:horn_coral_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material HornCoralBlock = new(Identifier.Minecraft("horn_coral_block"));


    /// <summary>Represents item by ID of minecraft:dead_tube_coral.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DeadTubeCoral = new(Identifier.Minecraft("dead_tube_coral"));


    /// <summary>Represents item by ID of minecraft:dead_brain_coral.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DeadBrainCoral = new(Identifier.Minecraft("dead_brain_coral"));


    /// <summary>Represents item by ID of minecraft:dead_bubble_coral.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DeadBubbleCoral = new(Identifier.Minecraft("dead_bubble_coral"));


    /// <summary>Represents item by ID of minecraft:dead_fire_coral.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DeadFireCoral = new(Identifier.Minecraft("dead_fire_coral"));


    /// <summary>Represents item by ID of minecraft:dead_horn_coral.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DeadHornCoral = new(Identifier.Minecraft("dead_horn_coral"));


    /// <summary>Represents item by ID of minecraft:tube_coral.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material TubeCoral = new(Identifier.Minecraft("tube_coral"));


    /// <summary>Represents item by ID of minecraft:brain_coral.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BrainCoral = new(Identifier.Minecraft("brain_coral"));


    /// <summary>Represents item by ID of minecraft:bubble_coral.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BubbleCoral = new(Identifier.Minecraft("bubble_coral"));


    /// <summary>Represents item by ID of minecraft:fire_coral.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material FireCoral = new(Identifier.Minecraft("fire_coral"));


    /// <summary>Represents item by ID of minecraft:horn_coral.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material HornCoral = new(Identifier.Minecraft("horn_coral"));


    /// <summary>Represents item by ID of minecraft:dead_tube_coral_fan.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DeadTubeCoralFan = new(Identifier.Minecraft("dead_tube_coral_fan"));


    /// <summary>Represents item by ID of minecraft:dead_brain_coral_fan.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DeadBrainCoralFan = new(Identifier.Minecraft("dead_brain_coral_fan"));


    /// <summary>Represents item by ID of minecraft:dead_bubble_coral_fan.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DeadBubbleCoralFan = new(Identifier.Minecraft("dead_bubble_coral_fan"));


    /// <summary>Represents item by ID of minecraft:dead_fire_coral_fan.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DeadFireCoralFan = new(Identifier.Minecraft("dead_fire_coral_fan"));


    /// <summary>Represents item by ID of minecraft:dead_horn_coral_fan.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DeadHornCoralFan = new(Identifier.Minecraft("dead_horn_coral_fan"));


    /// <summary>Represents item by ID of minecraft:tube_coral_fan.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material TubeCoralFan = new(Identifier.Minecraft("tube_coral_fan"));


    /// <summary>Represents item by ID of minecraft:brain_coral_fan.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BrainCoralFan = new(Identifier.Minecraft("brain_coral_fan"));


    /// <summary>Represents item by ID of minecraft:bubble_coral_fan.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BubbleCoralFan = new(Identifier.Minecraft("bubble_coral_fan"));


    /// <summary>Represents item by ID of minecraft:fire_coral_fan.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material FireCoralFan = new(Identifier.Minecraft("fire_coral_fan"));


    /// <summary>Represents item by ID of minecraft:horn_coral_fan.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material HornCoralFan = new(Identifier.Minecraft("horn_coral_fan"));


    /// <summary>Represents item by ID of minecraft:dead_tube_coral_wall_fan.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DeadTubeCoralWallFan =
        new(Identifier.Minecraft("dead_tube_coral_wall_fan"), typeof(CoralWallFan));


    /// <summary>Represents item by ID of minecraft:dead_brain_coral_wall_fan.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DeadBrainCoralWallFan =
        new(Identifier.Minecraft("dead_brain_coral_wall_fan"), typeof(CoralWallFan));


    /// <summary>Represents item by ID of minecraft:dead_bubble_coral_wall_fan.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DeadBubbleCoralWallFan =
        new(Identifier.Minecraft("dead_bubble_coral_wall_fan"), typeof(CoralWallFan));


    /// <summary>Represents item by ID of minecraft:dead_fire_coral_wall_fan.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DeadFireCoralWallFan =
        new(Identifier.Minecraft("dead_fire_coral_wall_fan"), typeof(CoralWallFan));


    /// <summary>Represents item by ID of minecraft:dead_horn_coral_wall_fan.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DeadHornCoralWallFan =
        new(Identifier.Minecraft("dead_horn_coral_wall_fan"), typeof(CoralWallFan));


    /// <summary>Represents item by ID of minecraft:tube_coral_wall_fan.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material TubeCoralWallFan =
        new(Identifier.Minecraft("tube_coral_wall_fan"), typeof(CoralWallFan));


    /// <summary>Represents item by ID of minecraft:brain_coral_wall_fan.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BrainCoralWallFan =
        new(Identifier.Minecraft("brain_coral_wall_fan"), typeof(CoralWallFan));


    /// <summary>Represents item by ID of minecraft:bubble_coral_wall_fan.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BubbleCoralWallFan =
        new(Identifier.Minecraft("bubble_coral_wall_fan"), typeof(CoralWallFan));


    /// <summary>Represents item by ID of minecraft:fire_coral_wall_fan.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material FireCoralWallFan =
        new(Identifier.Minecraft("fire_coral_wall_fan"), typeof(CoralWallFan));


    /// <summary>Represents item by ID of minecraft:horn_coral_wall_fan.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material HornCoralWallFan =
        new(Identifier.Minecraft("horn_coral_wall_fan"), typeof(CoralWallFan));


    /// <summary>Represents item by ID of minecraft:sea_pickle.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SeaPickle = new(Identifier.Minecraft("sea_pickle"), typeof(SeaPickle));


    /// <summary>Represents item by ID of minecraft:blue_ice.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BlueIce = new(Identifier.Minecraft("blue_ice"));


    /// <summary>Represents item by ID of minecraft:conduit.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Conduit = new(Identifier.Minecraft("conduit"));


    /// <summary>Represents item by ID of minecraft:bamboo_sapling.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BambooSapling = new(Identifier.Minecraft("bamboo_sapling"), typeof(Bamboo));


    /// <summary>Represents item by ID of minecraft:bamboo.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Bamboo = new(Identifier.Minecraft("bamboo"), typeof(Bamboo));


    /// <summary>Represents item by ID of minecraft:potted_bamboo.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PottedBamboo = new(Identifier.Minecraft("potted_bamboo"));


    /// <summary>Represents item by ID of minecraft:void_air.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material VoidAir = new(Identifier.Minecraft("void_air"));


    /// <summary>Represents item by ID of minecraft:cave_air.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CaveAir = new(Identifier.Minecraft("cave_air"));


    /// <summary>Represents item by ID of minecraft:bubble_column.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BubbleColumn = new(Identifier.Minecraft("bubble_column"), typeof(BubbleColumn));


    /// <summary>Represents item by ID of minecraft:polished_granite_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PolishedGraniteStairs =
        new(Identifier.Minecraft("polished_granite_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:smooth_red_sandstone_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SmoothRedSandstoneStairs =
        new(Identifier.Minecraft("smooth_red_sandstone_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:mossy_stone_brick_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MossyStoneBrickStairs =
        new(Identifier.Minecraft("mossy_stone_brick_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:polished_diorite_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PolishedDioriteStairs =
        new(Identifier.Minecraft("polished_diorite_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:mossy_cobblestone_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MossyCobblestoneStairs =
        new(Identifier.Minecraft("mossy_cobblestone_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:end_stone_brick_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material EndStoneBrickStairs =
        new(Identifier.Minecraft("end_stone_brick_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:stone_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material StoneStairs = new(Identifier.Minecraft("stone_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:smooth_sandstone_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SmoothSandstoneStairs =
        new(Identifier.Minecraft("smooth_sandstone_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:smooth_quartz_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SmoothQuartzStairs =
        new(Identifier.Minecraft("smooth_quartz_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:granite_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GraniteStairs = new(Identifier.Minecraft("granite_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:andesite_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material AndesiteStairs = new(Identifier.Minecraft("andesite_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:red_nether_brick_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RedNetherBrickStairs =
        new(Identifier.Minecraft("red_nether_brick_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:polished_andesite_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PolishedAndesiteStairs =
        new(Identifier.Minecraft("polished_andesite_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:diorite_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DioriteStairs = new(Identifier.Minecraft("diorite_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:polished_granite_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PolishedGraniteSlab =
        new(Identifier.Minecraft("polished_granite_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:smooth_red_sandstone_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SmoothRedSandstoneSlab =
        new(Identifier.Minecraft("smooth_red_sandstone_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:mossy_stone_brick_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MossyStoneBrickSlab =
        new(Identifier.Minecraft("mossy_stone_brick_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:polished_diorite_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PolishedDioriteSlab =
        new(Identifier.Minecraft("polished_diorite_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:mossy_cobblestone_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MossyCobblestoneSlab =
        new(Identifier.Minecraft("mossy_cobblestone_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:end_stone_brick_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material EndStoneBrickSlab = new(Identifier.Minecraft("end_stone_brick_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:smooth_sandstone_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SmoothSandstoneSlab =
        new(Identifier.Minecraft("smooth_sandstone_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:smooth_quartz_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SmoothQuartzSlab = new(Identifier.Minecraft("smooth_quartz_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:granite_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GraniteSlab = new(Identifier.Minecraft("granite_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:andesite_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material AndesiteSlab = new(Identifier.Minecraft("andesite_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:red_nether_brick_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RedNetherBrickSlab =
        new(Identifier.Minecraft("red_nether_brick_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:polished_andesite_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PolishedAndesiteSlab =
        new(Identifier.Minecraft("polished_andesite_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:diorite_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DioriteSlab = new(Identifier.Minecraft("diorite_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:brick_wall.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BrickWall = new(Identifier.Minecraft("brick_wall"), typeof(Wall));


    /// <summary>Represents item by ID of minecraft:prismarine_wall.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PrismarineWall = new(Identifier.Minecraft("prismarine_wall"), typeof(Wall));


    /// <summary>Represents item by ID of minecraft:red_sandstone_wall.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RedSandstoneWall = new(Identifier.Minecraft("red_sandstone_wall"), typeof(Wall));


    /// <summary>Represents item by ID of minecraft:mossy_stone_brick_wall.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MossyStoneBrickWall =
        new(Identifier.Minecraft("mossy_stone_brick_wall"), typeof(Wall));


    /// <summary>Represents item by ID of minecraft:granite_wall.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GraniteWall = new(Identifier.Minecraft("granite_wall"), typeof(Wall));


    /// <summary>Represents item by ID of minecraft:stone_brick_wall.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material StoneBrickWall = new(Identifier.Minecraft("stone_brick_wall"), typeof(Wall));


    /// <summary>Represents item by ID of minecraft:nether_brick_wall.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material NetherBrickWall = new(Identifier.Minecraft("nether_brick_wall"), typeof(Wall));


    /// <summary>Represents item by ID of minecraft:andesite_wall.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material AndesiteWall = new(Identifier.Minecraft("andesite_wall"), typeof(Wall));


    /// <summary>Represents item by ID of minecraft:red_nether_brick_wall.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RedNetherBrickWall =
        new(Identifier.Minecraft("red_nether_brick_wall"), typeof(Wall));


    /// <summary>Represents item by ID of minecraft:sandstone_wall.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SandstoneWall = new(Identifier.Minecraft("sandstone_wall"), typeof(Wall));


    /// <summary>Represents item by ID of minecraft:end_stone_brick_wall.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material EndStoneBrickWall = new(Identifier.Minecraft("end_stone_brick_wall"), typeof(Wall));


    /// <summary>Represents item by ID of minecraft:diorite_wall.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DioriteWall = new(Identifier.Minecraft("diorite_wall"), typeof(Wall));


    /// <summary>Represents item by ID of minecraft:scaffolding.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Scaffolding = new(Identifier.Minecraft("scaffolding"), typeof(Scaffolding));


    /// <summary>Represents item by ID of minecraft:loom.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Loom = new(Identifier.Minecraft("loom"));


    /// <summary>Represents item by ID of minecraft:barrel.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Barrel = new(Identifier.Minecraft("barrel"));


    /// <summary>Represents item by ID of minecraft:smoker.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Smoker = new(Identifier.Minecraft("smoker"));


    /// <summary>Represents item by ID of minecraft:blast_furnace.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BlastFurnace = new(Identifier.Minecraft("blast_furnace"));


    /// <summary>Represents item by ID of minecraft:cartography_table.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CartographyTable = new(Identifier.Minecraft("cartography_table"));


    /// <summary>Represents item by ID of minecraft:fletching_table.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material FletchingTable = new(Identifier.Minecraft("fletching_table"));


    /// <summary>Represents item by ID of minecraft:grindstone.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Grindstone = new(Identifier.Minecraft("grindstone"), typeof(Grindstone));


    /// <summary>Represents item by ID of minecraft:lectern.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Lectern = new(Identifier.Minecraft("lectern"), typeof(Lectern));


    /// <summary>Represents item by ID of minecraft:smithing_table.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SmithingTable = new(Identifier.Minecraft("smithing_table"));


    /// <summary>Represents item by ID of minecraft:stonecutter.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Stonecutter = new(Identifier.Minecraft("stonecutter"));


    /// <summary>Represents item by ID of minecraft:bell.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Bell = new(Identifier.Minecraft("bell"), typeof(Bell));


    /// <summary>Represents item by ID of minecraft:lantern.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Lantern = new(Identifier.Minecraft("lantern"), typeof(Lantern));


    /// <summary>Represents item by ID of minecraft:soul_lantern.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SoulLantern = new(Identifier.Minecraft("soul_lantern"), typeof(Lantern));


    /// <summary>Represents item by ID of minecraft:campfire.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Campfire = new(Identifier.Minecraft("campfire"), typeof(Campfire));


    /// <summary>Represents item by ID of minecraft:soul_campfire.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SoulCampfire = new(Identifier.Minecraft("soul_campfire"), typeof(Campfire));


    /// <summary>Represents item by ID of minecraft:sweet_berry_bush.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SweetBerryBush = new(Identifier.Minecraft("sweet_berry_bush"));


    /// <summary>Represents item by ID of minecraft:warped_stem.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WarpedStem = new(Identifier.Minecraft("warped_stem"));


    /// <summary>Represents item by ID of minecraft:stripped_warped_stem.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material StrippedWarpedStem = new(Identifier.Minecraft("stripped_warped_stem"));


    /// <summary>Represents item by ID of minecraft:warped_hyphae.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WarpedHyphae = new(Identifier.Minecraft("warped_hyphae"));


    /// <summary>Represents item by ID of minecraft:stripped_warped_hyphae.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material StrippedWarpedHyphae = new(Identifier.Minecraft("stripped_warped_hyphae"));


    /// <summary>Represents item by ID of minecraft:warped_nylium.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WarpedNylium = new(Identifier.Minecraft("warped_nylium"));


    /// <summary>Represents item by ID of minecraft:warped_fungus.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WarpedFungus = new(Identifier.Minecraft("warped_fungus"));


    /// <summary>Represents item by ID of minecraft:warped_wart_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WarpedWartBlock = new(Identifier.Minecraft("warped_wart_block"));


    /// <summary>Represents item by ID of minecraft:warped_roots.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WarpedRoots = new(Identifier.Minecraft("warped_roots"));


    /// <summary>Represents item by ID of minecraft:nether_sprouts.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material NetherSprouts = new(Identifier.Minecraft("nether_sprouts"));


    /// <summary>Represents item by ID of minecraft:crimson_stem.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CrimsonStem = new(Identifier.Minecraft("crimson_stem"));


    /// <summary>Represents item by ID of minecraft:stripped_crimson_stem.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material StrippedCrimsonStem = new(Identifier.Minecraft("stripped_crimson_stem"));


    /// <summary>Represents item by ID of minecraft:crimson_hyphae.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CrimsonHyphae = new(Identifier.Minecraft("crimson_hyphae"));


    /// <summary>Represents item by ID of minecraft:stripped_crimson_hyphae.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material StrippedCrimsonHyphae = new(Identifier.Minecraft("stripped_crimson_hyphae"));


    /// <summary>Represents item by ID of minecraft:crimson_nylium.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CrimsonNylium = new(Identifier.Minecraft("crimson_nylium"));


    /// <summary>Represents item by ID of minecraft:crimson_fungus.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CrimsonFungus = new(Identifier.Minecraft("crimson_fungus"));


    /// <summary>Represents item by ID of minecraft:shroomlight.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Shroomlight = new(Identifier.Minecraft("shroomlight"));


    /// <summary>Represents item by ID of minecraft:weeping_vines.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WeepingVines = new(Identifier.Minecraft("weeping_vines"));


    /// <summary>Represents item by ID of minecraft:weeping_vines_plant.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WeepingVinesPlant = new(Identifier.Minecraft("weeping_vines_plant"));


    /// <summary>Represents item by ID of minecraft:twisting_vines.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material TwistingVines = new(Identifier.Minecraft("twisting_vines"));


    /// <summary>Represents item by ID of minecraft:twisting_vines_plant.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material TwistingVinesPlant = new(Identifier.Minecraft("twisting_vines_plant"));


    /// <summary>Represents item by ID of minecraft:crimson_roots.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CrimsonRoots = new(Identifier.Minecraft("crimson_roots"));


    /// <summary>Represents item by ID of minecraft:crimson_planks.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CrimsonPlanks = new(Identifier.Minecraft("crimson_planks"));


    /// <summary>Represents item by ID of minecraft:warped_planks.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WarpedPlanks = new(Identifier.Minecraft("warped_planks"));


    /// <summary>Represents item by ID of minecraft:crimson_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CrimsonSlab = new(Identifier.Minecraft("crimson_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:warped_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WarpedSlab = new(Identifier.Minecraft("warped_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:crimson_pressure_plate.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CrimsonPressurePlate = new(Identifier.Minecraft("crimson_pressure_plate"));


    /// <summary>Represents item by ID of minecraft:warped_pressure_plate.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WarpedPressurePlate = new(Identifier.Minecraft("warped_pressure_plate"));


    /// <summary>Represents item by ID of minecraft:crimson_fence.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CrimsonFence = new(Identifier.Minecraft("crimson_fence"), typeof(Fence));


    /// <summary>Represents item by ID of minecraft:warped_fence.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WarpedFence = new(Identifier.Minecraft("warped_fence"), typeof(Fence));


    /// <summary>Represents item by ID of minecraft:crimson_trapdoor.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CrimsonTrapdoor = new(Identifier.Minecraft("crimson_trapdoor"), typeof(TrapDoor));


    /// <summary>Represents item by ID of minecraft:warped_trapdoor.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WarpedTrapdoor = new(Identifier.Minecraft("warped_trapdoor"), typeof(TrapDoor));


    /// <summary>Represents item by ID of minecraft:crimson_fence_gate.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CrimsonFenceGate = new(Identifier.Minecraft("crimson_fence_gate"), typeof(Gate));


    /// <summary>Represents item by ID of minecraft:warped_fence_gate.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WarpedFenceGate = new(Identifier.Minecraft("warped_fence_gate"), typeof(Gate));


    /// <summary>Represents item by ID of minecraft:crimson_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CrimsonStairs = new(Identifier.Minecraft("crimson_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:warped_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WarpedStairs = new(Identifier.Minecraft("warped_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:crimson_button.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CrimsonButton = new(Identifier.Minecraft("crimson_button"));


    /// <summary>Represents item by ID of minecraft:warped_button.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WarpedButton = new(Identifier.Minecraft("warped_button"));


    /// <summary>Represents item by ID of minecraft:crimson_door.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CrimsonDoor = new(Identifier.Minecraft("crimson_door"), typeof(Door));


    /// <summary>Represents item by ID of minecraft:warped_door.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WarpedDoor = new(Identifier.Minecraft("warped_door"), typeof(Door));


    /// <summary>Represents item by ID of minecraft:crimson_sign.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CrimsonSign = new(Identifier.Minecraft("crimson_sign"), typeof(Sign));


    /// <summary>Represents item by ID of minecraft:warped_sign.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WarpedSign = new(Identifier.Minecraft("warped_sign"), typeof(Sign));


    /// <summary>Represents item by ID of minecraft:crimson_wall_sign.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CrimsonWallSign = new(Identifier.Minecraft("crimson_wall_sign"), typeof(Sign));


    /// <summary>Represents item by ID of minecraft:warped_wall_sign.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WarpedWallSign = new(Identifier.Minecraft("warped_wall_sign"), typeof(Sign));


    /// <summary>Represents item by ID of minecraft:structure_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material StructureBlock =
        new(Identifier.Minecraft("structure_block"), typeof(StructureBlock));


    /// <summary>Represents item by ID of minecraft:jigsaw.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Jigsaw = new(Identifier.Minecraft("jigsaw"), typeof(Jigsaw));


    /// <summary>Represents item by ID of minecraft:composter.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Composter = new(Identifier.Minecraft("composter"));


    /// <summary>Represents item by ID of minecraft:target.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Target = new(Identifier.Minecraft("target"));


    /// <summary>Represents item by ID of minecraft:bee_nest.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BeeNest = new(Identifier.Minecraft("bee_nest"), typeof(Beehive));


    /// <summary>Represents item by ID of minecraft:beehive.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Beehive = new(Identifier.Minecraft("beehive"), typeof(Beehive));


    /// <summary>Represents item by ID of minecraft:honey_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material HoneyBlock = new(Identifier.Minecraft("honey_block"));


    /// <summary>Represents item by ID of minecraft:honeycomb_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material HoneycombBlock = new(Identifier.Minecraft("honeycomb_block"));


    /// <summary>Represents item by ID of minecraft:netherite_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material NetheriteBlock = new(Identifier.Minecraft("netherite_block"));


    /// <summary>Represents item by ID of minecraft:ancient_debris.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material AncientDebris = new(Identifier.Minecraft("ancient_debris"));


    /// <summary>Represents item by ID of minecraft:crying_obsidian.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CryingObsidian = new(Identifier.Minecraft("crying_obsidian"));


    /// <summary>Represents item by ID of minecraft:respawn_anchor.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RespawnAnchor = new(Identifier.Minecraft("respawn_anchor"), typeof(RespawnAnchor));


    /// <summary>Represents item by ID of minecraft:potted_crimson_fungus.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PottedCrimsonFungus = new(Identifier.Minecraft("potted_crimson_fungus"));


    /// <summary>Represents item by ID of minecraft:potted_warped_fungus.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PottedWarpedFungus = new(Identifier.Minecraft("potted_warped_fungus"));


    /// <summary>Represents item by ID of minecraft:potted_crimson_roots.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PottedCrimsonRoots = new(Identifier.Minecraft("potted_crimson_roots"));


    /// <summary>Represents item by ID of minecraft:potted_warped_roots.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PottedWarpedRoots = new(Identifier.Minecraft("potted_warped_roots"));


    /// <summary>Represents item by ID of minecraft:lodestone.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Lodestone = new(Identifier.Minecraft("lodestone"));


    /// <summary>Represents item by ID of minecraft:blackstone.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Blackstone = new(Identifier.Minecraft("blackstone"));


    /// <summary>Represents item by ID of minecraft:blackstone_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BlackstoneStairs = new(Identifier.Minecraft("blackstone_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:blackstone_wall.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BlackstoneWall = new(Identifier.Minecraft("blackstone_wall"), typeof(Wall));


    /// <summary>Represents item by ID of minecraft:blackstone_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BlackstoneSlab = new(Identifier.Minecraft("blackstone_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:polished_blackstone.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PolishedBlackstone = new(Identifier.Minecraft("polished_blackstone"));


    /// <summary>Represents item by ID of minecraft:polished_blackstone_bricks.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PolishedBlackstoneBricks = new(Identifier.Minecraft("polished_blackstone_bricks"));


    /// <summary>Represents item by ID of minecraft:cracked_polished_blackstone_bricks.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CrackedPolishedBlackstoneBricks =
        new(Identifier.Minecraft("cracked_polished_blackstone_bricks"));


    /// <summary>Represents item by ID of minecraft:chiseled_polished_blackstone.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material ChiseledPolishedBlackstone =
        new(Identifier.Minecraft("chiseled_polished_blackstone"));


    /// <summary>Represents item by ID of minecraft:polished_blackstone_brick_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PolishedBlackstoneBrickSlab =
        new(Identifier.Minecraft("polished_blackstone_brick_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:polished_blackstone_brick_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PolishedBlackstoneBrickStairs =
        new(Identifier.Minecraft("polished_blackstone_brick_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:polished_blackstone_brick_wall.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PolishedBlackstoneBrickWall =
        new(Identifier.Minecraft("polished_blackstone_brick_wall"), typeof(Wall));


    /// <summary>Represents item by ID of minecraft:gilded_blackstone.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GildedBlackstone = new(Identifier.Minecraft("gilded_blackstone"));


    /// <summary>Represents item by ID of minecraft:polished_blackstone_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PolishedBlackstoneStairs =
        new(Identifier.Minecraft("polished_blackstone_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:polished_blackstone_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PolishedBlackstoneSlab =
        new(Identifier.Minecraft("polished_blackstone_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:polished_blackstone_pressure_plate.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PolishedBlackstonePressurePlate =
        new(Identifier.Minecraft("polished_blackstone_pressure_plate"));


    /// <summary>Represents item by ID of minecraft:polished_blackstone_button.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PolishedBlackstoneButton = new(Identifier.Minecraft("polished_blackstone_button"));


    /// <summary>Represents item by ID of minecraft:polished_blackstone_wall.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PolishedBlackstoneWall =
        new(Identifier.Minecraft("polished_blackstone_wall"), typeof(Wall));


    /// <summary>Represents item by ID of minecraft:chiseled_nether_bricks.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material ChiseledNetherBricks = new(Identifier.Minecraft("chiseled_nether_bricks"));


    /// <summary>Represents item by ID of minecraft:cracked_nether_bricks.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CrackedNetherBricks = new(Identifier.Minecraft("cracked_nether_bricks"));


    /// <summary>Represents item by ID of minecraft:quartz_bricks.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material QuartzBricks = new(Identifier.Minecraft("quartz_bricks"));


    /// <summary>Represents item by ID of minecraft:candle.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Candle = new(Identifier.Minecraft("candle"), typeof(Candle));


    /// <summary>Represents item by ID of minecraft:white_candle.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WhiteCandle = new(Identifier.Minecraft("white_candle"), typeof(Candle));


    /// <summary>Represents item by ID of minecraft:orange_candle.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material OrangeCandle = new(Identifier.Minecraft("orange_candle"), typeof(Candle));


    /// <summary>Represents item by ID of minecraft:magenta_candle.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MagentaCandle = new(Identifier.Minecraft("magenta_candle"), typeof(Candle));


    /// <summary>Represents item by ID of minecraft:light_blue_candle.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LightBlueCandle = new(Identifier.Minecraft("light_blue_candle"), typeof(Candle));


    /// <summary>Represents item by ID of minecraft:yellow_candle.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material YellowCandle = new(Identifier.Minecraft("yellow_candle"), typeof(Candle));


    /// <summary>Represents item by ID of minecraft:lime_candle.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LimeCandle = new(Identifier.Minecraft("lime_candle"), typeof(Candle));


    /// <summary>Represents item by ID of minecraft:pink_candle.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PinkCandle = new(Identifier.Minecraft("pink_candle"), typeof(Candle));


    /// <summary>Represents item by ID of minecraft:gray_candle.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GrayCandle = new(Identifier.Minecraft("gray_candle"), typeof(Candle));


    /// <summary>Represents item by ID of minecraft:light_gray_candle.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LightGrayCandle = new(Identifier.Minecraft("light_gray_candle"), typeof(Candle));


    /// <summary>Represents item by ID of minecraft:cyan_candle.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CyanCandle = new(Identifier.Minecraft("cyan_candle"), typeof(Candle));


    /// <summary>Represents item by ID of minecraft:purple_candle.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PurpleCandle = new(Identifier.Minecraft("purple_candle"), typeof(Candle));


    /// <summary>Represents item by ID of minecraft:blue_candle.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BlueCandle = new(Identifier.Minecraft("blue_candle"), typeof(Candle));


    /// <summary>Represents item by ID of minecraft:brown_candle.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BrownCandle = new(Identifier.Minecraft("brown_candle"), typeof(Candle));


    /// <summary>Represents item by ID of minecraft:green_candle.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GreenCandle = new(Identifier.Minecraft("green_candle"), typeof(Candle));


    /// <summary>Represents item by ID of minecraft:red_candle.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RedCandle = new(Identifier.Minecraft("red_candle"), typeof(Candle));


    /// <summary>Represents item by ID of minecraft:black_candle.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BlackCandle = new(Identifier.Minecraft("black_candle"), typeof(Candle));


    /// <summary>Represents item by ID of minecraft:candle_cake.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CandleCake = new(Identifier.Minecraft("candle_cake"), typeof(Candle));


    /// <summary>Represents item by ID of minecraft:white_candle_cake.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WhiteCandleCake = new(Identifier.Minecraft("white_candle_cake"), typeof(Candle));


    /// <summary>Represents item by ID of minecraft:orange_candle_cake.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material OrangeCandleCake = new(Identifier.Minecraft("orange_candle_cake"), typeof(Candle));


    /// <summary>Represents item by ID of minecraft:magenta_candle_cake.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material
        MagentaCandleCake = new(Identifier.Minecraft("magenta_candle_cake"), typeof(Candle));


    /// <summary>Represents item by ID of minecraft:light_blue_candle_cake.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LightBlueCandleCake =
        new(Identifier.Minecraft("light_blue_candle_cake"), typeof(Candle));


    /// <summary>Represents item by ID of minecraft:yellow_candle_cake.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material YellowCandleCake = new(Identifier.Minecraft("yellow_candle_cake"), typeof(Candle));


    /// <summary>Represents item by ID of minecraft:lime_candle_cake.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LimeCandleCake = new(Identifier.Minecraft("lime_candle_cake"), typeof(Candle));


    /// <summary>Represents item by ID of minecraft:pink_candle_cake.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PinkCandleCake = new(Identifier.Minecraft("pink_candle_cake"), typeof(Candle));


    /// <summary>Represents item by ID of minecraft:gray_candle_cake.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GrayCandleCake = new(Identifier.Minecraft("gray_candle_cake"), typeof(Candle));


    /// <summary>Represents item by ID of minecraft:light_gray_candle_cake.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LightGrayCandleCake =
        new(Identifier.Minecraft("light_gray_candle_cake"), typeof(Candle));


    /// <summary>Represents item by ID of minecraft:cyan_candle_cake.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CyanCandleCake = new(Identifier.Minecraft("cyan_candle_cake"), typeof(Candle));


    /// <summary>Represents item by ID of minecraft:purple_candle_cake.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PurpleCandleCake = new(Identifier.Minecraft("purple_candle_cake"), typeof(Candle));


    /// <summary>Represents item by ID of minecraft:blue_candle_cake.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BlueCandleCake = new(Identifier.Minecraft("blue_candle_cake"), typeof(Candle));


    /// <summary>Represents item by ID of minecraft:brown_candle_cake.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BrownCandleCake = new(Identifier.Minecraft("brown_candle_cake"), typeof(Candle));


    /// <summary>Represents item by ID of minecraft:green_candle_cake.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GreenCandleCake = new(Identifier.Minecraft("green_candle_cake"), typeof(Candle));


    /// <summary>Represents item by ID of minecraft:red_candle_cake.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RedCandleCake = new(Identifier.Minecraft("red_candle_cake"), typeof(Candle));


    /// <summary>Represents item by ID of minecraft:black_candle_cake.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BlackCandleCake = new(Identifier.Minecraft("black_candle_cake"), typeof(Candle));


    /// <summary>Represents item by ID of minecraft:amethyst_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material AmethystBlock = new(Identifier.Minecraft("amethyst_block"));


    /// <summary>Represents item by ID of minecraft:budding_amethyst.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BuddingAmethyst = new(Identifier.Minecraft("budding_amethyst"));


    /// <summary>Represents item by ID of minecraft:amethyst_cluster.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material AmethystCluster =
        new(Identifier.Minecraft("amethyst_cluster"), typeof(AmethystCluster));


    /// <summary>Represents item by ID of minecraft:large_amethyst_bud.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LargeAmethystBud = new(Identifier.Minecraft("large_amethyst_bud"));


    /// <summary>Represents item by ID of minecraft:medium_amethyst_bud.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MediumAmethystBud = new(Identifier.Minecraft("medium_amethyst_bud"));


    /// <summary>Represents item by ID of minecraft:small_amethyst_bud.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SmallAmethystBud = new(Identifier.Minecraft("small_amethyst_bud"));


    /// <summary>Represents item by ID of minecraft:tuff.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Tuff = new(Identifier.Minecraft("tuff"));


    /// <summary>Represents item by ID of minecraft:calcite.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Calcite = new(Identifier.Minecraft("calcite"));


    /// <summary>Represents item by ID of minecraft:tinted_glass.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material TintedGlass = new(Identifier.Minecraft("tinted_glass"));


    /// <summary>Represents item by ID of minecraft:powder_snow.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PowderSnow = new(Identifier.Minecraft("powder_snow"));


    /// <summary>Represents item by ID of minecraft:sculk_sensor.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SculkSensor = new(Identifier.Minecraft("sculk_sensor"), typeof(SculkSensor));


    /// <summary>Represents item by ID of minecraft:oxidized_copper.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material OxidizedCopper = new(Identifier.Minecraft("oxidized_copper"));


    /// <summary>Represents item by ID of minecraft:weathered_copper.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WeatheredCopper = new(Identifier.Minecraft("weathered_copper"));


    /// <summary>Represents item by ID of minecraft:exposed_copper.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material ExposedCopper = new(Identifier.Minecraft("exposed_copper"));


    /// <summary>Represents item by ID of minecraft:copper_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CopperBlock = new(Identifier.Minecraft("copper_block"));


    /// <summary>Represents item by ID of minecraft:copper_ore.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CopperOre = new(Identifier.Minecraft("copper_ore"));


    /// <summary>Represents item by ID of minecraft:deepslate_copper_ore.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DeepslateCopperOre = new(Identifier.Minecraft("deepslate_copper_ore"));


    /// <summary>Represents item by ID of minecraft:oxidized_cut_copper.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material OxidizedCutCopper = new(Identifier.Minecraft("oxidized_cut_copper"));


    /// <summary>Represents item by ID of minecraft:weathered_cut_copper.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WeatheredCutCopper = new(Identifier.Minecraft("weathered_cut_copper"));


    /// <summary>Represents item by ID of minecraft:exposed_cut_copper.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material ExposedCutCopper = new(Identifier.Minecraft("exposed_cut_copper"));


    /// <summary>Represents item by ID of minecraft:cut_copper.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CutCopper = new(Identifier.Minecraft("cut_copper"));


    /// <summary>Represents item by ID of minecraft:oxidized_cut_copper_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material OxidizedCutCopperStairs =
        new(Identifier.Minecraft("oxidized_cut_copper_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:weathered_cut_copper_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WeatheredCutCopperStairs =
        new(Identifier.Minecraft("weathered_cut_copper_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:exposed_cut_copper_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material ExposedCutCopperStairs =
        new(Identifier.Minecraft("exposed_cut_copper_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:cut_copper_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CutCopperStairs = new(Identifier.Minecraft("cut_copper_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:oxidized_cut_copper_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material OxidizedCutCopperSlab =
        new(Identifier.Minecraft("oxidized_cut_copper_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:weathered_cut_copper_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WeatheredCutCopperSlab =
        new(Identifier.Minecraft("weathered_cut_copper_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:exposed_cut_copper_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material ExposedCutCopperSlab =
        new(Identifier.Minecraft("exposed_cut_copper_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:cut_copper_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CutCopperSlab = new(Identifier.Minecraft("cut_copper_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:waxed_copper_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WaxedCopperBlock = new(Identifier.Minecraft("waxed_copper_block"));


    /// <summary>Represents item by ID of minecraft:waxed_weathered_copper.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WaxedWeatheredCopper = new(Identifier.Minecraft("waxed_weathered_copper"));


    /// <summary>Represents item by ID of minecraft:waxed_exposed_copper.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WaxedExposedCopper = new(Identifier.Minecraft("waxed_exposed_copper"));


    /// <summary>Represents item by ID of minecraft:waxed_oxidized_copper.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WaxedOxidizedCopper = new(Identifier.Minecraft("waxed_oxidized_copper"));


    /// <summary>Represents item by ID of minecraft:waxed_oxidized_cut_copper.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WaxedOxidizedCutCopper = new(Identifier.Minecraft("waxed_oxidized_cut_copper"));


    /// <summary>Represents item by ID of minecraft:waxed_weathered_cut_copper.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WaxedWeatheredCutCopper = new(Identifier.Minecraft("waxed_weathered_cut_copper"));


    /// <summary>Represents item by ID of minecraft:waxed_exposed_cut_copper.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WaxedExposedCutCopper = new(Identifier.Minecraft("waxed_exposed_cut_copper"));


    /// <summary>Represents item by ID of minecraft:waxed_cut_copper.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WaxedCutCopper = new(Identifier.Minecraft("waxed_cut_copper"));


    /// <summary>Represents item by ID of minecraft:waxed_oxidized_cut_copper_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WaxedOxidizedCutCopperStairs =
        new(Identifier.Minecraft("waxed_oxidized_cut_copper_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:waxed_weathered_cut_copper_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WaxedWeatheredCutCopperStairs =
        new(Identifier.Minecraft("waxed_weathered_cut_copper_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:waxed_exposed_cut_copper_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WaxedExposedCutCopperStairs =
        new(Identifier.Minecraft("waxed_exposed_cut_copper_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:waxed_cut_copper_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WaxedCutCopperStairs =
        new(Identifier.Minecraft("waxed_cut_copper_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:waxed_oxidized_cut_copper_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WaxedOxidizedCutCopperSlab =
        new(Identifier.Minecraft("waxed_oxidized_cut_copper_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:waxed_weathered_cut_copper_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WaxedWeatheredCutCopperSlab =
        new(Identifier.Minecraft("waxed_weathered_cut_copper_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:waxed_exposed_cut_copper_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WaxedExposedCutCopperSlab =
        new(Identifier.Minecraft("waxed_exposed_cut_copper_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:waxed_cut_copper_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WaxedCutCopperSlab =
        new(Identifier.Minecraft("waxed_cut_copper_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:lightning_rod.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LightningRod = new(Identifier.Minecraft("lightning_rod"), typeof(LightningRod));


    /// <summary>Represents item by ID of minecraft:pointed_dripstone.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PointedDripstone =
        new(Identifier.Minecraft("pointed_dripstone"), typeof(PointedDripstone));


    /// <summary>Represents item by ID of minecraft:dripstone_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DripstoneBlock = new(Identifier.Minecraft("dripstone_block"));


    /// <summary>Represents item by ID of minecraft:cave_vines.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CaveVines = new(Identifier.Minecraft("cave_vines"), typeof(CaveVines));


    /// <summary>Represents item by ID of minecraft:cave_vines_plant.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CaveVinesPlant = new(Identifier.Minecraft("cave_vines_plant"));


    /// <summary>Represents item by ID of minecraft:spore_blossom.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SporeBlossom = new(Identifier.Minecraft("spore_blossom"));


    /// <summary>Represents item by ID of minecraft:azalea.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Azalea = new(Identifier.Minecraft("azalea"));


    /// <summary>Represents item by ID of minecraft:flowering_azalea.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material FloweringAzalea = new(Identifier.Minecraft("flowering_azalea"));


    /// <summary>Represents item by ID of minecraft:moss_carpet.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MossCarpet = new(Identifier.Minecraft("moss_carpet"));


    /// <summary>Represents item by ID of minecraft:moss_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MossBlock = new(Identifier.Minecraft("moss_block"));


    /// <summary>Represents item by ID of minecraft:big_dripleaf.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BigDripleaf = new(Identifier.Minecraft("big_dripleaf"), typeof(BigDripleaf));


    /// <summary>Represents item by ID of minecraft:big_dripleaf_stem.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BigDripleafStem = new(Identifier.Minecraft("big_dripleaf_stem"));


    /// <summary>Represents item by ID of minecraft:small_dripleaf.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SmallDripleaf = new(Identifier.Minecraft("small_dripleaf"), typeof(SmallDripleaf));


    /// <summary>Represents item by ID of minecraft:hanging_roots.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material HangingRoots = new(Identifier.Minecraft("hanging_roots"));


    /// <summary>Represents item by ID of minecraft:rooted_dirt.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RootedDirt = new(Identifier.Minecraft("rooted_dirt"));


    /// <summary>Represents item by ID of minecraft:deepslate.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Deepslate = new(Identifier.Minecraft("deepslate"));


    /// <summary>Represents item by ID of minecraft:cobbled_deepslate.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CobbledDeepslate = new(Identifier.Minecraft("cobbled_deepslate"));


    /// <summary>Represents item by ID of minecraft:cobbled_deepslate_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CobbledDeepslateStairs =
        new(Identifier.Minecraft("cobbled_deepslate_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:cobbled_deepslate_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CobbledDeepslateSlab =
        new(Identifier.Minecraft("cobbled_deepslate_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:cobbled_deepslate_wall.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CobbledDeepslateWall =
        new(Identifier.Minecraft("cobbled_deepslate_wall"), typeof(Wall));


    /// <summary>Represents item by ID of minecraft:polished_deepslate.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PolishedDeepslate = new(Identifier.Minecraft("polished_deepslate"));


    /// <summary>Represents item by ID of minecraft:polished_deepslate_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PolishedDeepslateStairs =
        new(Identifier.Minecraft("polished_deepslate_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:polished_deepslate_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PolishedDeepslateSlab =
        new(Identifier.Minecraft("polished_deepslate_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:polished_deepslate_wall.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PolishedDeepslateWall =
        new(Identifier.Minecraft("polished_deepslate_wall"), typeof(Wall));


    /// <summary>Represents item by ID of minecraft:deepslate_tiles.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DeepslateTiles = new(Identifier.Minecraft("deepslate_tiles"));


    /// <summary>Represents item by ID of minecraft:deepslate_tile_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DeepslateTileStairs =
        new(Identifier.Minecraft("deepslate_tile_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:deepslate_tile_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DeepslateTileSlab = new(Identifier.Minecraft("deepslate_tile_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:deepslate_tile_wall.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DeepslateTileWall = new(Identifier.Minecraft("deepslate_tile_wall"), typeof(Wall));


    /// <summary>Represents item by ID of minecraft:deepslate_bricks.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DeepslateBricks = new(Identifier.Minecraft("deepslate_bricks"));


    /// <summary>Represents item by ID of minecraft:deepslate_brick_stairs.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DeepslateBrickStairs =
        new(Identifier.Minecraft("deepslate_brick_stairs"), typeof(Stairs));


    /// <summary>Represents item by ID of minecraft:deepslate_brick_slab.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material
        DeepslateBrickSlab = new(Identifier.Minecraft("deepslate_brick_slab"), typeof(Slab));


    /// <summary>Represents item by ID of minecraft:deepslate_brick_wall.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material
        DeepslateBrickWall = new(Identifier.Minecraft("deepslate_brick_wall"), typeof(Wall));


    /// <summary>Represents item by ID of minecraft:chiseled_deepslate.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material ChiseledDeepslate = new(Identifier.Minecraft("chiseled_deepslate"));


    /// <summary>Represents item by ID of minecraft:cracked_deepslate_bricks.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CrackedDeepslateBricks = new(Identifier.Minecraft("cracked_deepslate_bricks"));


    /// <summary>Represents item by ID of minecraft:cracked_deepslate_tiles.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CrackedDeepslateTiles = new(Identifier.Minecraft("cracked_deepslate_tiles"));


    /// <summary>Represents item by ID of minecraft:infested_deepslate.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material InfestedDeepslate = new(Identifier.Minecraft("infested_deepslate"));


    /// <summary>Represents item by ID of minecraft:smooth_basalt.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SmoothBasalt = new(Identifier.Minecraft("smooth_basalt"));


    /// <summary>Represents item by ID of minecraft:raw_iron_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RawIronBlock = new(Identifier.Minecraft("raw_iron_block"));


    /// <summary>Represents item by ID of minecraft:raw_copper_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RawCopperBlock = new(Identifier.Minecraft("raw_copper_block"));


    /// <summary>Represents item by ID of minecraft:raw_gold_block.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RawGoldBlock = new(Identifier.Minecraft("raw_gold_block"));


    /// <summary>Represents item by ID of minecraft:potted_azalea_bush.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PottedAzaleaBush = new(Identifier.Minecraft("potted_azalea_bush"));


    /// <summary>Represents item by ID of minecraft:potted_flowering_azalea_bush.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PottedFloweringAzaleaBush =
        new(Identifier.Minecraft("potted_flowering_azalea_bush"));


    /// <summary>Represents item by ID of minecraft:redstone.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Redstone = new(Identifier.Minecraft("redstone"));


    /// <summary>Represents item by ID of minecraft:saddle.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Saddle = new(Identifier.Minecraft("saddle"));


    /// <summary>Represents item by ID of minecraft:minecart.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Minecart = new(Identifier.Minecraft("minecart"));


    /// <summary>Represents item by ID of minecraft:chest_minecart.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material ChestMinecart = new(Identifier.Minecraft("chest_minecart"));


    /// <summary>Represents item by ID of minecraft:furnace_minecart.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material FurnaceMinecart = new(Identifier.Minecraft("furnace_minecart"));


    /// <summary>Represents item by ID of minecraft:tnt_minecart.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material TntMinecart = new(Identifier.Minecraft("tnt_minecart"));


    /// <summary>Represents item by ID of minecraft:hopper_minecart.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material HopperMinecart = new(Identifier.Minecraft("hopper_minecart"));


    /// <summary>Represents item by ID of minecraft:carrot_on_a_stick.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CarrotOnAStick = new(Identifier.Minecraft("carrot_on_a_stick"));


    /// <summary>Represents item by ID of minecraft:warped_fungus_on_a_stick.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WarpedFungusOnAStick = new(Identifier.Minecraft("warped_fungus_on_a_stick"));


    /// <summary>Represents item by ID of minecraft:elytra.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Elytra = new(Identifier.Minecraft("elytra"));


    /// <summary>Represents item by ID of minecraft:oak_boat.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material OakBoat = new(Identifier.Minecraft("oak_boat"));


    /// <summary>Represents item by ID of minecraft:spruce_boat.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SpruceBoat = new(Identifier.Minecraft("spruce_boat"));


    /// <summary>Represents item by ID of minecraft:birch_boat.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BirchBoat = new(Identifier.Minecraft("birch_boat"));


    /// <summary>Represents item by ID of minecraft:jungle_boat.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material JungleBoat = new(Identifier.Minecraft("jungle_boat"));


    /// <summary>Represents item by ID of minecraft:acacia_boat.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material AcaciaBoat = new(Identifier.Minecraft("acacia_boat"));


    /// <summary>Represents item by ID of minecraft:dark_oak_boat.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DarkOakBoat = new(Identifier.Minecraft("dark_oak_boat"));


    /// <summary>Represents item by ID of minecraft:turtle_helmet.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material TurtleHelmet = new(Identifier.Minecraft("turtle_helmet"));


    /// <summary>Represents item by ID of minecraft:scute.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Scute = new(Identifier.Minecraft("scute"));


    /// <summary>Represents item by ID of minecraft:flint_and_steel.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material FlintAndSteel = new(Identifier.Minecraft("flint_and_steel"));


    /// <summary>Represents item by ID of minecraft:apple.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Apple = new(Identifier.Minecraft("apple"));


    /// <summary>Represents item by ID of minecraft:bow.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Bow = new(Identifier.Minecraft("bow"));


    /// <summary>Represents item by ID of minecraft:arrow.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Arrow = new(Identifier.Minecraft("arrow"));


    /// <summary>Represents item by ID of minecraft:coal.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Coal = new(Identifier.Minecraft("coal"));


    /// <summary>Represents item by ID of minecraft:charcoal.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Charcoal = new(Identifier.Minecraft("charcoal"));


    /// <summary>Represents item by ID of minecraft:diamond.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Diamond = new(Identifier.Minecraft("diamond"));


    /// <summary>Represents item by ID of minecraft:emerald.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Emerald = new(Identifier.Minecraft("emerald"));


    /// <summary>Represents item by ID of minecraft:lapis_lazuli.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LapisLazuli = new(Identifier.Minecraft("lapis_lazuli"));


    /// <summary>Represents item by ID of minecraft:quartz.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Quartz = new(Identifier.Minecraft("quartz"));


    /// <summary>Represents item by ID of minecraft:amethyst_shard.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material AmethystShard = new(Identifier.Minecraft("amethyst_shard"));


    /// <summary>Represents item by ID of minecraft:raw_iron.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RawIron = new(Identifier.Minecraft("raw_iron"));


    /// <summary>Represents item by ID of minecraft:iron_ingot.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material IronIngot = new(Identifier.Minecraft("iron_ingot"));


    /// <summary>Represents item by ID of minecraft:raw_copper.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RawCopper = new(Identifier.Minecraft("raw_copper"));


    /// <summary>Represents item by ID of minecraft:copper_ingot.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CopperIngot = new(Identifier.Minecraft("copper_ingot"));


    /// <summary>Represents item by ID of minecraft:raw_gold.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RawGold = new(Identifier.Minecraft("raw_gold"));


    /// <summary>Represents item by ID of minecraft:gold_ingot.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GoldIngot = new(Identifier.Minecraft("gold_ingot"));


    /// <summary>Represents item by ID of minecraft:netherite_ingot.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material NetheriteIngot = new(Identifier.Minecraft("netherite_ingot"));


    /// <summary>Represents item by ID of minecraft:netherite_scrap.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material NetheriteScrap = new(Identifier.Minecraft("netherite_scrap"));


    /// <summary>Represents item by ID of minecraft:wooden_sword.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WoodenSword = new(Identifier.Minecraft("wooden_sword"));


    /// <summary>Represents item by ID of minecraft:wooden_shovel.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WoodenShovel = new(Identifier.Minecraft("wooden_shovel"));


    /// <summary>Represents item by ID of minecraft:wooden_pickaxe.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WoodenPickaxe = new(Identifier.Minecraft("wooden_pickaxe"));


    /// <summary>Represents item by ID of minecraft:wooden_axe.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WoodenAxe = new(Identifier.Minecraft("wooden_axe"));


    /// <summary>Represents item by ID of minecraft:wooden_hoe.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WoodenHoe = new(Identifier.Minecraft("wooden_hoe"));


    /// <summary>Represents item by ID of minecraft:stone_sword.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material StoneSword = new(Identifier.Minecraft("stone_sword"));


    /// <summary>Represents item by ID of minecraft:stone_shovel.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material StoneShovel = new(Identifier.Minecraft("stone_shovel"));


    /// <summary>Represents item by ID of minecraft:stone_pickaxe.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material StonePickaxe = new(Identifier.Minecraft("stone_pickaxe"));


    /// <summary>Represents item by ID of minecraft:stone_axe.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material StoneAxe = new(Identifier.Minecraft("stone_axe"));


    /// <summary>Represents item by ID of minecraft:stone_hoe.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material StoneHoe = new(Identifier.Minecraft("stone_hoe"));


    /// <summary>Represents item by ID of minecraft:golden_sword.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GoldenSword = new(Identifier.Minecraft("golden_sword"));


    /// <summary>Represents item by ID of minecraft:golden_shovel.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GoldenShovel = new(Identifier.Minecraft("golden_shovel"));


    /// <summary>Represents item by ID of minecraft:golden_pickaxe.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GoldenPickaxe = new(Identifier.Minecraft("golden_pickaxe"));


    /// <summary>Represents item by ID of minecraft:golden_axe.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GoldenAxe = new(Identifier.Minecraft("golden_axe"));


    /// <summary>Represents item by ID of minecraft:golden_hoe.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GoldenHoe = new(Identifier.Minecraft("golden_hoe"));


    /// <summary>Represents item by ID of minecraft:iron_sword.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material IronSword = new(Identifier.Minecraft("iron_sword"));


    /// <summary>Represents item by ID of minecraft:iron_shovel.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material IronShovel = new(Identifier.Minecraft("iron_shovel"));


    /// <summary>Represents item by ID of minecraft:iron_pickaxe.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material IronPickaxe = new(Identifier.Minecraft("iron_pickaxe"));


    /// <summary>Represents item by ID of minecraft:iron_axe.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material IronAxe = new(Identifier.Minecraft("iron_axe"));


    /// <summary>Represents item by ID of minecraft:iron_hoe.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material IronHoe = new(Identifier.Minecraft("iron_hoe"));


    /// <summary>Represents item by ID of minecraft:diamond_sword.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DiamondSword = new(Identifier.Minecraft("diamond_sword"));


    /// <summary>Represents item by ID of minecraft:diamond_shovel.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DiamondShovel = new(Identifier.Minecraft("diamond_shovel"));


    /// <summary>Represents item by ID of minecraft:diamond_pickaxe.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DiamondPickaxe = new(Identifier.Minecraft("diamond_pickaxe"));


    /// <summary>Represents item by ID of minecraft:diamond_axe.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DiamondAxe = new(Identifier.Minecraft("diamond_axe"));


    /// <summary>Represents item by ID of minecraft:diamond_hoe.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DiamondHoe = new(Identifier.Minecraft("diamond_hoe"));


    /// <summary>Represents item by ID of minecraft:netherite_sword.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material NetheriteSword = new(Identifier.Minecraft("netherite_sword"));


    /// <summary>Represents item by ID of minecraft:netherite_shovel.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material NetheriteShovel = new(Identifier.Minecraft("netherite_shovel"));


    /// <summary>Represents item by ID of minecraft:netherite_pickaxe.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material NetheritePickaxe = new(Identifier.Minecraft("netherite_pickaxe"));


    /// <summary>Represents item by ID of minecraft:netherite_axe.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material NetheriteAxe = new(Identifier.Minecraft("netherite_axe"));


    /// <summary>Represents item by ID of minecraft:netherite_hoe.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material NetheriteHoe = new(Identifier.Minecraft("netherite_hoe"));


    /// <summary>Represents item by ID of minecraft:stick.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Stick = new(Identifier.Minecraft("stick"));


    /// <summary>Represents item by ID of minecraft:bowl.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Bowl = new(Identifier.Minecraft("bowl"));


    /// <summary>Represents item by ID of minecraft:mushroom_stew.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MushroomStew = new(Identifier.Minecraft("mushroom_stew"));


    /// <summary>Represents item by ID of minecraft:string.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material String = new(Identifier.Minecraft("string"));


    /// <summary>Represents item by ID of minecraft:feather.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Feather = new(Identifier.Minecraft("feather"));


    /// <summary>Represents item by ID of minecraft:gunpowder.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Gunpowder = new(Identifier.Minecraft("gunpowder"));


    /// <summary>Represents item by ID of minecraft:wheat_seeds.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WheatSeeds = new(Identifier.Minecraft("wheat_seeds"));


    /// <summary>Represents item by ID of minecraft:bread.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Bread = new(Identifier.Minecraft("bread"));


    /// <summary>Represents item by ID of minecraft:leather_helmet.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LeatherHelmet = new(Identifier.Minecraft("leather_helmet"));


    /// <summary>Represents item by ID of minecraft:leather_chestplate.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LeatherChestplate = new(Identifier.Minecraft("leather_chestplate"));


    /// <summary>Represents item by ID of minecraft:leather_leggings.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LeatherLeggings = new(Identifier.Minecraft("leather_leggings"));


    /// <summary>Represents item by ID of minecraft:leather_boots.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LeatherBoots = new(Identifier.Minecraft("leather_boots"));


    /// <summary>Represents item by ID of minecraft:chainmail_helmet.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material ChainmailHelmet = new(Identifier.Minecraft("chainmail_helmet"));


    /// <summary>Represents item by ID of minecraft:chainmail_chestplate.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material ChainmailChestplate = new(Identifier.Minecraft("chainmail_chestplate"));


    /// <summary>Represents item by ID of minecraft:chainmail_leggings.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material ChainmailLeggings = new(Identifier.Minecraft("chainmail_leggings"));


    /// <summary>Represents item by ID of minecraft:chainmail_boots.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material ChainmailBoots = new(Identifier.Minecraft("chainmail_boots"));


    /// <summary>Represents item by ID of minecraft:iron_helmet.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material IronHelmet = new(Identifier.Minecraft("iron_helmet"));


    /// <summary>Represents item by ID of minecraft:iron_chestplate.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material IronChestplate = new(Identifier.Minecraft("iron_chestplate"));


    /// <summary>Represents item by ID of minecraft:iron_leggings.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material IronLeggings = new(Identifier.Minecraft("iron_leggings"));


    /// <summary>Represents item by ID of minecraft:iron_boots.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material IronBoots = new(Identifier.Minecraft("iron_boots"));


    /// <summary>Represents item by ID of minecraft:diamond_helmet.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DiamondHelmet = new(Identifier.Minecraft("diamond_helmet"));


    /// <summary>Represents item by ID of minecraft:diamond_chestplate.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DiamondChestplate = new(Identifier.Minecraft("diamond_chestplate"));


    /// <summary>Represents item by ID of minecraft:diamond_leggings.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DiamondLeggings = new(Identifier.Minecraft("diamond_leggings"));


    /// <summary>Represents item by ID of minecraft:diamond_boots.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DiamondBoots = new(Identifier.Minecraft("diamond_boots"));


    /// <summary>Represents item by ID of minecraft:golden_helmet.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GoldenHelmet = new(Identifier.Minecraft("golden_helmet"));


    /// <summary>Represents item by ID of minecraft:golden_chestplate.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GoldenChestplate = new(Identifier.Minecraft("golden_chestplate"));


    /// <summary>Represents item by ID of minecraft:golden_leggings.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GoldenLeggings = new(Identifier.Minecraft("golden_leggings"));


    /// <summary>Represents item by ID of minecraft:golden_boots.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GoldenBoots = new(Identifier.Minecraft("golden_boots"));


    /// <summary>Represents item by ID of minecraft:netherite_helmet.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material NetheriteHelmet = new(Identifier.Minecraft("netherite_helmet"));


    /// <summary>Represents item by ID of minecraft:netherite_chestplate.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material NetheriteChestplate = new(Identifier.Minecraft("netherite_chestplate"));


    /// <summary>Represents item by ID of minecraft:netherite_leggings.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material NetheriteLeggings = new(Identifier.Minecraft("netherite_leggings"));


    /// <summary>Represents item by ID of minecraft:netherite_boots.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material NetheriteBoots = new(Identifier.Minecraft("netherite_boots"));


    /// <summary>Represents item by ID of minecraft:flint.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Flint = new(Identifier.Minecraft("flint"));


    /// <summary>Represents item by ID of minecraft:porkchop.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Porkchop = new(Identifier.Minecraft("porkchop"));


    /// <summary>Represents item by ID of minecraft:cooked_porkchop.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CookedPorkchop = new(Identifier.Minecraft("cooked_porkchop"));


    /// <summary>Represents item by ID of minecraft:painting.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Painting = new(Identifier.Minecraft("painting"));


    /// <summary>Represents item by ID of minecraft:golden_apple.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GoldenApple = new(Identifier.Minecraft("golden_apple"));


    /// <summary>Represents item by ID of minecraft:enchanted_golden_apple.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material EnchantedGoldenApple = new(Identifier.Minecraft("enchanted_golden_apple"));


    /// <summary>Represents item by ID of minecraft:bucket.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Bucket = new(Identifier.Minecraft("bucket"));


    /// <summary>Represents item by ID of minecraft:water_bucket.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WaterBucket = new(Identifier.Minecraft("water_bucket"));


    /// <summary>Represents item by ID of minecraft:lava_bucket.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LavaBucket = new(Identifier.Minecraft("lava_bucket"));


    /// <summary>Represents item by ID of minecraft:powder_snow_bucket.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PowderSnowBucket = new(Identifier.Minecraft("powder_snow_bucket"));


    /// <summary>Represents item by ID of minecraft:snowball.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Snowball = new(Identifier.Minecraft("snowball"));


    /// <summary>Represents item by ID of minecraft:leather.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Leather = new(Identifier.Minecraft("leather"));


    /// <summary>Represents item by ID of minecraft:milk_bucket.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MilkBucket = new(Identifier.Minecraft("milk_bucket"));


    /// <summary>Represents item by ID of minecraft:pufferfish_bucket.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PufferfishBucket = new(Identifier.Minecraft("pufferfish_bucket"));


    /// <summary>Represents item by ID of minecraft:salmon_bucket.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SalmonBucket = new(Identifier.Minecraft("salmon_bucket"));


    /// <summary>Represents item by ID of minecraft:cod_bucket.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CodBucket = new(Identifier.Minecraft("cod_bucket"));


    /// <summary>Represents item by ID of minecraft:tropical_fish_bucket.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material TropicalFishBucket = new(Identifier.Minecraft("tropical_fish_bucket"));


    /// <summary>Represents item by ID of minecraft:axolotl_bucket.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material AxolotlBucket = new(Identifier.Minecraft("axolotl_bucket"));


    /// <summary>Represents item by ID of minecraft:brick.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Brick = new(Identifier.Minecraft("brick"));


    /// <summary>Represents item by ID of minecraft:clay_ball.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material ClayBall = new(Identifier.Minecraft("clay_ball"));


    /// <summary>Represents item by ID of minecraft:paper.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Paper = new(Identifier.Minecraft("paper"));


    /// <summary>Represents item by ID of minecraft:book.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Book = new(Identifier.Minecraft("book"));


    /// <summary>Represents item by ID of minecraft:slime_ball.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SlimeBall = new(Identifier.Minecraft("slime_ball"));


    /// <summary>Represents item by ID of minecraft:egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Egg = new(Identifier.Minecraft("egg"));


    /// <summary>Represents item by ID of minecraft:compass.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Compass = new(Identifier.Minecraft("compass"));


    /// <summary>Represents item by ID of minecraft:bundle.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Bundle = new(Identifier.Minecraft("bundle"));


    /// <summary>Represents item by ID of minecraft:fishing_rod.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material FishingRod = new(Identifier.Minecraft("fishing_rod"));


    /// <summary>Represents item by ID of minecraft:clock.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Clock = new(Identifier.Minecraft("clock"));


    /// <summary>Represents item by ID of minecraft:spyglass.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Spyglass = new(Identifier.Minecraft("spyglass"));


    /// <summary>Represents item by ID of minecraft:glowstone_dust.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GlowstoneDust = new(Identifier.Minecraft("glowstone_dust"));


    /// <summary>Represents item by ID of minecraft:cod.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Cod = new(Identifier.Minecraft("cod"));


    /// <summary>Represents item by ID of minecraft:salmon.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Salmon = new(Identifier.Minecraft("salmon"));


    /// <summary>Represents item by ID of minecraft:tropical_fish.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material TropicalFish = new(Identifier.Minecraft("tropical_fish"));


    /// <summary>Represents item by ID of minecraft:pufferfish.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Pufferfish = new(Identifier.Minecraft("pufferfish"));


    /// <summary>Represents item by ID of minecraft:cooked_cod.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CookedCod = new(Identifier.Minecraft("cooked_cod"));


    /// <summary>Represents item by ID of minecraft:cooked_salmon.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CookedSalmon = new(Identifier.Minecraft("cooked_salmon"));


    /// <summary>Represents item by ID of minecraft:ink_sac.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material InkSac = new(Identifier.Minecraft("ink_sac"));


    /// <summary>Represents item by ID of minecraft:glow_ink_sac.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GlowInkSac = new(Identifier.Minecraft("glow_ink_sac"));


    /// <summary>Represents item by ID of minecraft:cocoa_beans.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CocoaBeans = new(Identifier.Minecraft("cocoa_beans"), typeof(CocoaBeans));


    /// <summary>Represents item by ID of minecraft:white_dye.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WhiteDye = new(Identifier.Minecraft("white_dye"));


    /// <summary>Represents item by ID of minecraft:orange_dye.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material OrangeDye = new(Identifier.Minecraft("orange_dye"));


    /// <summary>Represents item by ID of minecraft:magenta_dye.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MagentaDye = new(Identifier.Minecraft("magenta_dye"));


    /// <summary>Represents item by ID of minecraft:light_blue_dye.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LightBlueDye = new(Identifier.Minecraft("light_blue_dye"));


    /// <summary>Represents item by ID of minecraft:yellow_dye.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material YellowDye = new(Identifier.Minecraft("yellow_dye"));


    /// <summary>Represents item by ID of minecraft:lime_dye.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LimeDye = new(Identifier.Minecraft("lime_dye"));


    /// <summary>Represents item by ID of minecraft:pink_dye.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PinkDye = new(Identifier.Minecraft("pink_dye"));


    /// <summary>Represents item by ID of minecraft:gray_dye.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GrayDye = new(Identifier.Minecraft("gray_dye"));


    /// <summary>Represents item by ID of minecraft:light_gray_dye.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LightGrayDye = new(Identifier.Minecraft("light_gray_dye"));


    /// <summary>Represents item by ID of minecraft:cyan_dye.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CyanDye = new(Identifier.Minecraft("cyan_dye"));


    /// <summary>Represents item by ID of minecraft:purple_dye.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PurpleDye = new(Identifier.Minecraft("purple_dye"));


    /// <summary>Represents item by ID of minecraft:blue_dye.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BlueDye = new(Identifier.Minecraft("blue_dye"));


    /// <summary>Represents item by ID of minecraft:brown_dye.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BrownDye = new(Identifier.Minecraft("brown_dye"));


    /// <summary>Represents item by ID of minecraft:green_dye.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GreenDye = new(Identifier.Minecraft("green_dye"));


    /// <summary>Represents item by ID of minecraft:red_dye.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RedDye = new(Identifier.Minecraft("red_dye"));


    /// <summary>Represents item by ID of minecraft:black_dye.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BlackDye = new(Identifier.Minecraft("black_dye"));


    /// <summary>Represents item by ID of minecraft:bone_meal.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BoneMeal = new(Identifier.Minecraft("bone_meal"));


    /// <summary>Represents item by ID of minecraft:bone.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Bone = new(Identifier.Minecraft("bone"));


    /// <summary>Represents item by ID of minecraft:sugar.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Sugar = new(Identifier.Minecraft("sugar"));


    /// <summary>Represents item by ID of minecraft:cookie.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Cookie = new(Identifier.Minecraft("cookie"));


    /// <summary>Represents item by ID of minecraft:filled_map.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material FilledMap = new(Identifier.Minecraft("filled_map"));


    /// <summary>Represents item by ID of minecraft:shears.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Shears = new(Identifier.Minecraft("shears"));


    /// <summary>Represents item by ID of minecraft:melon_slice.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MelonSlice = new(Identifier.Minecraft("melon_slice"));


    /// <summary>Represents item by ID of minecraft:dried_kelp.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DriedKelp = new(Identifier.Minecraft("dried_kelp"));


    /// <summary>Represents item by ID of minecraft:pumpkin_seeds.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PumpkinSeeds = new(Identifier.Minecraft("pumpkin_seeds"));


    /// <summary>Represents item by ID of minecraft:melon_seeds.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MelonSeeds = new(Identifier.Minecraft("melon_seeds"));


    /// <summary>Represents item by ID of minecraft:beef.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Beef = new(Identifier.Minecraft("beef"));


    /// <summary>Represents item by ID of minecraft:cooked_beef.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CookedBeef = new(Identifier.Minecraft("cooked_beef"));


    /// <summary>Represents item by ID of minecraft:chicken.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Chicken = new(Identifier.Minecraft("chicken"));


    /// <summary>Represents item by ID of minecraft:cooked_chicken.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CookedChicken = new(Identifier.Minecraft("cooked_chicken"));


    /// <summary>Represents item by ID of minecraft:rotten_flesh.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RottenFlesh = new(Identifier.Minecraft("rotten_flesh"));


    /// <summary>Represents item by ID of minecraft:ender_pearl.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material EnderPearl = new(Identifier.Minecraft("ender_pearl"));


    /// <summary>Represents item by ID of minecraft:blaze_rod.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BlazeRod = new(Identifier.Minecraft("blaze_rod"));


    /// <summary>Represents item by ID of minecraft:ghast_tear.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GhastTear = new(Identifier.Minecraft("ghast_tear"));


    /// <summary>Represents item by ID of minecraft:gold_nugget.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GoldNugget = new(Identifier.Minecraft("gold_nugget"));


    /// <summary>Represents item by ID of minecraft:potion.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Potion = new(Identifier.Minecraft("potion"));


    /// <summary>Represents item by ID of minecraft:glass_bottle.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GlassBottle = new(Identifier.Minecraft("glass_bottle"));


    /// <summary>Represents item by ID of minecraft:spider_eye.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SpiderEye = new(Identifier.Minecraft("spider_eye"));


    /// <summary>Represents item by ID of minecraft:fermented_spider_eye.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material FermentedSpiderEye = new(Identifier.Minecraft("fermented_spider_eye"));


    /// <summary>Represents item by ID of minecraft:blaze_powder.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BlazePowder = new(Identifier.Minecraft("blaze_powder"));


    /// <summary>Represents item by ID of minecraft:magma_cream.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MagmaCream = new(Identifier.Minecraft("magma_cream"));


    /// <summary>Represents item by ID of minecraft:ender_eye.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material EnderEye = new(Identifier.Minecraft("ender_eye"));


    /// <summary>Represents item by ID of minecraft:glistering_melon_slice.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GlisteringMelonSlice = new(Identifier.Minecraft("glistering_melon_slice"));


    /// <summary>Represents item by ID of minecraft:axolotl_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material AxolotlSpawnEgg = new(Identifier.Minecraft("axolotl_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:bat_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BatSpawnEgg = new(Identifier.Minecraft("bat_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:bee_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BeeSpawnEgg = new(Identifier.Minecraft("bee_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:blaze_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BlazeSpawnEgg = new(Identifier.Minecraft("blaze_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:cat_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CatSpawnEgg = new(Identifier.Minecraft("cat_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:cave_spider_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CaveSpiderSpawnEgg = new(Identifier.Minecraft("cave_spider_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:chicken_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material ChickenSpawnEgg = new(Identifier.Minecraft("chicken_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:cod_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CodSpawnEgg = new(Identifier.Minecraft("cod_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:cow_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CowSpawnEgg = new(Identifier.Minecraft("cow_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:creeper_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CreeperSpawnEgg = new(Identifier.Minecraft("creeper_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:dolphin_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DolphinSpawnEgg = new(Identifier.Minecraft("dolphin_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:donkey_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DonkeySpawnEgg = new(Identifier.Minecraft("donkey_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:drowned_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DrownedSpawnEgg = new(Identifier.Minecraft("drowned_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:elder_guardian_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material ElderGuardianSpawnEgg = new(Identifier.Minecraft("elder_guardian_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:enderman_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material EndermanSpawnEgg = new(Identifier.Minecraft("enderman_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:endermite_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material EndermiteSpawnEgg = new(Identifier.Minecraft("endermite_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:evoker_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material EvokerSpawnEgg = new(Identifier.Minecraft("evoker_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:fox_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material FoxSpawnEgg = new(Identifier.Minecraft("fox_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:ghast_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GhastSpawnEgg = new(Identifier.Minecraft("ghast_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:glow_squid_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GlowSquidSpawnEgg = new(Identifier.Minecraft("glow_squid_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:goat_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GoatSpawnEgg = new(Identifier.Minecraft("goat_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:guardian_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GuardianSpawnEgg = new(Identifier.Minecraft("guardian_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:hoglin_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material HoglinSpawnEgg = new(Identifier.Minecraft("hoglin_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:horse_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material HorseSpawnEgg = new(Identifier.Minecraft("horse_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:husk_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material HuskSpawnEgg = new(Identifier.Minecraft("husk_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:llama_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LlamaSpawnEgg = new(Identifier.Minecraft("llama_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:magma_cube_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MagmaCubeSpawnEgg = new(Identifier.Minecraft("magma_cube_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:mooshroom_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MooshroomSpawnEgg = new(Identifier.Minecraft("mooshroom_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:mule_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MuleSpawnEgg = new(Identifier.Minecraft("mule_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:ocelot_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material OcelotSpawnEgg = new(Identifier.Minecraft("ocelot_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:panda_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PandaSpawnEgg = new(Identifier.Minecraft("panda_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:parrot_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material ParrotSpawnEgg = new(Identifier.Minecraft("parrot_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:phantom_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PhantomSpawnEgg = new(Identifier.Minecraft("phantom_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:pig_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PigSpawnEgg = new(Identifier.Minecraft("pig_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:piglin_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PiglinSpawnEgg = new(Identifier.Minecraft("piglin_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:piglin_brute_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PiglinBruteSpawnEgg = new(Identifier.Minecraft("piglin_brute_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:pillager_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PillagerSpawnEgg = new(Identifier.Minecraft("pillager_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:polar_bear_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PolarBearSpawnEgg = new(Identifier.Minecraft("polar_bear_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:pufferfish_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PufferfishSpawnEgg = new(Identifier.Minecraft("pufferfish_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:rabbit_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RabbitSpawnEgg = new(Identifier.Minecraft("rabbit_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:ravager_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RavagerSpawnEgg = new(Identifier.Minecraft("ravager_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:salmon_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SalmonSpawnEgg = new(Identifier.Minecraft("salmon_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:sheep_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SheepSpawnEgg = new(Identifier.Minecraft("sheep_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:shulker_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material ShulkerSpawnEgg = new(Identifier.Minecraft("shulker_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:silverfish_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SilverfishSpawnEgg = new(Identifier.Minecraft("silverfish_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:skeleton_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SkeletonSpawnEgg = new(Identifier.Minecraft("skeleton_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:skeleton_horse_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SkeletonHorseSpawnEgg = new(Identifier.Minecraft("skeleton_horse_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:slime_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SlimeSpawnEgg = new(Identifier.Minecraft("slime_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:spider_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SpiderSpawnEgg = new(Identifier.Minecraft("spider_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:squid_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SquidSpawnEgg = new(Identifier.Minecraft("squid_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:stray_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material StraySpawnEgg = new(Identifier.Minecraft("stray_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:strider_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material StriderSpawnEgg = new(Identifier.Minecraft("strider_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:trader_llama_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material TraderLlamaSpawnEgg = new(Identifier.Minecraft("trader_llama_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:tropical_fish_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material TropicalFishSpawnEgg = new(Identifier.Minecraft("tropical_fish_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:turtle_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material TurtleSpawnEgg = new(Identifier.Minecraft("turtle_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:vex_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material VexSpawnEgg = new(Identifier.Minecraft("vex_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:villager_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material VillagerSpawnEgg = new(Identifier.Minecraft("villager_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:vindicator_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material VindicatorSpawnEgg = new(Identifier.Minecraft("vindicator_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:wandering_trader_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WanderingTraderSpawnEgg = new(Identifier.Minecraft("wandering_trader_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:witch_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WitchSpawnEgg = new(Identifier.Minecraft("witch_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:wither_skeleton_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WitherSkeletonSpawnEgg = new(Identifier.Minecraft("wither_skeleton_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:wolf_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WolfSpawnEgg = new(Identifier.Minecraft("wolf_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:zoglin_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material ZoglinSpawnEgg = new(Identifier.Minecraft("zoglin_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:zombie_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material ZombieSpawnEgg = new(Identifier.Minecraft("zombie_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:zombie_horse_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material ZombieHorseSpawnEgg = new(Identifier.Minecraft("zombie_horse_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:zombie_villager_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material ZombieVillagerSpawnEgg = new(Identifier.Minecraft("zombie_villager_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:zombified_piglin_spawn_egg.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material ZombifiedPiglinSpawnEgg = new(Identifier.Minecraft("zombified_piglin_spawn_egg"));


    /// <summary>Represents item by ID of minecraft:experience_bottle.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material ExperienceBottle = new(Identifier.Minecraft("experience_bottle"));


    /// <summary>Represents item by ID of minecraft:fire_charge.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material FireCharge = new(Identifier.Minecraft("fire_charge"));


    /// <summary>Represents item by ID of minecraft:writable_book.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WritableBook = new(Identifier.Minecraft("writable_book"));


    /// <summary>Represents item by ID of minecraft:written_book.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material WrittenBook = new(Identifier.Minecraft("written_book"));


    /// <summary>Represents item by ID of minecraft:item_frame.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material ItemFrame = new(Identifier.Minecraft("item_frame"));


    /// <summary>Represents item by ID of minecraft:glow_item_frame.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GlowItemFrame = new(Identifier.Minecraft("glow_item_frame"));


    /// <summary>Represents item by ID of minecraft:carrot.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Carrot = new(Identifier.Minecraft("carrot"));


    /// <summary>Represents item by ID of minecraft:potato.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Potato = new(Identifier.Minecraft("potato"));


    /// <summary>Represents item by ID of minecraft:baked_potato.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BakedPotato = new(Identifier.Minecraft("baked_potato"));


    /// <summary>Represents item by ID of minecraft:poisonous_potato.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PoisonousPotato = new(Identifier.Minecraft("poisonous_potato"));


    /// <summary>Represents item by ID of minecraft:map.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Map = new(Identifier.Minecraft("map"));


    /// <summary>Represents item by ID of minecraft:golden_carrot.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GoldenCarrot = new(Identifier.Minecraft("golden_carrot"));


    /// <summary>Represents item by ID of minecraft:nether_star.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material NetherStar = new(Identifier.Minecraft("nether_star"));


    /// <summary>Represents item by ID of minecraft:pumpkin_pie.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PumpkinPie = new(Identifier.Minecraft("pumpkin_pie"));


    /// <summary>Represents item by ID of minecraft:firework_rocket.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material FireworkRocket = new(Identifier.Minecraft("firework_rocket"));


    /// <summary>Represents item by ID of minecraft:firework_star.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material FireworkStar = new(Identifier.Minecraft("firework_star"));


    /// <summary>Represents item by ID of minecraft:enchanted_book.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material EnchantedBook = new(Identifier.Minecraft("enchanted_book"));


    /// <summary>Represents item by ID of minecraft:nether_brick.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material NetherBrick = new(Identifier.Minecraft("nether_brick"));


    /// <summary>Represents item by ID of minecraft:prismarine_shard.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PrismarineShard = new(Identifier.Minecraft("prismarine_shard"));


    /// <summary>Represents item by ID of minecraft:prismarine_crystals.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PrismarineCrystals = new(Identifier.Minecraft("prismarine_crystals"));


    /// <summary>Represents item by ID of minecraft:rabbit.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Rabbit = new(Identifier.Minecraft("rabbit"));


    /// <summary>Represents item by ID of minecraft:cooked_rabbit.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CookedRabbit = new(Identifier.Minecraft("cooked_rabbit"));


    /// <summary>Represents item by ID of minecraft:rabbit_stew.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RabbitStew = new(Identifier.Minecraft("rabbit_stew"));


    /// <summary>Represents item by ID of minecraft:rabbit_foot.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RabbitFoot = new(Identifier.Minecraft("rabbit_foot"));


    /// <summary>Represents item by ID of minecraft:rabbit_hide.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material RabbitHide = new(Identifier.Minecraft("rabbit_hide"));


    /// <summary>Represents item by ID of minecraft:armor_stand.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material ArmorStand = new(Identifier.Minecraft("armor_stand"));


    /// <summary>Represents item by ID of minecraft:iron_horse_armor.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material IronHorseArmor = new(Identifier.Minecraft("iron_horse_armor"));


    /// <summary>Represents item by ID of minecraft:golden_horse_armor.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GoldenHorseArmor = new(Identifier.Minecraft("golden_horse_armor"));


    /// <summary>Represents item by ID of minecraft:diamond_horse_armor.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DiamondHorseArmor = new(Identifier.Minecraft("diamond_horse_armor"));


    /// <summary>Represents item by ID of minecraft:leather_horse_armor.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LeatherHorseArmor = new(Identifier.Minecraft("leather_horse_armor"));


    /// <summary>Represents item by ID of minecraft:lead.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Lead = new(Identifier.Minecraft("lead"));


    /// <summary>Represents item by ID of minecraft:name_tag.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material NameTag = new(Identifier.Minecraft("name_tag"));


    /// <summary>Represents item by ID of minecraft:command_block_minecart.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CommandBlockMinecart = new(Identifier.Minecraft("command_block_minecart"));


    /// <summary>Represents item by ID of minecraft:mutton.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Mutton = new(Identifier.Minecraft("mutton"));


    /// <summary>Represents item by ID of minecraft:cooked_mutton.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CookedMutton = new(Identifier.Minecraft("cooked_mutton"));


    /// <summary>Represents item by ID of minecraft:end_crystal.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material EndCrystal = new(Identifier.Minecraft("end_crystal"));


    /// <summary>Represents item by ID of minecraft:chorus_fruit.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material ChorusFruit = new(Identifier.Minecraft("chorus_fruit"));


    /// <summary>Represents item by ID of minecraft:popped_chorus_fruit.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PoppedChorusFruit = new(Identifier.Minecraft("popped_chorus_fruit"));


    /// <summary>Represents item by ID of minecraft:beetroot.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Beetroot = new(Identifier.Minecraft("beetroot"));


    /// <summary>Represents item by ID of minecraft:beetroot_seeds.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BeetrootSeeds = new(Identifier.Minecraft("beetroot_seeds"));


    /// <summary>Represents item by ID of minecraft:beetroot_soup.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material BeetrootSoup = new(Identifier.Minecraft("beetroot_soup"));


    /// <summary>Represents item by ID of minecraft:dragon_breath.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DragonBreath = new(Identifier.Minecraft("dragon_breath"));


    /// <summary>Represents item by ID of minecraft:splash_potion.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SplashPotion = new(Identifier.Minecraft("splash_potion"));


    /// <summary>Represents item by ID of minecraft:spectral_arrow.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SpectralArrow = new(Identifier.Minecraft("spectral_arrow"));


    /// <summary>Represents item by ID of minecraft:tipped_arrow.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material TippedArrow = new(Identifier.Minecraft("tipped_arrow"));


    /// <summary>Represents item by ID of minecraft:lingering_potion.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material LingeringPotion = new(Identifier.Minecraft("lingering_potion"));


    /// <summary>Represents item by ID of minecraft:shield.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Shield = new(Identifier.Minecraft("shield"));


    /// <summary>Represents item by ID of minecraft:totem_of_undying.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material TotemOfUndying = new(Identifier.Minecraft("totem_of_undying"));


    /// <summary>Represents item by ID of minecraft:shulker_shell.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material ShulkerShell = new(Identifier.Minecraft("shulker_shell"));


    /// <summary>Represents item by ID of minecraft:iron_nugget.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material IronNugget = new(Identifier.Minecraft("iron_nugget"));


    /// <summary>Represents item by ID of minecraft:knowledge_book.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material KnowledgeBook = new(Identifier.Minecraft("knowledge_book"));


    /// <summary>Represents item by ID of minecraft:debug_stick.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material DebugStick = new(Identifier.Minecraft("debug_stick"));


    /// <summary>Represents item by ID of minecraft:music_disc13.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MusicDisc13 = new(Identifier.Minecraft("music_disc13"));


    /// <summary>Represents item by ID of minecraft:music_disc_cat.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MusicDiscCat = new(Identifier.Minecraft("music_disc_cat"));


    /// <summary>Represents item by ID of minecraft:music_disc_blocks.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MusicDiscBlocks = new(Identifier.Minecraft("music_disc_blocks"));


    /// <summary>Represents item by ID of minecraft:music_disc_chirp.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MusicDiscChirp = new(Identifier.Minecraft("music_disc_chirp"));


    /// <summary>Represents item by ID of minecraft:music_disc_far.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MusicDiscFar = new(Identifier.Minecraft("music_disc_far"));


    /// <summary>Represents item by ID of minecraft:music_disc_mall.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MusicDiscMall = new(Identifier.Minecraft("music_disc_mall"));


    /// <summary>Represents item by ID of minecraft:music_disc_mellohi.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MusicDiscMellohi = new(Identifier.Minecraft("music_disc_mellohi"));


    /// <summary>Represents item by ID of minecraft:music_disc_stal.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MusicDiscStal = new(Identifier.Minecraft("music_disc_stal"));


    /// <summary>Represents item by ID of minecraft:music_disc_strad.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MusicDiscStrad = new(Identifier.Minecraft("music_disc_strad"));


    /// <summary>Represents item by ID of minecraft:music_disc_ward.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MusicDiscWard = new(Identifier.Minecraft("music_disc_ward"));


    /// <summary>Represents item by ID of minecraft:music_disc11.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MusicDisc11 = new(Identifier.Minecraft("music_disc11"));


    /// <summary>Represents item by ID of minecraft:music_disc_wait.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MusicDiscWait = new(Identifier.Minecraft("music_disc_wait"));


    /// <summary>Represents item by ID of minecraft:music_disc_otherside.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MusicDiscOtherside = new(Identifier.Minecraft("music_disc_otherside"));


    /// <summary>Represents item by ID of minecraft:music_disc_pigstep.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MusicDiscPigstep = new(Identifier.Minecraft("music_disc_pigstep"));


    /// <summary>Represents item by ID of minecraft:trident.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Trident = new(Identifier.Minecraft("trident"));


    /// <summary>Represents item by ID of minecraft:phantom_membrane.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PhantomMembrane = new(Identifier.Minecraft("phantom_membrane"));


    /// <summary>Represents item by ID of minecraft:nautilus_shell.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material NautilusShell = new(Identifier.Minecraft("nautilus_shell"));


    /// <summary>Represents item by ID of minecraft:heart_of_the_sea.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material HeartOfTheSea = new(Identifier.Minecraft("heart_of_the_sea"));


    /// <summary>Represents item by ID of minecraft:crossbow.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Crossbow = new(Identifier.Minecraft("crossbow"));


    /// <summary>Represents item by ID of minecraft:suspicious_stew.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SuspiciousStew = new(Identifier.Minecraft("suspicious_stew"));


    /// <summary>Represents item by ID of minecraft:flower_banner_pattern.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material FlowerBannerPattern = new(Identifier.Minecraft("flower_banner_pattern"));


    /// <summary>Represents item by ID of minecraft:creeper_banner_pattern.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material CreeperBannerPattern = new(Identifier.Minecraft("creeper_banner_pattern"));


    /// <summary>Represents item by ID of minecraft:skull_banner_pattern.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SkullBannerPattern = new(Identifier.Minecraft("skull_banner_pattern"));


    /// <summary>Represents item by ID of minecraft:mojang_banner_pattern.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material MojangBannerPattern = new(Identifier.Minecraft("mojang_banner_pattern"));


    /// <summary>Represents item by ID of minecraft:globe_banner_pattern.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GlobeBannerPattern = new(Identifier.Minecraft("globe_banner_pattern"));


    /// <summary>Represents item by ID of minecraft:piglin_banner_pattern.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material PiglinBannerPattern = new(Identifier.Minecraft("piglin_banner_pattern"));


    /// <summary>Represents item by ID of minecraft:sweet_berries.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material SweetBerries = new(Identifier.Minecraft("sweet_berries"));


    /// <summary>Represents item by ID of minecraft:glow_berries.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material GlowBerries = new(Identifier.Minecraft("glow_berries"));


    /// <summary>Represents item by ID of minecraft:honeycomb.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material Honeycomb = new(Identifier.Minecraft("honeycomb"));


    /// <summary>Represents item by ID of minecraft:honey_bottle.</summary>
    /// <remarks>This material constant is <b>Auto-Generated</b>!</remarks>
    public static readonly Material HoneyBottle = new(Identifier.Minecraft("honey_bottle"));
}