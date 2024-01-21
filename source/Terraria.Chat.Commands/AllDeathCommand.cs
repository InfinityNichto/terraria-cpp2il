using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Chat.Commands;

[Cpp2IlInjected.Token(Token = "0x2000536")]
[Cpp2IlInjected.Attribute(Name = "ChatCommandAttribute", RVA = "0x3852C4", Offset = "0x3852C4")]
public class AllDeathCommand : IChatCommand
{
	[Cpp2IlInjected.Token(Token = "0x400689D")]
	private static readonly Color RESPONSE_COLOR;

	[Cpp2IlInjected.Token(Token = "0x600394E")]
	[Cpp2IlInjected.Address(RVA = "0x11CD27C", Offset = "0x11CD27C", VA = "0x11CD27C", Slot = "4")]
	public void ProcessIncomingMessage(string text, byte clientId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600394F")]
	[Cpp2IlInjected.Address(RVA = "0x11CD588", Offset = "0x11CD588", VA = "0x11CD588", Slot = "5")]
	public void ProcessOutgoingMessage(ChatMessage message)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003950")]
	[Cpp2IlInjected.Address(RVA = "0x11CD58C", Offset = "0x11CD58C", VA = "0x11CD58C")]
	public AllDeathCommand()
	{
	}
}
