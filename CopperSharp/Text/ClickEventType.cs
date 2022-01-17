using CopperSharp.Utils;

namespace CopperSharp.Text;

/// <summary>
/// Type of click event, that occurs when a component is clicked on the sign or in the chat
/// </summary>
public enum ClickEventType
{
    /// <summary>
    /// Opens a provided url
    /// </summary>
    [EnumData("open_url")] OpenUrl,

    /// <summary>
    /// Opens a file on user's PC
    /// </summary>
    [EnumData("open_file")] OpenFile,

    /// <summary>
    /// Runs a provided command
    /// </summary>
    [EnumData("run_command")] RunCommand,

    /// <summary>
    /// Inserts the provided text selection into chat
    /// </summary>
    [EnumData("suggest_command")] SuggestCommand,

    /// <summary>
    /// Changes page of the book
    /// </summary>
    [EnumData("change_page")] ChangePage,

    /// <summary>
    /// Copies provided data to user's clipboard
    /// </summary>
    [EnumData("copy_to_clipboard")] CopyToClipboard
}