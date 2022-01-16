namespace CopperSharp.Text;

/// <summary>
/// Represents an entity, that can be converted into color
/// </summary>
public interface IColorLike
{
    /// <summary>
    /// Red value of this color
    /// </summary>
    public int Red { get; set; }

    /// <summary>
    /// Green value of this color
    /// </summary>
    public int Green { get; set; }

    /// <summary>
    /// Blue value of this color
    /// </summary>
    public int Blue { get; set; }
}