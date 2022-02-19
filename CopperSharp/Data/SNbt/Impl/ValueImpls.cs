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

    public async Task SerializeInto(INbtWriter sw)
    {
        await sw.WriteStringAsync(_v);
    }

    public async Task SerializeInto(JsonTextWriter sw)
    {
        await sw.WriteValueAsync(_v);
    }
}

internal readonly struct IntNbtValue : INbtValue
{
    private readonly int _v;

    public IntNbtValue(int v)
    {
        _v = v;
    }

    public async Task SerializeInto(INbtWriter sw)
    {
        await sw.WriteIntegerAsync(_v);
    }

    public async Task SerializeInto(JsonTextWriter sw)
    {
        await sw.WriteValueAsync(_v);
    }
}

internal readonly struct DoubleNbtValue : INbtValue
{
    private readonly double _v;

    public DoubleNbtValue(double v)
    {
        _v = v;
    }

    public async Task SerializeInto(INbtWriter sw)
    {
        await sw.WriteDoubleAsync(_v);
    }

    public async Task SerializeInto(JsonTextWriter sw)
    {
        await sw.WriteValueAsync(_v);
    }
}

internal readonly struct FloatNbtValue : INbtValue
{
    private readonly float _v;

    public FloatNbtValue(float v)
    {
        _v = v;
    }

    public async Task SerializeInto(INbtWriter sw)
    {
        await sw.WriteFloatAsync(_v);
    }

    public async Task SerializeInto(JsonTextWriter sw)
    {
        await sw.WriteValueAsync(_v);
    }
}

internal readonly struct ByteNbtValue : INbtValue
{
    private readonly byte _v;

    public ByteNbtValue(byte v)
    {
        _v = v;
    }

    public async Task SerializeInto(INbtWriter sw)
    {
        await sw.WriteByteAsync(_v);
    }

    public async Task SerializeInto(JsonTextWriter sw)
    {
        await sw.WriteValueAsync(_v);
    }
}

internal readonly struct SByteNbtValue : INbtValue
{
    private readonly sbyte _v;

    public SByteNbtValue(sbyte v)
    {
        _v = v;
    }

    public async Task SerializeInto(INbtWriter sw)
    {
        await sw.WriteSByteAsync(_v);
    }

    public async Task SerializeInto(JsonTextWriter sw)
    {
        await sw.WriteValueAsync(_v);
    }
}

internal readonly struct ShortNbtValue : INbtValue
{
    private readonly short _v;

    public ShortNbtValue(short v)
    {
        _v = v;
    }

    public async Task SerializeInto(INbtWriter sw)
    {
        await sw.WriteShortAsync(_v);
    }

    public async Task SerializeInto(JsonTextWriter sw)
    {
        await sw.WriteValueAsync(_v);
    }
}

internal readonly struct LongNbtValue : INbtValue
{
    private readonly long _v;

    public LongNbtValue(long v)
    {
        _v = v;
    }

    public async Task SerializeInto(INbtWriter sw)
    {
        await sw.WriteLongAsync(_v);
    }

    public async Task SerializeInto(JsonTextWriter sw)
    {
        await sw.WriteValueAsync(_v);
    }
}

internal readonly struct BoolNbtValue : INbtValue
{
    private readonly bool _v;

    public BoolNbtValue(bool v)
    {
        _v = v;
    }

    public async Task SerializeInto(INbtWriter sw)
    {
        await sw.WriteBoolAsync(_v);
    }

    public async Task SerializeInto(JsonTextWriter sw)
    {
        await sw.WriteValueAsync(_v);
    }
}

internal readonly struct GuidNbtValue : INbtValue
{
    private readonly Guid _v;

    public GuidNbtValue(Guid v)
    {
        _v = v;
    }

    public async Task SerializeInto(INbtWriter sw)
    {
        await sw.WriteUuidArrayAsync(_v);
    }

    public async Task SerializeInto(JsonTextWriter sw)
    {
        await sw.WriteValueAsync(_v);
    }
}

internal readonly struct CompoundNbtValue : INbtValue
{
    private readonly NbtCompound _v;

    public CompoundNbtValue(NbtCompound v)
    {
        _v = v;
    }

    public async Task SerializeInto(INbtWriter sw)
    {
        await _v.SerializeInto(sw);
    }

    public async Task SerializeInto(JsonTextWriter sw)
    {
        await sw.WriteStartObjectAsync();
        foreach (var e in _v)
        {
            await sw.WritePropertyNameAsync(e.Key);
            await e.Value.SerializeInto(sw);
        }

        await sw.WriteEndObjectAsync();
    }
}

internal readonly struct RawNbtValue : INbtValue
{
    private readonly string _v;

    public RawNbtValue(string v)
    {
        _v = v;
    }

    public async Task SerializeInto(INbtWriter sw)
    {
        await sw.WriteRawValueAsync(_v);
    }

    public async Task SerializeInto(JsonTextWriter sw)
    {
        await sw.WriteRawValueAsync(_v);
    }
}

internal readonly struct ItemNbtValue : INbtValue
{
    private readonly ItemStack _v;

    public ItemNbtValue(ItemStack v)
    {
        _v = v;
    }

    public async Task SerializeInto(INbtWriter sw)
    {
        await sw.WriteItem(_v);
    }

    public Task SerializeInto(JsonTextWriter sw)
    {
        throw new NotSupportedException("Items are not supposed to be serialized to JSON!");
    }
}

internal readonly struct SlotItemNbtValue : INbtValue
{
    private readonly (ItemStack, int) _v;

    public SlotItemNbtValue((ItemStack, int) v)
    {
        _v = v;
    }

    public async Task SerializeInto(INbtWriter sw)
    {
        await sw.WriteItem(_v.Item1, _v.Item2);
    }

    public Task SerializeInto(JsonTextWriter sw)
    {
        throw new NotSupportedException("Items are not supposed to be serialized to JSON!");
    }
}

internal readonly struct LocationNbtValue : INbtValue
{
    private readonly Location _v;

    public LocationNbtValue(Location v)
    {
        _v = v;
    }

    public async Task SerializeInto(INbtWriter sw)
    {
        await sw.WritePositionAsync(_v);
    }

    public Task SerializeInto(JsonTextWriter sw)
    {
        throw new NotSupportedException("Locations are not supposed to be serialized to JSON!");
    }
}