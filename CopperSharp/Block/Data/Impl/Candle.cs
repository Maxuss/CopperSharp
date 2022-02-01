namespace CopperSharp.Block.Data.Impl;

/// <summary>
/// Represents a candle block data
/// </summary>
public sealed class Candle : AbstractBlockData, ILightable, IWaterlogged
{
    /// <inheritdoc />
    public ILightable Lit(bool lit)
    {
        Data["lit"] = lit;
        return this;
    }

    /// <inheritdoc />
    public IWaterlogged Waterlogged(bool logged)
    {
        Data["waterlogged"] = logged;
        return this;
    }

    /// <summary>
    /// Sets amount of candles 
    /// </summary>
    /// <param name="amount">Amount in range of 1 to 4 to be set</param>
    /// <returns>This candle</returns>
    public Candle Amount(int amount)
    {
        Data["candles"] = Math.Clamp(amount, 1, 4);
        return this;
    }
}