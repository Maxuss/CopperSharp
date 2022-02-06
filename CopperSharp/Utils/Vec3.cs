namespace CopperSharp.Utils;

/// <summary>
///     Represents a motion vector
/// </summary>
public readonly struct Vec3
{
    /// <summary>
    ///     Constructs a new Vec3
    /// </summary>
    /// <param name="dx">X Motion</param>
    /// <param name="dy">Y Motion</param>
    /// <param name="dz">Z Motion</param>
    public Vec3(double dx, double dy, double dz)
    {
        DZ = dz;
        DY = dy;
        DX = dx;
    }

    /// <summary>
    ///     Motion by X
    /// </summary>
    public double DX { get; }

    /// <summary>
    ///     Motion by Y
    /// </summary>
    public double DY { get; }

    /// <summary>
    ///     Motion by Z
    /// </summary>
    public double DZ { get; }

    /// <summary>
    ///     Multiplies this vector by another vector
    /// </summary>
    /// <param name="by">Vector, by which this vector should be multiplied</param>
    /// <returns>Multiplied copy of this vector</returns>
    public Vec3 Multiply(Vec3 by)
    {
        return new Vec3(DX * by.DX, DY * by.DY, DZ * by.DZ);
    }

    /// <summary>
    ///     Multiplies this vector by provided value
    /// </summary>
    /// <param name="by">Amount by which this vector should be multiplied</param>
    /// <returns>Multiplied copy of this vector</returns>
    public Vec3 Multiply(double by)
    {
        return new Vec3(DX * by, DY * by, DZ * by);
    }

    /// <summary>
    ///     Divides this vector by another vector
    /// </summary>
    /// <param name="by">Vector, by which this vector should be divided</param>
    /// <returns>Divided copy of this vector</returns>
    public Vec3 Divide(Vec3 by)
    {
        return new Vec3(DX / by.DX, DY / by.DY, DZ / by.DZ);
    }

    /// <summary>
    ///     Divides this vector by provided value
    /// </summary>
    /// <param name="by">Amount by which this vector should be divided</param>
    /// <returns>Divided copy of this vector</returns>
    public Vec3 Divide(double by)
    {
        return new Vec3(DX / by, DY / by, DZ / by);
    }

    /// <summary>
    ///     Sums this vector with another one
    /// </summary>
    /// <param name="other">Vector to be added to this</param>
    /// <returns>Modified copy of this vector</returns>
    public Vec3 Add(Vec3 other)
    {
        return new Vec3(DX + other.DX, DY + other.DY, DZ + other.DZ);
    }

    /// <summary>
    ///     Adds provided amount to this vector
    /// </summary>
    /// <param name="amount">Amount to be added</param>
    /// <returns>Modified copy of this vector</returns>
    public Vec3 Add(double amount)
    {
        return new Vec3(DX + amount, DY + amount, DZ + amount);
    }

    /// <summary>
    ///     Subtracts provided vector from this vector
    /// </summary>
    /// <param name="other">Vector to be subtracted to this</param>
    /// <returns>Modified copy of this vector</returns>
    public Vec3 Sub(Vec3 other)
    {
        return new Vec3(DX - other.DX, DY - other.DY, DZ - other.DZ);
    }

    /// <summary>
    ///     Subtracts provided amount from this vector
    /// </summary>
    /// <param name="amount">Amount to be subtracted</param>
    /// <returns>Modified copy of this vector</returns>
    public Vec3 Sub(double amount)
    {
        return new Vec3(DX - amount, DY - amount, DZ - amount);
    }

    /// <inheritdoc cref="Multiply(Vec3)" />
    public static Vec3 operator *(Vec3 cur, Vec3 other)
    {
        return cur.Multiply(other);
    }

    /// <inheritdoc cref="Multiply(double)" />
    public static Vec3 operator *(Vec3 cur, double by)
    {
        return cur.Multiply(by);
    }

    /// <inheritdoc cref="Divide(double)" />
    public static Vec3 operator /(Vec3 cur, Vec3 by)
    {
        return cur.Divide(by);
    }

    /// <inheritdoc cref="Divide(double)" />
    public static Vec3 operator /(Vec3 cur, double by)
    {
        return cur.Divide(by);
    }

    /// <inheritdoc cref="Add(Vec3)" />
    public static Vec3 operator +(Vec3 cur, Vec3 other)
    {
        return cur.Add(other);
    }

    /// <inheritdoc cref="Add(double)" />
    public static Vec3 operator +(Vec3 cur, double by)
    {
        return cur.Add(by);
    }

    /// <inheritdoc cref="Sub(Vec3)" />
    public static Vec3 operator -(Vec3 cur, Vec3 by)
    {
        return cur.Sub(by);
    }

    /// <inheritdoc cref="Sub(double)" />
    public static Vec3 operator -(Vec3 cur, double by)
    {
        return cur.Sub(by);
    }
}