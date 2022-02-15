using CopperSharp.Data.Locations;
using CopperSharp.Data.SNbt.Impl;
using CopperSharp.Item;
using Newtonsoft.Json;

namespace CopperSharp.Data.SNbt;

/// <summary>
///     A global interface for all kinds of nbt values
/// </summary>
public interface INbtValue
{
    /// <summary>
    ///     Writes data to provided string writer
    /// </summary>
    /// <param name="sw">String writer to which data should be written</param>
    public void SerializeInto(StringNbtWriter sw); // ReSharper disable RedundantCast

    /// <summary>
    ///     Writes data to provided json string writer
    /// </summary>
    /// <param name="sw">String writer to which data should be written</param>
    public void SerializeInto(JsonTextWriter sw); // ReSharper disable RedundantCast


    /// <summary>
    ///     Wrap provided value inside an NBT tag
    /// </summary>
    /// <param name="value">Value to be wrapped</param>
    /// <returns>Wrapped NBT tag with provided value inside</returns>
    public static INbtValue Wrap(object value)
    {
        return value switch
        {
            string s => new StringNbtValue(s) as INbtValue,
            int i => new IntNbtValue(i) as INbtValue,
            double d => new DoubleNbtValue(d) as INbtValue,
            float f => new FloatNbtValue(f) as INbtValue,
            byte b => new ByteNbtValue(b) as INbtValue,
            sbyte sb => new SByteNbtValue(sb) as INbtValue,
            short s => new ShortNbtValue(s) as INbtValue,
            long l => new LongNbtValue(l) as INbtValue,
            bool z => new BoolNbtValue(z) as INbtValue,
            Location loc => new LocationNbtValue(loc) as INbtValue,
            Guid id => new GuidNbtValue(id) as INbtValue,
            NbtCompound cmp => new CompoundNbtValue(cmp) as INbtValue,
            ItemStack it => new ItemNbtValue(it) as INbtValue,
            (ItemStack it, int index) => new SlotItemNbtValue((it, index)) as INbtValue,
            INbtValue nbt => nbt,
            IEnumerable<object> coll => new NbtArray(coll.Select(Wrap).ToList()) as INbtValue,
            _ => new RawNbtValue(value.ToString() ?? "null") as INbtValue
        };
    }
}