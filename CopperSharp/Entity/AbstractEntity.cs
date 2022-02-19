using CopperSharp.Contexts;
using CopperSharp.Data.Locations;
using CopperSharp.Data.SNbt;
using CopperSharp.Text;
using CopperSharp.Utils;

namespace CopperSharp.Entity;

/// <summary>
///     A global interface for entity
/// </summary>
public abstract class AbstractEntity
{
    private readonly Dictionary<string, bool> _bools = new();

    private bool _firstLock = true;

    /// <summary>
    ///     Constructs a new abstract entity with provided type
    /// </summary>
    /// <param name="type">Type of this entity</param>
    protected AbstractEntity(EntityType type)
    {
        Type = type;
    }

    private bool _locked { get; set; }
    private WorldContext? _binding { get; set; }

    /// <summary>
    ///     Position of this entity
    /// </summary>
    public Location Position { get; internal set; }

    /// <summary>
    ///     Unique UUID of this entity
    /// </summary>
    public Guid EntityUid { get; } = Guid.NewGuid();

    /// <summary>
    ///     Extra data, stored inside this entity
    /// </summary>
    public NbtCompound ExtraData { get; set; } = new();

    /// <summary>
    ///     Extra UUID values to store inside this entity
    /// </summary>
    protected Dictionary<string, Guid> Ids { get; set; } = new();

    /// <summary>
    ///     Extra string values to store inside this entity
    /// </summary>
    protected Dictionary<string, string> Strings { get; set; } = new();

    /// <summary>
    ///     Extra byte values to store inside this entity
    /// </summary>
    protected Dictionary<string, byte> Bytes { get; set; } = new();

    /// <summary>
    ///     Extra bool values to store inside this entity
    /// </summary>
    protected Dictionary<string, bool> Bools { get; set; } = new();

    /// <summary>
    ///     Extra integers in this entity
    /// </summary>
    protected Dictionary<string, int> Ints { get; set; } = new();

    /// <summary>
    ///     Extra integers in this entity
    /// </summary>
    protected Dictionary<string, double> Doubles { get; set; } = new();

    /// <summary>
    ///     Type of this entity
    /// </summary>
    public EntityType Type { get; }

    private short Air { get; set; } = -1;
    private Component? CustomName { get; set; }
    private Vec3? Motion { get; set; }
    private Vec2? Rotation { get; set; }
    private List<AbstractEntity> Passengers { get; } = new();

    /// <summary>
    ///     Disables gravity for this entity
    /// </summary>
    /// <returns></returns>
    public AbstractEntity DisableGravity()
    {
        _bools["NoGravity"] = true;
        return this;
    }

    /// <summary>
    ///     Makes this entity silent, not making any noise at all
    /// </summary>
    /// <param name="silent">Whether to make this entity silent</param>
    /// <returns>This entity</returns>
    public AbstractEntity SetSilent(bool silent)
    {
        _bools["Silent"] = silent;
        return this;
    }

    /// <summary>
    ///     Makes the entity immune to all attacks
    /// </summary>
    /// <param name="immune">Whether to make entity immune to all attacks</param>
    /// <returns>This entity</returns>
    public AbstractEntity Invulnerability(bool immune = true)
    {
        _bools["Invulnerable"] = immune;
        return this;
    }

    /// <summary>
    ///     Configures the left amount of breathing air for this entity
    /// </summary>
    /// <returns>This entity</returns>
    public AbstractEntity BreathingAirLeft(short air)
    {
        Air = air;
        return this;
    }

    /// <summary>
    ///     Adds a visual-only fire effect to this entity
    /// </summary>
    /// <returns>This entity</returns>
    public AbstractEntity VisualFire()
    {
        _bools["HasVisualFire"] = true;
        return this;
    }

    /// <summary>
    ///     Applies a glowing effect to this entity
    /// </summary>
    /// <param name="glow">Whether the entity should glow</param>
    /// <returns>This entity</returns>
    public AbstractEntity Glow(bool glow = true)
    {
        _bools["Glowing"] = glow;
        return this;
    }

    /// <summary>
    ///     Sets custom name of this entity
    /// </summary>
    /// <param name="name">New name of this entity</param>
    /// <param name="alwaysVisible">Whether the name should be always visible</param>
    /// <returns>This entity</returns>
    public AbstractEntity Name(Component name, bool alwaysVisible = false)
    {
        CustomName = name;
        _bools["CustomNameVisible"] = alwaysVisible;
        return this;
    }

    /// <summary>
    ///     Applies a provided rotation to this entity
    /// </summary>
    /// <returns>This entity</returns>
    public AbstractEntity Rotate(Vec2 rotation)
    {
        Rotation = rotation;
        return this;
    }

    /// <summary>
    ///     Applies a provided rotation to this entity
    /// </summary>
    /// <param name="pitch">Pitch rotation of this entity</param>
    /// <param name="yaw">Yaw rotation of this entity</param>
    /// <returns>This entity</returns>
    public AbstractEntity Rotate(float pitch, float yaw)
    {
        Rotation = new Vec2(pitch, yaw);
        return this;
    }

