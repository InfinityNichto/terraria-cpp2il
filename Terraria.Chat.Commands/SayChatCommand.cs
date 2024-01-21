using Cpp2IlInjected;

namespace Terraria.Chat.Commands;

[Cpp2IlInjected.Token(Token = "0x200053F")]
[Cpp2IlInjected.Attribute(Name = "ChatCommandAttribute", RVA = "0x385498", Offset = "0x385498")]
public class SayChatCommand : IChatCommand
{
	[Cpp2IlInjected.Token(Token = "0x6003975")]
	[Cpp2IlInjected.Address(RVA = "0x11CFCB0", Offset = "0x11CFCB0", VA = "0x11CFCB0", Slot = "4")]
	public void ProcessIncomingMessage(string text, byte clientId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003976")]
	[Cpp2IlInjected.Address(RVA = "0x11CFE64", Offset = "0x11CFE64", VA = "0x11CFE64", Slot = "5")]
	public void ProcessOutgoingMessage(ChatMessage message)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003977")]
	[Cpp2IlInjected.Address(RVA = "0x11CFE68", Offset = "0x11CFE68", VA = "0x11CFE68")]
	public SayChatCommand()
	{
	}
}
