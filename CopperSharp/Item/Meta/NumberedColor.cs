using CopperSharp.Utils;

namespace CopperSharp.Item.Meta;

/// <summary>
/// Represents a numbered color
/// </summary>
public enum NumberedColor
{
    /// <summary>
    /// #FFFFFF 
    /// </summary>
    [EnumData("white")] White = 0,

    /// <summary>
    /// #D87F33 
    /// </summary>
    [EnumData("orange")] Orange = 1,

    /// <summary>
    /// #B24CD8 
    /// </summary>
    [EnumData("magenta")] Magenta = 2,

    /// <summary>
    /// #6699D8 
    /// </summary>
    [EnumData("light_blue")] LightBlue = 3,

    /// <summary>
    /// #E5E533 
    /// </summary>
    [EnumData("yellow")] Yellow = 4,

    /// <summary>
    /// #7FCC19 
    /// </summary>
    [EnumData("lime")] Lime = 5,

    /// <summary>
    /// #F27FA5 
    /// </summary>
    [EnumData("pink")] Pink = 6,

    /// <summary>
    /// #4C4C4C 
    /// </summary>
    [EnumData("gray")] Gray = 7,

    /// <summary>
    /// #999999 
    /// </summary>
    [EnumData("light_gray")] LightGray = 8,

    /// <summary>
    /// #4C7F99 
    /// </summary>
    [EnumData("cyan")] Cyan = 9,

    /// <summary>
    /// #7F3FB2 
    /// </summary>
    [EnumData("purple")] Purple = 10,

    /// <summary>
    /// #334CB2 
    /// </summary>
    [EnumData("blue")] Blue = 11,

    /// <summary>
    /// #664C33 
    /// </summary>
    [EnumData("brown")] Brown = 12,

    /// <summary>
    /// #667F33 
    /// </summary>
    [EnumData("green")] Green = 13,

    /// <summary>
    /// #993333 
    /// </summary>
    [EnumData("red")] Red = 14,

    /// <summary>
    /// #191919 
    /// </summary>
    [EnumData("black")] Black = 15
}