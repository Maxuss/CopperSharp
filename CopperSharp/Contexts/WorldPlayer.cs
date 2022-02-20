using CopperSharp.Data.Effects;
using CopperSharp.Data.Locations;
using CopperSharp.Item;
using CopperSharp.Registry;
using CopperSharp.Text;
using CopperSharp.Utils;

namespace CopperSharp.Contexts;

/// <summary>
///     Represents a player in the world, which can have different operations done with them
/// </summary>
public sealed class WorldPlayer : IWorldReference
{
    internal WorldPlayer(WorldContext ctx, string sel)
    {
        Lock = ctx;
        Name = sel;
    }

    /// <inheritdoc />
    public WorldContext World => Lock;
    private WorldContext Lock { get; }
    private string Name { get; }

    /// <summary>
    ///     Inventory of this player
    /// </summary>
    public PlayerInventory Inventory => new(Lock, Name);

    /// <summary>
    ///     Sends message to this player
    /// </summary>
    /// <param name="message">Message to be sent</param>
    /// <returns>This world player</returns>
    public async Task<WorldPlayer> SendMessage(Component message)
    {
        Lock.Cache.Add($"tellraw {Name} {await message.Serialize()}");
        return this;
    }

    /// <summary>
    ///     Sends a title to this player
    /// </summary>
    /// <param name="title">Title to be sent</param>
    /// <param name="subtitle">Optional subtitle to be sent</param>
    /// <returns>This world player</returns>
    public async Task<WorldPlayer> SendTitle(Component title, Component? subtitle = null)
    {
        Lock.Cache.Add($"title {Name} title {await title.Serialize()}");
        if (subtitle != null) Lock.Cache.Add($"title {Name} subtitle {await subtitle.Serialize()}");

        return this;
    }

    /// <summary>
    ///     Sends action bar to this player
    /// </summary>
    /// <param name="action">Action bar to be set</param>
    /// <returns>This world player</returns>
    public async Task<WorldPlayer> SendActionBar(Component action)
    {
        Lock.Cache.Add($"title {Name} actionbar {await action.Serialize()}");
        return this;
    }

    /// <summary>
    ///     Teleports this player to provided location
    /// </summary>
    /// <param name="to">Location to which to tp</param>
    /// <returns>This world player</returns>
    public WorldPlayer Teleport(Location to)
    {
        Lock.Cache.Add($"tp {Name} {to}");
        return this;
    }

    /// <summary>
    ///     Teleports this player to another player
    /// </summary>
    /// <param name="to">Player to which to teleport</param>
    /// <returns>This world player</returns>
    public WorldPlayer Teleport(WorldPlayer to)
    {
        Lock.Cache.Add($"tp {Name} {to.Name}");
        return this;
    }

    /// <summary>
    ///     Teleports this player to another player
    /// </summary>
    /// <param name="to">Name of another player</param>
    /// <returns>This world player</returns>
    public WorldPlayer Teleport(string to)
    {
        Lock.Cache.Add($"tp {Name} {to}");
        return this;
    }

    /// <summary>
    ///     Kicks the player off the server.
    ///     Note, you have to set functions-permission-level in server.properties to 3 or higher for it to work.
    /// </summary>
    /// <param name="cause">Cause of the kick</param>
    /// <returns>This world player</returns>
    public WorldPlayer Kick(string cause)
    {
        Lock.Cache.Add($"kick {Name} {cause}");
        return this;
    }

    /// <summary>
    ///     Plays a sound for this player
    /// </summary>
    /// <param name="sound">Sound to be played</param>
    /// <param name="category">Category channel of this sound</param>
    /// <param name="location">Location at which to be played</param>
    /// <param name="volume">Volume of this sound</param>
    /// <param name="pitch">Pitch of this sound</param>
    /// <param name="minVolume">Minimum volume of this sound</param>
    /// <returns></returns>
    public WorldPlayer PlaySound(string sound, SoundCategory category = SoundCategory.Master, Location? location = null,
        float volume = 1f, float pitch = 1f, float minVolume = 1f)
    {
        var loc = location ?? Location.FromString("~ ~ ~");
        Lock.Cache.Add(
            $"playsound minecraft:{sound} {category.GetName().ToLower()} {Name} {loc} {volume} {pitch} {minVolume}");
        return this;
    }

    /// <summary>
    ///     Stops sound for this player
    /// </summary>
    /// <param name="sound">Sound to be stopped. Optional.</param>
    /// <param name="channel">Channel to be stopped. Optional.</param>
    /// <returns>This world player</returns>
    public WorldPlayer StopSound(string sound = "", SoundCategory? channel = null)
    {
        Lock.Cache.Add($"stopsound {Name} {channel?.GetName().ToLower() ?? ""}");
        return this;
    }

    /// <summary>
    ///     Adds an effect to this player
    /// </summary>
    /// <param name="effect">Effect to be added</param>
    /// <returns>This world player.</returns>
    public WorldPlayer AddEffect(PotionEffect effect)
    {
        Lock.Cache.Add(
            $"effect give {Name} {effect.EffectName} {(int) Math.Round(effect.Duration / 20d)} {effect.Level + 1} {(!effect.ShowParticles).ToString().ToLower()}");
        return this;
    }

