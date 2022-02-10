using CopperSharp.Item;
using CopperSharp.Registry;
using CopperSharp.Text;

namespace CopperSharp.Advancements;

/// <summary>
/// Represents an advancement
/// </summary>
public sealed class Advancement
{
    private ItemStack AdvItemDisplay { get; set; } = new ItemStack(Material.Dirt);
    private IComponent AdvTitle { get; set; } = new TextComponent("undefined");
    private AdvancementType? AdvType { get; set; }
    private IComponent AdvDescription { get; set; } = new TextComponent("undefined");
    private bool? AdvAnnounce { get; set; }
    private bool? AdvHidden { get; set; }
    private AdvancementGroup? AdvGroup { get; set; }
    private Advancement? AdvParent { get; set; }
    private AdvancementReward? AdvRewards { get; set; }
    private List<Criterion> AdvCriteria { get; set; } = new();
    private List<string[]> AdvRequirements { get; set; } = new();

    /// <summary>
    /// Marks this advancement as root of provided advancement group. Nullifies parent advancement
    /// </summary>
    /// <param name="group">Advancement group to be set</param>
    /// <returns>This advancement</returns>
    public Advancement GroupRoot(AdvancementGroup group)
    {
        AdvGroup = group;
        AdvParent = null;
        return this;
    }

    /// <summary>
    /// Sets parent of this advancement.
    /// </summary>
    /// <param name="parent">Parent of this advancement to be set</param>
    /// <returns>This advancement</returns>
    public Advancement Parent(Advancement parent)
    {
        AdvParent = parent;
        AdvGroup = null;
        return this;
    }

    /// <summary>
    /// Sets display item, that is shown on this advancement
    /// </summary>
    /// <param name="item">Item to be set</param>
    /// <returns>This advancement</returns>
    public Advancement DisplayItem(ItemStack item)
    {
        AdvItemDisplay = item;
        return this;
    }
    
    /// <summary>
    /// Sets name of this advancement, when it is shown
    /// </summary>
    /// <param name="title">Name to be set</param>
    /// <returns>This advancement</returns>
    public Advancement Title(IComponent title)
    {
        AdvTitle = title;
        return this;
    }

    /// <summary>
    /// Sets type of this advancement
    /// </summary>
    /// <param name="type">Type to be set</param>
    /// <returns>This advancement</returns>
    public Advancement Type(AdvancementType type)
    {
        AdvType = type;
        return this;
    }

    /// <summary>
    /// Sets description of this advancement
    /// </summary>
    /// <param name="description">Description to be set</param>
    /// <returns>This advancement</returns>
    public Advancement Description(IComponent description)
    {
        AdvDescription = description;
        return this;
    }

    /// <summary>
    /// Sets this advancement to be announced in chat
    /// </summary>
    /// <param name="announce">Whether to announce this advancement in chat</param>
    /// <returns>This advancement</returns>
    public Advancement Announce(bool announce = true)
    {
        AdvAnnounce = announce;
        return this;
    }

    /// <summary>
    /// Makes this advancement hidden
    /// </summary>
    /// <param name="hide">Whether to hide this advancement</param>
    /// <returns>This advancement</returns>
    public Advancement Hidden(bool hide = true)
    {
        AdvHidden = hide;
        return this;
    }

    /// <summary>
    /// Sets rewards for this advancement
    /// </summary>
    /// <param name="rewards">Reward to be set</param>
    /// <returns>This advancement</returns>
    public Advancement Reward(AdvancementReward rewards)
    {
        AdvRewards = rewards;
        return this;
    }

    /// <summary>
    /// Adds provided criteria to this advancement
    /// </summary>
    /// <param name="crits">Criteria to be added</param>
    /// <returns>This advancement</returns>
    public Advancement Criteria(params Criterion[] crits)
    {
        AdvCriteria.AddRange(crits);
        return this;
    }

    /// <summary>
    /// Adds a new requirement case to this advancement.
    ///
    /// Optional. By default all criteria must be completed
    /// </summary>
    /// <param name="reqs">A single requirements case</param>
    /// <returns>This advancement</returns>
    public Advancement AddRequirements(params string[] reqs)
    {
        AdvRequirements.Add(reqs);
        return this;
    }
}

/// <summary>
/// Represents type of advancement frame
/// </summary>
public enum AdvancementType
{
    /// <summary>
    /// Simple task advancement
    /// </summary>
    Task,
    /// <summary>
    /// A goal advancement, usually harder to achieve
    /// </summary>
    Goal,
    /// <summary>
    /// A challenge advancement, usually the hardest
    /// </summary>
    Challenge
}