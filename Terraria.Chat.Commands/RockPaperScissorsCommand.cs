using Cpp2IlInjected;

namespace Terraria.Chat.Commands;

[Cpp2IlInjected.Token(Token = "0x2000539")]
[Cpp2IlInjected.Attribute(Name = "ChatCommandAttribute", RVA = "0x385360", Offset = "0x385360")]
public class RockPaperScissorsCommand : IChatCommand
{
	[Cpp2IlInjected.Token(Token = "0x600395B")]
	[Cpp2IlInjected.Address(RVA = "0x11CF72C", Offset = "0x11CF72C", VA = "0x11CF72C", Slot = "4")]
	public void ProcessIncomingMessage(string text, byte clientId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600395C")]
	[Cpp2IlInjected.Address(RVA = "0x11CF730", Offset = "0x11CF730", VA = "0x11CF730", Slot = "5")]
	public void ProcessOutgoingMessage(ChatMessage message)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600395D")]
	[Cpp2IlInjected.Address(RVA = "0x11CF990", Offset = "0x11CF990", VA = "0x11CF990")]
	public RockPaperScissorsCommand()
	{
	}
}
