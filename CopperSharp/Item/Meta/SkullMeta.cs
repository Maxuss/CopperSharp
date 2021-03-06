using System.Text;
using CopperSharp.Data.SNbt;
using Newtonsoft.Json;

namespace CopperSharp.Item.Meta;

/// <summary>
///     Metadata container for player skulls
/// </summary>
public sealed class SkullMeta : BlockItemMeta
{
    private bool _complexOwner;

    /// <inheritdoc />
    public SkullMeta() : base(Material.PlayerHead)
    {
    }

    private string? SkullOwner { get; set; }

    /// <summary>
    ///     Sets owner of this skull as player's name
    /// </summary>
    /// <param name="playerName">Name of the player to set as this skull's owner</param>
    /// <returns>This skull meta</returns>
    public SkullMeta SetOwner(string playerName)
    {
        SkullOwner = playerName;
        _complexOwner = false;
        return this;
    }

    /// <summary>
    ///     Sets owner of this skull as base64 texture value.
    /// </summary>
    /// <remarks>
    ///     You can find a lot of custom Base64 values<br />
    ///     on https://minecraft-heads.com/custom-heads
    /// </remarks>
    /// <param name="base64">Base64 encoded texture value</param>
    /// <returns>This skull meta</returns>
    public SkullMeta SetBase64Texture(string base64)
    {
        SkullOwner = base64;
        _complexOwner = true;
        return this;
    }

    /// <summary>
    ///     Sets owner of this skull as url to texture
    /// </summary>
    /// <param name="url">URL leading to skin texture</param>
    /// <returns>This skull meta</returns>
    public SkullMeta SetUrlTexture(string url)
    {
        using var sw = new StringWriter();
        using var w = new JsonTextWriter(sw);

        w.WriteStartObject();
        w.WritePropertyName("textures");
        w.WriteStartObject();
        w.WritePropertyName("SKIN");
        w.WriteStartObject();
        w.WritePropertyName("url");
        w.WriteValue(url);
        w.WriteEndObject();
        w.WriteEndObject();
        w.WriteEndObject();

        SkullOwner = Convert.ToBase64String(Encoding.UTF8.GetBytes(sw.ToString()));
        _complexOwner = true;
        return this;
    }

    /// <inheritdoc />
    internal override async Task WriteExternalMetaData(INbtWriter w)
    {
        if (SkullOwner == null) return;
        await w.WritePropertyNameAsync("SkullOwner");
        if (!_complexOwner)
        {
            await w.WriteStringAsync(SkullOwner);
            return;
        }

        await w.WriteBeginCompoundAsync();
        await w.WritePropertyNameAsync("Id");
        await w.WriteUuidArrayAsync(Guid.NewGuid());
        await w.WritePropertyNameAsync("Properties");
        await w.WriteBeginCompoundAsync();
        await w.WritePropertyNameAsync("textures");
        await w.WriteBeginArrayAsync();
        await w.WriteBeginCompoundAsync();
        await w.WritePropertyNameAsync("Value");
        await w.WriteStringAsync(SkullOwner);
        await w.WriteEndCompoundAsync();
        await w.WriteEndArrayAsync();
        await w.WriteEndCompoundAsync();
        await w.WriteEndCompoundAsync();
    }
}