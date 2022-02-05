using CopperSharp.Item;

namespace CopperSharp.Blocks.State;

/// <summary>
/// Represents a jigsaw block state
/// </summary>
public sealed class JigsawState : BlockState
{
    internal JigsawState(Material id) : base(id)
    {
    }

    /// <summary>
    /// Sets the block this jigsaw block becomes
    /// </summary>
    /// <param name="block">Block to be set</param>
    /// <returns>This jigsaw state</returns>
    public JigsawState Transformation(Material block)
    {
        Data["final_state"] = block.Id.ToString();
        return this;
    }

    /// <summary>
    /// Sets the joint of this jigsaw
    /// </summary>
    /// <param name="joint">Type of joint to be set</param>
    /// <returns>This jigsaw state</returns>
    public JigsawState SetJoint(Joint joint)
    {
        Data["joint"] = Enum.GetName(joint) ?? "rollable";
        return this;
    }

    /// <summary>
    /// Sets the name of this jigsaw block
    /// </summary>
    /// <param name="name">Name to be set</param>
    /// <returns>This jigsaw state</returns>
    public JigsawState Named(string name)
    {
        Data["name"] = name;
        return this;
    }

    /// <summary>
    /// Sets structure pool for this jigsaw
    /// </summary>
    /// <param name="pool">Pool to be set</param>
    /// <returns>This jigsaw state</returns>
    public JigsawState Pool(string pool)
    {
        Data["pool"] = pool;
        return this;
    }

    /// <summary>
    /// Sets target jigsaw block of this jigsaw block
    /// </summary>
    /// <param name="name">Name of the target</param>
    /// <returns>This jigsaw block state</returns>
    public JigsawState Target(string name)
    {
        Data["target"] = name;
        return this;
    }

    /// <summary>
    /// Represents type of jigsaw's joint
    /// </summary>
    public enum Joint
    {
        /// <summary>
        /// Rollable joint
        /// </summary>
        Rollable,
        /// <summary>
        /// Aligned joint
        /// </summary>
        Aligned
    }
}