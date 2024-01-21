using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Chat.Commands;

[Cpp2IlInjected.Token(Token = "0x200053E")]
[Cpp2IlInjected.Attribute(Name = "ChatCommandAttribute", RVA = "0x385464", Offset = "0x385464")]
public class RollCommand : IChatCommand
{
	[Cpp2IlInjected.Token(Token = "0x40068A5")]
	private static readonly Color RESPONSE_COLOR;

	[Cpp2IlInjected.Token(Token = "0x6003971")]
	[Cpp2IlInjected.Address(RVA = "0x11CF998", Offset = "0x11CF998", VA = "0x11CF998", Slot = "4")]
	public void ProcessIncomingMessage(string text, byte clientId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003972")]
	[Cpp2IlInjected.Address(RVA = "0x11CFC20", Offset = "0x11CFC20", VA = "0x11CFC20", Slot = "5")]
	public void ProcessOutgoingMessage(ChatMessage message)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003973")]
	[Cpp2IlInjected.Address(RVA = "0x11CFC24", Offset = "0x11CFC24", VA = "0x11CFC24")]
	public RollCommand()
	{
	}
}
