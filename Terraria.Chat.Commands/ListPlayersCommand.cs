using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Chat.Commands;

[Cpp2IlInjected.Token(Token = "0x200053C")]
[Cpp2IlInjected.Attribute(Name = "ChatCommandAttribute", RVA = "0x3853FC", Offset = "0x3853FC")]
public class ListPlayersCommand : IChatCommand
{
	[Cpp2IlInjected.Token(Token = "0x40068A3")]
	private static readonly Color RESPONSE_COLOR;

	[Cpp2IlInjected.Token(Token = "0x6003968")]
	[Cpp2IlInjected.Address(RVA = "0x11CEBDC", Offset = "0x11CEBDC", VA = "0x11CEBDC", Slot = "4")]
	public void ProcessIncomingMessage(string text, byte clientId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003969")]
	[Cpp2IlInjected.Address(RVA = "0x11CEED4", Offset = "0x11CEED4", VA = "0x11CEED4", Slot = "5")]
	public void ProcessOutgoingMessage(ChatMessage message)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600396A")]
	[Cpp2IlInjected.Address(RVA = "0x11CEED8", Offset = "0x11CEED8", VA = "0x11CEED8")]
	public ListPlayersCommand()
	{
	}
}
