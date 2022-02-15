using System.Text;

namespace CopperSharp.Contexts;

internal sealed class MinecraftChatWriter : TextWriter
{
    public MinecraftChatWriter(WorldContext world, bool err)
    {
        Error = err;
        World = world;
    }

    private StringBuilder MessageBuilder { get; } = new();
    private bool Error { get; }
    private WorldContext World { get; }
    public override Encoding Encoding => Encoding.UTF8;

    public override void Write(char value)
    {
        if (value == '\n')
        {
            World.Cache.Add(Error
                ? $"tellraw @a {{\"text\":\"[ERROR]: {MessageBuilder}\",\"color\":\"red\"}}"
                : $"tellraw @a \"{MessageBuilder}\"");
            MessageBuilder.Clear();
            return;
        }

        MessageBuilder.Append(value);
    }
}