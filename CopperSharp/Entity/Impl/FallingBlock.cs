using CopperSharp.Blocks;
using CopperSharp.Data.SNbt;

namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents a falling block entity
/// </summary>
public sealed class FallingBlock : AbstractEntity
{
    internal FallingBlock() : base(EntityType.FallingBlock)
    {
    }

    private BlockState? State { get; set; }

    /// <summary>
    ///     Whether this falling block drops item
    /// </summary>
    /// <param name="drops">Whether it drops item</param>
    /// <returns>This falling block</returns>
    public FallingBlock DropsItem(bool drops = true)
    {
        Bools["DropItem"] = drops;
        return this;
    }

    /// <summary>
    ///     Whether this block hurts entities
    /// </summary>
    /// <param name="hurts">Marker</param>
    /// <returns>This falling block</returns>
    public FallingBlock HurtsEntities(bool hurts = true)
    {
        Bools["HurtsEntities"] = hurts;
        return this;
    }

    /// <summary>
    ///     Multiplier of this block's hurt amount on fall
    /// </summary>
    /// <param name="amount">Multiplier</param>
    /// <returns>This falling block</returns>
    public FallingBlock FallHurtMultiplier(float amount)
    {
        Doubles["FallHurtAmount"] = amount;
        return this;
    }

    /// <summary>
    ///     Sets block state of this falling block
    /// </summary>
    /// <param name="state">Block state to be se</param>
    /// <returns>This falling block</returns>
    public FallingBlock BlockState(BlockState state)
    {
        State = state;
        return this;
    }

    /// <inheritdoc />
    protected override async Task SerializeExtra(INbtWriter sw)
    {
        await base.SerializeExtra(sw);

        if (State == null)
            return;

        await sw.WriteRawValueAsync("BlockState", await State.Serialize());
    }
}