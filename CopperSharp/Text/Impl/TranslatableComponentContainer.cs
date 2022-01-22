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

    [JsonProperty("with")] public List<AbstractComponentContainer> WithSlots { get; } = new();

    protected override void WriteExtraData(JsonTextWriter w)
    {
        w.WritePropertyName("key");
        w.WriteValue(Key);
        w.WritePropertyName("with");
        w.WriteStartArray();
        foreach (var slot in WithSlots)
        {
            w.WriteRawValue(slot.Serialize());
        }

        w.WriteEndArray();
    }
}