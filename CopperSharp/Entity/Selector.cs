using System.Text;
using CopperSharp.Utils;

namespace CopperSharp.Entity;

/// <summary>
///     An entity selector
/// </summary>
public readonly struct Selector
{
    /// <summary>
    ///     Nearest player to the caller
    /// </summary>
    public static Selector NearestPlayer = new("@p");

    /// <summary>
    ///     All entities in the callers world
    /// </summary>
    public static Selector AllEntities = new("@e");

    /// <summary>
    ///     Current command executor
    /// </summary>
    public static Selector CurrentEntity = new("@s");

    /// <summary>
    ///     All players in the callers world
    /// </summary>
    public static Selector AllPlayers = new("@a");

    /// <summary>
    ///     Random entity from the callers world
    /// </summary>
    public static Selector RandomEntity = new("@r");

    /// <summary>
    ///     Selector type of entity
    /// </summary>
    private string Search { get; }

    /// <summary>
    ///     Extra arguments for the selector
    /// </summary>
    private Dictionary<string, string> Args { get; }

    /// <summary>
    ///     Creates a new selector for entity with provided name
    /// </summary>
    /// <param name="name">Name of the entity for which to search</param>
    public Selector(string name)
    {
        Search = name;
        Args = new Dictionary<string, string>();
    }

    /// <summary>
    ///     Creates a new selector for all entities, to which calls the provided selector and extra arguments
    /// </summary>
    /// <param name="sel">Selector for entities</param>
    /// <param name="args">Extra args for the selector</param>
    public Selector(SelectorType sel, Dictionary<string, string> args)
    {
        Search = sel.GetData() ?? "NULL";
        Args = args;
    }

    /// <summary>
    ///     Creates a new selector for all entities, to which calls the provided selector
    /// </summary>
    /// <param name="sel">Selector for entities</param>
    public Selector(SelectorType sel) : this(sel, new Dictionary<string, string>())
    {
    }

    /// <summary>
    ///     Converts this selector to string
    /// </summary>
    /// <returns>String representation of this selector</returns>
    public override string ToString()
    {
        var builder = new StringBuilder(Search);
        if (Args.Count != 0)
        {
            var iter = 0;
            builder.Append('[');
            foreach (var pair in Args)
            {
                iter++;
                builder.Append($"{pair.Key}={pair.Value}");
                if (iter < Args.Count)
                    builder.Append(',');
            }

            builder.Append(']');
        }

        return builder.ToString();
    }
}