// See https://aka.ms/new-console-template for more information

using CopperSharp.Data.Attributes;
using CopperSharp.Item;
using CopperSharp.Text;

var stack = new ItemStack(Material.DiamondSword);
stack.Meta
    .Enchant(
        new Enchantment(Enchant.Fortune, 3),
        new Enchantment(Enchant.Sharpness, 10, true))
    .AddAttributes(
        new AttributeModifier(GenericAttribute.MovementSpeed, AttributeAction.Multiply, 1.4d, ItemSlot.OffHand))
    .HideFlags(ItemFlag.Unbreakable, ItemFlag.Effects)
    .AppendLore(
        new TextComponent(" "),
        new TextComponent("LEGENDARY").Formatted(FormattingType.Bold).NoItalic().Colored(NamedTextColor.Gold))
    .CustomName(
        new TextComponent("Epic Sword").Colored(NamedTextColor.Gold).NoItalic());
Console.WriteLine(stack.Serialize());