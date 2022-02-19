using CopperSharp.Blocks.State;
using CopperSharp.Contexts;
using CopperSharp.Data.Locations;
using CopperSharp.Item;

namespace CopperSharp.Blocks;

/// <summary>
///     Represents a single block
/// </summary>
public sealed class Block
{
    private bool _firstLock = true;

    internal Block(Material type, Location loc)
    {
        Type = type;
        Location = loc;
    }

    /// <summary>
    ///     Type of block
    /// </summary>
    public Material Type { get; }

    /// <summary>
    ///     Location of this block
    /// </summary>
    public Location Location { get; set; }

    /// <summary>
    ///     State of this block
    /// </summary>
    public BlockState? State { get; set; }

    private bool Locked { get; set; }
    private WorldContext? Binding { get; set; }

    /// <summary>
    ///     Locks this block to provided world context
    /// </summary>
    /// <param name="lk">World context to which this block should be locked</param>
    public void Lock(WorldContext lk)
    {
        Binding = lk;
        Locked = true;
    }

    /// <summary>
    ///     Generates block state for this block.
    ///     <b>Requires</b> locking the block, using <see cref="Lock" />!
    /// </summary>
    public void GenerateState()
    {
        if (!Locked)
            throw new Exception("The block was not locked! Lock the block first, then generate new block state!");
        var path = Type.Id.Path;
        if (path.Contains("banner"))
        {
            State = new BannerState(Type);
            return;
        }

        if (path.Contains("sign"))
        {
            State = new SignState(Type);
            return;
        }

        State = Type.Id.Path switch
        {
            "chest" => new ChestState(Type),
            "ender_chest" => new EnderChestState(Type),
            "trapped_chest" => new TrappedChestState(Type),
            "barrel" => new BarrelState(Type),
            "beacon" => new BeaconState(Type),
            "beehive" or "bee_nest" => new BeehiveState(Type),
            "blast_furnace" => new BlastFurnaceState(Type),
            "furnace" => new FurnaceState(Type),
            "smoker" => new SmokerState(Type),
            "end_gateway" => new EndGatewayState(Type),
            "brewing_stand" => new BrewingStandState(Type),
            "campfire" => new CampfireState(Type),
            "soul_campfire" => new SoulCampfireState(Type),
            "command_block" => new CommandBlockState(Type),
            "comparator" => new ComparatorState(Type),
            "conduit" => new ConduitState(Type),
            "daylight_detector" => new DaylightDetectorState(Type),
            "dispenser" => new DispenserState(Type),
            "dropper" => new DropperState(Type),
            "enchanting_table" => new EnchantingTableState(Type),
            "end_portal" => new EndPortalState(Type),
            "hopper" => new HopperState(Type),
            "jigsaw" => new JigsawState(Type),
            "jukebox" => new JukeboxState(Type),
            "lectern" => new LecternState(Type),
            "shulker_box" => new ShulkerBoxState(Type),
            "player_head" => new SkullState(Type),
            "structure_block" => new StructureBlockState(Type),
            _ => new DefaultBlockState(Type)
        };
    }

    /// <summary>
    ///     Releases lock from this block and
    ///     flushes all data to the context
    /// </summary>
    /// <returns>This block</returns>
    public async Task<Block> Release()
    {
        if (!Locked) return this;

        Locked = false;
        await (Binding?.Release(this, _firstLock) ?? Task.CompletedTask);
        _firstLock = false;
        return this;
    }
}