using System;
using Cpp2ILInjected;

namespace Terraria.Chat.Commands
{
	[global::Cpp2ILInjected.Token(Token = "0x200079D")]
	public interface IChatCommand
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003FB4")]
		void ProcessIncomingMessage(string text, byte clientId);

		[global::Cpp2ILInjected.Token(Token = "0x6003FB5")]
		void ProcessOutgoingMessage(ChatMessage message);
	}
}
