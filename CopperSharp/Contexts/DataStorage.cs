using System.Collections.Concurrent;
using System.Globalization;
using CopperSharp.Data.SNbt;
using CopperSharp.Registry;
using CopperSharp.Text;

namespace CopperSharp.Contexts;

/// <summary>
/// Represents a command data storage which can store nbt
/// </summary>
public sealed class DataStorage : IWorldReference
{
    private readonly Identifier _id;

    /// <inheritdoc />
    public WorldContext World { get; }

    internal DataStorage(WorldContext world, Identifier id)
    {
        _id = id;
        World = world;
    }

    internal void InternalSafeSet(string path, object value)
    {
        World.RunUnsafe($"data modify storage {_id} {path} set value {value}");
    }

    /// <summary>
    /// Sets an object to this data storage
    /// </summary>
    /// <param name="path">Path to which to set the data object</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="value"/> is not one of the serializable types.</exception>
    public object this[string path]
    {
        set
        { 
            _ = value switch
            {
                string v => Set(path, v),
                int v => Set(path, v),
                byte v => Set(path, v),
                bool v => Set(path, v),
                double v => Set(path, v),
                float v => Set(path, v),
                INbtValue v => Set(path, v).Result,
                _ => throw new ArgumentOutOfRangeException(nameof(value),
                    $"Can not set object of type {value.GetType()} to command data storage!")
            };
        }
    }
    
    /// <summary>
    /// Sets a string value in this storage
    /// </summary>
    /// <param name="path">Path to the value</param>
    /// <param name="value">Value to be set</param>
    public string Set(string path, string value)
    {
        InternalSafeSet(path, value);
        return path;
    }
    
    /// <summary>
    /// Sets an integer value in this storage
    /// </summary>
    /// <param name="path">Path to the value</param>
    /// <param name="value">Value to be set</param>
    public string Set(string path, int value)
    {
        InternalSafeSet(path, value.ToString());
        return path;
    }
    
    /// <summary>
    /// Sets a byte value in this storage
    /// </summary>
    /// <param name="path">Path to the value</param>
    /// <param name="value">Value to be set</param>
    public string Set(string path, byte value)
    {
        InternalSafeSet(path, $"{value}b");
        return path;
    }
    
    /// <summary>
    /// Sets a boolean value in this storage
    /// </summary>
    /// <param name="path">Path to the value</param>
    /// <param name="value">Value to be set</param>
    public string Set(string path, bool value)
    {
        InternalSafeSet(path, value.ToString().ToLower());
        return path;
    }
    
    /// <summary>
    /// Sets a double value in this storage
    /// </summary>
    /// <param name="path">Path to the value</param>
    /// <param name="value">Value to be set</param>
    public string Set(string path, double value)
    {
        InternalSafeSet(path, $"{value:G}d");
        return path;
    }
    
    /// <summary>
    /// Sets a float value in this storage
    /// </summary>
    /// <param name="path">Path to the value</param>
    /// <param name="value">Value to be set</param>
    public string Set(string path, float value)
    {
        InternalSafeSet(path, $"{value:G}f");
        return path;
    }
    
    /// <summary>
    /// Sets an nbt value in this storage
    /// </summary>
    /// <param name="path">Path to the value</param>
    /// <param name="value">Value to be set</param>
    public async Task<string> Set(string path, INbtValue value)
    {
        InternalSafeSet(path, await value.InternalSerialize());
        return path;
    }
}