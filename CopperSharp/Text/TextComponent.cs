// ReSharper disable RedundantCast

using CopperSharp.Utils;
using Newtonsoft.Json;

namespace CopperSharp.Text;

/// <summary>
///     A text based component for raw strings
/// </summary>
public sealed class TextComponent : Component
{
    /// <summary>
    ///     Creates a new text component from provided text
    /// </summary>
    /// <param name="text">Text to be put in component</param>
    public TextComponent(string text)
    {
        TextD = text;
    }

    /// <summary>
    ///     Text stored inside this component
    /// </summary>
    private string TextD { get; }

    /// <inheritdoc />
    public override ComponentType ComponentType => ComponentType.Text;

    /// <inheritdoc />
    public override Component QuadraticGradient(ITextColor from, ITextColor to, bool fast = true)
    {
        var red = MathUtils.QuadraticInterpolation(from.R, to.R, TextD.Length, fast);
        var green = MathUtils.QuadraticInterpolation(from.G, to.G, TextD.Length, fast);
        var blue = MathUtils.QuadraticInterpolation(from.B, to.B, TextD.Length, fast);

        var empty = new TextComponent(TextD[0].ToString()).Colored(ITextColor.Hex(red[0], green[0], blue[0]));
        for (var i = 1; i < TextD.Length; i++)
            empty = empty.Child(
                new TextComponent(TextD[i].ToString()).Colored(ITextColor.Hex(red[i], green[i], blue[i])));

        return empty;
    }

    /// <inheritdoc />
    public override Component LinearGradient(ITextColor from, ITextColor to)
    {
        var red = MathUtils.LinearInterpolation(from.R, to.R, TextD.Length);
        var green = MathUtils.LinearInterpolation(from.G, to.G, TextD.Length);
        var blue = MathUtils.LinearInterpolation(from.B, to.B, TextD.Length);

        var empty = new TextComponent(TextD[0].ToString()).Colored(ITextColor.Hex(red[0], green[0], blue[0]));
        for (var i = 1; i < TextD.Length; i++)
            empty = empty.Child(
                new TextComponent(TextD[i].ToString()).Colored(ITextColor.Hex(red[i], green[i], blue[i])));

        return empty;
    }

    /// <inheritdoc />
    protected override async Task SerializeExtra(JsonTextWriter jw)
    {
        await jw.WritePropertyNameAsync("text");
        await jw.WriteValueAsync(TextD);
    }
}