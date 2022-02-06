using System.Runtime.CompilerServices;
using CopperSharp.Functions;
using CopperSharp.Text.Impl;
using CopperSharp.Utils;

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
        return new(ClickEventType.OpenUrl, url);
    }

    /// <summary>
    ///     Opens a provided file on user's PC
    /// </summary>
    /// <param name="path">
    ///     Path to file. Note that user might use both Unix and Windows filesystem, so file separators might be
    ///     different
    /// </param>
    public static ClickEvent OpenFile(string path)
    {
        return new(ClickEventType.OpenFile, path);
    }

    /// <summary>
    ///     Runs a provided command for user
    /// </summary>
    /// <param name="command">Command to be ran</param>
    public static ClickEvent RunCommand(IAction command)
    {
        return new(ClickEventType.RunCommand, command.ToAction());
    }

    /// <summary>
    ///     Pastes provided selection to chat
    /// </summary>
    /// <param name="selection">String selection to be pasted</param>
    public static ClickEvent PasteToChat(string selection)
    {
        return new(ClickEventType.SuggestCommand, selection);
    }

    /// <summary>
    ///     Changes book's page to provided page
    /// </summary>
    /// <param name="page">Page to be set</param>
    public static ClickEvent ChangePage(int page)
    {
        return new(ClickEventType.ChangePage, page.ToString());
    }

    /// <summary>
    ///     Copies provided selection to user's clipboard
    /// </summary>
    /// <param name="selection">String selection to be copied</param>
    public static ClickEvent CopyToClipboard(string selection)
    {
        return new(ClickEventType.CopyToClipboard, selection);
    }

    private ClickEvent(ClickEventType eventType, string value)
    {
        EventType = eventType;
        Value = value;
    }

    /// <summary>
    ///     Converts this event to parseable container
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ComponentClickEvent Contain()
    {
        return new(EventType.GetData() ?? "null", Value);
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