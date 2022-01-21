namespace CopperSharp.Data.Attributes;

/// <summary>
/// Represents an attribute, only applicable to zombies
/// </summary>
public readonly struct ZombieAttribute
{
    private ZombieAttribute(string name, double defaultBase, double maximum)
    {
        Name = name;
        DefaultBase = defaultBase;
        Maximum = maximum;
    }

    /// <inheritdoc />
    public string Name { get; }

    /// <inheritdoc />
    public double DefaultBase { get; }

    /// <inheritdoc />
    public double Maximum { get; }

    /// <summary>
    /// Chance for a zombie to spawn another zombie when attacked. 
    /// </summary>
    public static ZombieAttribute SpawnReinforcements { get; } = new("zombie.spawn_reinforcements", 0d, 1d);
}