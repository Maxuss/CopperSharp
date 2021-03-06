namespace CopperSharp.Utils;

/// <summary>
///     Represents an in-game keybind
/// </summary>
public enum Keybind
{
    /// <summary>
    ///     Space
    /// </summary>
    [EnumData("key.jump")] Jump,

    /// <summary>
    ///     Shift
    /// </summary>
    [EnumData("key.sneak")] Sneak,

    /// <summary>
    ///     Ctrl
    /// </summary>
    [EnumData("key.sprint")] Sprint,

    /// <summary>
    ///     A
    /// </summary>
    [EnumData("key.left")] StrafeLeft,

    /// <summary>
    ///     D
    /// </summary>
    [EnumData("key.right")] StrafeRight,

    /// <summary>
    ///     S
    /// </summary>
    [EnumData("key.back")] WalkBackward,

    /// <summary>
    ///     W
    /// </summary>
    [EnumData("key.forward")] WalkForward,

    /// <summary>
    ///     LMB
    /// </summary>
    [EnumData("key.attack")] Attack,

    /// <summary>
    ///     MMB
    /// </summary>
    [EnumData("key.pickItem")] PickBlock,

    /// <summary>
    ///     RMB
    /// </summary>
    [EnumData("key.use")] Use,

    /// <summary>
    ///     Q
    /// </summary>
    [EnumData("key.drop")] Drop,

    /// <summary>
    ///     1
    /// </summary>
    [EnumData("key.hotbar.1")] Hotbar1,

    /// <summary>
    ///     2
    /// </summary>
    [EnumData("key.hotbar.2")] Hotbar2,

    /// <summary>
    ///     3
    /// </summary>
    [EnumData("key.hotbar.3")] Hotbar3,

    /// <summary>
    ///     4
    /// </summary>
    [EnumData("key.hotbar.4")] Hotbar4,

    /// <summary>
    ///     5
    /// </summary>
    [EnumData("key.hotbar.5")] Hotbar5,

    /// <summary>
    ///     6
    /// </summary>
    [EnumData("key.hotbar.6")] Hotbar6,

    /// <summary>
    ///     7
    /// </summary>
    [EnumData("key.hotbar.7")] Hotbar7,

    /// <summary>
    ///     8
    /// </summary>
    [EnumData("key.hotbar.8")] Hotbar8,

    /// <summary>
    ///     9
    /// </summary>
    [EnumData("key.hotbar.9")] Hotbar9,

    /// <summary>
    ///     E
    /// </summary>
    [EnumData("key.inventory")] Inventory,

    /// <summary>
    ///     F
    /// </summary>
    [EnumData("key.swapOffhand")] SwapOffHand,

    /// <summary>
    ///     X
    /// </summary>
    [EnumData("key.loadToolbarActivator")] LoadToolbar,

    /// <summary>
    ///     C
    /// </summary>
    [EnumData("key.saveToolbarActivator")] SaveToolbar,

    /// <summary>
    ///     TAB
    /// </summary>
    [EnumData("key.playerlist")] PlayerList,

    /// <summary>
    ///     T
    /// </summary>
    [EnumData("key.chat")] OpenChat,

    /// <summary>
    ///     /
    /// </summary>
    [EnumData("key.command")] Command,

    /// <summary>
    ///     P
    /// </summary>
    [EnumData("key.socialInteractions")] OpenSocialInteractions,

    /// <summary>
    ///     L
    /// </summary>
    [EnumData("key.advancements")] OpenAdvancements,

    /// <summary>
    ///     None by default
    /// </summary>
    [EnumData("key.spectatorOutlines")] HighlightSpectators,

    /// <summary>
    ///     F2
    /// </summary>
    [EnumData("key.screenshot")] Screenshot,

    /// <summary>
    ///     None by default
    /// </summary>
    [EnumData("key.smoothCamera")] SmoothCamera,

    /// <summary>
    ///     F11
    /// </summary>
    [EnumData("key.fullscreen")] Fullscreen,

    /// <summary>
    ///     F5
    /// </summary>
    [EnumData("key.togglePerspective")] ChangePerspective
}