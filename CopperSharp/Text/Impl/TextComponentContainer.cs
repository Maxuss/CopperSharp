using Newtonsoft.Json;

namespace CopperSharp.Text.Impl;

[JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
internal class TextComponentContainer : AbstractComponentContainer
{
    public TextComponentContainer(IComponent parent) : base(parent)
    {
        if (parent is not TextComponent tc)
            return;
        TextContents = tc.Text;
    }

    [JsonProperty("text")] public string TextContents { get; } = "undefined";

    protected override void WriteExtraData(JsonTextWriter w)
    {
        w.WritePropertyName("text");
        w.WriteValue(TextContents);
    }
}