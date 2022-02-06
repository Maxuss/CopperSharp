namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents a pufferfish entity
/// </summary>
public sealed class Pufferfish : LivingEntity
{
    /// <summary>
    ///     Represents pufferfish inflation state
    /// </summary>
    public enum State
    {
        /// <summary>
        ///     The fish is deflated
        /// </summary>
        Deflated = 0,

        /// <summary>
        ///     The fish is slightly puffed
        /// </summary>
        SlightlyPuffed = 1,

        /// <summary>
        ///     The fish is fully puffed
        /// </summary>
        FullyPuffed = 2
    }

    internal Pufferfish() : base(EntityType.Pufferfish)
    {
    }

    /// <summary>
    ///     Whether this pufferfish was released from bucket
    /// </summary>
    /// <param name="from">Marker</param>
    /// <returns>This pufferfish</returns>
    public Pufferfish FromBucket(bool from)
    {
        Bools["FromBucket"] = from;
        return this;
    }

    /// <summary>
    ///     Sets state of this pufferfish puff state
    /// </summary>
    /// <param name="state">State to be set</param>
    /// <returns>This pufferfish</returns>
    public Pufferfish PuffState(State state)
    {
        Ints["PuffState"] = (int) state;
        return this;
    }
}