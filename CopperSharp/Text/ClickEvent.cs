using System.Runtime.CompilerServices;

namespace CopperSharp.Text;

/// <summary>
///     An event that occurs when a component is clicked in the chat or on the sign
/// </summary>
public readonly struct ClickEvent
{
    /// <summary>
    ///     Opens the provided url for user
    /// </summary>
    /// <param name="url">Url to be opened</param>
    public static ClickEvent OpenUrl(string url)
    {
        return new ClickEvent(ClickEventType.OpenUrl, url);
    }

    /// <summary>
    ///     Opens a provided file on user's PC
    /// </summary>
    /// <param name="path">
    ///     Path to file. Note that user might use both Unix and Windows filesystem, so file separators might be
    ///     different
    /// </param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ClickEvent OpenFile(string path)
    {
        return new ClickEvent(ClickEventType.OpenFile, path);
    }

    /// <summary>
    ///     Runs a provided command for user
    /// </summary>
    /// <param name="command">Command to be ran</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ClickEvent RunCommand(string command)
    {
        return new ClickEvent(ClickEventType.RunCommand, command);
    }

    /// <summary>
    ///     Pastes provided selection to chat
    /// </summary>
    /// <param name="selection">String selection to be pasted</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ClickEvent PasteToChat(string selection)
    {
        return new ClickEvent(ClickEventType.SuggestCommand, selection);
    }

    /// <summary>
    ///     Changes book's page to provided page
    /// </summary>
    /// <param name="page">Page to be set</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ClickEvent ChangePage(int page)
    {
        return new ClickEvent(ClickEventType.ChangePage, page.ToString());
    }

    /// <summary>
    ///     Copies provided selection to user's clipboard
    /// </summary>
    /// <param name="selection">String selection to be copied</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ClickEvent CopyToClipboard(string selection)
    {
        return new ClickEvent(ClickEventType.CopyToClipboard, selection);
    }

    private ClickEvent(ClickEventType eventType, string value)
    {
        EventType = eventType;
        Value = value;
    }

    /// <summary>
    ///     Type of the event
    /// </summary>
    public ClickEventType EventType { get; }

    /// <summary>
    ///     Value of the event
    /// </summary>
    public string Value { get; }
}