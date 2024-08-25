using System;
using Cpp2ILInjected;

namespace Terraria.Chat
{
	[global::Cpp2ILInjected.Token(Token = "0x200079B")]
	public interface IChatProcessor
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003FB1")]
		void ProcessIncomingMessage(ChatMessage message, int clientId);

		[global::Cpp2ILInjected.Token(Token = "0x6003FB2")]
		ChatMessage CreateOutgoingMessage(string text);
	}
}
