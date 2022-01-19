using Newtonsoft.Json;

namespace CopperSharp.Text.Impl;

[JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
internal class TranslatableComponentContainer : AbstractComponentContainer
{
    public TranslatableComponentContainer(IComponent parent) : base(parent)
    {
        if (parent is not TranslatableComponent tc)
            return;
        Key = tc.Key;
        WithSlots = tc.ExtraSlots.Select(it => it.Contain()).ToList();
    }

    [JsonProperty("translate")] public string Key { get; } = "undefined";

    [JsonProperty("with")] public List<AbstractComponentContainer>? WithSlots { get; }
}