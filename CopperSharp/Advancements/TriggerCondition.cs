using CopperSharp.Advancements.Predicates;
using CopperSharp.Advancements.Triggers;
using CopperSharp.Utils;
using Newtonsoft.Json;

namespace CopperSharp.Advancements;

/// <summary>
///     Represents a condition of an advancement trigger
/// </summary>
public abstract class TriggerCondition
{
    /// <summary>
    ///     Extra ranges to be stored
    /// </summary>
    protected Dictionary<string, StrictRange> Ranges { get; set; } = new();

    /// <summary>
    ///     Extra data for this trigger condition
    /// </summary>
    protected Dictionary<string, object> Data { get; set; } = new();

    /// <summary>
    ///     Extra item slots to be used
    /// </summary>
    protected Dictionary<string, ItemPredicate> Items { get; set; } = new();

    /// <summary>
    ///     Extra entity slots to be used
    /// </summary>
    protected Dictionary<string, EntityPredicate> Entities { get; set; } = new();

    /// <summary>
    ///     Extra location slots to be used
    /// </summary>
    protected Dictionary<string, LocationPredicate> Locations { get; set; } = new();

    /// <summary>
    ///     Extra location slots to be used
    /// </summary>
    protected Dictionary<string, DistancePredicate> Distances { get; set; } = new();

    /// <summary>
    ///     Player data inside this trigger
    /// </summary>
    protected EntityPredicate? PlayerData { get; set; }

    /// <inheritdoc cref="Triggers.BeeNestDestroyed" />
    public static BeeNestDestroyed BeeNestDestroyed => new();

    /// <inheritdoc cref="Triggers.BredAnimals" />
    public static BredAnimals BreedAnimals => new();

    /// <inheritdoc cref="Triggers.BrewedPotion" />
    public static BrewedPotion BrewPotion => new();

    /// <inheritdoc cref="Triggers.ChangedDimension" />
    public static ChangedDimension ChangeDimension => new();

    /// <inheritdoc cref="Triggers.ChanneledLightning" />
    public static ChanneledLightning ChannelLightning => new();

    /// <inheritdoc cref="Triggers.ConstructBeacon" />
    public static ConstructBeacon ConstructBeacon => new();

    /// <inheritdoc cref="Triggers.ConsumeItem" />
    public static ConsumeItem ConsumeItem => new();

    /// <inheritdoc cref="Triggers.CuredZombieVillager" />
    public static CuredZombieVillager CureZombieVillager => new();

    /// <inheritdoc cref="Triggers.EffectChanged" />
    public static EffectChanged EffectChanged => new();

    /// <inheritdoc cref="Triggers.EnchantedItem" />
    public static EnchantedItem EnchantItem => new();

    /// <inheritdoc cref="Triggers.EnterBlock" />
    public static EnterBlock EnterBlock => new();

    /// <inheritdoc cref="Triggers.EntityDamagePlayer" />
    public static EntityDamagePlayer EntityDamagePlayer => new();

    /// <inheritdoc cref="Triggers.EntityKillPlayer" />
    public static EntityKillPlayer EntityKillPlayer => new();

    /// <inheritdoc cref="Triggers.EntityPickUpItem" />
    public static EntityPickUpItem EntityPickUpItem => new();

    /// <inheritdoc cref="Triggers.FallFromHeight" />
    public static FallFromHeight FallFromHeight => new();

    /// <inheritdoc cref="Triggers.FilledBucket" />
    public static FilledBucket FillBucket => new();

    /// <inheritdoc cref="Triggers.FishingRodHooked" />
    public static FishingRodHooked FishingRodHooked => new();

    /// <inheritdoc cref="Triggers.HeroOfTheVillage" />
    public static HeroOfTheVillage WinRaid => new();

    /// <inheritdoc cref="Triggers.InventoryChanged" />
    public static InventoryChanged InventoryChange => new();

    /// <inheritdoc cref="Triggers.ItemDurabilityChanged" />
    public static ItemDurabilityChanged ItemDurabilityChange => new();

    /// <inheritdoc cref="Triggers.ItemUsedOnBlock" />
    public static ItemUsedOnBlock ItemUseOnBlock => new();

    /// <inheritdoc cref="Triggers.KilledByCrossbow" />
    public static KilledByCrossbow KillByCrossbow => new();

    /// <inheritdoc cref="Triggers.LevitationTrigger" />
    public static LevitationTrigger Levitate => new();

    /// <inheritdoc cref="Triggers.LightningStrikeTrigger" />
    public static LightningStrikeTrigger LightningStrike => new();

    /// <inheritdoc cref="Triggers.LocationTrigger" />
    public static LocationTrigger Location => new();

