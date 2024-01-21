using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Chat.Commands;

[Cpp2IlInjected.Token(Token = "0x200053A")]
[Cpp2IlInjected.Attribute(Name = "ChatCommandAttribute", RVA = "0x385394", Offset = "0x385394")]
public class EmoteCommand : IChatCommand
{
	[Cpp2IlInjected.Token(Token = "0x40068A1")]
	private static readonly Color RESPONSE_COLOR;

	[Cpp2IlInjected.Token(Token = "0x600395E")]
	[Cpp2IlInjected.Address(RVA = "0x11CE308", Offset = "0x11CE308", VA = "0x11CE308", Slot = "4")]
	public void ProcessIncomingMessage(string text, byte clientId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600395F")]
	[Cpp2IlInjected.Address(RVA = "0x11CE490", Offset = "0x11CE490", VA = "0x11CE490", Slot = "5")]
	public void ProcessOutgoingMessage(ChatMessage message)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003960")]
	[Cpp2IlInjected.Address(RVA = "0x11CE494", Offset = "0x11CE494", VA = "0x11CE494")]
	public EmoteCommand()
	{
	}
}
