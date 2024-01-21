using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Chat.Commands;

[Cpp2IlInjected.Token(Token = "0x2000535")]
[Cpp2IlInjected.Attribute(Name = "ChatCommandAttribute", RVA = "0x385290", Offset = "0x385290")]
public class PVPDeathCommand : IChatCommand
{
	[Cpp2IlInjected.Token(Token = "0x400689C")]
	private static readonly Color RESPONSE_COLOR;

	[Cpp2IlInjected.Token(Token = "0x600394A")]
	[Cpp2IlInjected.Address(RVA = "0x11CEFE8", Offset = "0x11CEFE8", VA = "0x11CEFE8", Slot = "4")]
	public void ProcessIncomingMessage(string text, byte clientId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600394B")]
	[Cpp2IlInjected.Address(RVA = "0x11CF324", Offset = "0x11CF324", VA = "0x11CF324", Slot = "5")]
	public void ProcessOutgoingMessage(ChatMessage message)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600394C")]
	[Cpp2IlInjected.Address(RVA = "0x11CF328", Offset = "0x11CF328", VA = "0x11CF328")]
	public PVPDeathCommand()
	{
	}
}
