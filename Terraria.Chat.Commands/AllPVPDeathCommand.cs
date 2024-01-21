using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Chat.Commands;

[Cpp2IlInjected.Token(Token = "0x2000537")]
[Cpp2IlInjected.Attribute(Name = "ChatCommandAttribute", RVA = "0x3852F8", Offset = "0x3852F8")]
public class AllPVPDeathCommand : IChatCommand
{
	[Cpp2IlInjected.Token(Token = "0x400689E")]
	private static readonly Color RESPONSE_COLOR;

	[Cpp2IlInjected.Token(Token = "0x6003952")]
	[Cpp2IlInjected.Address(RVA = "0x11CD618", Offset = "0x11CD618", VA = "0x11CD618", Slot = "4")]
	public void ProcessIncomingMessage(string text, byte clientId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003953")]
	[Cpp2IlInjected.Address(RVA = "0x11CD924", Offset = "0x11CD924", VA = "0x11CD924", Slot = "5")]
	public void ProcessOutgoingMessage(ChatMessage message)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003954")]
	[Cpp2IlInjected.Address(RVA = "0x11CD928", Offset = "0x11CD928", VA = "0x11CD928")]
	public AllPVPDeathCommand()
	{
	}
}
