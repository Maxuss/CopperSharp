using CopperSharp.Data.Effects;
using CopperSharp.Text;

namespace CopperSharp.Entity;

/// <summary>
/// An interface for potion-containing entities and items such as area effect cloud and arrows
/// </summary>
public interface IPotionContainer
{
    /// <summary>
    /// Adds an extra effect to this potion container
    /// </summary>
    /// <param name="effect">Effect to be added</param>
    /// <returns>This potion container</returns>
    public IPotionContainer AddEffect(PotionEffect effect);

    /// <summary>
    /// Sets a potion color for this potion container
    /// </summary>
    /// <param name="color">Color to be set</param>
    /// <returns>This potion container</returns>
    public IPotionContainer PotionColor(ITextColor color);
}