    /// <inheritdoc cref="Triggers.NetherTravel" />
    public static NetherTravel NetherTravel => new();

    /// <inheritdoc cref="Triggers.NullTrigger" />
    public static NullTrigger Impossible => new();

    /// <inheritdoc cref="Triggers.PlacedBlock" />
    public static PlacedBlock PlaceBlock => new();

    /// <inheritdoc cref="Triggers.PlayerDamageEntity" />
    public static PlayerDamageEntity PlayerDamageEntity => new();

    /// <inheritdoc cref="Triggers.PlayerGenerateLoot" />
    public static PlayerGenerateLoot PlayerGenerateLoot => new();

    /// <inheritdoc cref="Triggers.PlayerInteractEntity" />
    public static PlayerInteractEntity PlayerInteractEntity => new();

    /// <inheritdoc cref="Triggers.PlayerKillEntity" />
    public static PlayerKillEntity PlayerKillEntity => new();

    /// <inheritdoc cref="Triggers.RecipeUnlocked" />
    public static RecipeUnlocked UnlockRecipe => new();

    /// <inheritdoc cref="Triggers.ShotCrossbow" />
    public static ShotCrossbow ShotCrossbow => new();

    /// <inheritdoc cref="Triggers.SleptInBed" />
    public static SleptInBed SleepInBed => new();

    /// <inheritdoc cref="Triggers.SlideDownBlock" />
    public static SlideDownBlock SlideDownBlock => new();

    /// <inheritdoc cref="Triggers.StartedRiding" />
    public static StartedRiding StartRiding => new();

    /// <inheritdoc cref="Triggers.SummonedEntity" />
    public static SummonedEntity SummonEntity => new();

    /// <inheritdoc cref="Triggers.TameAnimal" />
    public static TameAnimal TameAnimal => new();

    /// <inheritdoc cref="Triggers.TargetHit" />
    public static TargetHit HitTargetBlock => new();

    /// <inheritdoc cref="Triggers.TickTrigger" />
    public static TickTrigger Tick => new();

    /// <inheritdoc cref="Triggers.UsedEnderEye" />
    public static UsedEnderEye UseEnderEye => new();

    /// <inheritdoc cref="Triggers.UsedTotem" />
    public static UsedTotem UseTotem => new();

    /// <inheritdoc cref="Triggers.UsingItem" />
    public static UsingItem UseItem => new();

    /// <inheritdoc cref="Triggers.VillagerTradeComplete" />
    public static VillagerTradeComplete CompleteVillagerTrade => new();

    /// <inheritdoc cref="Triggers.VoluntaryExileTrigger" />
    public static VoluntaryExileTrigger StartRaid => new();

    /// <summary>
    ///     Makes this trigger require certain player data
    /// </summary>
    /// <param name="player">Player data to be used</param>
    /// <returns>This trigger condition</returns>
    public TriggerCondition RequirePlayer(EntityPredicate player)
    {
        PlayerData = player;
        return this;
    }

    /// <summary>
    ///     Writes extra data to the text writer
    /// </summary>
    /// <param name="w">Writer to which to write data</param>
    protected virtual async Task SerializeExtra(JsonTextWriter w)
    {
        await Task.CompletedTask;
    }

    /// <summary>
    ///     Serializes this condition into provided json text writer
    /// </summary>
    /// <param name="w">Writer into which to write all data</param>
    public async Task SerializeInto(JsonTextWriter w)
    {
        await w.WriteStartObjectAsync();
        if (!Data.Any())
        {
            await w.WriteEndObjectAsync();
            return;
        }

        foreach (var (key, value) in Data)
        {
            await w.WritePropertyNameAsync(key);
            await w.WriteValueAsync(value);
        }

        foreach (var (key, value) in Items)
        {
            await w.WritePropertyNameAsync(key);
            await value.SerializeInto(w);
        }

        foreach (var (key, value) in Entities)
        {
            await w.WritePropertyNameAsync(key);
            await value.SerializeInto(w);
        }

        foreach (var (key, value) in Locations)
        {
            await w.WritePropertyNameAsync(key);
            await value.SerializeInto(w);
        }

        foreach (var (key, value) in Ranges) await value.SerializeInto(w, key);

        foreach (var (key, value) in Distances)
        {
            await w.WritePropertyNameAsync(key);
            await value.SerializeInto(w);
        }

        if (PlayerData != null)
        {
            await w.WritePropertyNameAsync("player");
            await (PlayerData?.SerializeInto(w) ?? Task.CompletedTask);
        }

        await SerializeExtra(w);

        await w.WriteEndObjectAsync();
    }
}