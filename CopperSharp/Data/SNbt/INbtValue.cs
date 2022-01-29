using CopperSharp.Data.SNbt.Impl;
using CopperSharp.Item;

namespace CopperSharp.Data.SNbt;

/// <summary>
/// A global interface for all kinds of nbt values
/// </summary>
public interface INbtValue
{
    /// <summary>
    /// Writes data to provided string writer
    /// </summary>
    /// <param name="sw">String writer to which data should be written</param>
    public void SerializeInto(StringNbtWriter sw); // ReSharper disable RedundantCast
    /// <summary>
    /// Encapsulates provided value inside an NBT value
    /// </summary>
    /// <param name="value">Value to be encapsulated</param>
    /// <returns>Encapsulated NBT value</returns>
    public static INbtValue Encapsulate(object value)
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
            Guid id => new GuidNbtValue(id) as INbtValue,
            NbtCompound cmp => new CompoundNbtValue(cmp) as INbtValue,
            ItemStack it => new ItemNbtValue(it) as INbtValue,
            (ItemStack it, int index) => new SlotItemNbtValue((it, index)) as INbtValue,
            List<object> ls => new ListNbtValue(ls.Select(Encapsulate).ToList()) as INbtValue,
            List<string> ls => new ListNbtValue(ls.Select(Encapsulate).ToList()) as INbtValue,
            List<int> ls => new ListNbtValue(ls.Select(it => Encapsulate(it)).ToList()) as INbtValue,
            List<double> ls => new ListNbtValue(ls.Select(it => Encapsulate(it)).ToList()) as INbtValue,
            List<float> ls => new ListNbtValue(ls.Select(it => Encapsulate(it)).ToList()) as INbtValue,
            List<byte> ls => new ListNbtValue(ls.Select(it => Encapsulate(it)).ToList()) as INbtValue,
            List<sbyte> ls => new ListNbtValue(ls.Select(it => Encapsulate(it)).ToList()) as INbtValue,
            List<short> ls => new ListNbtValue(ls.Select(it => Encapsulate(it)).ToList()) as INbtValue,
            List<long> ls => new ListNbtValue(ls.Select(it => Encapsulate(it)).ToList()) as INbtValue,
            List<bool> ls => new ListNbtValue(ls.Select(it => Encapsulate(it)).ToList()) as INbtValue,
            List<Guid> ls => new ListNbtValue(ls.Select(it => Encapsulate(it)).ToList()) as INbtValue,
            List<NbtCompound> ls => new ListNbtValue(ls.Select(Encapsulate).ToList()) as INbtValue,
            List<ItemStack> ls => new ListNbtValue(ls.Select(it => Encapsulate(it)).ToList()) as INbtValue,
            List<(ItemStack, int)> ls => new ListNbtValue(ls.Select(it => Encapsulate(it)).ToList()) as INbtValue,
            _ => new RawNbtValue(value.ToString() ?? "null") as INbtValue
        };
    }
}