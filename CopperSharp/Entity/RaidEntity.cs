using CopperSharp.Data.Locations;
using CopperSharp.Data.SNbt;

namespace CopperSharp.Entity;

/// <summary>
///     Represents an entity that can be spawned during raid
/// </summary>
public abstract class RaidEntity : LivingEntity
{
    /// <inheritdoc />
    protected RaidEntity(EntityType type) : base(type)
    {
    }

    private Location? PatrolTarget { get; set; }

    /// <summary>
    ///     Whether the mob can join the raid when it starts
    /// </summary>
    /// <param name="can">Can the mob join raid</param>
    /// <returns>This raid entity</returns>
    public RaidEntity CanJoinRaid(bool can = true)
    {
        Bools["CanJoinRaid"] = can;
        return this;
    }

    /// <summary>
    ///     Whether this mob is the patrol leader
    /// </summary>
    /// <param name="leader">Marker</param>
    /// <returns>This raid entity</returns>
    public RaidEntity PatrolLeader(bool leader = true)
    {
        Bools["PatrolLeader"] = leader;
        return this;
    }

    /// <summary>
    ///     Whether this mob is patrolling
    /// </summary>
    /// <param name="patrolling">Marker</param>
    /// <returns>This raid entity</returns>
    public RaidEntity Patrolling(bool patrolling = true)
    {
        Bools["Patrolling"] = patrolling;
        return this;
    }

    /// <summary>
    ///     Sets patrolling target for this entity
    /// </summary>
    /// <param name="target">Target to be set</param>
    /// <returns>This raid entity</returns>
    public RaidEntity SetPatrolTarget(Location target)
    {
        PatrolTarget = target;
        return this;
    }

    /// <summary>
    ///     Sets numeric ID of the raid this mob participates
    /// </summary>
    /// <param name="id">ID of the raid</param>
    /// <returns>This raid entity</returns>
    public RaidEntity RaidId(int id)
    {
        Ints["RaidId"] = id;
        return this;
    }

    /// <summary>
    ///     Sets raid wave in which this mob spawned
    /// </summary>
    /// <param name="wave">Wave in which mob spawned</param>
    /// <returns>This raid entity</returns>
    public RaidEntity RaidWave(int wave)
    {
        Ints["Wave"] = wave;
        return this;
    }

    /// <inheritdoc />
    protected override void SerializeExtra(StringNbtWriter sw)
    {
        base.SerializeExtra(sw);

        if (PatrolTarget != null)
            sw.WritePosition(PatrolTarget ?? new Location(0, 0, 0));
    }
}