    /// <summary>
    ///     Applies a provided velocity to this entity
    /// </summary>
    /// <param name="motion">Velocity to be applied</param>
    /// <returns>This entity</returns>
    public AbstractEntity Velocity(Vec3 motion)
    {
        Motion = motion;
        return this;
    }

    /// <summary>
    ///     Gets velocity of this entity
    /// </summary>
    /// <returns>This entity's velocity</returns>
    public Vec3? Velocity()
    {
        return Motion;
    }

    /// <summary>
    ///     Gets rotation of this entity
    /// </summary>
    /// <returns>This entity's rotation</returns>
    public Vec2? EntityRotation()
    {
        return Rotation;
    }

    /// <summary>
    ///     Adds all provided entities as passengers to this entity
    /// </summary>
    /// <param name="passengers">Passengers to be added</param>
    /// <returns>This entity</returns>
    public AbstractEntity AddPassengers(params AbstractEntity[] passengers)
    {
        Passengers.AddRange(passengers);
        return this;
    }

    /// <summary>
    ///     Serializes extra data from this inheritor
    /// </summary>
    /// <param name="sw">Writer to which the data should be written</param>
    protected virtual Task SerializeExtra(INbtWriter sw)
    {
        return Task.CompletedTask;
    }

    /// <summary>
    /// Serializes this entity into provided writer
    /// </summary>
    /// <param name="w">Writer to be used</param>
    /// <param name="includeType">Whether to include entity type</param>
    public async Task SerializeInto(INbtWriter w, bool includeType = true)
    {
        await w.WriteBeginCompoundAsync();

        foreach (var (key, value) in _bools)
        {
            await w.WritePropertyNameAsync(key);
            await w.WriteBoolAsync(value);
        }

        if (Air != -1) await w.WriteShortAsync("Air", Air);

        if (CustomName != null)
            await w.WriteStringAsync("CustomName", await CustomName.Serialize());

        if (Motion != null)
        {
            await w.WritePropertyNameAsync("Motion");
            await w.WriteBeginArrayAsync();
            await w.WriteFloatAsync(Motion?.DX ?? 0);
            await w.WriteFloatAsync(Motion?.DY ?? 0);
            await w.WriteFloatAsync(Motion?.DZ ?? 0);
            await w.WriteEndArrayAsync();
        }

        if (Rotation != null)
        {
            await w.WritePropertyNameAsync("Rotation");
            await w.WriteBeginArrayAsync();
            await w.WriteFloatAsync(Rotation?.Yaw ?? 0);
            await w.WriteFloatAsync(Rotation?.Pitch ?? 0);
            await w.WriteEndArrayAsync();
        }

        if (Passengers.Any())
        {
            await w.WritePropertyNameAsync("Passengers");
            await w.WriteBeginArrayAsync();
            foreach (var passenger in Passengers)
                await passenger.SerializeInto(w);

            await w.WriteEndArrayAsync();
        }

        foreach (var (key, val) in Bools) await w.WriteBoolAsync(key, val);

        foreach (var (key, val) in Bytes) await w.WriteByteAsync(key, val);

        foreach (var (key, val) in Strings) await w.WriteStringAsync(key, val);

        foreach (var (key, val) in Ids) await w.WriteUuidArrayAsync(key, val);

        foreach (var (key, val) in Ints) await w.WriteIntegerAsync(key, val);

        foreach (var (key, val) in Doubles) await w.WriteDoubleAsync(key, val);

        await SerializeExtra(w);

        if (!includeType)
            await w.WriteStringAsync("id", Type.Id.ToString());

        await ExtraData.SerializeInto(w, false);

        await w.WritePropertyNameAsync("Tags");
        await w.WriteBeginArrayAsync();
        await w.WriteStringAsync($"CID{EntityUid}");
        await w.WriteEndArrayAsync();
        await w.WriteEndCompoundAsync();

    }

    /// <summary>
    ///     Serializes this entity into SNBT
    /// </summary>
    /// <returns>Serialized entity</returns>
    public async Task<string> Serialize(bool includeType = true)
    {
        await using var sw = new StringWriter();
        await using var w = new StringNbtWriter(sw);

        await SerializeInto(w);

        return $"{sw}";
    }

    /// <summary>
    ///     Locks this entity under provided
    /// </summary>
    /// <param name="ctx"></param>
    public void Lock(WorldContext ctx)
    {
        _binding = ctx;
        _locked = true;
    }

    /// <summary>
    ///     Releases lock of this entity, and flushes
    ///     all changes to current context
    /// </summary>
    /// <returns>This abstract entity</returns>
    public async Task<AbstractEntity> Release()
    {
        if (!_locked) return this;

        _locked = false;
        await (_binding?.Release(this, _firstLock) ?? Task.CompletedTask);
        _firstLock = false;
        return this;
    }
}