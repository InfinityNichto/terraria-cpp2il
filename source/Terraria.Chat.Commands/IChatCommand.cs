using Cpp2IlInjected;

namespace Terraria.Chat.Commands;

[Cpp2IlInjected.Token(Token = "0x2000533")]
public interface IChatCommand
{
	[Cpp2IlInjected.Token(Token = "0x6003944")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ProcessIncomingMessage(string text, byte clientId);

	[Cpp2IlInjected.Token(Token = "0x6003945")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ProcessOutgoingMessage(ChatMessage message);
}
