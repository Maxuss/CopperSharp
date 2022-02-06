namespace CopperSharp.Text;

/// <summary>
///     Formatting for text component, e.g. <b>bold</b> or <i>italic</i>
/// </summary>
public enum FormattingType
{
    /// <summary>
    ///     Whether to render the content in bold.
    /// </summary>
    Bold,

    /// <summary>
    ///     Whether to render the content in italics.<br />
    ///     Note that text that is italicized by default,<br />
    ///     such as custom item names, should be un-italicized<br />
    ///     by setting this to false in component.
    /// </summary>
    Italic,

    /// <summary>
    ///     Whether to underline the content.
    /// </summary>
    Underlined,

    /// <summary>
    ///     Whether to strikethrough the content.
    /// </summary>
    Strikethrough,

    /// <summary>
    ///     Whether to render the content obfuscated.
    /// </summary>
    Obfuscated
}