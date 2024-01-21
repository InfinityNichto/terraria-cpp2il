using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Chat.Commands;

[Cpp2IlInjected.Token(Token = "0x2000534")]
[Cpp2IlInjected.Attribute(Name = "ChatCommandAttribute", RVA = "0x38525C", Offset = "0x38525C")]
public class DeathCommand : IChatCommand
{
	[Cpp2IlInjected.Token(Token = "0x400689B")]
	private static readonly Color RESPONSE_COLOR;

	[Cpp2IlInjected.Token(Token = "0x6003946")]
	[Cpp2IlInjected.Address(RVA = "0x11CD9D4", Offset = "0x11CD9D4", VA = "0x11CD9D4", Slot = "4")]
	public void ProcessIncomingMessage(string text, byte clientId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003947")]
	[Cpp2IlInjected.Address(RVA = "0x11CDD10", Offset = "0x11CDD10", VA = "0x11CDD10", Slot = "5")]
	public void ProcessOutgoingMessage(ChatMessage message)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003948")]
	[Cpp2IlInjected.Address(RVA = "0x11CDD14", Offset = "0x11CDD14", VA = "0x11CDD14")]
	public DeathCommand()
	{
	}
}
