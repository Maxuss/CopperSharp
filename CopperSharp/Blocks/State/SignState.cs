using CopperSharp.Item;
using CopperSharp.Item.Meta;
using CopperSharp.Text;
using CopperSharp.Utils;

namespace CopperSharp.Blocks.State;

/// <summary>
///     Represents a sign block state
/// </summary>
public sealed class SignState : BlockState
{
    internal SignState(Material id) : base(id)
    {
    }

    /// <summary>
    ///     Sets text on this sign to provided text
    /// </summary>
    /// <param name="line">Line on which to change text. Must be in range of 1 to 4</param>
    /// <param name="text">Text to be set</param>
    /// <returns></returns>
    public SignState SetText(int line, IComponent text)
    {
        Data[$"Text{Math.Clamp(line, 1, 4)}"] = text.Serialize();
        return this;
    }

    /// <summary>
    ///     Makes this text sign glow
    /// </summary>
    /// <param name="glowing">Marker</param>
    /// <returns>This sign state</returns>
    public SignState Glowing(bool glowing = true)
    {
        Data["GlowingText"] = glowing;
        return this;
    }

    /// <summary>
    ///     Sets color of this sing
    /// </summary>
    /// <param name="color">Color to be set</param>
    /// <returns>This sign state</returns>
    public SignState Color(NumberedColor color)
    {
        Data["Color"] = color.GetData() ?? "black";
        return this;
    }
}