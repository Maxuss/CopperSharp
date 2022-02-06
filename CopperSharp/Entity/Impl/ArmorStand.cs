using CopperSharp.Data.SNbt;
using CopperSharp.Item;

namespace CopperSharp.Entity.Impl;

/// <summary>
///     Represents an armor stand entity
/// </summary>
public sealed class ArmorStand : AbstractEntity
{
    internal ArmorStand() : base(EntityType.ArmorStand)
    {
    }

    private Dictionary<string, (float, float, float)> Poses { get; } = new();

    /// <summary>
    ///     Locks specified slot
    /// </summary>
    /// <param name="slot">Slot to be locked</param>
    /// <param name="flag">Type of lock</param>
    /// <returns>This armor stand</returns>
    public ArmorStand LockSlot(ItemSlot slot, StandFlag flag)
    {
        if (Ints.ContainsKey("DisabledSlots"))
            Ints["DisabledSlots"] += 1 << ((int) slot + (int) flag);
        else
            Ints["DisabledSlots"] = 1 << ((int) slot + (int) flag);

        return this;
    }

    /// <summary>
    ///     Makes this armor stand invisible
    /// </summary>
    /// <param name="invis">Marker</param>
    /// <returns>This armor stand</returns>
    public ArmorStand Invisible(bool invis = true)
    {
        Bools["Invisible"] = invis;
        return this;
    }

    /// <summary>
    ///     Makes this armor stand a marker, setting size to 0
    ///     and decreasing size of hitbox
    /// </summary>
    /// <param name="marker">Marker</param>
    /// <returns>This armor stand</returns>
    public ArmorStand Marker(bool marker = true)
    {
        Bools["Marker"] = marker;
        return this;
    }

    /// <summary>
    ///     If true, ArmorStand does not display the base beneath it.
    /// </summary>
    /// <param name="plate">Whether to remove the plate</param>
    /// <returns>This armor stand</returns>
    public ArmorStand NoBasePlate(bool plate = true)
    {
        Bools["NoBasePlate"] = plate;
        return this;
    }

    /// <summary>
    ///     Shows arms of this armor stand
    /// </summary>
    /// <param name="show">Whether to show the arms</param>
    /// <returns>This armor stand</returns>
    public ArmorStand ShowArms(bool show = true)
    {
        Bools["ShowArms"] = show;
        return this;
    }

    /// <summary>
    ///     Makes this armor stand small
    /// </summary>
    /// <param name="small">Marker</param>
    /// <returns>This armor stand</returns>
    public ArmorStand Small(bool small = true)
    {
        Bools["Small"] = small;
        return this;
    }

    /// <summary>
    ///     Sets body rotation of this armor stand
    /// </summary>
    /// <param name="x">X rotation</param>
    /// <param name="y">Y rotation</param>
    /// <param name="z">Z rotation</param>
    /// <returns>This armor stand</returns>
    public ArmorStand BodyRotation(float x, float y, float z)
    {
        Poses["Body"] = (x, y, z);
        return this;
    }

    /// <summary>
    ///     Sets head rotation of this armor stand
    /// </summary>
    /// <param name="x">X rotation</param>
    /// <param name="y">Y rotation</param>
    /// <param name="z">Z rotation</param>
    /// <returns>This armor stand</returns>
    public ArmorStand HeadRotation(float x, float y, float z)
    {
        Poses["Head"] = (x, y, z);
        return this;
    }

    /// <summary>
    ///     Sets left arm rotation of this armor stand
    /// </summary>
    /// <param name="x">X rotation</param>
    /// <param name="y">Y rotation</param>
    /// <param name="z">Z rotation</param>
    /// <returns>This armor stand</returns>
    public ArmorStand LeftArmRotation(float x, float y, float z)
    {
        Poses["LeftArm"] = (x, y, z);
        return this;
    }

    /// <summary>
    ///     Sets left leg rotation of this armor stand
    /// </summary>
    /// <param name="x">X rotation</param>
    /// <param name="y">Y rotation</param>
    /// <param name="z">Z rotation</param>
    /// <returns>This armor stand</returns>
    public ArmorStand LeftLegRotation(float x, float y, float z)
    {
        Poses["LeftLeg"] = (x, y, z);
        return this;
    }

    /// <summary>
    ///     Sets right arm rotation of this armor stand
    /// </summary>
    /// <param name="x">X rotation</param>
    /// <param name="y">Y rotation</param>
    /// <param name="z">Z rotation</param>
    /// <returns>This armor stand</returns>
    public ArmorStand RightArmRotation(float x, float y, float z)
    {
        Poses["RightArm"] = (x, y, z);
        return this;
    }

    /// <summary>
    ///     Sets right leg rotation of this armor stand
    /// </summary>
    /// <param name="x">X rotation</param>
    /// <param name="y">Y rotation</param>
    /// <param name="z">Z rotation</param>
    /// <returns>This armor stand</returns>
    public ArmorStand RightLegRotation(float x, float y, float z)
    {
        Poses["RightLeg"] = (x, y, z);
        return this;
    }

    /// <inheritdoc />
    protected override void SerializeExtra(StringNbtWriter sw)
    {
        base.SerializeExtra(sw);

        if (!Poses.Any())
            return;

        sw.WritePropertyName("Pose");
        sw.WriteBeginCompound();
        foreach (var (name, (x, y, z)) in Poses)
        {
            sw.WritePropertyName(name);
            sw.WriteBeginArray();
            sw.WriteFloat(x);
            sw.WriteFloat(y);
            sw.WriteFloat(z);
            sw.WriteEndArray();
        }

        sw.WriteEndCompound();
    }
}

/// <summary>
///     An extra policy flag for armor stand
/// </summary>
public enum StandFlag
{
    /// <summary>
    ///     Disables removing item from this slot
    /// </summary>
    NoRemove = 1,

    /// <summary>
    ///     Disables replacing item in this slot
    /// </summary>
    NoReplace = 8,

    /// <summary>
    ///     Disables placing item in this slot
    /// </summary>
    NoPlace = 16
}