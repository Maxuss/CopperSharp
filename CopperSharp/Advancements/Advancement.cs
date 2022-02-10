using CopperSharp.Item;
using CopperSharp.Registry;
using CopperSharp.Text;
using CopperSharp.Utils;
using Newtonsoft.Json;

namespace CopperSharp.Advancements;

/// <summary>
/// Represents an advancement
/// </summary>
public sealed class Advancement
{
    private ItemStack AdvItemDisplay { get; set; } = new ItemStack(Material.Dirt);
    private IComponent AdvTitle { get; set; } = new TextComponent("undefined");
    private AdvancementType AdvType { get; set; } = AdvancementType.Task;
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

    /// <summary>
    /// Asynchronously serializes this advancement to string
    /// </summary>
    /// <returns>Serializes JSON string of this advancement</returns>
    public async Task<string> Serialize(bool indent = true)
    {
        await using var sw = new StringWriter();
        using var jw = new JsonTextWriter(sw);
        jw.Formatting = indent ? Formatting.Indented : Formatting.None;
        await jw.WriteStartObjectAsync();
        
        await jw.WritePropertyNameAsync("display");
        await jw.WriteStartObjectAsync();
        
        await jw.WritePropertyNameAsync("icon");
        await jw.WriteStartObjectAsync();

        await jw.WritePropertyNameAsync("item");
        await jw.WriteValueAsync(AdvItemDisplay.Material.Id.ToString());
        if (AdvItemDisplay.Meta != null)
        {
            await jw.WritePropertyNameAsync("nbt");
            await jw.WriteValueAsync(AdvItemDisplay.Meta!.Serialize());
        }

        await jw.WriteEndObjectAsync();

        await jw.WritePropertyNameAsync("title");
        await jw.WriteRawValueAsync(AdvTitle.Serialize(indent));

        await jw.WritePropertyNameAsync("frame");
        await jw.WriteValueAsync(AdvType.GetName().ToLower());

        if (AdvGroup != null)
        {
            await jw.WritePropertyNameAsync("background");
            await jw.WriteValueAsync(AdvGroup?.Background.ToString());
        }

        await jw.WritePropertyNameAsync("description");
        await jw.WriteRawValueAsync(AdvDescription.Serialize(indent));

        if (AdvAnnounce != null)
        {
            await jw.WritePropertyNameAsync("announce_to_chat");
            await jw.WriteValueAsync(AdvAnnounce);
        }

        if (AdvHidden != null)
        {
            await jw.WritePropertyNameAsync("hidden");
            await jw.WriteValueAsync(AdvHidden);
        }
        
        await jw.WriteEndObjectAsync();

        if (AdvParent != null)
        {
            await jw.WritePropertyNameAsync("parent");
            await jw.WriteValueAsync((Registries.Advancements.Seek(AdvParent) ?? Identifier.Minecraft("null")).ToString());
        }

        await jw.WritePropertyNameAsync("criteria");
        await jw.WriteStartObjectAsync();

        if (AdvCriteria.Count <= 0)
            throw new Exception("An advancement must contain at least 1 criterion!");
        
        foreach (var crit in AdvCriteria)
        {
            await crit.SerializeInto(jw);
        }
        
        await jw.WriteEndObjectAsync();

        if (AdvRequirements.Any())
        {
            await jw.WritePropertyNameAsync("requirements");
            await jw.WriteStartArrayAsync();

            foreach (var list in AdvRequirements)
            {
                await jw.WriteStartArrayAsync();
                
                foreach (var element in list)
                {
                    await jw.WriteValueAsync(element);
                }
                
                await jw.WriteEndArrayAsync();
            }
            
            await jw.WriteEndArrayAsync();
        }

        if (AdvRewards != null)
        {
            await jw.WritePropertyNameAsync("rewards");
            if (AdvRewards?.Exp != -1)
            {
                await jw.WritePropertyNameAsync("experience");
                await jw.WriteValueAsync(AdvRewards?.Exp);
            }

            if (AdvRewards?.Items.Any() == true)
            {
                await jw.WritePropertyNameAsync("items");
                await jw.WriteStartArrayAsync();
                foreach (var item in AdvRewards?.Items!)
                {
                    await jw.WriteValueAsync(item);
                }
                await jw.WriteEndArrayAsync();
            }
            
            if (AdvRewards?.Recipe.Any() == true)
            {
                await jw.WritePropertyNameAsync("recipes");
                await jw.WriteStartArrayAsync();
                foreach (var item in AdvRewards?.Recipe!)
                {
                    await jw.WriteValueAsync(item);
                }
                await jw.WriteEndArrayAsync();
            }

            if (AdvRewards?.Trigger != null)
            {
                await jw.WritePropertyNameAsync("function");
                await jw.WriteValueAsync(AdvRewards?.Trigger);
            }
        }
        
        await jw.WriteEndObjectAsync();

        return sw.ToString();
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