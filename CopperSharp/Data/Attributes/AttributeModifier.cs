using CopperSharp.Item;
using CopperSharp.Utils;

namespace CopperSharp.Data.Attributes;

/// <summary>
///     An attribute modifier, containing a type and a modifier
/// </summary>
public readonly struct AttributeModifier
{
    /// <summary>
    ///     Constructs a new attribute modifier
    /// </summary>
    /// <param name="provider">Type of attribute</param>
    /// <param name="action">Action to be performed with provided amount</param>
    /// <param name="amount">Amount by which the attribute will be modified</param>
    /// <param name="slot">Slot for this attribute modifier to work. If applied to entities, ignore</param>
    /// <param name="name">Name of this attribute modifier. If null, default name will be used</param>
    public AttributeModifier(IAttributeType provider, AttributeAction action, double amount, ItemSlot? slot = null,
        string? name = null)
    {
        Name = name ?? provider.Name;
        Action = action;
        Type = provider.Name;
        Amount = amount > provider.Maximum ? provider.Maximum : amount;
        Slot = slot?.GetData() ?? null;
    }

    /// <summary>
    ///     Slot for this attribute modifier to work
    /// </summary>
    public string? Slot { get; }

    /// <summary>
    ///     Name of this attribute modifier
    /// </summary>
    public string Name { get; }

    /// <summary>
    ///     Type of this attribute modifier
    /// </summary>
    public string Type { get; }

    /// <summary>
    ///     Amount to be applied to this attribute
    /// </summary>
    public double Amount { get; }

    /// <summary>
    ///     Action to be performed with this attribute
    /// </summary>
    public AttributeAction Action { get; }
}