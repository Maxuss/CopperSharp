using CopperSharp.Data.Locations;
using CopperSharp.Item;
using Newtonsoft.Json;

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

    public void SerializeInto(JsonTextWriter sw)
    {
        sw.WriteValue(_v);
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
    
    public void SerializeInto(JsonTextWriter sw)
    {
        sw.WriteValue(_v);
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
    
    public void SerializeInto(JsonTextWriter sw)
    {
        sw.WriteValue(_v);
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

    public void SerializeInto(JsonTextWriter sw)
    {
        sw.WriteValue(_v);
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
    
    public void SerializeInto(JsonTextWriter sw)
    {
        sw.WriteValue(_v);
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
    
    public void SerializeInto(JsonTextWriter sw)
    {
        sw.WriteValue(_v);
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
    
    public void SerializeInto(JsonTextWriter sw)
    {
        sw.WriteValue(_v);
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
    
    public void SerializeInto(JsonTextWriter sw)
    {
        sw.WriteValue(_v);
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
    
    public void SerializeInto(JsonTextWriter sw)
    {
        sw.WriteValue(_v);
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
    
    public void SerializeInto(JsonTextWriter sw)
    {
        sw.WriteValue(_v);
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
    
    public void SerializeInto(JsonTextWriter sw)
    {
        sw.WriteStartObject();
        foreach (var e in _v)
        {
            sw.WritePropertyName(e.Key);
            e.Value.SerializeInto(sw);
        }
        sw.WriteEndObject();
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
    
    public void SerializeInto(JsonTextWriter sw)
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
    
    public void SerializeInto(JsonTextWriter sw)
    {
        throw new PlatformNotSupportedException("Items are not supposed to be serialized to JSON!");
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

    public void SerializeInto(JsonTextWriter sw)
    {
        throw new PlatformNotSupportedException("Items are not supposed to be serialized to JSON!");
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
    
    public void SerializeInto(JsonTextWriter sw)
    {
        throw new PlatformNotSupportedException("Locations are not supposed to be serialized to JSON!");
    }
}