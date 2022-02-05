using CopperSharp.Data.Locations;
using CopperSharp.Item;

namespace CopperSharp.Data.SNbt.Impl;

internal readonly struct StringNbtValue : INbtValue
{
    private readonly string _v;

    public StringNbtValue(string v)
    {
        _v = v;
    }

    public void SerializeInto(StringNbtWriter sw)
    {
        sw.WriteString(_v);
    }
}

internal readonly struct IntNbtValue : INbtValue
{
    private readonly int _v;

    public IntNbtValue(int v)
    {
        _v = v;
    }

    public void SerializeInto(StringNbtWriter sw)
    {
        sw.WriteInteger(_v);
    }
}

internal readonly struct DoubleNbtValue : INbtValue
{
    private readonly double _v;

    public DoubleNbtValue(double v)
    {
        _v = v;
    }

    public void SerializeInto(StringNbtWriter sw)
    {
        sw.WriteDouble(_v);
    }
}

internal readonly struct FloatNbtValue : INbtValue
{
    private readonly float _v;

    public FloatNbtValue(float v)
    {
        _v = v;
    }

    public void SerializeInto(StringNbtWriter sw)
    {
        sw.WriteFloat(_v);
    }
}

internal readonly struct ByteNbtValue : INbtValue
{
    private readonly byte _v;

    public ByteNbtValue(byte v)
    {
        _v = v;
    }

    public void SerializeInto(StringNbtWriter sw)
    {
        sw.WriteByte(_v);
    }
}

internal readonly struct SByteNbtValue : INbtValue
{
    private readonly sbyte _v;

    public SByteNbtValue(sbyte v)
    {
        _v = v;
    }

    public void SerializeInto(StringNbtWriter sw)
    {
        sw.WriteSByte(_v);
    }
}

internal readonly struct ShortNbtValue : INbtValue
{
    private readonly short _v;

    public ShortNbtValue(short v)
    {
        _v = v;
    }

    public void SerializeInto(StringNbtWriter sw)
    {
        sw.WriteShort(_v);
    }
}

internal readonly struct LongNbtValue : INbtValue
{
    private readonly long _v;

    public LongNbtValue(long v)
    {
        _v = v;
    }

    public void SerializeInto(StringNbtWriter sw)
    {
        sw.WriteLong(_v);
    }
}

internal readonly struct BoolNbtValue : INbtValue
{
    private readonly bool _v;

    public BoolNbtValue(bool v)
    {
        _v = v;
    }

    public void SerializeInto(StringNbtWriter sw)
    {
        sw.WriteBool(_v);
    }
}

internal readonly struct GuidNbtValue : INbtValue
{
    private readonly Guid _v;

    public GuidNbtValue(Guid v)
    {
        _v = v;
    }

    public void SerializeInto(StringNbtWriter sw)
    {
        sw.WriteUuidArray(_v);
    }
}

internal readonly struct CompoundNbtValue : INbtValue
{
    private readonly NbtCompound _v;

    public CompoundNbtValue(NbtCompound v)
    {
        _v = v;
    }

    public void SerializeInto(StringNbtWriter sw)
    {
        _v.SerializeInto(sw);
    }
}

internal readonly struct RawNbtValue : INbtValue
{
    private readonly string _v;

    public RawNbtValue(string v)
    {
        _v = v;
    }

    public void SerializeInto(StringNbtWriter sw)
    {
        sw.WriteRawValue(_v);
    }
}

internal readonly struct ItemNbtValue : INbtValue
{
    private readonly ItemStack _v;

    public ItemNbtValue(ItemStack v)
    {
        _v = v;
    }

    public void SerializeInto(StringNbtWriter sw)
    {
        sw.WriteItem(_v);
    }
}

internal readonly struct SlotItemNbtValue : INbtValue
{
    private readonly (ItemStack, int) _v;

    public SlotItemNbtValue((ItemStack, int) v)
    {
        _v = v;
    }

    public void SerializeInto(StringNbtWriter sw)
    {
        sw.WriteItem(_v.Item1, _v.Item2);
    }
}

internal readonly struct LocationNbtValue : INbtValue
{
    private readonly Location _v;

    public LocationNbtValue(Location v)
    {
        _v = v;
    }

    public void SerializeInto(StringNbtWriter sw)
    {
        sw.WritePosition(_v);
    }
}