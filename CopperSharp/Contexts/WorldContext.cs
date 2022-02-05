using System.Reflection;
using CopperSharp.Blocks;
using CopperSharp.Data.Locations;
using CopperSharp.Entity;
using CopperSharp.Item;

namespace CopperSharp.Contexts;

/// <summary>
/// Represents a world-scoped context, in which the function will be invoked
/// </summary>
public sealed class WorldContext
{
    private List<string> Cache { get; set; } = new();

    /// <summary>
    /// Releases lock on provided entity
    /// </summary>
    /// <param name="entity">Entity to be unlocked</param>
    /// <param name="summon">Whether to summon a new entity or modify it's data</param>
    public void Release(AbstractEntity entity, bool summon)
    {
        var cmd = summon
            ? $"summon {entity.Type.Id} {entity.Position} {entity.Serialize()}"
            : $"data merge entity @e[tag=CID{entity.EntityUid},limit=1] {entity.Serialize()}";
        Cache.Add(cmd);
    }

    /// <summary>
    /// Releases lock on provided block
    /// </summary>
    /// <param name="block">Block to be unlocked</param>
    /// <param name="place">Whether to place a new block, or modify existing</param>
    public void Release(Block block, bool place)
    {
        var cmd = place
            ? $"setblock {block.Location} {block.Type.Id}{block.State?.Serialize() ?? "{}"}"
            : $"data merge block {block.Location} {block.State?.Serialize() ?? "{}"}";
        Cache.Add(cmd);
    }

    /// <summary>
    /// Generates and <b>locks</b> an entity.
    ///
    /// Note that to actually summon entity
    /// you will need to call <see cref="AbstractEntity.Release"/> on your
    /// entity, to flush all metadata to the setblock command.
    /// </summary>
    /// <param name="type">Type of entity to be spawned</param>
    /// <param name="pos">Position where to spawn entity</param>
    /// <returns>Generated and locked entity</returns>
    /// <exception cref="Exception">Entity type does not contain reference to a valid entity class.</exception>
    public AbstractEntity GenerateEntity(EntityType type, Location pos)
    {
        var ctor = type.Class.GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, Array.Empty<Type>());
        var entity = ctor?.Invoke(null) as AbstractEntity ??
                     throw new Exception(
                         $"Could not invoke default no-args constructor for entity of type {type.Class.FullName}");

        entity.Lock(this);
        entity.Position = pos;

        return entity;
    }
    
    /// <summary>
    /// Generates and <b>locks</b> a block.
    ///
    /// Note that to actually set the block
    /// you will need to call <see cref="Block.Release"/> on your
    /// block, to flush all metadata to the setblock command.
    /// </summary>
    /// <param name="blockType">Type of block to be placed</param>
    /// <param name="pos">Position where to place the block</param>
    /// <returns>Generated and locked block</returns>
    public Block SetBlock(Material blockType, Location pos)
    {
        var block = new Block(blockType, pos);
        block.Lock(this);
        return block;
    }

    /// <summary>
    /// Flushes contents of this context into provided text writer
    /// </summary>
    /// <param name="w">TextWriter to which data should be written</param>
    public void Flush(TextWriter w)
    {
        while (Cache.Any())
        {
            var ele = Cache[0];
            w.WriteLine(ele);
            Cache.RemoveAt(0);
        }
    }

    /// <summary>
    /// Flushes contents of this context into provided stream writer
    /// </summary>
    /// <param name="w">StreamWriter to which data should be written</param>
    public void Flush(StreamWriter w)
    {
        Flush(w as TextWriter);
    }

    /// <summary>
    /// Flushes contents of this context into provided stream
    /// </summary>
    /// <param name="to">Stream to which data should be written</param>
    public void Flush(Stream to)
    {
        using var writer = new StreamWriter(to);
        Flush(writer);
    }
}