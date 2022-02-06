using CopperSharp.Utils;

namespace CopperSharp.Item;

/// <summary>
///     Represents an applicable enchantment
/// </summary>
public readonly struct Enchantment
{
    /// <summary>
    ///     Initializes a new enchantment with provided enchant type and level
    /// </summary>
    /// <param name="level">Level of the enchantment.</param>
    /// <param name="enchant">Type of enchantment</param>
    /// <param name="allowBigLevels">Whether levels over default values should be allowed. False by default.</param>
    public Enchantment(Enchant enchant, int level, bool allowBigLevels = false)
    {
        Level = !allowBigLevels &&
                level > (enchant.GetEnchantData()?.MaxLevel ?? throw new Exception("Invalid enchant provided!"))
            ? throw new Exception("The level of enchantment exceeds its default maximum!")
            : level;

        Enchant = enchant;
    }

    /// <summary>
    ///     Type of enchantment
    /// </summary>
    public Enchant Enchant { get; }

    /// <summary>
    ///     Level of this enchantment
    /// </summary>
    public int Level { get; }
}