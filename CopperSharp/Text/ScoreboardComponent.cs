using CopperSharp.Entity;
using Newtonsoft.Json;

namespace CopperSharp.Text;

/// <summary>
///     Represents a scoreboard text component
/// </summary>
public sealed class ScoreboardComponent : Component
{
    /// <summary>
    ///     Constructs a new scoreboard component
    /// </summary>
    /// <param name="sb">The scoreboard name to be displayed</param>
    /// <param name="holder">The holder of scoreboard</param>
    public ScoreboardComponent(string sb, Selector holder)
    {
        Holder = holder;
        Scoreboard = sb;
    }

    /// <inheritdoc />
    public override ComponentType ComponentType => ComponentType.Scoreboard;

    private Selector Holder { get; }
    private string Scoreboard { get; }

    /// <inheritdoc />
    protected override async Task SerializeExtra(JsonTextWriter jw)
    {
        await jw.WritePropertyNameAsync("score");
        await jw.WriteStartObjectAsync();

        await jw.WritePropertyNameAsync("name");
        await jw.WriteValueAsync(Holder.ToString());

        await jw.WritePropertyNameAsync("objective");
        await jw.WriteValueAsync(Scoreboard);

        await jw.WriteEndObjectAsync();
    }
}