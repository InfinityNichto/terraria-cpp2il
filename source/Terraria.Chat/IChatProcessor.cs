using Cpp2IlInjected;

namespace Terraria.Chat;

[Cpp2IlInjected.Token(Token = "0x2000531")]
public interface IChatProcessor
{
	[Cpp2IlInjected.Token(Token = "0x6003941")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ProcessIncomingMessage(ChatMessage message, int clientId);

	[Cpp2IlInjected.Token(Token = "0x6003942")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ChatMessage CreateOutgoingMessage(string text);
}
