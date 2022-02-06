namespace CopperSharp.Text;

/// <summary>
///     Represents a formatting for text
/// </summary>
public struct TextFormatting
{
    /// <summary>
    ///     Type of this formatting
    /// </summary>
    public FormattingType Formatting { get; }

    /// <summary>
    ///     Whether the formatting is toggled on
    /// </summary>
    public bool Toggled { get; set; }

    /// <summary>
    ///     Constructs a new text formatting from provided formatting type
    /// </summary>
    /// <param name="type">Type of formatting</param>
    /// <param name="toggle">Whether the formatting should be toggled on</param>
    public TextFormatting(FormattingType type, bool toggle = true)
    {
        Formatting = type;
        Toggled = toggle;
    }
}