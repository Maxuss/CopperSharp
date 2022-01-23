using System.Drawing;

namespace CopperSharp.Utils;

/// <summary>
/// Different Math-related utilities
/// </summary>
public static class MathUtils
{
    /// <summary>
    /// Produces quadratic interpolation on provided values
    /// </summary>
    /// <param name="from">From value</param>
    /// <param name="to">To value</param>
    /// <param name="max">Max interpolation size</param>
    /// <param name="mode">True for fast interpolation and false for slow.</param>
    public static double[] QuadraticInterpolation(double from, double to, int max, bool mode)
    {
        var results = new double[max];
        if (mode)
        {
            var a = (to - from) / (max * max);
            for (var i = 0; i < results.Length; i++)
            {
                results[i] = a * i * i + from;
            }
        }
        else
        {
            var a = (from - to) / (max * max);
            var b = -2 * a * max;
            for (var i = 0; i < results.Length; i++)
            {
                results[i] = a * i * i + b * i + from;
            }
        }

        return results;
    }

    /// <summary>
    /// Produces linear interpolation on provided values
    /// </summary>
    /// <param name="from">From value</param>
    /// <param name="to">To value</param>
    /// <param name="max">Max interpolation size</param>
    /// <returns></returns>
    public static double[] LinearInterpolation(double from, double to, int max)
    {
        var res = new double[max];
        for (var i = 0; i < max; i++)
        {
            res[i] = from + i * ((to - from) / (max - 1));
        }

        return res;
    }

    /// <summary>
    /// Converts RGB to HSV
    /// </summary>
    /// <param name="r">Red value</param>
    /// <param name="g">Green value</param>
    /// <param name="b">Blue value</param>
    /// <returns>Hue, saturation and brightness</returns>
    public static (double h, double s, double v) ColorToHsv(double r, double g, double b)
    {
        var color = Color.FromArgb((int) r, (int) g, (int) b);
        return (color.GetHue(), color.GetSaturation(), color.GetBrightness());
    }
}