using CopperSharp.Utils;

namespace CopperSharp.Block.Impl;

/// <summary>
/// Represents a note block 
/// </summary>
public sealed class NoteBlock : AbstractBlockData, IPowerable
{
    /// <inheritdoc />
    public IPowerable Powered(bool power)
    {
        Data["powered"] = power;
        return this;
    }

    /// <summary>
    /// Sets type of sound for this note block
    /// </summary>
    /// <param name="instr">Instrument type to be set</param>
    /// <returns>This note block</returns>
    public NoteBlock SetInstrument(Instrument instr)
    {
        Data["instrument"] = instr.GetData() ?? "harp";
        return this;
    }

    /// <summary>
    /// Sets pitch of this note block
    /// </summary>
    /// <param name="note">Pitch amount in range of 0 to 24 to be set</param>
    /// <returns>This note block</returns>
    public NoteBlock Pitch(int note)
    {
        Data["note"] = Math.Clamp(note, 0, 24);
        return this;
    }
}

/// <summary>
/// Represents a type of instrument for note blocks
/// </summary>
public enum Instrument
{
    /// <summary>
    /// Banjo
    /// </summary>
    [EnumData("banjo")] Banjo,

    /// <summary>
    /// Base drum
    /// </summary>
    [EnumData("basedrum")] BaseDrum,

    /// <summary>
    /// Bass
    /// </summary>
    [EnumData("bass")] Bass,

    /// <summary>
    /// Bell
    /// </summary>
    [EnumData("bell")] Bell,

    /// <summary>
    /// Bit
    /// </summary>
    [EnumData("bit")] Bit,

    /// <summary>
    /// Chime
    /// </summary>
    [EnumData("chime")] Chime,

    /// <summary>
    /// Cow bell
    /// </summary>
    [EnumData("cow_bell")] CowBell,

    /// <summary>
    /// Didgeridoo
    /// </summary>
    [EnumData("didgeridoo")] Didgeridoo,

    /// <summary>
    /// Flute
    /// </summary>
    [EnumData("flute")] Flute,

    /// <summary>
    /// Guitar
    /// </summary>
    [EnumData("guitar")] Guitar,

    /// <summary>
    /// Harp
    /// </summary>
    [EnumData("harp")] Harp,

    /// <summary>
    /// Hat
    /// </summary>
    [EnumData("hat")] Hat,

    /// <summary>
    /// Iron Xylophone
    /// </summary>
    [EnumData("iron_xylophone")] IronXylophone,

    /// <summary>
    /// Pling
    /// </summary>
    [EnumData("pling")] Pling,

    /// <summary>
    /// Snare
    /// </summary>
    [EnumData("snare")] Snare,

    /// <summary>
    /// Xylophone
    /// </summary>
    [EnumData("xylophone")] Xylophone
}