    /// <summary>
    ///     Clears all effects from this player
    /// </summary>
    /// <param name="effect">Effect to be cleared. Optional.</param>
    /// <returns>This world player.</returns>
    public WorldPlayer ClearEffects(StatusEffect? effect = null)
    {
        Lock.Cache.Add($"effect clear {Name} {effect?.GetData() ?? ""}");
        return this;
    }

    /// <summary>
    ///     Displays certain particles for this player.
    /// </summary>
    /// <param name="particle">Particle to be displayed.</param>
    /// <param name="at">Position at which the particles will be displayed.</param>
    /// <param name="delta">Delta position for particle spread</param>
    /// <param name="speed">Speed of particle</param>
    /// <param name="count">Count of particles</param>
    /// <param name="force">Whether to force display particles</param>
    /// <param name="options">Extra options for this particle</param>
    /// <returns>This world player</returns>
    public WorldPlayer DisplayParticle(string particle, Location at, Vec3 delta, float speed, int count,
        bool force = false, IParticleOptions? options = null)
    {
        Lock.Cache.Add(
            $"particle {particle} {options?.ToString() ?? ""} {at} {delta.DX} {delta.DY} {delta.DZ} {speed} {count} {(force ? "force" : "normal")} {Name}");
        return this;
    }

    /// <summary>
    ///     Grants a certain advancement to this player
    /// </summary>
    /// <param name="adv">Advancement to be added</param>
    /// <returns>This world player</returns>
    public WorldPlayer GrantAdvancement(Identifier adv)
    {
        Lock.Cache.Add($"advancement grant {Name} only {adv}");
        return this;
    }

    /// <summary>
    ///     Revokes a certain advancement from this player
    /// </summary>
    /// <param name="adv">Advancement to be revoked</param>
    /// <returns>This world player</returns>
    public WorldPlayer RevokeAdvancement(Identifier adv)
    {
        Lock.Cache.Add($"advancement revoke {Name} only {adv}");
        return this;
    }
}

/// <summary>
///     A global interface for particle options
/// </summary>
public interface IParticleOptions
{
    /// <summary>
    ///     Returns string representation of this particle options
    /// </summary>
    public string ToString();
}

/// <summary>
///     Represents item particle options
/// </summary>
public readonly struct ItemOptions : IParticleOptions
{
    /// <summary>
    ///     Material of the item
    /// </summary>
    public ItemStack State { get; }

    /// <summary>
    ///     Constructs new item options
    /// </summary>
    /// <param name="item">Item data</param>
    public ItemOptions(ItemStack item)
    {
        item.Amount = 1;
        State = item;
    }

    /// <inheritdoc cref="IParticleOptions.ToString" />
    public override string ToString()
    {
        return State.Serialize().Result;
    }
}

/// <summary>
///     Represents block particle options
/// </summary>
public readonly struct BlockOptions : IParticleOptions
{
    /// <summary>
    ///     Material of the block
    /// </summary>
    public Material State { get; }

    /// <summary>
    ///     Constructs new block options
    /// </summary>
    /// <param name="block">Type of block</param>
    public BlockOptions(Material block)
    {
        State = block;
    }

    /// <inheritdoc cref="IParticleOptions.ToString" />
    public override string ToString()
    {
        return State.Id.ToString();
    }
}

/// <summary>
///     Options for dust particle
/// </summary>
public readonly struct DustOptions : IParticleOptions
{
    /// <summary>
    ///     Color of this dust
    /// </summary>
    public ITextColor Color { get; }

    /// <summary>
    ///     Constructs new dust options
    /// </summary>
    /// <param name="color">Color to be set</param>
    public DustOptions(ITextColor color)
    {
        Color = color;
    }

    /// <inheritdoc cref="IParticleOptions.ToString" />
    public override string ToString()
    {
        return $"{Color.R / 256d} {Color.G / 256d} {Color.B / 256d} 1";
    }
}

/// <summary>
///     Represents a category for playsound command
/// </summary>
public enum SoundCategory
{
    /// <summary>
    ///     Master channel
    /// </summary>
    Master,

    /// <summary>
    ///     Music channel
    /// </summary>
    Music,

    /// <summary>
    ///     Record channel
    /// </summary>
    Record,

    /// <summary>
    ///     Weather channel
    /// </summary>
    Weather,

    /// <summary>
    ///     Block channel
    /// </summary>
    Block,

    /// <summary>
    ///     Hostile channel
    /// </summary>
    Hostile,

    /// <summary>
    ///     Neutral channel
    /// </summary>
    Neutral,

    /// <summary>
    ///     Player channel
    /// </summary>
    Player,

    /// <summary>
    ///     Ambient sound channel
    /// </summary>
    Ambient,

    /// <summary>
    ///     Voice channel
    /// </summary>
    Voice
}